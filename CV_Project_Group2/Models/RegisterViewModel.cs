using System.ComponentModel.DataAnnotations;

namespace CV_Project_Group2.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Vänligen fyll i ett förnamn")]
        [StringLength(255, MinimumLength = 2 ,ErrorMessage = "Felaktigt förnamn")]
        [RegularExpression("^[a-zA-Z]+$" , ErrorMessage = "Du får inte använda siffror eller specialtecken i förnamnet")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Vänligen fyll i ett efternamn")]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Felaktigt efternamn")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Du får inte använda siffror eller specialtecken i förnamnet")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Vänligen fyll i ett användarnamn")]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Felaktigt användarnamn")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vänligen fyll i lösenord")]
        [DataType(DataType.Password)]
        [Compare ("ConfirmPassword")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vänligen bekräfta lösenordet")]
        [DataType(DataType.Password)]
        [Display(Name = "Bekräfta lösenordet")]

        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


    }
}
