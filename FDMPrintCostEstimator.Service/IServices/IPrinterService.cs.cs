using FDMPrintCostEstimator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMPrintCostEstimator.Service
{
    public interface IPrinterService
    {
        IEnumerable<Printers> GetAll();

        Printers? Get(int id);

        void Add(Printers printer, int userDataId);

        void Update(Printers printer);

        void Delete(int id);
    }
}