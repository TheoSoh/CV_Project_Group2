using Microsoft.EntityFrameworkCore;

namespace CV_Project_Group2.Models
{
    public class CvDbContext : DbContext
    {

        public CvDbContext(DbContextOptions<CvDbContext>options) : base(options) 
        { 
        }

        public  DbSet<Project> Project { get; set; }
        public  DbSet<User_Project> User_Project { get; set; }
        public  DbSet<User> User { get; set; }
        public  DbSet<CV> CV { get; set; }

    }
}
