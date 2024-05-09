using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditOnSponserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Writings",
                table: "AwardSponsors",
                newName: "EnglishWritings");

            migrationBuilder.RenameColumn(
                name: "UpbringingAndAiography",
                table: "AwardSponsors",
                newName: "EnglishUpbringingAndAiography");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AwardSponsors",
                newName: "EnglishName");

            migrationBuilder.RenameColumn(
                name: "HonoraryPositions",
                table: "AwardSponsors",
                newName: "EnglishHonoraryPositions");

            migrationBuilder.RenameColumn(
                name: "EducationalStages",
                table: "AwardSponsors",
                newName: "EnglishEducationalStages");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "AwardSponsors",
                newName: "EnglishDescription");

            migrationBuilder.AddColumn<string>(
                name: "ArabicDescription",
                table: "AwardSponsors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArabicEducationalStages",
                table: "AwardSponsors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArabicHonoraryPositions",
                table: "AwardSponsors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "AwardSponsors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArabicUpbringingAndAiography",
                table: "AwardSponsors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArabicWritings",
                table: "AwardSponsors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7239), new DateTime(2024, 5, 19, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7243), new DateTime(2024, 5, 14, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7250), new DateTime(2024, 5, 24, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7252), new DateTime(2024, 5, 19, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7254), new DateTime(2024, 5, 29, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7255), new DateTime(2024, 5, 24, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7257), new DateTime(2024, 6, 3, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7259), new DateTime(2024, 5, 29, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7261), new DateTime(2024, 6, 8, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7262), new DateTime(2024, 6, 3, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArabicDescription", "ArabicName", "CategoryClassification", "CreatedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationQualificationMark", "Icon", "RelatedToClasses", "WinningScore" },
                values: new object[] { "", "جائزة جوهرة اللغة العربية", null, new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(9064), "", "The \"Gem\" of the Arabic Language", null, null, "", null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArabicDescription", "ArabicName", "CreatedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationQualificationMark", "Icon", "MinimumAmountToObtainACertificateOfParticipation", "MinimumAmountToParticipateInTheAward", "RelatedToClasses", "WinningScore" },
                values: new object[] { "جائزة رائدة استثنائيّة تتسابق فيها المدارس الحكومية والخاصة في رعاية اللغة العربية، وتمكين المجتمع المدرسيّ (طالب، معلم، ولي الأمر...) من امتلاك مهارات اللغة العربية وتوظيفها في العلم والحياة.", "جائزة جوهرة اللغة العربية", new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(9072), "It is an exceptional pioneering award where both public and private schools compete to promote the Arabic language, empower the school community students, teachers, and parents and equip them with the Arabic language skills that they can utilize in life and knowledge acquisition.", "The \"Gem\" of the Arabic Language", 3, 100f, "", 80f, 60f, true, 90f });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ArabicDescription", "ArabicName", "CategoryClassification", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationQualificationMark", "Icon", "LastModifiedAt", "LastModifiedBy", "MinimumAmountToObtainACertificateOfParticipation", "MinimumAmountToParticipateInTheAward", "ParentId", "RelatedToClasses", "WinningScore", "isDeleted" },
                values: new object[] { 3, "", "فئة الأفراد المتميزين", null, new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(9080), null, 1, null, "", "Distinguished Individuals Category", null, null, "", null, null, null, null, null, null, null, false });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArabicName", "CreatedAt", "CycleNumber", "EnglishName", "GroupCategoryNumber", "IndividualCategoryNumber", "MarginOfDifferenceBetweenArbitrators", "RegistrationPortalClosingDate", "RegistrationPortalOpeningDate", "TheUpperLimitForObtainingInformation", "Year" },
                values: new object[] { "جائزة الشارقة للتفوق والتميز التربوي", new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(9007), 31, "Sharjah Award for Educational Excellence", 1, 1, 10, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "2024 - 2025" });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7852), new DateTime(2024, 5, 9, 12, 33, 18, 906, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7872), new DateTime(2024, 5, 9, 12, 33, 18, 906, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7874), new DateTime(2024, 5, 9, 12, 33, 18, 906, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7877), new DateTime(2024, 5, 9, 12, 33, 18, 906, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6208), new DateTime(2024, 5, 14, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6211), new DateTime(2024, 5, 11, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6220), new DateTime(2024, 5, 12, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6223), new DateTime(2024, 5, 17, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6225), new DateTime(2024, 5, 14, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6227), new DateTime(2024, 5, 15, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6853), new DateTime(2024, 5, 19, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6859), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6887), new DateTime(2024, 5, 29, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6890), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 905, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ArabicDescription", "ArabicName", "CategoryClassification", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationQualificationMark", "Icon", "LastModifiedAt", "LastModifiedBy", "MinimumAmountToObtainACertificateOfParticipation", "MinimumAmountToParticipateInTheAward", "ParentId", "RelatedToClasses", "WinningScore", "isDeleted" },
                values: new object[,]
                {
                    { 4, "تشمل جميع القيادات التّربويّة في القطاعين الحكوميّ والخاص من فئة القيادات العليا والقيادات الوسطى.\r\n\r\nتشمل القيادة العليا (مدير مدرسة).\r\nتشمل القيادة الوسطى (مساعد مدير أكاديمي، رئيس وحدة الشؤون الأكاديمية، رئيس وحدة شؤون الطلبة، رئيس وحدة الخدمات).", "فئة القائد التربوي المتميز", 0, new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(9084), null, 1, null, "This category consists of all educational leaders in the public and private sectors including senior leaders and middle leaders.\r\n\r\n- Senior leadership includes school principal.\r\n\r\n- Middle leadership includes Assistant Academic Principal, Head of Academic Affairs Unit, Head of Student Affairs Unit, Head of Services Unit.", "Distinguished Educational Leader Category", 3, 100f, "", null, null, 80f, 60f, 3, true, 90f, false },
                    { 5, "المعلم هو المحرك الأساسي لعملية التعليم والتعلم، فبمقدار جودة عطائه ترتقي العملية التعليمية، وخاصة مع المتغيرات الحديثة التي تقتضي من المعلم مواكبتها، لينتج التعليم ثماره المرجوة، ويمتزج بعصر المعرفة والثورات التكنولوجية، ويصبح جزءاً فاعلًا في الحياة والاقتصاد، وتهتم الجائزة بهذه الفئة وتأهيلها ليثبت المعلم المشارك إنجازه وقيادته الفاعلة، وتطوّره المهنيّ، ويبرهن على إبداعه وابتكاراته الوظيفيّة ومسؤولياته المجتمعيّة، ويحق لجميع المعلمين من مرحلة رياض الأطفال إلى الصف الثاني عشر ومن ذوي التّخصصات المختلفة في التعليم الحكومي والخاص والفنّي والتكنولوجي الترشح لهذه الفئة.", "فئة المعلم المتميز", 0, new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(9090), null, 1, null, "The teacher is the main guide of the teaching and learning process as the quality of his/her input elevates the educational process, especially with the new changes and the technological revolution that require teachers to keep up with in order to achieve the desired results in life and economy. The Sharjah Award for Educational Excellence acknowledges this category and requires participant teachers to underscore their distinguished performance, effective leadership, professional development, creativity and innovation in the job, and social responsibility. All teachers from kindergarten to the twelfth grade with various specializations in public, private, and applied technology schools are eligible to nominate for this category.", "Distinguished Teacher Category", 3, 100f, "", null, null, 80f, 60f, 3, true, 90f, false },
                    { 6, "", "فئة المؤسسات المتميزة", null, new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(9095), null, 1, null, "", "Distinguished Institutions Category", null, null, "", null, null, null, null, 3, null, null, false },
                    { 7, "تحرص الحكومة الرشيدة في دولة الامارات العربية المتحدة على جودة الخدمات المقدمة للطفل باعتباره اللبنة الأولى في بناء المجتمع وتلقينه الدروس الأولى للانطلاق إلى فضاء الحياة مسلحاً بالقيم والسلوكيات الإيجابية ومتمكنا من المهارات الأساسية الأولى لذا فقد أفردت الجائزة لهذه الفئة مجالًا لإبراز تميزها في مجال تطوير الأدوات وبيئة العمل وتقديم الخدمات المتميزة للعاملين فيها، وللطلبة ولأولياء الأمور، وللمجتمع ككل، ويحق لجميع الحضانات الحكومية والخاصة على مستوى دولة الإمارات التّقدّم للجائزة وفق معايير مخصّصة وضمن شروط محدّدة.", "فئة الحضانة المتميزة", null, new DateTime(2024, 5, 9, 9, 33, 18, 906, DateTimeKind.Utc).AddTicks(9100), null, 1, null, "", "Distinguished Institutions Category", null, null, "", null, null, null, null, 3, null, null, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ArabicDescription",
                table: "AwardSponsors");

            migrationBuilder.DropColumn(
                name: "ArabicEducationalStages",
                table: "AwardSponsors");

            migrationBuilder.DropColumn(
                name: "ArabicHonoraryPositions",
                table: "AwardSponsors");

            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "AwardSponsors");

            migrationBuilder.DropColumn(
                name: "ArabicUpbringingAndAiography",
                table: "AwardSponsors");

            migrationBuilder.DropColumn(
                name: "ArabicWritings",
                table: "AwardSponsors");

            migrationBuilder.RenameColumn(
                name: "EnglishWritings",
                table: "AwardSponsors",
                newName: "Writings");

            migrationBuilder.RenameColumn(
                name: "EnglishUpbringingAndAiography",
                table: "AwardSponsors",
                newName: "UpbringingAndAiography");

            migrationBuilder.RenameColumn(
                name: "EnglishName",
                table: "AwardSponsors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EnglishHonoraryPositions",
                table: "AwardSponsors",
                newName: "HonoraryPositions");

            migrationBuilder.RenameColumn(
                name: "EnglishEducationalStages",
                table: "AwardSponsors",
                newName: "EducationalStages");

            migrationBuilder.RenameColumn(
                name: "EnglishDescription",
                table: "AwardSponsors",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5265), new DateTime(2024, 5, 18, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5277), new DateTime(2024, 5, 13, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5295), new DateTime(2024, 5, 23, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5297), new DateTime(2024, 5, 18, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5301), new DateTime(2024, 5, 28, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5303), new DateTime(2024, 5, 23, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5307), new DateTime(2024, 6, 2, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5310), new DateTime(2024, 5, 28, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5313), new DateTime(2024, 6, 7, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5317), new DateTime(2024, 6, 2, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArabicDescription", "ArabicName", "CategoryClassification", "CreatedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationQualificationMark", "Icon", "RelatedToClasses", "WinningScore" },
                values: new object[] { "اختبار وصف 1", "اختبار اسم 1", 0, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5690), "Test Description 1", "Test Name 1", 1, 0f, "string", false, 0f });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArabicDescription", "ArabicName", "CreatedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationQualificationMark", "Icon", "MinimumAmountToObtainACertificateOfParticipation", "MinimumAmountToParticipateInTheAward", "RelatedToClasses", "WinningScore" },
                values: new object[] { "اختبار وصف 2", "اختبار اسم 2", new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5705), "Test Description 2", "Test Name 2", 1, 0f, "string", null, null, false, 0f });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArabicName", "CreatedAt", "CycleNumber", "EnglishName", "GroupCategoryNumber", "IndividualCategoryNumber", "MarginOfDifferenceBetweenArbitrators", "RegistrationPortalClosingDate", "RegistrationPortalOpeningDate", "TheUpperLimitForObtainingInformation", "Year" },
                values: new object[] { "جائزة الشارقة", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "SharijhaAward", 10, 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "2023-2024" });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6788), new DateTime(2024, 5, 8, 16, 56, 18, 504, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6916), new DateTime(2024, 5, 8, 16, 56, 18, 504, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6925), new DateTime(2024, 5, 8, 16, 56, 18, 504, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6931), new DateTime(2024, 5, 8, 16, 56, 18, 504, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9863), new DateTime(2024, 5, 13, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9868), new DateTime(2024, 5, 10, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9879), new DateTime(2024, 5, 11, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9884), new DateTime(2024, 5, 16, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9888), new DateTime(2024, 5, 13, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 5, 14, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(831), new DateTime(2024, 5, 18, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(837), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1172), new DateTime(2024, 5, 28, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1177), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6284));
        }
    }
}
