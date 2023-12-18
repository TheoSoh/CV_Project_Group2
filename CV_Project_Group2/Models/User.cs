namespace CV_Project_Group2.Models;

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User : IdentityUser
{
    [Key]
    public string UserName { get; set; }

    [Required]
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Password { get; set; }

    public bool Private_status { get; set; }

    public bool Login_status { get; set; }

    public Address Address { get; set; }

    public CV Cv {  get; set; }

    public virtual ICollection<User_Project> User_Projects { get; set; } = new List<User_Project>();

}
