using FDMPrintCostEstimator.Data.Contexts;
using FDMPrintCostEstimator.Data.Repository.IRepository;
using FDMPrintCostEstimator.Model;

namespace FDMPrintCostEstimator.Data.Repository
{
    public class UserDataRepository : Repository<UserData>, IUserDataRepository
    {
        private ProjectContext _db;

        public UserDataRepository(ProjectContext db) : base(db)
        {
            _db = db;
        }

        public override void Update(UserData entity)
        {
            var objFromDb = _db.UserData.FirstOrDefault(x => x.Id == entity.Id);
            if (objFromDb != null)
            {
                objFromDb.Cost1kWh = entity.Cost1kWh;
                objFromDb.CurencySymbol = entity.CurencySymbol;
                objFromDb.Printer = entity.Printer;
                objFromDb.Filament = entity.Filament;


            }
        }
    }
}
