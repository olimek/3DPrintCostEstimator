using System.ComponentModel.DataAnnotations;

namespace FDMPrintCostEstimator.Model
{
    public class Filaments
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public FilamentType? Type { get; set; }
        public Double Price { get; set; }
        public Double? Weight { get; set; }
    }
}