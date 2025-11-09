using _3DPrintCostEstimator.Data.Repository.IRepository;

namespace _3DPrintCostEstimator.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IFilamentsRepository Filaments { get; }
        IPrintersRepository Printers { get; }
        IUserDataRepository UserData { get; }
        void Save();
    }
}
