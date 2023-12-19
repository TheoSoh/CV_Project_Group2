using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class CV_Competence
    {

        public int Cv_ID { get; set; }
        public int Competence_ID { get; set; }

        
        public virtual CV? CV { get; set; }


        public virtual Competence? Competence { get; set; }
    }
}
