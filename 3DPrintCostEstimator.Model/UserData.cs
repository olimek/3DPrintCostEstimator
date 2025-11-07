using System.ComponentModel.DataAnnotations;

namespace _3DPrintCostEstimator.Model
{
    public class UserData
    {
        [Key]
        public int Id { get; set; }

        public Double Cost1kWh { get; set; }
        public string CurencySymbol { get; set; }
    }
}