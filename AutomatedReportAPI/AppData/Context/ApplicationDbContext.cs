using AutomatedReportAPI.AppData.Models;
using Microsoft.EntityFrameworkCore;

namespace AutomatedReportAPI.AppData.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<_Class> Classes { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Sessions_Record> Sessions_Records { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Test_Mark> Test_Marks { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Remove cascade delete convention for all relationships
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;                
            }
            // Data Seeds
            modelBuilder.Entity<Certificate>().HasData(
                new Certificate()
                {
                    Name = "الشهادة الإعدادية"
                },
                new Certificate()
                {
                    Name = "الشهادة الثانوية - علمي"
                },
                new Certificate()
                {
                    Name = "الشهادة الثانوية - أدبي"
                });
            modelBuilder.Entity<_Class>().HasData(
                new _Class()
                {
                    Name = "الحصة الأولى",
                    Time = Enums.ClassTimes.First
                },
                new _Class()
                {
                    Name = "الحصة الثانية",
                    Time = Enums.ClassTimes.Second
                },
                new _Class()
                {
                    Name = "الحصة الثالثة",
                    Time = Enums.ClassTimes.Therid
                },
                new _Class()
                {
                    Name = "الحصة الرابعة",
                    Time = Enums.ClassTimes.Fourth
                },
                new _Class()
                {
                    Name = "الحصة الخامسة",
                    Time = Enums.ClassTimes.Fiveth
                },
                new _Class()
                {
                    Name = "الحصة السادسة",
                    Time = Enums.ClassTimes.Sixeth
                });
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Type = Enums.UserTypes.Manager,
                    Password = "AaBbCc@112233"
                },
                new User()
                {
                    Type = Enums.UserTypes.Assistante,
                    Password = "Aa@112233"
                });
        }
    }
}
