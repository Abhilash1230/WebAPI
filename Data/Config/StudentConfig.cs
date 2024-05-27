using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebAPIPracticeProject.Models;

namespace WebAPIPracticeProject.Data.Config
{
    public class StudentConfig:IEntityTypeConfiguration<Student>
    {

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseIdentityColumn();
            builder.Property(t=>t.Address).HasMaxLength(250).IsRequired();
            builder.Property(t=>t.Name).HasMaxLength(100).IsRequired();
            builder.Property(t=>t.Age).IsRequired();


            builder.HasData(new List<Student>()
            {
                new Student() { Id = 1,
                Name="dummyName",
                Address="DummyAddress",
                AdmissionDate=DateTime.Now,
                 Age=10
                });
        }
    }
}
