namespace CV_Project_Group2.Models;

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User : IdentityUser
{
    //[Key]
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //public int User_ID { get; set; }


   
    public string? FirstName { get; set; }

    public string? LastName { get; set; }
    
    public  int Age { get; set; }
    public bool Private_status { get; set; }

    public bool Login_status { get; set; }


    public byte[]? ImageData { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual CV? Cv {  get; set; }

    public virtual ICollection<User_Project>? User_Projects { get; set; }

}
