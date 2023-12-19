using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class Competence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Competence_ID { get; set; }
        public  string? CompetenceName { get; set; }

        public virtual ICollection<CV_Competence>? CV_Competence { get; set; } 


    }
}
