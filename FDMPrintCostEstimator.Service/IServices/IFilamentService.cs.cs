using FDMPrintCostEstimator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMPrintCostEstimator.Service
{
    public interface IFilamentService
    {
        IEnumerable<Filaments> GetAll();

        Filaments? Get(int id);

        void Add(Filaments filament, int userDataId);

        void Update(Filaments filament);

        void Delete(int id);
    }
}