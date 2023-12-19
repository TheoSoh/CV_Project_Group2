using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Emit;

namespace CV_Project_Group2.Models
{
    public class CvDbContext : IdentityDbContext<User>
    {

        public CvDbContext(DbContextOptions<CvDbContext> options) : base(options) 
        { 
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User_Project> User_Projects { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<CV> CVs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Competence> Competence { get; set; }
       
        public DbSet<CV_Education> Cv_Education { get; set; }
        public DbSet<CV_Experience> Cv_Experiences { get; set; }
        public DbSet<CV_Competence> Cv_Competences { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<User>().HasData(
            //    new User()
            //    {
            //        UserName = "FilippaBostrom",
            //        FirstName = "Filippa",
            //        LastName = "Bostrom",
            //        PasswordHash = "hej123",
            //        Age = 22,
            //        Private_status = true,
            //        Login_status = false,
            //        Email = "filippa.bostrom@gmail.com"
            //    }
            //    );

            //builder.Entity<CV>().HasData(
            //    new CV
            //    {
            //        Cv_ID = 1,
            //        User_ID = "1"
            //    }
            //    );

            //builder.Entity<Experience>().HasData(
            //    new Experience
            //    {
            //        Experience_ID = 1,
            //        Experience_Name = "Elevassistent",

            //    }

            //    );

            //builder.Entity<Education>().HasData(
            //    new Education
            //    {
            //        Education_ID = 1,
            //        Education_name = "Systemvetenskap"
            //    },

            //    new Education
            //    {
            //        Education_ID = 2,
            //        Education_name = "Ekonomi"

            //    }

            //  );
            //builder.Entity<Competence>().HasData(
            //    new Competence
            //    {
            //        Competence_ID = 1,
            //        CompetenceName = "Java",
            //    }

            //    );

            //builder.Entity<Project>().HasData(
            //    new Project
            //    {
            //        Project_ID = 1,
            //        Name = "MIB-Projekt",
            //        Description = "Utvecklade ett system så att MIB-agenterna inom MIB lättare skulle kunna ha koll på ailens som anlände till jorden. Effektivisera systemhanteringen av registrering samt spårning av ailens under den jordliga vistelsen.",

            //    }

            //    );

            //builder.Entity<Address>().HasData(
            //    new Address
            //    {
            //        Address_ID = 1,
            //        Address_name = "Stenvägen",
            //        Address_Number = 8,
            //        Address_City = "Örebro",
            //        Address_postcode = "70235",
            //        User_ID = "1"
            //    }
            //    ); ;


            //builder.Entity<User>().HasKey(u => u.User_ID);
            //builder.Entity<Project>().HasKey(p => p.Project_ID);
            builder.Entity<User_Project>().HasKey(up => new { up.User_ID, up.Project_ID });

            builder.Entity<User_Project>()
                .HasOne(up => up.User)
                .WithMany(S => S.User_Projects)
                .HasForeignKey(CC => CC.User_ID);
            builder.Entity<User_Project>()
                        .HasOne(up => up.Project)
                        .WithMany(C => C.User_Projects)
                        .HasForeignKey(CC => CC.Project_ID);

            //builder.Entity<User_Project>().HasData(
            //    new User_Project
            //    {
            //        User_ID = "1",
            //        Project_ID = 1

            //    }

            //);


            builder.Entity<CV>().HasKey(c => c.Cv_ID);
            builder.Entity<Education>().HasKey(e => e.Education_ID);
            builder.Entity<CV_Education>().HasKey(ce => new { ce.Cv_ID, ce.Education_ID });

            builder.Entity<CV_Education>()
                .HasOne(E => E.Education)
                .WithMany(S => S.CV_Education)
                .HasForeignKey(CC => CC.Education_ID);

            builder.Entity<CV_Education>()
                .HasOne(CE => CE.CV)
                .WithMany(C => C.CV_Education)
                .HasForeignKey(CC => CC.Cv_ID);

            //builder.Entity<CV_Education>().HasData(
            //   new CV_Education
            //   {
            //       Cv_ID = 1,
            //       Education_ID = 1
            //   }

            //   );

            builder.Entity<CV>().HasKey(c => c.Cv_ID);
            builder.Entity<Experience>().HasKey(e => e.Experience_ID);
            builder.Entity<CV_Experience>().HasKey(ce => new { ce.Cv_ID, ce.Experience_ID });

            builder.Entity<CV_Experience>()
                .HasOne(CEx => CEx.Experience)
                .WithMany(S => S.CV_Experience)
                .HasForeignKey(CC => CC.Experience_ID);

            builder.Entity<CV_Experience>()
                .HasOne(CEx => CEx.CV)
                .WithMany(C => C.CV_Experience)
                .HasForeignKey(CEx => CEx.Cv_ID);


            //builder.Entity<CV_Experience>().HasData(
            //   new CV_Experience
            //   {
            //       Cv_ID = 1,
            //       Experience_ID = 1
            //   }

            //   );


            builder.Entity<CV>().HasKey(c => c.Cv_ID);
            builder.Entity<Competence>().HasKey(c => c.Competence_ID);
            builder.Entity<CV_Competence>().HasKey(ce => new { ce.Cv_ID, ce.Competence_ID });


            builder.Entity<CV_Competence>()
                .HasOne(CC => CC.Competence)
                .WithMany(S => S.CV_Competence)
                .HasForeignKey(CC => CC.Competence_ID);

            builder.Entity<CV_Competence>()
                .HasOne(CC => CC.CV)
                .WithMany(C => C.CV_Competence)
                .HasForeignKey(CC => CC.Cv_ID);



            //builder.Entity<CV_Competence>().HasData(
            //   new CV_Competence
            //   {
            //       Cv_ID = 1,
            //       Competence_ID = 1
            //   }
            //   );
        }
        }
}
