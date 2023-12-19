using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class CV_Education
    {

        public int  Cv_ID { get; set; }
        public  int Education_ID  { get; set; }

       
        public virtual CV? CV { get; set; }

       
        public virtual Education? Education { get; set; }
    }



}

