using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class CV
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cv_ID { get; set; }


        public int User_ID { get; set; }
        [ForeignKey(nameof(User_ID))]
        public virtual User User { get; set; }

        public virtual ICollection<CV_Education> CV_Education { get; set; } = new List<CV_Education>();
        public virtual ICollection<CV_Experience> CV_Experience { get; set; } = new List<CV_Experience>();
        public virtual ICollection<CV_Competence> CV_Competence { get; set; } = new List<CV_Competence>();









    }
}
