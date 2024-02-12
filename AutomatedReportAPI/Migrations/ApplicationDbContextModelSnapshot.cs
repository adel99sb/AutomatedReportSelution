﻿// <auto-generated />
using System;
using AutomatedReportAPI.AppData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutomatedReportAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models._Class", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("aed717cf-eff1-4f8c-b6af-7095dab1bf8b"),
                            Name = "الحصة الأولى",
                            Time = 0
                        },
                        new
                        {
                            Id = new Guid("9cb0221c-b386-4795-b4a9-c80b777ad9a0"),
                            Name = "الحصة الثانية",
                            Time = 1
                        },
                        new
                        {
                            Id = new Guid("8ea5b6cb-26fd-4c76-8fe5-9952779b4e66"),
                            Name = "الحصة الثالثة",
                            Time = 2
                        },
                        new
                        {
                            Id = new Guid("09eab6cf-fccc-4a32-9485-b711286d4181"),
                            Name = "الحصة الرابعة",
                            Time = 3
                        },
                        new
                        {
                            Id = new Guid("8ca2e97f-a24d-4d1f-ba61-a68032e2a933"),
                            Name = "الحصة الخامسة",
                            Time = 4
                        },
                        new
                        {
                            Id = new Guid("fe3d734e-9325-4a4b-a786-904f14ebac8d"),
                            Name = "الحصة السادسة",
                            Time = 5
                        });
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Advertisement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Advertisements");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Attendance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Enter_Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Outer_Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("sessionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("sessionId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Certificate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Certificates");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3a6d666c-b63b-4cb4-8305-5513aa2606ae"),
                            Name = "الشهادة الإعدادية"
                        },
                        new
                        {
                            Id = new Guid("2692443d-96a2-4313-8a4d-da64c17f8967"),
                            Name = "الشهادة الثانوية - علمي"
                        },
                        new
                        {
                            Id = new Guid("d1b96993-8923-4025-bc12-4864354b1676"),
                            Name = "الشهادة الثانوية - أدبي"
                        });
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Division", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CertificateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CertificateId");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Score", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Sessions_Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DivisionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("_ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("day")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("_ClassId");

                    b.ToTable("Sessions_Records");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DivisionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Parent_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Parent_Phone")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<double>("Total_Payments")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CertificateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CertificateId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Full_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DivisionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Test_Mark", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Mark")
                        .HasColumnType("float");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TestId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TestId");

                    b.ToTable("Test_Marks");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("747a417f-f3f4-48c8-b7f6-202ace0f04d8"),
                            Password = "AaBbCc@112233",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("11ccab5a-c461-4615-81fc-4c022e6f95bd"),
                            Password = "Aa@112233",
                            Type = 0
                        });
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Attendance", b =>
                {
                    b.HasOne("AutomatedReportAPI.AppData.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutomatedReportAPI.AppData.Models.Sessions_Record", "session")
                        .WithMany()
                        .HasForeignKey("sessionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("session");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Division", b =>
                {
                    b.HasOne("AutomatedReportAPI.AppData.Models.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Certificate");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Payment", b =>
                {
                    b.HasOne("AutomatedReportAPI.AppData.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Score", b =>
                {
                    b.HasOne("AutomatedReportAPI.AppData.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Sessions_Record", b =>
                {
                    b.HasOne("AutomatedReportAPI.AppData.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutomatedReportAPI.AppData.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutomatedReportAPI.AppData.Models._Class", "_Class")
                        .WithMany()
                        .HasForeignKey("_ClassId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Division");

                    b.Navigation("Subject");

                    b.Navigation("_Class");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Student", b =>
                {
                    b.HasOne("AutomatedReportAPI.AppData.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Division");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Subject", b =>
                {
                    b.HasOne("AutomatedReportAPI.AppData.Models.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Certificate");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Teacher", b =>
                {
                    b.HasOne("AutomatedReportAPI.AppData.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Test", b =>
                {
                    b.HasOne("AutomatedReportAPI.AppData.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutomatedReportAPI.AppData.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Division");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Test_Mark", b =>
                {
                    b.HasOne("AutomatedReportAPI.AppData.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutomatedReportAPI.AppData.Models.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Test");
                });
#pragma warning restore 612, 618
        }
    }
}
