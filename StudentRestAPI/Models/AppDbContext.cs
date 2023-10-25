using Microsoft.EntityFrameworkCore;

namespace StudentRestAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "Akash",
                    LastName = "Gupta",
                    Email = "Akash@gmail.com",
                    DateOfBirth = new DateTime(1992,8,14),
                    Gender = Gender.Male,
                    DepartmentId = 1,
                    PhotoPath = "Images/Akash.png"
                });
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 3,
                    FirstName = "Christina",
                    LastName = "Frost",
                    Email = "Chris@gmail.com",
                    DateOfBirth = new DateTime(1987, 12, 5),
                    Gender = Gender.Female,
                    DepartmentId = 2,
                    PhotoPath = "Images/Christina.png"
                });
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 4,
                    FirstName = "Rachel",
                    LastName = "Stone",
                    Email = "Rachel@gmail.com",
                    DateOfBirth = new DateTime(1993, 1, 27),
                    Gender = Gender.Female,
                    DepartmentId = 3,
                    PhotoPath = "Images/Rachel.png"
                });
        }
    }
}
