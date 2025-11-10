using FDMPrintCostEstimator.Data.Repository.IRepository;

namespace FDMPrintCostEstimator.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IFilamentsRepository Filaments { get; }
        IPrintersRepository Printers { get; }
        IUserDataRepository UserData { get; }
        void Save();
    }
}
