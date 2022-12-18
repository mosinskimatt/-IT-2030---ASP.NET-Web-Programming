using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace MattsSportingGoods.Models
{
    public class Customer
    {
        [Required (ErrorMessage = "Pleae enter a first name.")]
        [StringLength(10, ErrorMessage = "First Name  must be 10 characters or less.")]
        [RegularExpression("^[a-zA-Z]+$", 
            ErrorMessage ="First Name may not contain numbers or special characters.")]

        public string? FirstName{get; set;}

        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(10, ErrorMessage = "Last Name  must be 10 characters or less.")]
        [RegularExpression("^[a-zA-Z]+$",
            ErrorMessage = "Last Name may not contain numbers or special characters.")]

        public string? LastName { get; set; }
        [Required(ErrorMessage = "Please add a street address.")]
        public string? Street { get; set; }

        [Required(ErrorMessage ="Please enter a city.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Please enter a state.")]
        [StringLength(2, ErrorMessage = "State must be 2 characters only.")]
        [RegularExpression("[a-zA-Z]{2}", ErrorMessage ="Sate may not contain numbers or special characters.")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Please enter a Zip Code.")]
        [StringLength(2, ErrorMessage = "Zip Code must be 5 digits.")]
        [RegularExpression("[0-9]{5}", ErrorMessage = "Zip Code may not contain letters or special characters andmust be 5 digits.")]
        public string? ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        [StringLength(10, ErrorMessage = "Phone number must be 10 digits.")]
        [RegularExpression("[0-9]{10}", ErrorMessage = "Phone number must containe only numbers.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter a valid e-mail address.")]
        public string? Email { get; set; }
    }
}
