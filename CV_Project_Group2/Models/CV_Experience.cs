using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class CV_Experience
    {

        public int Cv_ID { get; set; }
        public  int  Experience_ID { get; set; }

        [ForeignKey(nameof(Cv_ID))]
        public virtual CV CV { get; set; }

        [ForeignKey(nameof(Experience_ID))]
        public virtual Experience Experience { get; set; }
    }
}
