using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class Experience
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Experience_ID { get; set; }
        public string Experience_Name { get; set; }

        public  string?  Description { get; set; }
        public DateTime? Start_date { get; set; }
        public DateTime? End_date { get; set;}

        public int Cv_ID { get; set; }

        [ForeignKey(nameof(Cv_ID))]
        public virtual CV Cv { get; set; }


        public virtual ICollection<CV_Experience> CV_Experience { get; set; } = new List<CV_Experience>();
    }
}
