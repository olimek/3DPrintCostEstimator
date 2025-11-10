using FDMPrintCostEstimator.Data.Contexts;
using FDMPrintCostEstimator.Data.Repository.IRepository;
using FDMPrintCostEstimator.Model;

namespace FDMPrintCostEstimator.Data.Repository
{
    public class FilamentsRepository : Repository<Filaments>, IFilamentsRepository
    {
        private ProjectContext _db;

        public FilamentsRepository(ProjectContext db) : base(db)
        {
            _db = db;
        }

        public override void Update(Filaments entity)
        {
            var objFromDb = _db.Filaments.FirstOrDefault(x => x.Id == entity.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = entity.Name;
                objFromDb.Weight = entity.Weight;
                objFromDb.Type = entity.Type;
                objFromDb.Price = entity.Price;
            }
        }
    }

}
