using System;
using System.ComponentModel.DataAnnotations;

namespace MattsSportsEmporium.Models
{
    public class MattsSportsEmporiumModel
    {
        [Required(ErrorMessage =
            "The subtotal is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = 
            "Subtotal must at least .01.")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage =
            "The tax percent is required.")]
        [Range(0,10, ErrorMessage =
            "Tax Percent must be a valid number from 0 to 10.")]
        public decimal? TaxPercent { get; set; }
  
        
        public decimal?  TotalCalculator()
        {
            
            decimal? Total = (Subtotal * (TaxPercent / 100)) + Subtotal;
            return Total;

        }
        public decimal? TaxCalculator()
        {
            
            decimal? TaxAmount = Subtotal * (TaxPercent / 100);
            return TaxAmount;
        }

    }
}
