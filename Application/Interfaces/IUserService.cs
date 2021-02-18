using Application.RequestModels;

namespace Application.Interfaces
{
    public interface IUserService
    {
        public void Create(UserCreateModel model);

    }
}
