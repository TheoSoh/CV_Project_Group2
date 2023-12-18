using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class User_Project
    {
        public int User_id { get; set; }

        public int Project_id { get; set; }

        [ForeignKey(nameof(User_id))]
        public User User { get; set; }

        [ForeignKey(nameof(Project_id))]
        public Project Project { get; set; }    
    }
}
