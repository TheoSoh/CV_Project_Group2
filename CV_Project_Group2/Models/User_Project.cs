using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class User_Project
    {
        public String? User_ID { get; set; }

        public int Project_ID { get; set; }

        
        public virtual User? User { get; set; }

       
        public virtual Project? Project { get; set; }    
    }
}
