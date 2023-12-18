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
        public DbSet <Competence> Competence{ get; set; }

        public DbSet<CV_Education> Cv_Education { get; set; }
        public DbSet<CV_Experience> Cv_Experiences { get;set; }
        public DbSet<CV_Competence> Cv_Competences { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().HasData(
                new User()
                {
                    User_ID = 1,
                    UserName = "FilippaBostrom",
                    FirstName ="Filippa",
                    LastName= "Bostrom",
                    Age = 22,
                    Password = "Bostrom123",
                    Private_status= true,
                    Login_status=false,
                }
                );

            builder.Entity<CV>().HasData(
                new CV
                {
                    Cv_ID = 1,
                    User_ID = 1
                }
                );

            builder.Entity<Experience>().HasData(
                new Experience
                {
                    Experience_ID = 1,
                    Experience_Name = "Elevassistent",
                    Cv_ID = 1
                }

                );
            
            builder.Entity<Education>().HasData(
                new Education
                {
                    Education_ID = 1,
                    Education_name = "Systemvetenskap"
                },

                new Education
                {
                    Education_ID = 2,
                    Education_name = "Ekonomi"

                }

              );
            builder.Entity<Competence>().HasData(
                new Competence
                {
                    Competence_ID = 1,
                    CompetenceName = "Java",
                }

                );

            builder.Entity<Project>().HasData(
                new Project
                {
                    Project_ID = 1,
                    Name = "MIB-Projekt",
                    Description = "Utvecklade ett system så att MIB-agenterna inom MIB lättare skulle kunna ha koll på ailens som anlände till jorden. Effektivisera systemhanteringen av registrering samt spårning av ailens under den jordliga vistelsen.",

                }

                );

            builder.Entity<Address>().HasData(
                new Address
                {
                    Adress_ID = 1,
                    Address_name = "Stenvägen",
                    Address_Number = 8,
                    Address_City = "Örebro",
                    Adress_postcode = "70235",
                    User_ID = 1
                }
                );



            builder.Entity<User_Project>().HasKey(up => new { up.User_ID, up.Project_ID });
            builder.Entity<User_Project>().HasData(
                new User_Project
                {
                    User_ID = 1,
                    Project_ID =1

                }

                );

            builder.Entity<CV_Education>().HasKey(CE => new { CE.Cv_ID, CE.Education_ID });
            builder.Entity<CV_Education>().HasData(
               new CV_Education
               {
                   Cv_ID = 1,
                   Education_ID = 1
               }

               );

            builder.Entity<CV_Experience>().HasKey(CEx => new { CEx.Cv_ID, CEx.Experience_ID });
            builder.Entity<CV_Experience>().HasData(
               new CV_Experience
               {
                   Cv_ID = 1,
                   Experience_ID = 1    
               }

               );

            builder.Entity<CV_Competence>().HasKey(CC => new { CC.Cv_ID, CC.Competence_ID });
            builder.Entity<CV_Competence>().HasData(
               new CV_Competence
               {
                   Cv_ID= 1,
                   Competence_ID = 1
               }

               );


        }

    }
}
