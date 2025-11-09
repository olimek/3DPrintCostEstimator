using _3DPrintCostEstimator.Data.Contexts;
using _3DPrintCostEstimator.Data.Repository.IRepository;
using _3DPrintCostEstimator.Model;

namespace _3DPrintCostEstimator.Data.Repository
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
