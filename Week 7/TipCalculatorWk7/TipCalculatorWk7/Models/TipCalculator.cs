using System.ComponentModel.DataAnnotations;

namespace TipCalculatorWk7.Models
{
   public class TipCalculator
   {
      [Required(ErrorMessage = "Please enter a value for cost of meal.")]
      [Range(0.0, 10000000.0, ErrorMessage = "Cost of meal must be greater than zero.")]
      public double? MealCost { get; set; }

        

        public double? Fifteen()
        {
            double? Total = MealCost * (.15);
            return Total;
        }

        public double? Twenty()
        {
            double? Total = MealCost * (.2);
            return Total;
        }

        public double? TwentyFive()
        {
            double? Total = MealCost * (.25);
            return Total;
        }


    }
}
