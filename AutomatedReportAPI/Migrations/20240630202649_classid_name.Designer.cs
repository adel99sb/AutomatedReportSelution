﻿// <auto-generated />
using System;
using AutomatedReportAPI.AppData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutomatedReportAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240630202649_classid_name")]
    partial class classid_name
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("From_Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("To_Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8d18e93b-441a-4fa2-8575-a8c283fcbec6"),
                            From_Time = "08:30",
                            Name = "الحصة الأولى",
                            To_Time = "10:00"
                        },
                        new
                        {
                            Id = new Guid("70384e75-34e2-4765-a9d4-336ec920141d"),
                            From_Time = "10:00",
                            Name = "الحصة الثانية",
                            To_Time = "11:30"
                        },
                        new
                        {
                            Id = new Guid("77da8fa9-f933-4bb6-8f07-be2c92091910"),
                            From_Time = "11:30",
                            Name = "الحصة الثالثة",
                            To_Time = "01:00"
                        },
                        new
                        {
                            Id = new Guid("23e0e53a-3d08-478d-8ff8-cb8c96b72972"),
                            From_Time = "01:00",
                            Name = "الحصة الرابعة",
                            To_Time = "02:30"
                        },
                        new
                        {
                            Id = new Guid("b2a972e8-1bc0-4b06-bdec-a1839cc934e2"),
                            From_Time = "02:30",
                            Name = "الحصة الخامسة",
                            To_Time = "03:00"
                        },
                        new
                        {
                            Id = new Guid("7dfd1656-6e0e-4f17-ae77-cd7f14e88dac"),
                            From_Time = "03:00",
                            Name = "الحصة السادسة",
                            To_Time = "04:30"
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

                    b.Property<Guid>("DailySessions_RecordId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Enter_Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Outer_Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DailySessions_RecordId");

                    b.HasIndex("StudentId");

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
                            Id = new Guid("42eeac1f-c8fa-4d5d-b5a8-383790c7027c"),
                            Name = "الشهادة الإعدادية"
                        },
                        new
                        {
                            Id = new Guid("35eb7393-be09-4f76-a13d-ff17d1fa6308"),
                            Name = "الشهادة الثانوية - أدبي"
                        },
                        new
                        {
                            Id = new Guid("3a7484e4-f17a-4c70-9939-44eba3736bc7"),
                            Name = "الشهادة الثانوية - علمي"
                        });
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.DailySessions_Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Sessions_RecordId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Subject_Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Sessions_RecordId");

                    b.ToTable("DailySessions_Records");
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

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Hall", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hall");
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

                    b.Property<Guid>("HallId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("_ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("day")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.HasIndex("HallId");

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

                    b.HasData(
                        new
                        {
                            Id = new Guid("bce302ca-280d-4ce3-9c36-f8dac532e555"),
                            CertificateId = new Guid("42eeac1f-c8fa-4d5d-b5a8-383790c7027c"),
                            Name = "رياضيات"
                        },
                        new
                        {
                            Id = new Guid("e5d01d24-f7ad-4c86-8be9-2ea4da779220"),
                            CertificateId = new Guid("42eeac1f-c8fa-4d5d-b5a8-383790c7027c"),
                            Name = "فيزياء و كيمياء"
                        },
                        new
                        {
                            Id = new Guid("86b57bce-8b43-42f2-ab9a-560dc721b8eb"),
                            CertificateId = new Guid("42eeac1f-c8fa-4d5d-b5a8-383790c7027c"),
                            Name = "علوم"
                        },
                        new
                        {
                            Id = new Guid("79c271fc-ec3b-4be0-bcd7-7e3b1bcbc72a"),
                            CertificateId = new Guid("42eeac1f-c8fa-4d5d-b5a8-383790c7027c"),
                            Name = "لغة انكليزية"
                        },
                        new
                        {
                            Id = new Guid("12420c81-371f-434d-b594-478b4de8ff16"),
                            CertificateId = new Guid("42eeac1f-c8fa-4d5d-b5a8-383790c7027c"),
                            Name = "لغة فرنسية"
                        },
                        new
                        {
                            Id = new Guid("b729d04f-79fe-4753-bf37-79c7e297cf71"),
                            CertificateId = new Guid("42eeac1f-c8fa-4d5d-b5a8-383790c7027c"),
                            Name = "لغة عربية"
                        },
                        new
                        {
                            Id = new Guid("2ab87230-c11c-4513-ac64-b1883b10f35c"),
                            CertificateId = new Guid("42eeac1f-c8fa-4d5d-b5a8-383790c7027c"),
                            Name = "اجتماعيات"
                        },
                        new
                        {
                            Id = new Guid("19385ff6-fe89-4250-8f7e-ec9c8322e8cb"),
                            CertificateId = new Guid("42eeac1f-c8fa-4d5d-b5a8-383790c7027c"),
                            Name = "ديانة"
                        },
                        new
                        {
                            Id = new Guid("18582aff-0179-42b4-9ae1-eb47b53c625e"),
                            CertificateId = new Guid("35eb7393-be09-4f76-a13d-ff17d1fa6308"),
                            Name = "جغرافيا"
                        },
                        new
                        {
                            Id = new Guid("45a87a22-52e1-4b46-b380-74e34ed32877"),
                            CertificateId = new Guid("35eb7393-be09-4f76-a13d-ff17d1fa6308"),
                            Name = "لغة عربية"
                        },
                        new
                        {
                            Id = new Guid("85d532de-49b9-4b54-86bc-a734f8e46417"),
                            CertificateId = new Guid("35eb7393-be09-4f76-a13d-ff17d1fa6308"),
                            Name = "لغة فرنسية"
                        },
                        new
                        {
                            Id = new Guid("fb265fea-106f-4133-a712-fe3d3419908d"),
                            CertificateId = new Guid("35eb7393-be09-4f76-a13d-ff17d1fa6308"),
                            Name = "وطنية"
                        },
                        new
                        {
                            Id = new Guid("4b7f064f-ff23-44bf-913e-874e55099087"),
                            CertificateId = new Guid("35eb7393-be09-4f76-a13d-ff17d1fa6308"),
                            Name = "فلسفة"
                        },
                        new
                        {
                            Id = new Guid("262aafb4-da37-4c7b-b4f1-7a0f90ba6246"),
                            CertificateId = new Guid("35eb7393-be09-4f76-a13d-ff17d1fa6308"),
                            Name = "لغة انكليزية"
                        },
                        new
                        {
                            Id = new Guid("d859b28d-ee99-4612-940c-df7925be41ed"),
                            CertificateId = new Guid("35eb7393-be09-4f76-a13d-ff17d1fa6308"),
                            Name = "ديانة"
                        },
                        new
                        {
                            Id = new Guid("2ab0c0f5-40f8-425e-a5e8-4ba97800b0e8"),
                            CertificateId = new Guid("35eb7393-be09-4f76-a13d-ff17d1fa6308"),
                            Name = "تاريخ"
                        },
                        new
                        {
                            Id = new Guid("f29f7a55-bfd4-4d36-ac99-eb1b9b4c256c"),
                            CertificateId = new Guid("3a7484e4-f17a-4c70-9939-44eba3736bc7"),
                            Name = "فيزياء"
                        },
                        new
                        {
                            Id = new Guid("0dd2df41-4307-4850-8a50-c2d2ae842f6a"),
                            CertificateId = new Guid("3a7484e4-f17a-4c70-9939-44eba3736bc7"),
                            Name = "لغة عربية"
                        },
                        new
                        {
                            Id = new Guid("75b7d4ea-fb5b-4800-86b6-af0b179ab8a6"),
                            CertificateId = new Guid("3a7484e4-f17a-4c70-9939-44eba3736bc7"),
                            Name = "لغة فرنسية"
                        },
                        new
                        {
                            Id = new Guid("510a9743-eb96-4560-a1a5-48404b708f83"),
                            CertificateId = new Guid("3a7484e4-f17a-4c70-9939-44eba3736bc7"),
                            Name = "وطنية"
                        },
                        new
                        {
                            Id = new Guid("5f6071a2-d86d-4af0-95eb-f25804af27fd"),
                            CertificateId = new Guid("3a7484e4-f17a-4c70-9939-44eba3736bc7"),
                            Name = "رياضيات"
                        },
                        new
                        {
                            Id = new Guid("60020b08-2d06-422c-9342-2657a8b60aef"),
                            CertificateId = new Guid("3a7484e4-f17a-4c70-9939-44eba3736bc7"),
                            Name = "لغة انكليزية"
                        },
                        new
                        {
                            Id = new Guid("ba30c90c-7bd2-4b9e-a2a7-f0d17536a82a"),
                            CertificateId = new Guid("3a7484e4-f17a-4c70-9939-44eba3736bc7"),
                            Name = "ديانة"
                        },
                        new
                        {
                            Id = new Guid("a0bf60c9-a53a-44c1-8e97-94313fddafc9"),
                            CertificateId = new Guid("3a7484e4-f17a-4c70-9939-44eba3736bc7"),
                            Name = "علم أحياء"
                        },
                        new
                        {
                            Id = new Guid("3182c88d-90f3-49d0-8d20-80055b2ae11d"),
                            CertificateId = new Guid("3a7484e4-f17a-4c70-9939-44eba3736bc7"),
                            Name = "كيمياء"
                        });
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

                    b.HasKey("Id");

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

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TotalMark")
                        .HasColumnType("float");

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

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1f58bf4b-5e94-426c-b17c-201fe39311a8"),
                            Password = "AaBbCc@112233",
                            Type = "مدير"
                        },
                        new
                        {
                            Id = new Guid("6fc47e41-bfe7-4b48-b93e-af00a5e71858"),
                            Password = "Aa@112233",
                            Type = "مشرف"
                        });
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.Attendance", b =>
                {
                    b.HasOne("AutomatedReportAPI.AppData.Models.DailySessions_Record", "DailySessions_Record")
                        .WithMany()
                        .HasForeignKey("DailySessions_RecordId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutomatedReportAPI.AppData.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DailySessions_Record");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("AutomatedReportAPI.AppData.Models.DailySessions_Record", b =>
                {
                    b.HasOne("AutomatedReportAPI.AppData.Models.Sessions_Record", "Sessions_Record")
                        .WithMany()
                        .HasForeignKey("Sessions_RecordId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Sessions_Record");
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

                    b.HasOne("AutomatedReportAPI.AppData.Models.Hall", "Hall")
                        .WithMany()
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutomatedReportAPI.AppData.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutomatedReportAPI.AppData.Models._Class", "Class")
                        .WithMany()
                        .HasForeignKey("_ClassId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Division");

                    b.Navigation("Hall");

                    b.Navigation("Subject");
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