using System.ComponentModel;

namespace FDMPrintCostEstimator.Service
{
    // All the code in this file is included in all platforms.
    public class CalculatePrintCost
    {
        public double getFinalPrintCost(double weight, double filamentcost, double kwtcost, double wattage, double printTimeMinutes)
        {

            return weight*filamentcost+(printTimeMinutes/60)*wattage*kwtcost;
                }
    }
}
