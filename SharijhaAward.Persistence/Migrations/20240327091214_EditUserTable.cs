using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "lang",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4909), new DateTime(2024, 4, 26, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4913), new DateTime(2024, 4, 21, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4890), new DateTime(2024, 4, 21, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4895), new DateTime(2024, 4, 16, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4871), new DateTime(2024, 4, 16, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4876), new DateTime(2024, 4, 11, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4851), new DateTime(2024, 4, 11, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4856), new DateTime(2024, 4, 6, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4803), new DateTime(2024, 4, 6, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4817), new DateTime(2024, 4, 1, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(5719), new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(5726), new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(5731), new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(5735), new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(5666), new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(5678), new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(5689), new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(5694), new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 797, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 797, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 797, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 797, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 797, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 797, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 797, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7057), new DateTime(2024, 3, 27, 11, 12, 6, 799, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7203), new DateTime(2024, 3, 27, 11, 12, 6, 799, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7226), new DateTime(2024, 3, 27, 11, 12, 6, 799, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7248), new DateTime(2024, 3, 27, 11, 12, 6, 799, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 795, DateTimeKind.Utc).AddTicks(9326), new DateTime(2024, 4, 1, 9, 12, 6, 795, DateTimeKind.Utc).AddTicks(9372), new DateTime(2024, 3, 29, 9, 12, 6, 795, DateTimeKind.Utc).AddTicks(9388), new DateTime(2024, 3, 30, 9, 12, 6, 795, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 795, DateTimeKind.Utc).AddTicks(9401), new DateTime(2024, 4, 4, 9, 12, 6, 795, DateTimeKind.Utc).AddTicks(9409), new DateTime(2024, 4, 1, 9, 12, 6, 795, DateTimeKind.Utc).AddTicks(9413), new DateTime(2024, 4, 2, 9, 12, 6, 795, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName", "Time" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(2593), new DateTime(2024, 4, 6, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(2610), "Saturday", "09:12:06.7962952" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName", "Time" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3006), new DateTime(2024, 4, 16, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3017), "Tuesday", "09:12:06.7963028" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 796, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "lang" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6550), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                columns: new[] { "CreatedAt", "lang" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6575), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                columns: new[] { "CreatedAt", "lang" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6591), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                columns: new[] { "CreatedAt", "lang" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(6604), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                columns: new[] { "CreatedAt", "lang" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(8645), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                columns: new[] { "CreatedAt", "lang" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(8631), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                columns: new[] { "CreatedAt", "lang" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(8615), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                columns: new[] { "CreatedAt", "lang" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(8600), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                columns: new[] { "CreatedAt", "lang" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(8582), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "lang" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 12, 6, 799, DateTimeKind.Utc).AddTicks(8562), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lang",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2709), new DateTime(2024, 4, 25, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2714), new DateTime(2024, 4, 20, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2674), new DateTime(2024, 4, 20, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2681), new DateTime(2024, 4, 15, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2414), new DateTime(2024, 4, 15, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2423), new DateTime(2024, 4, 10, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(1552), new DateTime(2024, 4, 10, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(1659), new DateTime(2024, 4, 5, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 358, DateTimeKind.Utc).AddTicks(9834), new DateTime(2024, 4, 5, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(1383), new DateTime(2024, 3, 31, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8754), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8760), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8765), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8768), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8696), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8709), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8719), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8724), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3039), new DateTime(2024, 3, 26, 15, 26, 30, 360, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3201), new DateTime(2024, 3, 26, 15, 26, 30, 360, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3224), new DateTime(2024, 3, 26, 15, 26, 30, 360, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3247), new DateTime(2024, 3, 26, 15, 26, 30, 360, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6038), new DateTime(2024, 3, 31, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6074), new DateTime(2024, 3, 28, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6090), new DateTime(2024, 3, 29, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6098), new DateTime(2024, 4, 3, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6107), new DateTime(2024, 3, 31, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6111), new DateTime(2024, 4, 1, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName", "Time" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(8680), new DateTime(2024, 4, 5, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(8696), "Friday", "13:26:30.3559038" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName", "Time" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9094), new DateTime(2024, 4, 15, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9105), "Monday", "13:26:30.3559117" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(4914));
        }
    }
}
