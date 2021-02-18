using Application.Interfaces;
using Application.RequestModels;
using Data;
using Data.Entities;
using Data.Repositories.Users;
using System;

namespace Application.Implements
{
    public class UserService : BaseService, IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _userRepository = unitOfWork.User;
        }
        public void Create(UserCreateModel model)
        {
            _userRepository.Add(new User
            {
                Id = Guid.NewGuid(),
                Name = model.Name
            }) ;



        }
    }
}
