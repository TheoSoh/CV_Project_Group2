using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Adress_ID { get; set; }

        public string Address_name { get; set; }

        public int Address_Number { get; set;}

        public string Address_City { get; set; }

        public string Adress_postcode { get; set; }

        public int User_ID { get; set; }
        [ForeignKey(nameof(User_ID))]
        public virtual User User { get; set; }
    }
}
