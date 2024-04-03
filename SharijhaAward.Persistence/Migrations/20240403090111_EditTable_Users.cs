using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConfirmationCodeForForgetPassword",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3477), new DateTime(2024, 5, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3480), new DateTime(2024, 4, 28, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3466), new DateTime(2024, 4, 28, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3469), new DateTime(2024, 4, 23, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3457), new DateTime(2024, 4, 23, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3459), new DateTime(2024, 4, 18, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3447), new DateTime(2024, 4, 18, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3450), new DateTime(2024, 4, 13, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3419), new DateTime(2024, 4, 13, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3428), new DateTime(2024, 4, 8, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4767), new DateTime(2024, 4, 3, 11, 1, 5, 980, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4890), new DateTime(2024, 4, 3, 11, 1, 5, 980, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4905), new DateTime(2024, 4, 3, 11, 1, 5, 980, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4916), new DateTime(2024, 4, 3, 11, 1, 5, 980, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5704), new DateTime(2024, 4, 8, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5737), new DateTime(2024, 4, 5, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5752), new DateTime(2024, 4, 6, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5757), new DateTime(2024, 4, 11, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5761), new DateTime(2024, 4, 8, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5763), new DateTime(2024, 4, 9, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(7817), new DateTime(2024, 4, 13, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8198), new DateTime(2024, 4, 23, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "ConfirmationCodeForForgetPassword", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                columns: new[] { "ConfirmationCodeForForgetPassword", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                columns: new[] { "ConfirmationCodeForForgetPassword", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                columns: new[] { "ConfirmationCodeForForgetPassword", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                columns: new[] { "ConfirmationCodeForForgetPassword", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                columns: new[] { "ConfirmationCodeForForgetPassword", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                columns: new[] { "ConfirmationCodeForForgetPassword", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                columns: new[] { "ConfirmationCodeForForgetPassword", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                columns: new[] { "ConfirmationCodeForForgetPassword", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "ConfirmationCodeForForgetPassword", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5767) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmationCodeForForgetPassword",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1795), new DateTime(2024, 5, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1800), new DateTime(2024, 4, 28, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1776), new DateTime(2024, 4, 28, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1781), new DateTime(2024, 4, 23, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 4, 23, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1761), new DateTime(2024, 4, 18, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1738), new DateTime(2024, 4, 18, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1743), new DateTime(2024, 4, 13, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1693), new DateTime(2024, 4, 13, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1709), new DateTime(2024, 4, 8, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4162), new DateTime(2024, 4, 3, 10, 29, 49, 193, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4311), new DateTime(2024, 4, 3, 10, 29, 49, 193, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4337), new DateTime(2024, 4, 3, 10, 29, 49, 193, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4358), new DateTime(2024, 4, 3, 10, 29, 49, 193, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5866), new DateTime(2024, 4, 8, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5901), new DateTime(2024, 4, 5, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5919), new DateTime(2024, 4, 6, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5929), new DateTime(2024, 4, 11, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5938), new DateTime(2024, 4, 8, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5941), new DateTime(2024, 4, 9, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(8895), new DateTime(2024, 4, 13, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9263), new DateTime(2024, 4, 23, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6037));
        }
    }
}
