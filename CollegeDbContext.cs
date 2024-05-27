using Microsoft.EntityFrameworkCore;
using WebAPIPracticeProject.Models;

namespace WebAPIPracticeProject.Data
{
    public class CollegeDbContext:DbContext
    {

        public CollegeDbContext(DbContextOptions<CollegeDbContext> options) : base(options) {
        }
        DbSet<Student> Students {  get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new List<Student>()
            {
                new Student{Id=1, Name="DummyData", Address="adrds--", AdmissionDate=DateTime.Now, Age=25}
            });
        }

    }
}
