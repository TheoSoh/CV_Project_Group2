namespace CV_Project_Group2.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User_Project> User_Projects { get; set; } = new List<User_Project>();
    }
}
