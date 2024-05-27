using Microsoft.EntityFrameworkCore;
using WebAPIPracticeProject.Data.Config;
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
            //modelBuilder.Entity<Student>().HasData(new List<Student>()
            //{
            //    new Student{Id=1, Name="DummyData", Address="adrds--", AdmissionDate=DateTime.Now, Age=25}
            //});

            //modelBuilder.Entity<Student>(entity =>
            //{
            //    //entity.Property(n => n.Name).IsRequired().HasMaxLength(100);
            //    //entity.Property(n => n.Address).IsRequired().HasMaxLength(250);
            //    //entity.Property(n => n.Name).HasMaxLength(100);
            //    //entity.Property(n=> n.Address).HasMaxLength(250);   

            //}
            //);

            modelBuilder.ApplyConfiguration(new StudentConfig());
        }

    }
}
