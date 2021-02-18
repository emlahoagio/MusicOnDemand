using Data.Repositories.Users;

namespace Data
{
    public interface IUnitOfWork
    {
        public void Save();//Save to database

        public IUserRepository User { get; }
    }
}
