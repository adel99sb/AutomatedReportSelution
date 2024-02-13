using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomatedReportAPI.Migrations
{
    public partial class Hangfire_Setup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("4ae732e6-30c1-4fce-87dc-3d8944d8af69"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("56d54a41-9368-4d96-a3f2-545bd553a7a3"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("6d815e3f-e0d5-4ef9-b576-e74aad719570"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0a4db11a-3b0f-4ec6-b558-d14b7e93f244"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("42629396-6a6f-4c0b-86d4-cdebf1c65aa9"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("493b6595-4fab-4178-84f7-e5bd6796e26b"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("5bb4ac05-cceb-4c31-84b0-bf70e5c8ad4a"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("6f7c85f3-5154-4761-ba04-78639de1d3fa"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("8fb8c54a-1deb-4fef-bf8b-5734affc3c08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94fbe68a-74a1-4444-a5be-fe85cfe8d999"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf28626c-a92a-44c7-b9e8-238c736c3bca"));

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d3429f0-91c6-436d-8449-783c1232fbb0"), "الشهادة الثانوية - أدبي" },
                    { new Guid("2e4ef6ad-f496-42f3-9e35-906824ce7715"), "الشهادة الإعدادية" },
                    { new Guid("f2ea5c52-2c85-48ec-ab4e-5f4b5fd01597"), "الشهادة الثانوية - علمي" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name", "Time" },
                values: new object[,]
                {
                    { new Guid("549bd3fd-79a7-476b-9cc7-11f8f1ee7c7d"), "الحصة السادسة", 5 },
                    { new Guid("6612001e-5eb7-4add-bd7f-04337882d2ff"), "الحصة الخامسة", 4 },
                    { new Guid("6d40112e-362b-4849-a5f8-1e142af0f6ac"), "الحصة الأولى", 0 },
                    { new Guid("7dee2ec1-9d02-43e5-87de-d7e5970c1706"), "الحصة الثانية", 1 },
                    { new Guid("c0016ae4-180b-498a-bd4a-84cfeaea1b76"), "الحصة الرابعة", 3 },
                    { new Guid("d693b808-db65-4595-a4cc-dfc8d71fb077"), "الحصة الثالثة", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Type" },
                values: new object[,]
                {
                    { new Guid("398ed3d2-8adf-4b34-bb12-e647cd804b9a"), "AaBbCc@112233", 0 },
                    { new Guid("b18084d6-1833-48b7-89bc-09b8b9fa6770"), "Aa@112233", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("0d3429f0-91c6-436d-8449-783c1232fbb0"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("2e4ef6ad-f496-42f3-9e35-906824ce7715"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("f2ea5c52-2c85-48ec-ab4e-5f4b5fd01597"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("549bd3fd-79a7-476b-9cc7-11f8f1ee7c7d"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("6612001e-5eb7-4add-bd7f-04337882d2ff"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("6d40112e-362b-4849-a5f8-1e142af0f6ac"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("7dee2ec1-9d02-43e5-87de-d7e5970c1706"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("c0016ae4-180b-498a-bd4a-84cfeaea1b76"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("d693b808-db65-4595-a4cc-dfc8d71fb077"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("398ed3d2-8adf-4b34-bb12-e647cd804b9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b18084d6-1833-48b7-89bc-09b8b9fa6770"));

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4ae732e6-30c1-4fce-87dc-3d8944d8af69"), "الشهادة الثانوية - أدبي" },
                    { new Guid("56d54a41-9368-4d96-a3f2-545bd553a7a3"), "الشهادة الإعدادية" },
                    { new Guid("6d815e3f-e0d5-4ef9-b576-e74aad719570"), "الشهادة الثانوية - علمي" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name", "Time" },
                values: new object[,]
                {
                    { new Guid("0a4db11a-3b0f-4ec6-b558-d14b7e93f244"), "الحصة الخامسة", 4 },
                    { new Guid("42629396-6a6f-4c0b-86d4-cdebf1c65aa9"), "الحصة الأولى", 0 },
                    { new Guid("493b6595-4fab-4178-84f7-e5bd6796e26b"), "الحصة السادسة", 5 },
                    { new Guid("5bb4ac05-cceb-4c31-84b0-bf70e5c8ad4a"), "الحصة الثالثة", 2 },
                    { new Guid("6f7c85f3-5154-4761-ba04-78639de1d3fa"), "الحصة الرابعة", 3 },
                    { new Guid("8fb8c54a-1deb-4fef-bf8b-5734affc3c08"), "الحصة الثانية", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Type" },
                values: new object[,]
                {
                    { new Guid("94fbe68a-74a1-4444-a5be-fe85cfe8d999"), "AaBbCc@112233", 0 },
                    { new Guid("bf28626c-a92a-44c7-b9e8-238c736c3bca"), "Aa@112233", 0 }
                });
        }
    }
}
