using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Project_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public  byte[]? ImageProject { get; set; }

        public virtual ICollection<User_Project> User_Projects { get; set; } = new List<User_Project>();
    }
}
