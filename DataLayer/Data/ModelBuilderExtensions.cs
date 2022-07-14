using Microsoft.EntityFrameworkCore;
using UCRMS_API.Models;

namespace UCRMS_API.Model
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Semester>().HasData(
                new Semester { Name = "1st Semester" },
                new Semester { Name = "2nd Semester" },
                new Semester { Name = "3rd Semester" },
                new Semester { Name = "4th Semester" },
                new Semester { Name = "5th Semester" },
                new Semester { Name = "6th Semester" },
                new Semester { Name = "7th Semester" },
                new Semester { Name = "8th Semester" }
            );
            /*modelBuilder.Entity<Semester>().HasNoKey();*/

            modelBuilder.Entity<Designation>().HasData(
                new Designation { Name = "Lecturer" },
                new Designation { Name = "Assistance Professor" },
                new Designation { Name = "Associate Professor" },
                new Designation { Name = "Professor" }
            );
            /*modelBuilder.Entity<Designation>().HasNoKey();
            modelBuilder.Entity<Course>().HasNoKey();
            modelBuilder.Entity<Department>().HasNoKey();
            modelBuilder.Entity<Teacher>().HasNoKey();*/
        }
    }
}
