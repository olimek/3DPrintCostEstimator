using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace _3DPrintCostEstimator.Model
{
    public class Filaments
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string PlasticType { get; set; }
        public Double Price { get; set; }

        public Double Weight { get; set; }

    }
}
