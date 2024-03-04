using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomatedReportAPI.Migrations
{
    public partial class FixIsDoneProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("06f4c2ff-d8b6-4821-af87-355c160eb9dd"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("480c6686-525b-42df-8f39-ab6b267c228f"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("7de75bbd-03c5-4de7-abc1-3b949fecc762"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("a0e24b3e-6250-4636-a5c4-ece8cbd920dd"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("d598d28a-6f21-4ca7-8573-e54484f48f7d"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("ee29381d-c010-4a75-afa9-092c9be14c3b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1090dc9f-14dd-41ac-a505-9270eefe69e5"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("14b1efee-ac2d-44d6-b496-9c6e2527827e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1b9723fd-d30d-4bba-9036-a3ba9bb04bbe"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1c0e3e54-8aaf-4aee-b17c-41f22aacce7f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2de9def4-d264-4d35-8e4a-9f22b5e0131c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("330ef570-1a21-412c-b1bd-ca00adc4d8a1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("392b7126-c75a-4620-80ba-9f9d7966de32"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3d3ad1e3-d1d8-4785-8abf-cd680810e588"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("59d39056-afb3-4d64-8ee0-62cddc45b5be"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("657d5449-5769-4a57-afc3-0fafa92a569b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6bac44e1-009f-4823-a984-fbc78dcb6031"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("806bb831-de6d-4504-a17a-7e7d9143e44b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("87327521-0c65-4dc1-9ff9-e2558681279e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("9c9d501e-be0b-4a1e-b2d8-3855cad4d8fb"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b2076a9f-25bf-4728-b548-ac00bcd04b04"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b5a7730e-884b-434c-86a1-a67de1fbe40d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("bf18117f-8acf-4848-8701-615a9ac034d4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c089b6ac-05b8-41a8-b1bd-127fa9e36990"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("cf6a3469-fbb9-4422-897f-21a54dfc84ec"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d9444ce8-6edb-4b9d-91c1-d8112b08b439"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("dc05fe84-bb86-4166-bdb8-77d1c0ae50a4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e29aaae8-71ac-49de-b1de-8db5188aa0b4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f0229bda-4949-42c7-a1ed-a91dead77dfe"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f5050d75-17e8-4d9e-8527-f69ae2aded15"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("fbdb4d75-f7d0-4fee-9cbd-d636675f0952"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6148c57c-0057-4223-bd2c-73a5b820ab4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f6b5ac6-ea0a-4eff-8e2b-df032c4503f1"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("3670c65c-2c55-4883-b615-4e9d27e471a0"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("c1234c26-d922-4620-9dd0-3740eef840e1"));

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: new Guid("f66b816e-8ab8-4f69-8336-8ac4629e7559"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3670c65c-2c55-4883-b615-4e9d27e471a0"), "الشهادة الثانوية - أدبي" },
                    { new Guid("c1234c26-d922-4620-9dd0-3740eef840e1"), "الشهادة الإعدادية" },
                    { new Guid("f66b816e-8ab8-4f69-8336-8ac4629e7559"), "الشهادة الثانوية - علمي" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "From_Time", "Name", "To_Time" },
                values: new object[,]
                {
                    { new Guid("06f4c2ff-d8b6-4821-af87-355c160eb9dd"), "08:30", "الحصة الأولى", "10:00" },
                    { new Guid("480c6686-525b-42df-8f39-ab6b267c228f"), "10:00", "الحصة الثانية", "11:30" },
                    { new Guid("7de75bbd-03c5-4de7-abc1-3b949fecc762"), "01:00", "الحصة الرابعة", "02:30" },
                    { new Guid("a0e24b3e-6250-4636-a5c4-ece8cbd920dd"), "02:30", "الحصة الخامسة", "03:00" },
                    { new Guid("d598d28a-6f21-4ca7-8573-e54484f48f7d"), "03:00", "الحصة السادسة", "04:30" },
                    { new Guid("ee29381d-c010-4a75-afa9-092c9be14c3b"), "11:30", "الحصة الثالثة", "01:00" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Type" },
                values: new object[,]
                {
                    { new Guid("6148c57c-0057-4223-bd2c-73a5b820ab4a"), "Aa@112233", "مشرف" },
                    { new Guid("8f6b5ac6-ea0a-4eff-8e2b-df032c4503f1"), "AaBbCc@112233", "مدير" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CertificateId", "Name" },
                values: new object[,]
                {
                    { new Guid("1090dc9f-14dd-41ac-a505-9270eefe69e5"), new Guid("c1234c26-d922-4620-9dd0-3740eef840e1"), "لغة انكليزية" },
                    { new Guid("14b1efee-ac2d-44d6-b496-9c6e2527827e"), new Guid("f66b816e-8ab8-4f69-8336-8ac4629e7559"), "علم أحياء" },
                    { new Guid("1b9723fd-d30d-4bba-9036-a3ba9bb04bbe"), new Guid("3670c65c-2c55-4883-b615-4e9d27e471a0"), "تاريخ" },
                    { new Guid("1c0e3e54-8aaf-4aee-b17c-41f22aacce7f"), new Guid("c1234c26-d922-4620-9dd0-3740eef840e1"), "اجتماعيات" },
                    { new Guid("2de9def4-d264-4d35-8e4a-9f22b5e0131c"), new Guid("c1234c26-d922-4620-9dd0-3740eef840e1"), "علوم" },
                    { new Guid("330ef570-1a21-412c-b1bd-ca00adc4d8a1"), new Guid("3670c65c-2c55-4883-b615-4e9d27e471a0"), "لغة عربية" },
                    { new Guid("392b7126-c75a-4620-80ba-9f9d7966de32"), new Guid("c1234c26-d922-4620-9dd0-3740eef840e1"), "لغة فرنسية" },
                    { new Guid("3d3ad1e3-d1d8-4785-8abf-cd680810e588"), new Guid("c1234c26-d922-4620-9dd0-3740eef840e1"), "فيزياء و كيمياء" },
                    { new Guid("59d39056-afb3-4d64-8ee0-62cddc45b5be"), new Guid("3670c65c-2c55-4883-b615-4e9d27e471a0"), "جغرافيا" },
                    { new Guid("657d5449-5769-4a57-afc3-0fafa92a569b"), new Guid("f66b816e-8ab8-4f69-8336-8ac4629e7559"), "لغة فرنسية" },
                    { new Guid("6bac44e1-009f-4823-a984-fbc78dcb6031"), new Guid("3670c65c-2c55-4883-b615-4e9d27e471a0"), "وطنية" },
                    { new Guid("806bb831-de6d-4504-a17a-7e7d9143e44b"), new Guid("f66b816e-8ab8-4f69-8336-8ac4629e7559"), "رياضيات" },
                    { new Guid("87327521-0c65-4dc1-9ff9-e2558681279e"), new Guid("f66b816e-8ab8-4f69-8336-8ac4629e7559"), "كيمياء" },
                    { new Guid("9c9d501e-be0b-4a1e-b2d8-3855cad4d8fb"), new Guid("c1234c26-d922-4620-9dd0-3740eef840e1"), "ديانة" },
                    { new Guid("b2076a9f-25bf-4728-b548-ac00bcd04b04"), new Guid("3670c65c-2c55-4883-b615-4e9d27e471a0"), "فلسفة" },
                    { new Guid("b5a7730e-884b-434c-86a1-a67de1fbe40d"), new Guid("3670c65c-2c55-4883-b615-4e9d27e471a0"), "ديانة" },
                    { new Guid("bf18117f-8acf-4848-8701-615a9ac034d4"), new Guid("f66b816e-8ab8-4f69-8336-8ac4629e7559"), "ديانة" },
                    { new Guid("c089b6ac-05b8-41a8-b1bd-127fa9e36990"), new Guid("c1234c26-d922-4620-9dd0-3740eef840e1"), "رياضيات" },
                    { new Guid("cf6a3469-fbb9-4422-897f-21a54dfc84ec"), new Guid("f66b816e-8ab8-4f69-8336-8ac4629e7559"), "لغة عربية" },
                    { new Guid("d9444ce8-6edb-4b9d-91c1-d8112b08b439"), new Guid("3670c65c-2c55-4883-b615-4e9d27e471a0"), "لغة انكليزية" },
                    { new Guid("dc05fe84-bb86-4166-bdb8-77d1c0ae50a4"), new Guid("f66b816e-8ab8-4f69-8336-8ac4629e7559"), "فيزياء" },
                    { new Guid("e29aaae8-71ac-49de-b1de-8db5188aa0b4"), new Guid("3670c65c-2c55-4883-b615-4e9d27e471a0"), "لغة فرنسية" },
                    { new Guid("f0229bda-4949-42c7-a1ed-a91dead77dfe"), new Guid("c1234c26-d922-4620-9dd0-3740eef840e1"), "لغة عربية" },
                    { new Guid("f5050d75-17e8-4d9e-8527-f69ae2aded15"), new Guid("f66b816e-8ab8-4f69-8336-8ac4629e7559"), "وطنية" },
                    { new Guid("fbdb4d75-f7d0-4fee-9cbd-d636675f0952"), new Guid("f66b816e-8ab8-4f69-8336-8ac4629e7559"), "لغة انكليزية" }
                });
        }
    }
}
