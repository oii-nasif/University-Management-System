using Entity.Entities;
using Entity.ViewModel;
using Microsoft.EntityFrameworkCore;
using UCRMS_API.Model;
using UCRMS_API.Models;

namespace UCRMS_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Semester> Semesters => Set<Semester>();
        public DbSet<Designation> Designations => Set<Designation>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
        public DbSet<CourseAssignment> CourseAssignments => Set<CourseAssignment>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<RoomNo> RoomNos => Set<RoomNo>();
        public DbSet<Day> Days => Set<Day>();
        public DbSet<AllocateClassroom> AllocateClassrooms => Set<AllocateClassroom>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Seed();
        }
    }
}
