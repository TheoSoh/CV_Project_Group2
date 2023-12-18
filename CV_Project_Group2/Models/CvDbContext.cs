using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CV_Project_Group2.Models
{
    public class CvDbContext : IdentityDbContext<User>
    {

        public CvDbContext(DbContextOptions<CvDbContext> options) : base(options) 
        { 
        }

        public  DbSet<Project> Projects { get; set; }
        public  DbSet<User_Project> User_Projects { get; set; }
        public  DbSet<User> Users { get; set; }
        public  DbSet<CV> CVs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}
