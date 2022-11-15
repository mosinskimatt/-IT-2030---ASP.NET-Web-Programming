namespace MattsSportsEmporium.Models
{
    public class PriceCalculator
    {
        public decimal SubTotal { get; set; }
        public decimal TaxPercent { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Total { get; set; }

        public void CalculateTotal()
        {
            
            decimal _TaxAmount = System.Math.Round(SubTotal * TaxPercent / 100, 2);
            decimal _Total = SubTotal + _TaxAmount;

            TaxAmount = _TaxAmount;
            Total = _Total;

        }
    }
}
