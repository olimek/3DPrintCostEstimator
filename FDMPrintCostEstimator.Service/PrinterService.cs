using FDMPrintCostEstimator.Data.UnitOfWork;
using FDMPrintCostEstimator.Model;

namespace FDMPrintCostEstimator.Service
{
    public class PrinterService : IPrinterService
    {
        private readonly IUnitOfWork _uow;

        public PrinterService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<Printers> GetAll()
        {
            return _uow.Printers.GetAll() ?? Enumerable.Empty<Printers>();
        }

        public Printers? Get(int id)
        {
            return _uow.Printers.GetFirstOrDefault(p => p.Id == id);
        }

        public void Add(Printers printer, int userDataId)
        {
            printer.UserDataId = userDataId;

            _uow.Printers.Add(printer);
            _uow.Save();
        }

        public void Update(Printers printer)
        {
            _uow.Printers.Update(printer);
            _uow.Save();
        }

        public void Delete(int id)
        {
            var obj = Get(id);
            if (obj == null) return;

            _uow.Printers.Remove(obj);
            _uow.Save();
        }
    }
}