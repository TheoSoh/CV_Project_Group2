namespace CV_Project_Group2.Models;
using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {
        [Required(ErrorMessage = "vänligen fyll i ditt användarnamm")]
        [StringLength(255)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vänligen fyll i ditt lösenord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }

