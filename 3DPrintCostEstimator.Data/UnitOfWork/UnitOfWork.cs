using _3DPrintCostEstimator.Data.Contexts;
using _3DPrintCostEstimator.Data.Repository;
using _3DPrintCostEstimator.Data.Repository.IRepository;
using _3DPrintCostEstimator.Model;

namespace _3DPrintCostEstimator.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProjectContext _db;

        public UnitOfWork(ProjectContext db)
        {
            _db = db;
            
            Filaments = new FilamentsRepository(_db);
            Printers = new PrintersRepository(_db);
            UserData = new UserDataRepository(_db);
        }

        public IFilamentsRepository Filaments { get; private set; }

        public IPrintersRepository Printers { get; private set; }
        public IUserDataRepository UserData { get; private set; }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
