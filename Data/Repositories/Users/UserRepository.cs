using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Users
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MusicOnDemandContext db) : base(db)
        {

        }
    }
}
