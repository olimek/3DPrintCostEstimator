using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace FDMPrintCostEstimator.Model
{
    public class UserData
    {
        [Key]
        public int Id { get; set; }

        public Double Cost1kWh { get; set; }
        public string CurencySymbol { get; set; }
        public List<Printers>? Printer { get; set; }
        public List<Filaments>? Filament { get; set; }
    }
}