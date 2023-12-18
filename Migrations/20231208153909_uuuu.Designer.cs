﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurveySystem.Models;

#nullable disable

namespace SurveySystem.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231208153909_uuuu")]
    partial class uuuu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SurveySystem.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("SurveySystem.Models.TblKPI", b =>
                {
                    b.Property<int>("KPIDNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KPIDNum"));

                    b.Property<int>("DepNO")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("MeasurementUnit")
                        .HasColumnType("Bit");

                    b.Property<int>("TargetValue")
                        .HasColumnType("int");

                    b.HasKey("KPIDNum");

                    b.HasIndex("DepNO");

                    b.ToTable("KPIs");
                });

            modelBuilder.Entity("SurveySystem.Models.TblKPI", b =>
                {
                    b.HasOne("SurveySystem.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepNO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
