﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebStudentDatabaseAPI.Data;

#nullable disable

namespace WebStudentDatabaseAPI.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20240207092958_StudentMig")]
    partial class StudentMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebStudentDatabaseAPI.Models.Student", b =>
                {
                    b.Property<int>("StuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StuId"), 1L, 1);

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<string>("StuName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StuId");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
