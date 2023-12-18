using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set;}

        public int Cv_id { get; set; }

        [ForeignKey(nameof(Cv_id))]
        public virtual CV Cv { get; set; }
    }
}
