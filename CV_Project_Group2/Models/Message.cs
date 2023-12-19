using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class Message
    {
        [Key]
        public  int Message_ID { get; set; }
        public DateTime SentTime  { get; set; }
        public  string? Content  { get; set; }
        public  bool?  Read { get; set; }

        public  String? User_ID { get; set; }
        [ForeignKey(nameof(User_ID))]
        public  virtual User? User { get; set; }
    }
}
