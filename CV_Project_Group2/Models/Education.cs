using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class Education
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Education_ID {  get; set; }
        public string Education_name { get; set; }

        public virtual ICollection<CV_Education> CV_Education { get; set; } = new List<CV_Education>();



    }
}
