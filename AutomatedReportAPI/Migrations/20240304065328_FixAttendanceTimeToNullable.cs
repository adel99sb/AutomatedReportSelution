using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomatedReportAPI.Migrations
{
    public partial class FixAttendanceTimeToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0349d7ec-988d-43d5-b023-fe7c1cd7fc64"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("15e464ce-a4f1-4ce2-a176-7735ae119483"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("acd904fa-d98c-404d-8819-71baaf838ff1"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("b07947a0-e940-471a-9b34-cf3780c273c8"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("ebb28142-f772-479e-8ac8-1e9d711c72af"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("f63fbc04-e602-4b5e-a8f7-78851c5df53a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("0326e7d7-031d-4950-bcf0-929d3a66ec6a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2a359972-8e8a-46c6-b1ea-b6b5893a07dc"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2aaa82d0-eb12-4dae-a8ce-4073adf8dd36"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2bae7e37-2dd7-4863-b3cc-5f5bada22e3c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("33178b0f-f393-4cd5-948f-b40ed581c561"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3590fa00-e3fc-4d12-b11d-82438bcfd9dc"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("405c8e3b-d723-4e9e-bd8a-2b49468d2ccb"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4223b132-1752-4241-bb43-cbc01fcb92ff"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4aa55386-a9b4-45b7-b563-6be939bfb7ad"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("52533348-96ea-4aa1-8e26-be22347aecae"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("589ae8e7-7a42-42e2-b7d2-fc7253a6000d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5ebaa2ad-b617-4175-9128-08250adcf4a1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("85284b43-15c3-4bf7-96f7-ae8022fef41f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("879056eb-4049-4e11-8f44-07ec2c4181bc"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("887d571e-e050-40a2-a052-7e5a6f488609"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("88c4d40f-2d2b-466c-8cac-193191adc028"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8e4aa679-c7f2-4cbf-a21b-8351f7aa9e8c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a4382d18-fad1-4d12-8a5f-d3571716c6f7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b61c1915-b1cd-4f26-9d84-8fe221d3ab4e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("bf261913-79ac-4a4e-ab22-4aa0e32ce335"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d3a380f2-418e-4ba4-844e-27135a316608"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ddf35a61-b1a7-4471-bb00-4a3b788d8a52"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ea0cfce5-d4f6-4bc0-84c4-4ec945925d00"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ebaea11c-3a01-4aa3-a323-bfc7c2c057f9"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f3424811-f7f4-4429-97a1-0eb3ca1584db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b721616-1c4c-49f8-ad23-929dddd08442"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd2deb31-06ed-4e4b-8466-e053f8cb2dff"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("033b19f7-cd84-49b9-90c4-39cd32b0d507"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("0fb09817-1dea-4154-b7de-f836a2feb664"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("d1305bdb-3739-4d9a-8105-954f563846d5"));

            migrationBuilder.AlterColumn<string>(
                name: "Outer_Time",
                table: "Attendances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Enter_Time",
                table: "Attendances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1afbd8e7-a917-4c16-bc56-1b5bbb0df4dd"), "الشهادة الإعدادية" },
                    { new Guid("a0e2acd6-c7bd-4433-a707-ada7863d05e0"), "الشهادة الثانوية - علمي" },
                    { new Guid("f585bff8-97aa-4981-83cf-4bc84d0c284a"), "الشهادة الثانوية - أدبي" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "From_Time", "Name", "To_Time" },
                values: new object[,]
                {
                    { new Guid("020a6539-370d-4495-88ff-9cc524d04a7f"), "08:30", "الحصة الأولى", "10:00" },
                    { new Guid("294bedf1-26b2-4205-b24f-11d9bb416e84"), "10:00", "الحصة الثانية", "11:30" },
                    { new Guid("5625f3da-e0c8-4c22-b894-8081c3b786b5"), "01:00", "الحصة الرابعة", "02:30" },
                    { new Guid("78eb997e-ea0f-4787-a933-d282d580dd64"), "03:00", "الحصة السادسة", "04:30" },
                    { new Guid("ba19bef5-cd10-41ad-b8a2-f859933289ec"), "11:30", "الحصة الثالثة", "01:00" },
                    { new Guid("fc8108c2-551d-4722-8eaa-d19e0cdff23c"), "02:30", "الحصة الخامسة", "03:00" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Type" },
                values: new object[,]
                {
                    { new Guid("10f3562f-1a07-4dab-a16b-8b64855df56d"), "AaBbCc@112233", "مدير" },
                    { new Guid("c16c70bd-ab3e-430e-a0d1-b35ec0ff2953"), "Aa@112233", "مشرف" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CertificateId", "Name" },
                values: new object[,]
                {
                    { new Guid("09b9b8fc-0a7d-4e9a-8948-a1dc01e95637"), new Guid("1afbd8e7-a917-4c16-bc56-1b5bbb0df4dd"), "لغة عربية" },
                    { new Guid("258cd579-3a63-41ed-be73-d5b11f31f7c0"), new Guid("f585bff8-97aa-4981-83cf-4bc84d0c284a"), "فلسفة" },
                    { new Guid("307a802b-1f4e-4595-95e3-a7feda4e0e70"), new Guid("a0e2acd6-c7bd-4433-a707-ada7863d05e0"), "علم أحياء" },
                    { new Guid("334afdcb-b122-4681-8953-1566a765c3b9"), new Guid("a0e2acd6-c7bd-4433-a707-ada7863d05e0"), "لغة انكليزية" },
                    { new Guid("3b97199e-4f77-4c55-a66c-5f0d03aa7b56"), new Guid("f585bff8-97aa-4981-83cf-4bc84d0c284a"), "ديانة" },
                    { new Guid("3eee41cb-6a51-450e-831c-f160def8bad3"), new Guid("1afbd8e7-a917-4c16-bc56-1b5bbb0df4dd"), "لغة فرنسية" },
                    { new Guid("43e373f1-fc70-4e06-ac65-8c0f5b4f9c93"), new Guid("1afbd8e7-a917-4c16-bc56-1b5bbb0df4dd"), "اجتماعيات" },
                    { new Guid("4cd7dea9-8a73-47af-aaa1-aa8d4abb18ea"), new Guid("a0e2acd6-c7bd-4433-a707-ada7863d05e0"), "فيزياء" },
                    { new Guid("4e1eb7c4-096d-49d9-94ad-5e6fcb949917"), new Guid("f585bff8-97aa-4981-83cf-4bc84d0c284a"), "لغة عربية" },
                    { new Guid("50de49cd-c4ff-4ab8-a57e-79a1fcb62827"), new Guid("f585bff8-97aa-4981-83cf-4bc84d0c284a"), "وطنية" },
                    { new Guid("5b1a3ca7-e53e-4a15-9631-d88c2b1c1cff"), new Guid("a0e2acd6-c7bd-4433-a707-ada7863d05e0"), "لغة فرنسية" },
                    { new Guid("5d275a5f-1d18-4755-9aef-b3e17e898fa8"), new Guid("1afbd8e7-a917-4c16-bc56-1b5bbb0df4dd"), "علوم" },
                    { new Guid("670cdbf8-3120-4c59-8dac-afcbc73b72f5"), new Guid("f585bff8-97aa-4981-83cf-4bc84d0c284a"), "لغة انكليزية" },
                    { new Guid("67d5ea2d-09bd-4a3b-99fe-e032d21a602d"), new Guid("f585bff8-97aa-4981-83cf-4bc84d0c284a"), "تاريخ" },
                    { new Guid("89746f7e-a63b-4a13-bbda-563b98f682c1"), new Guid("a0e2acd6-c7bd-4433-a707-ada7863d05e0"), "لغة عربية" },
                    { new Guid("89d62677-3e42-45bd-ae3e-28441fa3d9b5"), new Guid("f585bff8-97aa-4981-83cf-4bc84d0c284a"), "لغة فرنسية" },
                    { new Guid("8ed34e0e-2122-4583-86ae-34922f792ab0"), new Guid("a0e2acd6-c7bd-4433-a707-ada7863d05e0"), "كيمياء" },
                    { new Guid("90646a00-3321-44e2-abfa-0aa03da43f37"), new Guid("1afbd8e7-a917-4c16-bc56-1b5bbb0df4dd"), "رياضيات" },
                    { new Guid("a34127ce-9723-454e-bdcd-0a9728d37c51"), new Guid("a0e2acd6-c7bd-4433-a707-ada7863d05e0"), "ديانة" },
                    { new Guid("a6c47bad-7e1d-4fe0-accc-8d7e74526670"), new Guid("1afbd8e7-a917-4c16-bc56-1b5bbb0df4dd"), "لغة انكليزية" },
                    { new Guid("ac192fb0-8d16-41d1-92fe-bddee696e3a8"), new Guid("a0e2acd6-c7bd-4433-a707-ada7863d05e0"), "رياضيات" },
                    { new Guid("d09c067d-ab4d-4d44-90f1-01e7e353253d"), new Guid("1afbd8e7-a917-4c16-bc56-1b5bbb0df4dd"), "ديانة" },
                    { new Guid("d3f4a398-0153-4c24-9908-7414217eb0de"), new Guid("f585bff8-97aa-4981-83cf-4bc84d0c284a"), "جغرافيا" },
                    { new Guid("d4581a7d-26b3-46d5-be62-13c4f14851c8"), new Guid("a0e2acd6-c7bd-4433-a707-ada7863d05e0"), "وطنية" },
                    { new Guid("e193ee40-0880-47d8-8019-e5e3fc988dcc"), new Guid("1afbd8e7-a917-4c16-bc56-1b5bbb0df4dd"), "فيزياء و كيمياء" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("020a6539-370d-4495-88ff-9cc524d04a7f"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("294bedf1-26b2-4205-b24f-11d9bb416e84"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("5625f3da-e0c8-4c22-b894-8081c3b786b5"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("78eb997e-ea0f-4787-a933-d282d580dd64"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("ba19bef5-cd10-41ad-b8a2-f859933289ec"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("fc8108c2-551d-4722-8eaa-d19e0cdff23c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("09b9b8fc-0a7d-4e9a-8948-a1dc01e95637"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("258cd579-3a63-41ed-be73-d5b11f31f7c0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("307a802b-1f4e-4595-95e3-a7feda4e0e70"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("334afdcb-b122-4681-8953-1566a765c3b9"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3b97199e-4f77-4c55-a66c-5f0d03aa7b56"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3eee41cb-6a51-450e-831c-f160def8bad3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("43e373f1-fc70-4e06-ac65-8c0f5b4f9c93"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4cd7dea9-8a73-47af-aaa1-aa8d4abb18ea"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4e1eb7c4-096d-49d9-94ad-5e6fcb949917"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("50de49cd-c4ff-4ab8-a57e-79a1fcb62827"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5b1a3ca7-e53e-4a15-9631-d88c2b1c1cff"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5d275a5f-1d18-4755-9aef-b3e17e898fa8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("670cdbf8-3120-4c59-8dac-afcbc73b72f5"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("67d5ea2d-09bd-4a3b-99fe-e032d21a602d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("89746f7e-a63b-4a13-bbda-563b98f682c1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("89d62677-3e42-45bd-ae3e-28441fa3d9b5"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8ed34e0e-2122-4583-86ae-34922f792ab0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("90646a00-3321-44e2-abfa-0aa03da43f37"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a34127ce-9723-454e-bdcd-0a9728d37c51"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a6c47bad-7e1d-4fe0-accc-8d7e74526670"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ac192fb0-8d16-41d1-92fe-bddee696e3a8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d09c067d-ab4d-4d44-90f1-01e7e353253d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d3f4a398-0153-4c24-9908-7414217eb0de"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d4581a7d-26b3-46d5-be62-13c4f14851c8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e193ee40-0880-47d8-8019-e5e3fc988dcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10f3562f-1a07-4dab-a16b-8b64855df56d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c16c70bd-ab3e-430e-a0d1-b35ec0ff2953"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("1afbd8e7-a917-4c16-bc56-1b5bbb0df4dd"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("a0e2acd6-c7bd-4433-a707-ada7863d05e0"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("f585bff8-97aa-4981-83cf-4bc84d0c284a"));

            migrationBuilder.AlterColumn<string>(
                name: "Outer_Time",
                table: "Attendances",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Enter_Time",
                table: "Attendances",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("033b19f7-cd84-49b9-90c4-39cd32b0d507"), "الشهادة الثانوية - أدبي" },
                    { new Guid("0fb09817-1dea-4154-b7de-f836a2feb664"), "الشهادة الثانوية - علمي" },
                    { new Guid("d1305bdb-3739-4d9a-8105-954f563846d5"), "الشهادة الإعدادية" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "From_Time", "Name", "To_Time" },
                values: new object[,]
                {
                    { new Guid("0349d7ec-988d-43d5-b023-fe7c1cd7fc64"), "08:30", "الحصة الأولى", "10:00" },
                    { new Guid("15e464ce-a4f1-4ce2-a176-7735ae119483"), "11:30", "الحصة الثالثة", "01:00" },
                    { new Guid("acd904fa-d98c-404d-8819-71baaf838ff1"), "10:00", "الحصة الثانية", "11:30" },
                    { new Guid("b07947a0-e940-471a-9b34-cf3780c273c8"), "03:00", "الحصة السادسة", "04:30" },
                    { new Guid("ebb28142-f772-479e-8ac8-1e9d711c72af"), "01:00", "الحصة الرابعة", "02:30" },
                    { new Guid("f63fbc04-e602-4b5e-a8f7-78851c5df53a"), "02:30", "الحصة الخامسة", "03:00" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Type" },
                values: new object[,]
                {
                    { new Guid("9b721616-1c4c-49f8-ad23-929dddd08442"), "AaBbCc@112233", "مدير" },
                    { new Guid("fd2deb31-06ed-4e4b-8466-e053f8cb2dff"), "Aa@112233", "مشرف" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CertificateId", "Name" },
                values: new object[,]
                {
                    { new Guid("0326e7d7-031d-4950-bcf0-929d3a66ec6a"), new Guid("033b19f7-cd84-49b9-90c4-39cd32b0d507"), "لغة فرنسية" },
                    { new Guid("2a359972-8e8a-46c6-b1ea-b6b5893a07dc"), new Guid("d1305bdb-3739-4d9a-8105-954f563846d5"), "علوم" },
                    { new Guid("2aaa82d0-eb12-4dae-a8ce-4073adf8dd36"), new Guid("d1305bdb-3739-4d9a-8105-954f563846d5"), "لغة عربية" },
                    { new Guid("2bae7e37-2dd7-4863-b3cc-5f5bada22e3c"), new Guid("033b19f7-cd84-49b9-90c4-39cd32b0d507"), "لغة انكليزية" },
                    { new Guid("33178b0f-f393-4cd5-948f-b40ed581c561"), new Guid("0fb09817-1dea-4154-b7de-f836a2feb664"), "علم أحياء" },
                    { new Guid("3590fa00-e3fc-4d12-b11d-82438bcfd9dc"), new Guid("033b19f7-cd84-49b9-90c4-39cd32b0d507"), "وطنية" },
                    { new Guid("405c8e3b-d723-4e9e-bd8a-2b49468d2ccb"), new Guid("033b19f7-cd84-49b9-90c4-39cd32b0d507"), "لغة عربية" },
                    { new Guid("4223b132-1752-4241-bb43-cbc01fcb92ff"), new Guid("d1305bdb-3739-4d9a-8105-954f563846d5"), "فيزياء و كيمياء" },
                    { new Guid("4aa55386-a9b4-45b7-b563-6be939bfb7ad"), new Guid("d1305bdb-3739-4d9a-8105-954f563846d5"), "رياضيات" },
                    { new Guid("52533348-96ea-4aa1-8e26-be22347aecae"), new Guid("0fb09817-1dea-4154-b7de-f836a2feb664"), "وطنية" },
                    { new Guid("589ae8e7-7a42-42e2-b7d2-fc7253a6000d"), new Guid("033b19f7-cd84-49b9-90c4-39cd32b0d507"), "ديانة" },
                    { new Guid("5ebaa2ad-b617-4175-9128-08250adcf4a1"), new Guid("0fb09817-1dea-4154-b7de-f836a2feb664"), "ديانة" },
                    { new Guid("85284b43-15c3-4bf7-96f7-ae8022fef41f"), new Guid("0fb09817-1dea-4154-b7de-f836a2feb664"), "لغة عربية" },
                    { new Guid("879056eb-4049-4e11-8f44-07ec2c4181bc"), new Guid("0fb09817-1dea-4154-b7de-f836a2feb664"), "لغة فرنسية" },
                    { new Guid("887d571e-e050-40a2-a052-7e5a6f488609"), new Guid("0fb09817-1dea-4154-b7de-f836a2feb664"), "كيمياء" },
                    { new Guid("88c4d40f-2d2b-466c-8cac-193191adc028"), new Guid("033b19f7-cd84-49b9-90c4-39cd32b0d507"), "تاريخ" },
                    { new Guid("8e4aa679-c7f2-4cbf-a21b-8351f7aa9e8c"), new Guid("0fb09817-1dea-4154-b7de-f836a2feb664"), "فيزياء" },
                    { new Guid("a4382d18-fad1-4d12-8a5f-d3571716c6f7"), new Guid("0fb09817-1dea-4154-b7de-f836a2feb664"), "رياضيات" },
                    { new Guid("b61c1915-b1cd-4f26-9d84-8fe221d3ab4e"), new Guid("d1305bdb-3739-4d9a-8105-954f563846d5"), "ديانة" },
                    { new Guid("bf261913-79ac-4a4e-ab22-4aa0e32ce335"), new Guid("0fb09817-1dea-4154-b7de-f836a2feb664"), "لغة انكليزية" },
                    { new Guid("d3a380f2-418e-4ba4-844e-27135a316608"), new Guid("d1305bdb-3739-4d9a-8105-954f563846d5"), "لغة فرنسية" },
                    { new Guid("ddf35a61-b1a7-4471-bb00-4a3b788d8a52"), new Guid("033b19f7-cd84-49b9-90c4-39cd32b0d507"), "فلسفة" },
                    { new Guid("ea0cfce5-d4f6-4bc0-84c4-4ec945925d00"), new Guid("033b19f7-cd84-49b9-90c4-39cd32b0d507"), "جغرافيا" },
                    { new Guid("ebaea11c-3a01-4aa3-a323-bfc7c2c057f9"), new Guid("d1305bdb-3739-4d9a-8105-954f563846d5"), "لغة انكليزية" },
                    { new Guid("f3424811-f7f4-4429-97a1-0eb3ca1584db"), new Guid("d1305bdb-3739-4d9a-8105-954f563846d5"), "اجتماعيات" }
                });
        }
    }
}
