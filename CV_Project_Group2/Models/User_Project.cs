using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class User_Project
    {
        public int User_ID { get; set; }

        public int Project_ID { get; set; }

        [ForeignKey(nameof(User_ID))]
        public virtual User User { get; set; }

        [ForeignKey(nameof(Project_ID))]
        public virtual Project Project { get; set; }    
    }
}
