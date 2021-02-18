using Data;

namespace Application.Implements
{
    public class BaseService
    {
        protected IUnitOfWork _unitOfWork;
        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
