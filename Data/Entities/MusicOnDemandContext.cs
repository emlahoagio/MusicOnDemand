using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Entities
{
    public partial class MusicOnDemandContext : DbContext
    {
        public MusicOnDemandContext()
        {
        }

        public MusicOnDemandContext(DbContextOptions<MusicOnDemandContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<MediaAlbum> MediaAlbums { get; set; }
        public virtual DbSet<MediaGenre> MediaGenres { get; set; }
        public virtual DbSet<MediaSinger> MediaSingers { get; set; }
        public virtual DbSet<Medium> Media { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<PlaylistMedium> PlaylistMedia { get; set; }
        public virtual DbSet<Singer> Singers { get; set; }
        public virtual DbSet<Stack> Stacks { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=quandtm.database.windows.net;Database=MusicOnDemand;Trusted_Connection=False;User ID=quandtm;Password=Abc123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Album>(entity =>
            {
                entity.ToTable("Album");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Doi)
                    .HasColumnType("date")
                    .HasColumnName("DOI");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Producer).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Logo).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Slogan).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("Genre");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            modelBuilder.Entity<MediaAlbum>(entity =>
            {
                entity.ToTable("Media_Album");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AlbumId).HasColumnName("AlbumID");

                entity.Property(e => e.MediaId).HasColumnName("MediaID");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.MediaAlbums)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK__Media_Alb__Album__0B91BA14");

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.MediaAlbums)
                    .HasForeignKey(d => d.MediaId)
                    .HasConstraintName("FK__Media_Alb__Media__0A9D95DB");
            });

            modelBuilder.Entity<MediaGenre>(entity =>
            {
                entity.ToTable("Media_Genre");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.GenreId).HasColumnName("GenreID");

                entity.Property(e => e.MediaId).HasColumnName("MediaID");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.MediaGenres)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK__Media_Gen__Genre__02084FDA");

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.MediaGenres)
                    .HasForeignKey(d => d.MediaId)
                    .HasConstraintName("FK__Media_Gen__Media__01142BA1");
            });

            modelBuilder.Entity<MediaSinger>(entity =>
            {
                entity.ToTable("Media_Singer");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MainSinger).HasMaxLength(255);

                entity.Property(e => e.MediaId).HasColumnName("MediaID");

                entity.Property(e => e.SingerId).HasColumnName("SingerID");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.MediaSingers)
                    .HasForeignKey(d => d.MediaId)
                    .HasConstraintName("FK__Media_Sin__Media__05D8E0BE");

                entity.HasOne(d => d.Singer)
                    .WithMany(p => p.MediaSingers)
                    .HasForeignKey(d => d.SingerId)
                    .HasConstraintName("FK__Media_Sin__Singe__06CD04F7");
            });

            modelBuilder.Entity<Medium>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Doi)
                    .HasColumnType("date")
                    .HasColumnName("DOI");

                entity.Property(e => e.Musician).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            modelBuilder.Entity<Playlist>(entity =>
            {
                entity.ToTable("Playlist");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.StackId).HasColumnName("StackID");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Playlists)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Playlist__BrandI__6B24EA82");

                entity.HasOne(d => d.Stack)
                    .WithMany(p => p.Playlists)
                    .HasForeignKey(d => d.StackId)
                    .HasConstraintName("FK__Playlist__StackI__6D0D32F4");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Playlists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Playlist__UserID__6C190EBB");
            });

            modelBuilder.Entity<PlaylistMedium>(entity =>
            {
                entity.ToTable("Playlist_Media");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MediaId).HasColumnName("MediaID");

                entity.Property(e => e.PlaylistId).HasColumnName("PlaylistID");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.PlaylistMedia)
                    .HasForeignKey(d => d.MediaId)
                    .HasConstraintName("FK__Playlist___Media__7D439ABD");

                entity.HasOne(d => d.Playlist)
                    .WithMany(p => p.PlaylistMedia)
                    .HasForeignKey(d => d.PlaylistId)
                    .HasConstraintName("FK__Playlist___Playl__7C4F7684");
            });

            modelBuilder.Entity<Singer>(entity =>
            {
                entity.ToTable("Singer");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BirthName).HasMaxLength(255);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Origin).HasMaxLength(255);

                entity.Property(e => e.StageName).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            modelBuilder.Entity<Stack>(entity =>
            {
                entity.ToTable("Stack");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Dow).HasColumnName("DOW");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Stacks)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__Stack__StoreID__6754599E");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("Store");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Store__BrandID__60A75C0F");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.Role).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
