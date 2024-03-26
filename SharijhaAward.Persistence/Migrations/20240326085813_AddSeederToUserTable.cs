using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSeederToUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7339), new DateTime(2024, 4, 15, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7342), new DateTime(2024, 4, 10, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7325), new DateTime(2024, 4, 10, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7329), new DateTime(2024, 4, 5, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7293), new DateTime(2024, 4, 5, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7302), new DateTime(2024, 3, 31, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7760), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7763), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7765), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7768), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7722), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7730), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7735), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7738), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8661), new DateTime(2024, 3, 26, 10, 58, 5, 657, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8790), new DateTime(2024, 3, 26, 10, 58, 5, 657, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8803), new DateTime(2024, 3, 26, 10, 58, 5, 657, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8815), new DateTime(2024, 3, 26, 10, 58, 5, 657, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4821), new DateTime(2024, 3, 31, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4854), new DateTime(2024, 3, 28, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4865), new DateTime(2024, 3, 29, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4870), new DateTime(2024, 4, 3, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4877), new DateTime(2024, 3, 31, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4879), new DateTime(2024, 4, 1, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName", "Time" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7155), new DateTime(2024, 4, 5, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7166), "Friday", "08:58:05.6557441" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName", "Time" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7485), new DateTime(2024, 4, 15, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7491), "Monday", "08:58:05.6557495" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ArabicName", "ConfirmationCodeForResetPassword", "ConfirmationCodeForSignUp", "CreatedAt", "CreatedBy", "DeletedAt", "Email", "EnglishName", "Gender", "ImageURL", "LastModifiedAt", "LastModifiedBy", "Password", "PhoneNumber", "RoleId", "TrainingWorkshopId", "isDeleted", "isValidAccount" },
                values: new object[,]
                {
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e73d"), "تامر 2", null, null, new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9792), null, null, "ta.mer@gmail.com", "Tamer 2", 0, null, null, null, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"), null, false, true },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"), "تامر", null, null, new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9783), null, null, "tamer@gmail.com", "Tamer", 0, null, null, null, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"), null, false, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e73d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"));

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(846), new DateTime(2024, 4, 14, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(851), new DateTime(2024, 4, 9, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(825), new DateTime(2024, 4, 9, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(830), new DateTime(2024, 4, 4, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(782), new DateTime(2024, 4, 4, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(796), new DateTime(2024, 3, 30, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1418), new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1423), new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1427), new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1330), new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1340), new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1349), new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1354), new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 848, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 848, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 848, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 848, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 848, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 848, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 848, DateTimeKind.Utc).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2799), new DateTime(2024, 3, 25, 17, 19, 8, 850, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2941), new DateTime(2024, 3, 25, 17, 19, 8, 850, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2964), new DateTime(2024, 3, 25, 17, 19, 8, 850, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2987), new DateTime(2024, 3, 25, 17, 19, 8, 850, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(390), new DateTime(2024, 3, 30, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(434), new DateTime(2024, 3, 27, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(449), new DateTime(2024, 3, 28, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(458), new DateTime(2024, 4, 2, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(468), new DateTime(2024, 3, 30, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(471), new DateTime(2024, 3, 31, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName", "Time" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(3257), new DateTime(2024, 4, 4, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(3272), "Thursday", "15:19:08.8473617" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName", "Time" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(3679), new DateTime(2024, 4, 14, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(3690), "Sunday", "15:19:08.8473701" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 847, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 19, 8, 850, DateTimeKind.Utc).AddTicks(4216));
        }
    }
}
