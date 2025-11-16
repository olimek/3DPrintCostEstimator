using FDMPrintCostEstimator.Model;

namespace FDMPrintCostEstimator.Service
{
    public interface IUserDataService
    {
        UserData? GetUser();

        void Save(UserData user);
    }
}