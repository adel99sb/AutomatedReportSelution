using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomatedReportAPI.Migrations
{
    public partial class InintialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    From_Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To_Time = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hall",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hall", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Full_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divisions_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certificates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certificates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Parent_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Parent_Phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Total_Payments = table.Column<double>(type: "float", nullable: false),
                    DivisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sessions_Records",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DivisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    day = table.Column<int>(type: "int", nullable: false),
                    HallId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Records_Classes__ClassId",
                        column: x => x._ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Records_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Records_Hall_HallId",
                        column: x => x.HallId,
                        principalTable: "Hall",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Records_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalMark = table.Column<double>(type: "float", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DivisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tests_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tests_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scores_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DailySessions_Records",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sessions_RecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject_Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailySessions_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailySessions_Records_Sessions_Records_Sessions_RecordId",
                        column: x => x.Sessions_RecordId,
                        principalTable: "Sessions_Records",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Test_Marks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Mark = table.Column<double>(type: "float", nullable: false),
                    TestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test_Marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Test_Marks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Test_Marks_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Enter_Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Outer_Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DailySessions_RecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_DailySessions_Records_DailySessions_RecordId",
                        column: x => x.DailySessions_RecordId,
                        principalTable: "DailySessions_Records",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1b2863ac-355c-482e-ae38-cea49080ed26"), "الشهادة الثانوية - أدبي" },
                    { new Guid("36d07ab7-6bcf-4fc2-abf3-01c5d1a0ea57"), "الشهادة الثانوية - علمي" },
                    { new Guid("fc80176a-a242-41c8-a1c3-fbd5be3ea6a1"), "الشهادة الإعدادية" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "From_Time", "Name", "To_Time" },
                values: new object[,]
                {
                    { new Guid("100eaf83-d59b-4be2-bbf3-60d6f8424f23"), "03:00", "الحصة السادسة", "04:30" },
                    { new Guid("54480f6f-9b8b-4e12-a921-6c27ecdfa8aa"), "08:30", "الحصة الأولى", "10:00" },
                    { new Guid("547498e8-664d-49cf-9ad0-c3b21f03b297"), "02:30", "الحصة الخامسة", "03:00" },
                    { new Guid("7e3a5dd4-df51-4982-9446-0345df038d44"), "01:00", "الحصة الرابعة", "02:30" },
                    { new Guid("8a13e7e0-8ae8-4f58-881c-5d988acb1869"), "10:00", "الحصة الثانية", "11:30" },
                    { new Guid("d1dcb2c0-7e64-45f1-b9ba-7d9673237215"), "11:30", "الحصة الثالثة", "01:00" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Type" },
                values: new object[,]
                {
                    { new Guid("90047aef-e518-4c7d-9097-c21e2335743f"), "AaBbCc@112233", "مدير" },
                    { new Guid("a2aef319-f5b5-473b-8219-66a10f49b229"), "Aa@112233", "مشرف" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CertificateId", "Name" },
                values: new object[,]
                {
                    { new Guid("04c0ef73-cef7-4b85-a5a8-0d5480c29488"), new Guid("1b2863ac-355c-482e-ae38-cea49080ed26"), "لغة عربية" },
                    { new Guid("18287ed1-6d11-4ecc-9d6e-6a23873f0e27"), new Guid("fc80176a-a242-41c8-a1c3-fbd5be3ea6a1"), "لغة انكليزية" },
                    { new Guid("1e17efcb-d6c0-4dab-afc3-b02e761c7d55"), new Guid("36d07ab7-6bcf-4fc2-abf3-01c5d1a0ea57"), "ديانة" },
                    { new Guid("26a68f1c-8192-42c4-acff-88eb5f876741"), new Guid("36d07ab7-6bcf-4fc2-abf3-01c5d1a0ea57"), "فيزياء" },
                    { new Guid("2fc418cd-e827-468d-855d-67db6e805dfd"), new Guid("fc80176a-a242-41c8-a1c3-fbd5be3ea6a1"), "فيزياء و كيمياء" },
                    { new Guid("425cf91c-887d-4f4e-9b90-0a490d77b3a6"), new Guid("36d07ab7-6bcf-4fc2-abf3-01c5d1a0ea57"), "رياضيات" },
                    { new Guid("4859812d-9f19-4f69-9c3b-edb13bcf57b5"), new Guid("1b2863ac-355c-482e-ae38-cea49080ed26"), "لغة انكليزية" },
                    { new Guid("622de670-66c7-4637-888c-eabd2afa2d10"), new Guid("36d07ab7-6bcf-4fc2-abf3-01c5d1a0ea57"), "كيمياء" },
                    { new Guid("725910ba-fcd6-44b0-8d59-da1e188a2cd3"), new Guid("1b2863ac-355c-482e-ae38-cea49080ed26"), "لغة فرنسية" },
                    { new Guid("7af3288b-35d2-49fb-8c1f-eab7bb77d75f"), new Guid("36d07ab7-6bcf-4fc2-abf3-01c5d1a0ea57"), "لغة فرنسية" },
                    { new Guid("919165e1-49aa-41f6-adf2-5271a4b6b639"), new Guid("36d07ab7-6bcf-4fc2-abf3-01c5d1a0ea57"), "وطنية" },
                    { new Guid("925432df-b41f-4aec-8b82-a17742b43a87"), new Guid("36d07ab7-6bcf-4fc2-abf3-01c5d1a0ea57"), "لغة عربية" },
                    { new Guid("9636e080-8c92-4f03-84ac-0d45d11f5184"), new Guid("1b2863ac-355c-482e-ae38-cea49080ed26"), "ديانة" },
                    { new Guid("9e45f555-64fa-497c-90b3-bb6a89b1fcc9"), new Guid("fc80176a-a242-41c8-a1c3-fbd5be3ea6a1"), "لغة عربية" },
                    { new Guid("a92d8aa1-c783-4a05-8066-7c0d40553e49"), new Guid("1b2863ac-355c-482e-ae38-cea49080ed26"), "تاريخ" },
                    { new Guid("a968c0cd-c8d0-4a80-b04f-4391cc54c331"), new Guid("1b2863ac-355c-482e-ae38-cea49080ed26"), "فلسفة" },
                    { new Guid("ab66d2cd-3029-4e26-b884-aae60d62208d"), new Guid("fc80176a-a242-41c8-a1c3-fbd5be3ea6a1"), "علوم" },
                    { new Guid("b061b6a6-2fb8-4d24-bce4-07a5b9539850"), new Guid("fc80176a-a242-41c8-a1c3-fbd5be3ea6a1"), "ديانة" },
                    { new Guid("bf242ba9-2b78-45c6-8292-df52829a616e"), new Guid("fc80176a-a242-41c8-a1c3-fbd5be3ea6a1"), "اجتماعيات" },
                    { new Guid("c763d7dc-d47e-4bc2-b335-75c3b58b5f5e"), new Guid("1b2863ac-355c-482e-ae38-cea49080ed26"), "وطنية" },
                    { new Guid("de18a1b8-b55a-49a5-9dff-29274d33d5e0"), new Guid("fc80176a-a242-41c8-a1c3-fbd5be3ea6a1"), "رياضيات" },
                    { new Guid("e42b56cd-36c9-43eb-8cd8-fae8d6c0f954"), new Guid("36d07ab7-6bcf-4fc2-abf3-01c5d1a0ea57"), "علم أحياء" },
                    { new Guid("e6a7af08-985a-42d3-a361-931e055f8ba8"), new Guid("fc80176a-a242-41c8-a1c3-fbd5be3ea6a1"), "لغة فرنسية" },
                    { new Guid("e809e402-4e3e-4a72-a108-8660f8f94e74"), new Guid("1b2863ac-355c-482e-ae38-cea49080ed26"), "جغرافيا" },
                    { new Guid("e97949c3-1073-49e8-acc7-9ffc8e188410"), new Guid("36d07ab7-6bcf-4fc2-abf3-01c5d1a0ea57"), "لغة انكليزية" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_DailySessions_RecordId",
                table: "Attendances",
                column: "DailySessions_RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_DailySessions_Records_Sessions_RecordId",
                table: "DailySessions_Records",
                column: "Sessions_RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_CertificateId",
                table: "Divisions",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_StudentId",
                table: "Payments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_StudentId",
                table: "Scores",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_Records__ClassId",
                table: "Sessions_Records",
                column: "_ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_Records_DivisionId",
                table: "Sessions_Records",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_Records_HallId",
                table: "Sessions_Records",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_Records_SubjectId",
                table: "Sessions_Records",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DivisionId",
                table: "Students",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CertificateId",
                table: "Subjects",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Marks_StudentId",
                table: "Test_Marks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Marks_TestId",
                table: "Test_Marks",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_DivisionId",
                table: "Tests",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_SubjectId",
                table: "Tests",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Test_Marks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DailySessions_Records");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Sessions_Records");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Hall");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Certificates");
        }
    }
}
