using FDMPrintCostEstimator.Data.UnitOfWork;
using FDMPrintCostEstimator.Model;

namespace FDMPrintCostEstimator.Service
{
    public class FilamentService : IFilamentService
    {
        private readonly IUnitOfWork _uow;

        public FilamentService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<Filaments> GetAll()
        {
            return _uow.Filaments.GetAll() ?? Enumerable.Empty<Filaments>();
        }

        public Filaments? Get(int id)
        {
            return _uow.Filaments.GetFirstOrDefault(f => f.Id == id);
        }

        public void Add(Filaments filament, int userDataId)
        {
            filament.UserDataId = userDataId;

            _uow.Filaments.Add(filament);
            _uow.Save();
        }

        public void Update(Filaments filament)
        {
            _uow.Filaments.Update(filament);
            _uow.Save();
        }

        public void Delete(int id)
        {
            var obj = Get(id);
            if (obj == null) return;

            _uow.Filaments.Remove(obj);
            _uow.Save();
        }
    }
}