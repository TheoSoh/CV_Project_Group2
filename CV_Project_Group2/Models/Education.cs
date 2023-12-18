using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class Education
    {
        public int id {  get; set; }
        public string Education_name { get; set; }

        public int Cv_id { get; set; }
        [ForeignKey(nameof(Cv_id))]
        public virtual CV Cv { get; set; }

    }
}
