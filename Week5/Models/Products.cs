using System.ComponentModel.DataAnnotations;

namespace MattsSportsEmporium.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter what you are looking for.")]
        public string ProductName { get; set; }
        

        [Required(ErrorMessage = "Please select a sport.")]
        public string Sport { get; set; }
        

        [Required(ErrorMessage = "Please enter a price.")]
        public string Price { get; set; }
        


    }
}
