using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class CV
    {

        public int id { get; set; }


        public int User_id { get; set; }
        [ForeignKey(nameof(User_id))]
        public User user { get; set; }

        public virtual ICollection<Experience> experience { get; set; } = new List<Experience>();

        public virtual ICollection<Education> educations { get; set; } = new List <Education>();


   



    }
}
