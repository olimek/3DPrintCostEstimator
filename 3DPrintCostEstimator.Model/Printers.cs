using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMPrintCostEstimator.Model
{
    public class Printers
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public Double? Consumption { get; set; }

        [ForeignKey("UserData")]
        public int UserDataId { get; set; }

        public UserData? UserData { get; set; }
    }
}