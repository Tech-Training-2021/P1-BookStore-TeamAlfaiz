using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore4._0.Models
{
    public class Registration
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be blank")]
        [StringLength(maximumLength: 50, ErrorMessage = "name  should be between 2 to 50 characters", MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Age cannot be blank")]
        public int? Age { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[789]\d{9}$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
     
        [Required(ErrorMessage = "Address cannot be blank")]
        [StringLength(maximumLength: 50, ErrorMessage = "Address should be between 2 to 50 characters", MinimumLength = 15)]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Gender cannot be blank")]
        [DisplayName("Gender")]
        public string Gender { get; set; }
    }
}