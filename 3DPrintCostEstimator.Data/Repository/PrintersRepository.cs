using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDMPrintCostEstimator.Data.Contexts;
using FDMPrintCostEstimator.Data.Repository.IRepository;
using FDMPrintCostEstimator.Model;

namespace FDMPrintCostEstimator.Data.Repository
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
