using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3DPrintCostEstimator.Data.Contexts;
using _3DPrintCostEstimator.Data.Repository.IRepository;
using _3DPrintCostEstimator.Model;

namespace _3DPrintCostEstimator.Data.Repository
{
    public class PrintersRepository : Repository<Printers>, IPrintersRepository
    {
        private ProjectContext _db;

        public PrintersRepository(ProjectContext db) : base(db)
        {
            _db = db;
        }

        public override void Update(Printers entity)
        {
            var objFromDb = _db.Printers.FirstOrDefault(x => x.Id == entity.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = entity.Name;
                objFromDb.Consumption = entity.Consumption;

            }
        }
    }

}
