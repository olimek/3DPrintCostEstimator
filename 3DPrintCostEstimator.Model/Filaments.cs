using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("UserData")]
        public int UserDataId { get; set; }

        public UserData? UserData { get; set; }
    }
}