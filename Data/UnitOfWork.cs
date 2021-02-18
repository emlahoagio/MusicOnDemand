using Data.Entities;
using Data.Repositories.Users;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private MusicOnDemandContext _db;
        private IUserRepository _user;

        public UnitOfWork(MusicOnDemandContext db)
        {
            _db = db;
        }

        public IUserRepository User
        {
            get
            {
                return _user ??= new UserRepository(_db);
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
