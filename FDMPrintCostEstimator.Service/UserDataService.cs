using FDMPrintCostEstimator.Data.UnitOfWork;
using FDMPrintCostEstimator.Model;

namespace FDMPrintCostEstimator.Service
{
    public class UserDataService : IUserDataService
    {
        private readonly IUnitOfWork _uow;

        public UserDataService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public UserData? GetUser()
        {
            return _uow.UserData.GetFirstOrDefault(u => true);
        }

        public void Save(UserData user)
        {
            if (user.Id == 0)
                _uow.UserData.Add(user);
            else
                _uow.UserData.Update(user);

            _uow.Save();
        }
    }
}