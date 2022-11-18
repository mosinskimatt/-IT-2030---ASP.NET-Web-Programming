using System.ComponentModel.DataAnnotations;

namespace MattsSportingGoods.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a name for the product.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Select a sport.")]
        public string? Sport { get; set; }

        [Required(ErrorMessage ="Enter a price.")]
        public decimal? Price { get; set; }


    }
}
