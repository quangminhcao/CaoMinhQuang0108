// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CaoMinhQuang108.Migrations
{
    [DbContext(typeof(ApplicationDBcontext))]
    [Migration("20211223100630_Create_Table_UniversityCMQ108")]
    partial class Create_Table_UniversityCMQ108
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CaoMinhQuang108.Models.UniversityCMQ108", b =>
                {
                    b.Property<string>("UniversityId")
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("UniversityName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("UniversityId");

                    b.ToTable("UniversityCMQ108");
                });
#pragma warning restore 612, 618
        }
    }
}
