using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutAwardPage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicAboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishAboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicAboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishAboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicOurVisionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishOurVisionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicOurVisionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishOurVisionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurVisionImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutAwardPage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderPatterns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderPatterns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppVersions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppType = table.Column<int>(type: "int", nullable: false),
                    VersionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isRequired = table.Column<bool>(type: "bit", nullable: false),
                    UpdatesOnVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppVersions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arbitrators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isChairman = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitrators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttributeDataTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeDataTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttributeOperations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationAsString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeOperations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttributeTableNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeTableNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AwardSponsors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishUpbringingAndAiography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicUpbringingAndAiography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishHonoraryPositions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicHonoraryPositions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishEducationalStages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicEducationalStages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishWritings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicWritings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardSponsors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Circulars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArabicFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circulars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coordinators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cycles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CycleNumber = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RegistrationPortalOpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationPortalClosingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscriberPortalClosingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InitialArbitrationStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InitialArbitrationEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinalArbitrationStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinalArbitrationEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IndividualCategoryNumber = table.Column<int>(type: "int", nullable: false),
                    TheUpperLimitForObtainingInformation = table.Column<int>(type: "int", nullable: false),
                    MarginOfDifferenceBetweenArbitrators = table.Column<int>(type: "int", nullable: false),
                    GroupCategoryNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cycles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DependencyGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DependencyGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DynamicAttributePatterns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicAttributePatterns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationalClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationalEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueIntegerId = table.Column<int>(type: "int", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishSiteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicSiteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExplanatoryMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExplanatoryMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralFAQCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralFAQCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralWorkshops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumbnale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfWorkShop = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgendaImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralWorkshops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePageSliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageSliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slug = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    isImplemented = table.Column<bool>(type: "bit", nullable: false),
                    isCanceled = table.Column<bool>(type: "bit", nullable: false),
                    EnglishReasonOfCanceling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArabicReasonOfCanceling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogUserActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FunctionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HttpMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogUserActions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnePageText",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnePageText", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageStructures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hasHelography = table.Column<bool>(type: "bit", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishSubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArabicSubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArabicContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageStructures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageStructures_PageStructures_ParentId",
                        column: x => x.ParentId,
                        principalTable: "PageStructures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PermissionHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionHeaders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishSources = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicSources = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaveFullAccess = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StrategicPartners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrategicPartners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VirtualTableForSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirtualTableForSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VirtualTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirtualTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OurGoals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicGoal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishGoal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutAwardPageId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OurGoals_AboutAwardPage_AboutAwardPageId",
                        column: x => x.AboutAwardPageId,
                        principalTable: "AboutAwardPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderPatternValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvancedFormBuilderPatternId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderPatternValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderPatternValues_AdvancedFormBuilderPatterns_AdvancedFormBuilderPatternId",
                        column: x => x.AdvancedFormBuilderPatternId,
                        principalTable: "AdvancedFormBuilderPatterns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DynamicAttributeSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordIdOnRelation = table.Column<int>(type: "int", nullable: true),
                    TableTypeSection = table.Column<bool>(type: "bit", nullable: false),
                    AttributeTableNameId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicAttributeSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DynamicAttributeSections_AttributeTableNames_AttributeTableNameId",
                        column: x => x.AttributeTableNameId,
                        principalTable: "AttributeTableNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaticAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttributeDataTypeId = table.Column<int>(type: "int", nullable: false),
                    AttributeTableNameId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaticAttributes_AttributeDataTypes_AttributeDataTypeId",
                        column: x => x.AttributeDataTypeId,
                        principalTable: "AttributeDataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaticAttributes_AttributeTableNames_AttributeTableNameId",
                        column: x => x.AttributeTableNameId,
                        principalTable: "AttributeTableNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateType = table.Column<int>(type: "int", nullable: false),
                    CycleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendas_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CycleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AwardPublications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutherDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CycleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardPublications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AwardPublications_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AwardStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatisticValue = table.Column<int>(type: "int", nullable: false),
                    CycleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AwardStatistics_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryClassification = table.Column<int>(type: "int", nullable: true),
                    FinalArbitrationQualificationMark = table.Column<float>(type: "real", nullable: true),
                    ExpectedNumberOfWinners = table.Column<int>(type: "int", nullable: true),
                    MinimumAmountToObtainAStatement = table.Column<int>(type: "int", nullable: true),
                    MaximumAmountToObtainAStatement = table.Column<int>(type: "int", nullable: true),
                    MinimumRequirementToObtainACertificate = table.Column<int>(type: "int", nullable: true),
                    MaximumRequirementToObtainACertificate = table.Column<int>(type: "int", nullable: true),
                    MinimumWinningScore = table.Column<int>(type: "int", nullable: true),
                    RelatedToClasses = table.Column<bool>(type: "bit", nullable: true),
                    RelatedToEducationalEntities = table.Column<bool>(type: "bit", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    CycleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Categories_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CycleCondition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeedAttachment = table.Column<bool>(type: "bit", nullable: false),
                    RequiredAttachmentNumber = table.Column<int>(type: "int", nullable: true),
                    AttachmentType = table.Column<int>(type: "int", nullable: true),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: true),
                    IsAgree = table.Column<bool>(type: "bit", nullable: false),
                    CycleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CycleCondition_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CycleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DependencyValidations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DependencyGroupId = table.Column<int>(type: "int", nullable: false),
                    AttributeOperationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DependencyValidations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DependencyValidations_AttributeOperations_AttributeOperationId",
                        column: x => x.AttributeOperationId,
                        principalTable: "AttributeOperations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DependencyValidations_DependencyGroup_DependencyGroupId",
                        column: x => x.DependencyGroupId,
                        principalTable: "DependencyGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DynamicAttributePatternValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DynamicAttributePatternId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicAttributePatternValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DynamicAttributePatternValues_DynamicAttributePatterns_DynamicAttributePatternId",
                        column: x => x.DynamicAttributePatternId,
                        principalTable: "DynamicAttributePatterns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArbitratorClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalClassId = table.Column<int>(type: "int", nullable: false),
                    ArbitratorId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitratorClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitratorClasses_Arbitrators_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArbitratorClasses_EducationalClasses_EducationalClassId",
                        column: x => x.EducationalClassId,
                        principalTable: "EducationalClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalInstitutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationType = table.Column<int>(type: "int", nullable: false),
                    Emirates = table.Column<int>(type: "int", nullable: false),
                    EducationalEntityId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalInstitutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalInstitutions_EducationalEntities_EducationalEntityId",
                        column: x => x.EducationalEntityId,
                        principalTable: "EducationalEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationCoordinators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoordinatorId = table.Column<int>(type: "int", nullable: false),
                    EducationalEntityId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationCoordinators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationCoordinators_Coordinators_CoordinatorId",
                        column: x => x.CoordinatorId,
                        principalTable: "Coordinators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationCoordinators_EducationalEntities_EducationalEntityId",
                        column: x => x.EducationalEntityId,
                        principalTable: "EducationalEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupInvitees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueIntegerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedNumberOfAttendees = table.Column<int>(type: "int", nullable: false),
                    ActualNumberOfAttendees = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupInvitees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupInvitees_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personalnvitees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueIntegerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Employer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfInvitee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAttend = table.Column<bool>(type: "bit", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personalnvitees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personalnvitees_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneralFAQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralFrequentlyAskedQuestionCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralFAQs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralFAQs_GeneralFAQCategories_GeneralFrequentlyAskedQuestionCategoryId",
                        column: x => x.GeneralFrequentlyAskedQuestionCategoryId,
                        principalTable: "GeneralFAQCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterviewAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterviewId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterviewAttachments_Interviews_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterviewNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterviewId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterviewNotes_Interviews_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterviewQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterviewId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterviewQuestions_Interviews_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterviewUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterviewId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterviewUsers_Interviews_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DarkCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DarkCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DarkCards_PageStructures_PageId",
                        column: x => x.PageId,
                        principalTable: "PageStructures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParagraphCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArabicContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageInStart = table.Column<bool>(type: "bit", nullable: true),
                    PageId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParagraphCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParagraphCards_PageStructures_PageId",
                        column: x => x.PageId,
                        principalTable: "PageStructures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionHeaderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_PermissionHeaders_PermissionHeaderId",
                        column: x => x.PermissionHeaderId,
                        principalTable: "PermissionHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responsibilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsibilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responsibilities_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleMessageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageTypeId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMessageTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleMessageTypes_MessageTypes_MessageTypeId",
                        column: x => x.MessageTypeId,
                        principalTable: "MessageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleMessageTypes_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TableTypeSection = table.Column<bool>(type: "bit", nullable: false),
                    VirtualTableForSectionId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderSections_VirtualTableForSections_VirtualTableForSectionId",
                        column: x => x.VirtualTableForSectionId,
                        principalTable: "VirtualTableForSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DynamicAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
                    LinkedToAnotherAttribute = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MaxSizeInKB = table.Column<int>(type: "int", nullable: true),
                    AttributeDataTypeId = table.Column<int>(type: "int", nullable: false),
                    DynamicAttributeSectionId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DynamicAttributes_AttributeDataTypes_AttributeDataTypeId",
                        column: x => x.AttributeDataTypeId,
                        principalTable: "AttributeDataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DynamicAttributes_DynamicAttributeSections_DynamicAttributeSectionId",
                        column: x => x.DynamicAttributeSectionId,
                        principalTable: "DynamicAttributeSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Galleries_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArbitrationScales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeScale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitrationScales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitrationScales_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesArbitrators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ArbitratorId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesArbitrators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriesArbitrators_Arbitrators_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesArbitrators_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryEducationalClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalClassId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    NumberOfExpectedWinners = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEducationalClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryEducationalClasses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryEducationalClasses_EducationalClasses_EducationalClassId",
                        column: x => x.EducationalClassId,
                        principalTable: "EducationalClasses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryEducationalEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalEntityId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEducationalEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryEducationalEntities_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryEducationalEntities_EducationalEntities_EducationalEntityId",
                        column: x => x.EducationalEntityId,
                        principalTable: "EducationalEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryFAQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFAQs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryFAQs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Committees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ChairmanId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Committees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Committees_Arbitrators_ChairmanId",
                        column: x => x.ChairmanId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Committees_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExplanatoryGuides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishFilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicFilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExplanatoryGuides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExplanatoryGuides_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FrequentlyAskedQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrequentlyAskedQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FrequentlyAskedQuestions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterviewCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterviewId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterviewCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterviewCategories_Interviews_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    isImplemented = table.Column<bool>(type: "bit", nullable: false),
                    isCanceled = table.Column<bool>(type: "bit", nullable: false),
                    EnglishReasonOfCanceling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArabicReasonOfCanceling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meetings_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rewards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RewardValue = table.Column<int>(type: "int", nullable: false),
                    ArabicRank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishRank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rewards_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TermsAndConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeedAttachment = table.Column<bool>(type: "bit", nullable: false),
                    RequiredAttachmentNumber = table.Column<int>(type: "int", nullable: true),
                    AttachmentType = table.Column<int>(type: "int", nullable: true),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: true),
                    IsAgree = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermsAndConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TermsAndConditions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingWorkshops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingWorkshops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingWorkshops_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionCoordinators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoordinatorId = table.Column<int>(type: "int", nullable: false),
                    EducationalInstitutionId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionCoordinators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitutionCoordinators_Coordinators_CoordinatorId",
                        column: x => x.CoordinatorId,
                        principalTable: "Coordinators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstitutionCoordinators_EducationalInstitutions_EducationalInstitutionId",
                        column: x => x.EducationalInstitutionId,
                        principalTable: "EducationalInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupInviteeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_GroupInvitees_GroupInviteeId",
                        column: x => x.GroupInviteeId,
                        principalTable: "GroupInvitees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
                    LinkedToAnotherAttribute = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MaxSizeInKB = table.Column<int>(type: "int", nullable: true),
                    AttributeDataTypeId = table.Column<int>(type: "int", nullable: false),
                    AdvancedFormBuilderSectionId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilders_AdvancedFormBuilderSections_AdvancedFormBuilderSectionId",
                        column: x => x.AdvancedFormBuilderSectionId,
                        principalTable: "AdvancedFormBuilderSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilders_AttributeDataTypes_AttributeDataTypeId",
                        column: x => x.AttributeDataTypeId,
                        principalTable: "AttributeDataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dependencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainDynamicAttributeId = table.Column<int>(type: "int", nullable: false),
                    DependencyGroupId = table.Column<int>(type: "int", nullable: false),
                    DynamicAttributeId = table.Column<int>(type: "int", nullable: true),
                    StaticAttributeId = table.Column<int>(type: "int", nullable: true),
                    AttributeOperationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dependencies_AttributeOperations_AttributeOperationId",
                        column: x => x.AttributeOperationId,
                        principalTable: "AttributeOperations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dependencies_DependencyGroup_DependencyGroupId",
                        column: x => x.DependencyGroupId,
                        principalTable: "DependencyGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dependencies_DynamicAttributes_DynamicAttributeId",
                        column: x => x.DynamicAttributeId,
                        principalTable: "DynamicAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dependencies_DynamicAttributes_MainDynamicAttributeId",
                        column: x => x.MainDynamicAttributeId,
                        principalTable: "DynamicAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dependencies_StaticAttributes_StaticAttributeId",
                        column: x => x.StaticAttributeId,
                        principalTable: "StaticAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DynamicAttributeGeneralValidations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DynamicAttributeId = table.Column<int>(type: "int", nullable: false),
                    AttributeOperationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicAttributeGeneralValidations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DynamicAttributeGeneralValidations_AttributeOperations_AttributeOperationId",
                        column: x => x.AttributeOperationId,
                        principalTable: "AttributeOperations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DynamicAttributeGeneralValidations_DynamicAttributes_DynamicAttributeId",
                        column: x => x.DynamicAttributeId,
                        principalTable: "DynamicAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DynamicAttributeListValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DynamicAttributeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicAttributeListValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DynamicAttributeListValues_DynamicAttributes_DynamicAttributeId",
                        column: x => x.DynamicAttributeId,
                        principalTable: "DynamicAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DynamicAttributeTableValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false),
                    RecordId = table.Column<int>(type: "int", nullable: false),
                    isAccepted = table.Column<bool>(type: "bit", nullable: true),
                    ReasonForRejecting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DynamicAttributeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicAttributeTableValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DynamicAttributeTableValue_DynamicAttributes_DynamicAttributeId",
                        column: x => x.DynamicAttributeId,
                        principalTable: "DynamicAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DynamicAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordId = table.Column<int>(type: "int", nullable: true),
                    RecordIdAsGuid = table.Column<int>(type: "int", nullable: true),
                    isAccepted = table.Column<bool>(type: "bit", nullable: true),
                    ReasonForRejecting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DynamicAttributeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DynamicAttributeValues_DynamicAttributes_DynamicAttributeId",
                        column: x => x.DynamicAttributeId,
                        principalTable: "DynamicAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryCommittees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CommitteeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryCommittees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryCommittees_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryCommittees_Committees_CommitteeId",
                        column: x => x.CommitteeId,
                        principalTable: "Committees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComitteesArbitrators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommitteeId = table.Column<int>(type: "int", nullable: false),
                    ArbitratorId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComitteesArbitrators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComitteesArbitrators_Arbitrators_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComitteesArbitrators_Committees_CommitteeId",
                        column: x => x.CommitteeId,
                        principalTable: "Committees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MeetingCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetingCategories_Meetings_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingWrokshopeAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    AttachmentType = table.Column<int>(type: "int", nullable: false),
                    WorkshopeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingWrokshopeAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingWrokshopeAttachment_TrainingWorkshops_WorkshopeId",
                        column: x => x.WorkshopeId,
                        principalTable: "TrainingWorkshops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmationCodeForResetPassword = table.Column<int>(type: "int", nullable: true),
                    ConfirmationCodeForSignUp = table.Column<int>(type: "int", nullable: true),
                    ConfirmationCodeForForgetPassword = table.Column<int>(type: "int", nullable: true),
                    isValidAccount = table.Column<bool>(type: "bit", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfIndividualCategories = table.Column<int>(type: "int", nullable: true),
                    NumberOfGroupCategories = table.Column<int>(type: "int", nullable: true),
                    TrainingWorkshopId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_TrainingWorkshops_TrainingWorkshopId",
                        column: x => x.TrainingWorkshopId,
                        principalTable: "TrainingWorkshops",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderGeneralValidations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvancedFormBuilderId = table.Column<int>(type: "int", nullable: false),
                    AttributeOperationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderGeneralValidations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderGeneralValidations_AdvancedFormBuilders_AdvancedFormBuilderId",
                        column: x => x.AdvancedFormBuilderId,
                        principalTable: "AdvancedFormBuilders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderGeneralValidations_AttributeOperations_AttributeOperationId",
                        column: x => x.AttributeOperationId,
                        principalTable: "AttributeOperations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderListValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvancedFormBuilderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderListValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderListValues_AdvancedFormBuilders_AdvancedFormBuilderId",
                        column: x => x.AdvancedFormBuilderId,
                        principalTable: "AdvancedFormBuilders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderTableValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false),
                    VirtualTableId = table.Column<int>(type: "int", nullable: false),
                    AdvancedFormBuilderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderTableValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderTableValues_AdvancedFormBuilders_AdvancedFormBuilderId",
                        column: x => x.AdvancedFormBuilderId,
                        principalTable: "AdvancedFormBuilders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderTableValues_VirtualTables_VirtualTableId",
                        column: x => x.VirtualTableId,
                        principalTable: "VirtualTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VirtualTableId = table.Column<int>(type: "int", nullable: false),
                    AdvancedFormBuilderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderValues_AdvancedFormBuilders_AdvancedFormBuilderId",
                        column: x => x.AdvancedFormBuilderId,
                        principalTable: "AdvancedFormBuilders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderValues_VirtualTables_VirtualTableId",
                        column: x => x.VirtualTableId,
                        principalTable: "VirtualTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistinctionField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Projects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillsAndExperiences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Youtube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Snapchat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tiktok = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDistinctionField = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateProjects = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateSkillsAndExperiences = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateSocialMedia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AcceptedOnDistinctionField = table.Column<bool>(type: "bit", nullable: true),
                    AcceptedOnProjects = table.Column<bool>(type: "bit", nullable: true),
                    AcceptedOnSkillsAndExperiences = table.Column<bool>(type: "bit", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achievements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArbitrationProcedure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicGuidDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishGuidDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    StrengthPoints = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImprovementAreas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    UpdatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitrationProcedure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitrationProcedure_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArbitrationProcedure_Users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmailMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    AsignId = table.Column<int>(type: "int", nullable: true),
                    MessageId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailMessages_EmailMessages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmailMessages_MessageTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "MessageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailMessages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MeetingUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeetingId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingUsers_Meetings_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetingUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProvidedForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PercentCompletion = table.Column<int>(type: "int", nullable: false),
                    CycleNumber = table.Column<int>(type: "int", nullable: false),
                    CycleYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SubscriberType = table.Column<int>(type: "int", nullable: false),
                    CurrentStep = table.Column<int>(type: "int", nullable: false),
                    TotalStep = table.Column<int>(type: "int", nullable: false),
                    FinalScore = table.Column<float>(type: "real", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: true),
                    ReasonOfRejection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryEducationalClassId = table.Column<int>(type: "int", nullable: true),
                    CategoryEducationalEntityId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvidedForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProvidedForms_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProvidedForms_CategoryEducationalClasses_CategoryEducationalClassId",
                        column: x => x.CategoryEducationalClassId,
                        principalTable: "CategoryEducationalClasses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProvidedForms_CategoryEducationalEntities_CategoryEducationalEntityId",
                        column: x => x.CategoryEducationalEntityId,
                        principalTable: "CategoryEducationalEntities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProvidedForms_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatedAccountRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ReceiverId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedAccountRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedAccountRequests_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedAccountRequests_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RelatedAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User1Id = table.Column<int>(type: "int", nullable: false),
                    User2Id = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedAccounts_Users_User1Id",
                        column: x => x.User1Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedAccounts_Users_User2Id",
                        column: x => x.User2Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ResponsibilitiesUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ResponsibilityId = table.Column<int>(type: "int", nullable: false),
                    IsAccept = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibilitiesUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponsibilitiesUsers_Responsibilities_ResponsibilityId",
                        column: x => x.ResponsibilityId,
                        principalTable: "Responsibilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponsibilitiesUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingWorkshopSubscribers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TrainingWorkshopsId = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    UpdatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingWorkshopSubscribers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingWorkshopSubscribers_TrainingWorkshops_TrainingWorkshopsId",
                        column: x => x.TrainingWorkshopsId,
                        principalTable: "TrainingWorkshops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingWorkshopSubscribers_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TrainingWorkshopSubscribers_Users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TrainingWorkshopSubscribers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserNotifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    NotificationId = table.Column<int>(type: "int", nullable: false),
                    isReaded = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNotifications_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNotifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Platform = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criterions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MaxAttachmentNumber = table.Column<int>(type: "int", nullable: true),
                    ArbitrationProcedureId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criterions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criterions_ArbitrationProcedure_ArbitrationProcedureId",
                        column: x => x.ArbitrationProcedureId,
                        principalTable: "ArbitrationProcedure",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Criterions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Criterions_Criterions_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Criterions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArbitrationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Note_ArbitrationProcedure_ArbitrationId",
                        column: x => x.ArbitrationId,
                        principalTable: "ArbitrationProcedure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Note_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachmentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailAttachments_EmailMessages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArbitrationResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    EligibleForCertification = table.Column<bool>(type: "bit", nullable: false),
                    EligibleForAStatement = table.Column<bool>(type: "bit", nullable: false),
                    EligibleToWin = table.Column<bool>(type: "bit", nullable: false),
                    GotCertification = table.Column<bool>(type: "bit", nullable: false),
                    GotStatement = table.Column<bool>(type: "bit", nullable: false),
                    Winner = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitrationResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitrationResults_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Arbitrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isAccepted = table.Column<bool>(type: "bit", nullable: false),
                    ReasonForRejecting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isAcceptedFromChairman = table.Column<bool>(type: "bit", nullable: true),
                    ArbitratorId = table.Column<int>(type: "int", nullable: false),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    DateOfArbitration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FullScore = table.Column<float>(type: "real", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arbitrations_Arbitrators_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arbitrations_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArbitratorForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    ArbitratorId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitratorForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitratorForms_Arbitrators_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArbitratorForms_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConditionsProvidedForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAgree = table.Column<bool>(type: "bit", nullable: false),
                    TermAndConditionId = table.Column<int>(type: "int", nullable: false),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionsProvidedForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConditionsProvidedForms_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConditionsProvidedForms_TermsAndConditions_TermAndConditionId",
                        column: x => x.TermAndConditionId,
                        principalTable: "TermsAndConditions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CoordinatorForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    CoordinatorId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoordinatorForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoordinatorForms_Coordinators_CoordinatorId",
                        column: x => x.CoordinatorId,
                        principalTable: "Coordinators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoordinatorForms_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CycleConditionsProvidedForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAgree = table.Column<bool>(type: "bit", nullable: false),
                    CycleConditionId = table.Column<int>(type: "int", nullable: false),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleConditionsProvidedForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CycleConditionsProvidedForms_CycleCondition_CycleConditionId",
                        column: x => x.CycleConditionId,
                        principalTable: "CycleCondition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CycleConditionsProvidedForms_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExtraAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredAttachmentNumber = table.Column<int>(type: "int", nullable: false),
                    AttachmentType = table.Column<int>(type: "int", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExtraAttachments_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinalArbitrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isAccepted = table.Column<bool>(type: "bit", nullable: false),
                    ReasonForRejecting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isAcceptedFromChairman = table.Column<bool>(type: "bit", nullable: false),
                    ArbitratorId = table.Column<int>(type: "int", nullable: false),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    DateOfArbitration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FullScore = table.Column<float>(type: "real", nullable: false),
                    FinalScore = table.Column<float>(type: "real", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalArbitrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinalArbitrations_Arbitrators_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinalArbitrations_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CriterionAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriterionId = table.Column<int>(type: "int", nullable: false),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterionAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriterionAttachments_Criterions_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "Criterions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriterionAttachments_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CriterionItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    ActualScore = table.Column<int>(type: "int", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: true),
                    CriterionId = table.Column<int>(type: "int", nullable: false),
                    MaxAttachmentNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterionItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriterionItems_Criterions_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "Criterions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConditionAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    IsAccept = table.Column<bool>(type: "bit", nullable: true),
                    ReasonOfReject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConditionsProvidedFormsId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConditionAttachments_ConditionsProvidedForms_ConditionsProvidedFormsId",
                        column: x => x.ConditionsProvidedFormsId,
                        principalTable: "ConditionsProvidedForms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CycleConditionAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    IsAccept = table.Column<bool>(type: "bit", nullable: true),
                    ReasonOfReject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CycleConditionsProvidedFormId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleConditionAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CycleConditionAttachments_CycleConditionsProvidedForms_CycleConditionsProvidedFormId",
                        column: x => x.CycleConditionsProvidedFormId,
                        principalTable: "CycleConditionsProvidedForms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExtraAttachmentsProvidedForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAccept = table.Column<bool>(type: "bit", nullable: true),
                    ReasonOfReject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraAttachmentId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraAttachmentsProvidedForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExtraAttachmentsProvidedForms_ExtraAttachments_ExtraAttachmentId",
                        column: x => x.ExtraAttachmentId,
                        principalTable: "ExtraAttachments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArbitrationScalesCriterions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriterionId = table.Column<int>(type: "int", nullable: true),
                    CriterionItemId = table.Column<int>(type: "int", nullable: true),
                    ArbitrationScaleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitrationScalesCriterions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitrationScalesCriterions_ArbitrationScales_ArbitrationScaleId",
                        column: x => x.ArbitrationScaleId,
                        principalTable: "ArbitrationScales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArbitrationScalesCriterions_CriterionItems_CriterionItemId",
                        column: x => x.CriterionItemId,
                        principalTable: "CriterionItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArbitrationScalesCriterions_Criterions_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "Criterions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CriterionItemAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriterionItemId = table.Column<int>(type: "int", nullable: false),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterionItemAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriterionItemAttachments_CriterionItems_CriterionItemId",
                        column: x => x.CriterionItemId,
                        principalTable: "CriterionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriterionItemAttachments_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FinalArbitrationScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriterionId = table.Column<int>(type: "int", nullable: true),
                    CriterionItemId = table.Column<int>(type: "int", nullable: true),
                    FinalArbitrationId = table.Column<int>(type: "int", nullable: false),
                    StrengthPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImprovementAreas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArbitrationScore = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalArbitrationScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinalArbitrationScores_CriterionItems_CriterionItemId",
                        column: x => x.CriterionItemId,
                        principalTable: "CriterionItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalArbitrationScores_Criterions_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "Criterions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalArbitrationScores_FinalArbitrations_FinalArbitrationId",
                        column: x => x.FinalArbitrationId,
                        principalTable: "FinalArbitrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InitialArbitrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriterionId = table.Column<int>(type: "int", nullable: true),
                    CriterionItemId = table.Column<int>(type: "int", nullable: true),
                    ArbitrationId = table.Column<int>(type: "int", nullable: false),
                    StrengthPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImprovementAreas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArbitrationScore = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InitialArbitrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InitialArbitrations_Arbitrations_ArbitrationId",
                        column: x => x.ArbitrationId,
                        principalTable: "Arbitrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InitialArbitrations_CriterionItems_CriterionItemId",
                        column: x => x.CriterionItemId,
                        principalTable: "CriterionItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InitialArbitrations_Criterions_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "Criterions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChairmanNotesOnFinalArbitrationScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalArbitrationScoreId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChairmanNotesOnFinalArbitrationScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChairmanNotesOnFinalArbitrationScores_FinalArbitrationScores_FinalArbitrationScoreId",
                        column: x => x.FinalArbitrationScoreId,
                        principalTable: "FinalArbitrationScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChairmanNotesOnInitialArbitrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InitialArbitrationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChairmanNotesOnInitialArbitrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChairmanNotesOnInitialArbitrations_InitialArbitrations_InitialArbitrationId",
                        column: x => x.InitialArbitrationId,
                        principalTable: "InitialArbitrations",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AboutAwardPage",
                columns: new[] { "Id", "AboutImage", "ArabicAboutDescription", "ArabicAboutTitle", "ArabicOurVisionDescription", "ArabicOurVisionTitle", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishAboutDescription", "EnglishAboutTitle", "EnglishOurVisionDescription", "EnglishOurVisionTitle", "LastModifiedAt", "LastModifiedBy", "OurVisionImage", "isDeleted" },
                values: new object[] { 1, "https://award-shj.ae/media/fuebwvg4/17.jpg?center=0.15180018758166036,0.48777667777111344&mode=crop&width=796&height=329&rnd=133312190453500000", "تأسست جائزة الشارقة للتفوق والتميز التربوي عام 1994-1995 برعاية كريمة من صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الاعلى حاكم إمارة الشارقة حفظه الله ورعاه... وتعتبر أول جائزة تربوية على مستوى الدولة", "نبذة عن الجائزة", "تعلـــيم متــميز", "رؤيتنا", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8748), null, null, "The Sharjah Award for Educational Excellence and Excellence was established in 1994-1995 under the generous patronage of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of the Emirate of Sharjah, may God protect and preserve him... It is considered the first educational award at the state level.", "About the award", "Distinguished education", "Our vision", null, null, "https://award-shj.ae/media/fuebwvg4/17.jpg?center=0.15180018758166036,0.48777667777111344&mode=crop&width=796&height=329&rnd=133312190453500000", false });

            migrationBuilder.InsertData(
                table: "AttributeDataTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8675), null, null, null, null, "Text", false },
                    { 2, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8679), null, null, null, null, "Email", false },
                    { 3, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8684), null, null, null, null, "Image", false },
                    { 4, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8687), null, null, null, null, "File", false },
                    { 5, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8690), null, null, null, null, "Phone Number", false },
                    { 6, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8694), null, null, null, null, "Number", false },
                    { 7, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8697), null, null, null, null, "Date", false },
                    { 8, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8700), null, null, null, null, "List", false },
                    { 9, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8703), null, null, null, null, "Location", false },
                    { 10, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8706), null, null, null, null, "Emirates ID number", false }
                });

            migrationBuilder.InsertData(
                table: "AttributeOperations",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "OperationAsString", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8821), null, null, null, null, ">", false },
                    { 2, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8825), null, null, null, null, ">=", false },
                    { 3, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8828), null, null, null, null, "<", false },
                    { 4, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8831), null, null, null, null, "<=", false },
                    { 5, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8834), null, null, null, null, "=", false },
                    { 6, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8837), null, null, null, null, "!=", false },
                    { 7, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8840), null, null, null, null, "is Empty", false },
                    { 8, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8844), null, null, null, null, "is not Empty", false }
                });

            migrationBuilder.InsertData(
                table: "AttributeTableNames",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8569), null, null, null, null, "ProvidedForm", false },
                    { 2, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8572), null, null, null, null, "Coordinator", false },
                    { 3, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8576), null, null, null, null, "Arbitrator", false }
                });

            migrationBuilder.InsertData(
                table: "AwardSponsors",
                columns: new[] { "Id", "ArabicDescription", "ArabicEducationalStages", "ArabicHonoraryPositions", "ArabicName", "ArabicUpbringingAndAiography", "ArabicWritings", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishDescription", "EnglishEducationalStages", "EnglishHonoraryPositions", "EnglishName", "EnglishUpbringingAndAiography", "EnglishWritings", "Image", "Image2", "Image3", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[] { 1, "حفلت السيرة الذاتية لصاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الأعلى حاكم الشارقة بالعديد من الإنجازات التي تكشف عن اهتمام سموه المبكر بتحصيل العلوم بمختلف أنواعها، وحرص سموه على إفادة المجتمع من هذا العلم، سواء عن طريق إنشاء الكليات والجامعات، أو تأليف نحو 17 كتاباً ودراسة في مختلف أنواع الآداب والمعارف، رغم انشغال سموه بأمور الدولة، ومتابعة شؤون إمارة الشارقة الباسمة.\r\n\r\n \r\n\r\nإن منح صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الأعلى حاكم الشارقة دكتوراه فخرية من جامعة تيوبنجن الألمانية، تلك الجامعة التي تعد واحدة من أعرق الجامعات الألمانية يؤكد من جديد ما يتمتع به سموه حفظه الله من مكانة رفيعة بين الأوساط العلمية والأكاديمية، تلك المكانة التي تتوج مسيرة طويلة من الجهد المضني الذي بذله ويبذله سموه بتفان وإخلاص من أجل إرساء قواعد نهضة حقيقية للبلاد تنبعث من الإنسان الواعي المثقف الذي يتخذ من العلم والإيمان والثقافة طريقا وحياة ليجعل لبلاده مكاناً ومكانة رفيعة بين الأمم.\r\n\r\n \r\n\r\nتلك الرؤية العميقة لصاحب السمو حاكم الشارقة من أجل التطور والنهوض كانت دائماً هي الهاجس الذي كرس سموه من أجله وقته وحياته وبدأ من أجل تحقيقها مسيرة طويلة من الجهد والعمل الدؤؤوب.\r\n\r\n \r\n\r\nوقد كانت جهود سموه المشهودة الساعية باستمرار الى نشر العلم ودعم البحث العلمي والأخذ بأسبابه، وما يقدمه من مؤلفات وأبحاث ودراسات وآراء قيمة، وكذلك اهتمام كبير بنشر ثقافة الحوار بين الشعوب العربية والإسلامية وشعوب العالم الغربي، وسعي سموه المتواصل لدعم هذا التوجه عبر فعاليات ثقافية ومد خطوط تواصل دائمة بين الشارقة والعديد من البلدان الأوروبية، جعلت من سموه شخصية استثنائية بكل المقاييس وأحد أهم وأبرز شخصيات العالم العربي التي تحظي بتقدير عالمي في الأوساط الأكاديمية والعلمية ما حدا بجامعات العالم أن تسعى الى تكريم سموه وإهدائه أعلى درجاتها العلمية، وما حصول سموه بالأمس على الدكتوراه الفخرية من جامعة تيوبنجن الألمانية إلا تقديرا واعترافا جديدا بفضل سموه وشخصيته وجهوده وأعماله المقدرة.. ففضلا عن حصول سموه على درجة الدكتوراه في فلسفة التاريخ بامتياز من جامعة إكسيتر 1985م بالمملكة المتحدة ودرجة الدكتوراه في الفلسفة في الجغرافيا السياسية للخليج من جامعة دورهام 1999م بالمملكة المتحدة. فإن سموه يحمل تسع شهادات دكتوراه فخرية من أعرق الجامعات العربية والإسلامية والآسيوية والأوروبية حيث منح سموه دكتوراه فخرية في الآداب 1985م من جامعة أكستر بالمملكة المتحدة، في الحقوق 1986م من جامعة الخرطوم بالسودان، في القانون من جامعة ماك ماستر الكندية، في التاريخ من معهد الاستشراق التابع لأكاديمية العلوم الروسية، دكتوراه فخرية من جامعة فيصل أباد البنجاب في باكستان، من جامعة أدنبرة، من الجامعة الإسلامية العالمية بماليزيا، دكتوراه فخرية من جامعة ساوث بانك البريطانية وأخرى من أكاديمية العلوم القومية بجمهورية أرمينيا. هذا التكريم الذي صادف أهله بحق والذي حصل عليه سموه من جامعات العالم، والذي يشكل إجماعاً أكاديمياً على قدر سموه العلمي والإنساني وعلى قيمة وأهمية مايقدمه سموه لبلاده وشعبه من جهد وعمل، هو في حقيقة الأمر وسام على صدر كل ابن من أبناء الإمارات. بارك الله في جهود سموه  المخلصة البناءة التي تحث وتشهد على عظمة الإنسان عندما يكرس حياته وجهده وعمله لخدمة الوطن وأبنائه المخلصين.", "1948 التعليم الابتدائي - مدرسة الإصلاح القاسمية\r\nالتعليم الإعدادي والثانوي - الشارقة ودبي\r\n 1971 البكالوريوس في الزراعة - كلية الزراعة، جامعة القاهرة، القاهرة، مصر\r\nدكتوراه في التاريخ بامتياز - عن أطروحة تناولت مزاعم القرصنة ومحاولات شركة الهند الشرقية السيطرة على الخليج بين 1797-1820 ، جامعة إكسيتر، إكسيتر، المملكة المتحدة - 10 مايو 1985 م\r\nدكتوراه في الجغرافية السياسية للخليج - عن أطروحة بعنوان «صراع القوى والتجارة في الخليج خلال الفترة من سنة 1620 م وحتى سنة 1820 م» ، جامعة درهام، درهام، المملكة المتحدة ، 2 يوليو 1999 م", "الزمالة الفخرية من المعهد الملكي للمهندسين المعماريين البريطانيين، تقديراً لجهود ومساهمات سموه الكبيرة في عالم التصميم والهندسة المعمارية ودوره في بناء مجتمعات أكثر استدامة، 02 نوفمبر 2018.\r\nالعضوية الفخرية بمجمع اللغة العربية وذلك تقديراً لدور سموه في خدمة اللغة والثقافة العربية، 24 ديسمبر 2015.\r\nالزمالة الفخرية من كليات الأطباء الملكية في كل من لندن وجلاسكو وأدنبرة وذلك تقديراً لدور سموه في دعم المسيرة التعليمية والطبية على مستوى العالم، 16 يونيو 2015.\r\nالرئيس الشرفي للاتحاد العربي للمرشدين السياحيين، 2013.\r\nالرئيس الفخري لاتحاد كتاب وأدباء الإمارات، 2012.\r\nالزمالة الشرفية من الكلية الملكية الإنجليزية للجراحيين، لندن، بريطانيا 12نوفمبر 2009.\r\nالرئيس الفخري لاتحاد الجامعات العربية، 2009.\r\nالرئيس الأعلى للهيئة العربية للمسرح،2008.\r\nالرئيس الفخري للجمعية العربية لعلوم الفضاء والفلك 2008.\r\nالرئيس الفخري للمؤسسة الدولية لتاريخ العلوم عند العرب والمسلمين 2008.\r\nالعضوية الفخرية باتحاد كتاب مصر 2008.\r\nالعضوية الشرفية، الجمعية الوطنية للجغرافيا، تقديراً لدعم سموه للجمعية الوطنية للجغرافيا بالولايات المتحدة الأمريكية، التي تأسست في عام 1888، للعناية بعلم الجغرافيا وتطوير البحث والاستكشاف، واشنطن، أمريكا يناير 2004.\r\nالرئيس الفخري للجمعية المصرية للدراسات التاريخية 2001.\r\nالرئيس الفخري للمؤسسة العربية للعلوم والتكنولوجيا، 2000.\r\nالرئيس الفخري للخدمات الجامعية العالمية 1998.\r\nالرئيس الفخري لمدينة الشارقة للخدمات الإنسانية 1998.\r\nالعضوية الفخرية في مركز الدراسات الشرق أوسطية والإسلامية، جامعة درم، المملكة المتحدة 22 اكتوبر 1992.\r\nالزمالة الفخرية، معهد الدراسات الأفريقية، جامعة الخرطوم، السودان، 1977.", "صاحبِ السموّ الشيخ الدكتور سلطان بن محمد القاسمي، عضوِ المجلس الأعلى، حاكمِ الشارقةِ، إمارةِ الثقافةِ والتميّز", "هو صاحب السمو الشيخ الدكتور سلطان بن محمد بن صقر بن خالد بن سلطان بن صقر بن راشد القاسمي ولد يوم الأحد في الرابع عشر من جمادى الأولى سنة 1358 هـ، الموافق الثاني من يوليو عام 1939 م بمدينة الشارقة.\r\n\r\nوالدته الشيخة مريم بنت الشيخ غانم ابن الشيخ سالم بن عبدالله بن سعيد ابن سبت بن مطر بن سلطان بن فارس بن شهوان الشامسي.\r\n\r\nله من والدته من الأشقاء أربع الشيخ خالد والشيخ صقر والشيخ عبدالعزيز والشيخ عبدالله ومن  الشقيقات اثنتان الشيخة شيخة والشيخة ناعمة .\r\n\r\nولصاحب السمو حاكم الشارقة أخوة غير أشقاء هم الشيخ راشد والشيخ حميد والشيخ علي والشيخة موزة والشيخة علياء والشيخات غاية ونورة وعائشة وعزة.\r\n\r\nتزوج سموه من الشيخة موزة بنت سالم بن محمد ابن مانع الفلاسي (جدتها الشيخة موزة بنت الشيخ غانم ابن الشيخ سالم الشامسي خالة صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي)، وقد انجبت له ابنه المرحوم الشيخ محمد الذي توفي في الثالث من أبريل عام 1999 عن عمر يناهز 24 عاماً، وابنته الشيخة عزة .\r\n\r\nكما تزوج صاحب السمو حاكم الشارقة سمو الشيخة جواهر بنت الشيخ محمد بن سلطان بن صقر القاسمي ، وأنجبت له من الأبناء الشيخ خالد (توفي في 01 يوليو2019 عن عمر ناهز الأربعين عامًا) و الشيخة بدور والشيخة نور و الشيخة حور .. .\r\n\r\nتربى سموه على الوطنية، وترعرع على حب العلم والمعرفة، وكان شغوفا جدا بتاريخ وطنه، تفرغ في بداية عمره للدراسة وانتقل بين الشارقة والكويت ومصر ليتلقى تعليمه، وقد بدأ سموه تعليمه العام في شهر سبتمبر سنة 1948 في مدرسة الإصلاح القاسمية وكان عمره آنذاك تسع سنوات وشهرين، وكان قد درس سموه قبلها القرآن لدى الشيخ فارس ابن عبد الرحمن. وفي العام 1954 انضم صاحب السمو حاكم الشارقة للمدرسة الإنجليزية الخاصة ليدرس اللغة الإنجليزية. وانتقل سموه بين الشارقة والكويت لتلقي تعليمه الإعدادي والثانوي لينتهي به المطاف في نهاية عام 1965 في القاهرة حيث بدأ الدراسة الجامعية في كلية الزراعة بجامعة القاهرة.\r\n\r\nعمل سموه مدة عامين منذ فبراير عام 1961 وإلى سبتمبر 1963 كمدرس لمادتي اللغة الانجليزية والرياضيات بالمدرسة الصناعية بالشارقة.\r\n\r\nثم تسلم رئاسة البلدية في عام 1965 . وبعد عودته إلى الشارقة بعد اتمامه دراسته الجامعية عام 1971 تسلم صاحب السمو حاكم الشارقة إدارة مكتب سمو الحاكم بإمارة الشارقة.\r\n\r\nوبعد أيام من قيام اتحاد دولة الإمارات العربية المتحدة صباح يوم الثاني من ديسمبر عام 1971، وتحديداً في اليوم التاسع من ديسمبر تم تشكيل مجلس الوزراء ونصب صاحب السمو الشيخ الدكتور سلطان القاسمي يومها وزيراً للتربية والتعليم.\r\n\r\nوفي يوم الثلاثاء التاسع من ذي الحجة، يوم عرفة سنة 1391 هـ الموافق الخامس والعشرين من يناير 1972 تسلم صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي مقاليد حكم إمارة الشارقة بعد مقتل حاكم الشارقة آنذاك الشيخ خالد بن محمد القاسمي بعد انقلاب قاده الشيخ صقر بن سلطان القاسمي ، وليكون عضواً في المجلس الأعلى لدولة الامارات العربية المتحدة، وكان عمر سموه آنذاك 32 عاماً.\r\n\r\nويعد سموه الحاكم الثامن عشر لإمارة الشارقة من حكم القواسم الذي يعود للعام 1600 ميلادية.\r\n\r\nوقد قاد سموه التنمية الثقافية والاقتصادية والاجتماعية في إمارة الشارقة، وبذل سموه جهداً اضافياً ووفر مصادر لتشجيع التفاعل والحوار الثقافي محلياً واقليمياً ودولياً بين الشعوب كافة.", "صاحب السمو الشيخ الدكتور سلطان القاسمي، له العديد من المؤلفات منها\r\n\r\nمحاكم التفتيش\r\nسيرة مدينة (الجزء الأول)ـ\r\nسيرة مدينة (الجزء الثاني)ـ", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8655), null, null, "The biography of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of Sharjah, is full of many achievements that reveal his early interest in acquiring all kinds of sciences. His Highness was keen to support the society with this knowledge, whether by establishing colleges and universities, or authoring more than 17 books and studies in various types of literature and knowledge, beside his responsibilities of country affairs, and following up on the affairs of the smiling Emirate of Sharjah.\r\n\r\n \r\n\r\nHis Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of Sharjah, has an honorary doctorate from the German University of Tuebingen, which is one of the ancient German universities. This confirms His Highness’s high status among the scientific and academic community. This prestige status culminates the long march of strenuous effort that His Highness made and is making with devotion and sincerity in order to empower the foundations for a real advantage for the country, emanating from the conscious and educated person who takes science, faith and culture as a path and life guide to give his country a high status place among nations.\r\n\r\n \r\n\r\nThat deep vision of His Highness the Ruler of Sharjah for development and advancement has always been the obsession for which His Highness devoted his time and life and began to achieve it through a long journey of effort and hard work.\r\n\r\n \r\n\r\nHis Highness's remarkable efforts were constantly attempt to spread knowledge, support scientific research and take into account its causes, and what his highness presents of valuable books, research, studies and opinions, as well as his great interest in spreading the culture of dialogue between the Arabic and Islamic people and the people of the Western world. His Highness' continuous endeavor to support this trend through cultural activities and extending permanent lines of communication between Sharjah and many European countries, made His Highness an exceptional personality by all standards and one of the most important and prominent personalities in the Arab world that enjoys global appreciation in the academic and scientific circles, which prompted the world's universities to seek to honor His Highness and bestow upon him the highest academic degrees. His Highness received an honorary doctorate from the University of Tuebingen in Germany, is an appreciation and recognition of His Highness, his personality, his efforts, and his appreciable work. In addition to his obtaining a PhD in Philosophy of History with distinction from the University of Exeter in 1985 in the United Kingdom, and a PhD in Philosophy in the Political Geography of the Gulf from Durham University in 1999 in the United Kingdom, His Highness holds nine honorary doctorates from the most prestigious Arab, Islamic, Asian and European universities. Furthermore, his Highness was awarded an honorary doctorate in literature in 1985 from the University of Exeter in the United Kingdom, in law in 1986 from the University of Khartoum in Sudan, in law from Canadian McMaster University, in history from the Oriental Institute of the Russian Academy of Sciences, an honorary doctorate from the University of Faisalabad Punjab in Pakistan, from University of Edinburgh, International Islamic University Malaysia, Honorary Doctorate from British South Bank University and another from the National Academy of Sciences of the Republic of Armenia. This honor which His Highness received from the universities of the world, constitutes an academic consensus on the scientific and human value of His Highness and on the value and importance of what His Highness offers to his country and his people of effort and work, is in fact a medal on the chest of every son of the Emirates. May God bless His Highness's sincere and constructive efforts that urge and testify to the greatness of man who devotes his life, effort and work to the country and people.", "1948 Primary Education - Al-Islah Al-Qasimiya School\r\nPreparatory and secondary education - Sharjah and Dubai\r\n  1971 Bachelor of Agriculture - Faculty of Agriculture, Cairo University, Cairo, Egypt\r\nDoctorate in History with distinction - on a thesis that dealt with allegations of piracy and the attempts of the East India Company to control the Gulf between 1797-1820, University of Exeter, Exeter, United Kingdom - May 10, 1985 AD\r\nDoctorate in the Political Geography of the Gulf - for a thesis entitled “Power Conflict and Trade in the Gulf during the Period from 1620 AD to 1820 AD,” Durham University, Durham, United Kingdom, July 2, 1999 AD.", "Honorary Fellowship from the Royal Institute of British Architects, in recognition of His Highness’s great efforts and contributions to the world of design and architecture and his role in building more sustainable societies, 02 November 2018.\r\nHonorary membership in the Arabic Language Academy in recognition of His Highness’s role in serving the Arabic language and culture, December 24, 2015.\r\nHonorary Fellowship from the Royal Colleges of Physicians in London, Glasgow and Edinburgh in recognition of His Highness’s role in supporting the educational and medical process worldwide, June 16, 2015.\r\nHonorary President of the Arab Federation of Tourist Guides, 2013.\r\nHonorary President of the Emirates Writers and Writers Union, 2012.\r\nHonorary Fellowship from the Royal College of Surgeons, London, Britain November 12, 2009.\r\nHonorary President of the Association of Arab Universities, 2009.\r\nSupreme President of the Arab Theater Authority, 2008.\r\nHonorary President of the Arab Society for Space and Astronomy 2008.\r\nHonorary President of the International Foundation for the History of Science among Arabs and Muslims 2008.\r\nHonorary membership in the Egyptian Writers Union 2008.\r\nHonorary Membership, National Geographic Society, in recognition of His Highness’s support for the National Geographic Society of the United States of America, which was founded in 1888, to care for the science of geography and develop research and exploration, Washington, America, January 2004.\r\nHonorary President of the Egyptian Society for Historical Studies 2001.\r\nHonorary President of the Arab Science and Technology Foundation, 2000.\r\nHonorary President of Global University Services 1998.\r\nHonorary President of Sharjah City for Humanitarian Services 1998.\r\nHonorary membership in the Center for Middle Eastern and Islamic Studies, Durham University, United Kingdom, October 22, 1992.\r\nHonorary Fellowship, Institute of African Studies, University of Khartoum, Sudan, 1977.", "His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Supreme Council Member and Ruler of Sharjah", "He is His Highness Sheikh Dr. Sultan bin Muhammad bin Saqr bin Khalid bin Sultan bin Saqr bin Rashid Al Qasimi. He was born on Sunday, the fourteenth of Jumada Al-Awwal, 1358 AH, corresponding to the second of July, 1939 AD, in the city of Sharjah.\r\n\r\nHis mother is Sheikha Maryam, daughter of Sheikh Ghanem, son of Sheikh Salem bin Abdullah bin Saeed bin Sabt bin Matar bin Sultan bin Faris bin Shahwan Al Shamsi.\r\n\r\nHe has four brothers from his mother, Sheikh Khaled, Sheikh Saqr, Sheikh Abdulaziz, and Sheikh Abdullah, and two sisters, Sheikha Sheikha and Sheikha Naamah.\r\n\r\nHis Highness the Ruler of Sharjah has half-siblings, Sheikh Rashid, Sheikh Humaid, Sheikh Ali, Sheikha Moza, Sheikha Alia, and Sheikhs Ghaya, Noura, Aisha and Azza.\r\n\r\nHis Highness married Sheikha Moza bint Salem bin Mohammed bin Mani Al Falasi (her grandmother was Sheikha Moza bint Sheikh Ghanem bin Sheikh Salem Al Shamsi, aunt of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi), and she gave birth to his son, the late Sheikh Mohammed, who died on April 3, 1999. Omar is 24 years old, and his daughter, Sheikha Azza.\r\n\r\nHis Highness the Ruler of Sharjah also married Her Highness Sheikha Jawaher, daughter of Sheikh Mohammed bin Sultan bin Saqr Al Qasimi, and she bore him children Sheikh Khaled (died on July 1, 2019 at the age of forty), Sheikha Bodour, Sheikha Nour, and Sheikha Hoor...\r\n\r\nHis Highness was raised on patriotism, and he grew up with a love of science and knowledge, and he was very passionate about the history of his homeland. At the beginning of his life, he devoted himself to studying and moved between Sharjah, Kuwait, and Egypt to receive his education. His Highness began his general education in September 1948 at Al-Islah Al-Qasimia School, and he was nine years and two months old at the time. Before that, His Highness had studied the Qur’an with Sheikh Faris bin Abdul Rahman. In 1954, His Highness the Ruler of Sharjah joined the private English school to study the English language. His Highness moved between Sharjah and Kuwait to receive his preparatory and secondary education, ending up at the end of 1965 in Cairo, where he began university studies at the Faculty of Agriculture at Cairo University.\r\n\r\nHis Highness worked for two years from February 1961 to September 1963 as a teacher of English and mathematics at the Sharjah Industrial School.\r\n\r\nThen he assumed the presidency of the municipality in 1965. After his return to Sharjah after completing his university studies in 1971, His Highness the Ruler of Sharjah assumed the management of the Office of His Highness the Ruler in the Emirate of Sharjah.\r\n\r\nDays after the establishment of the United Arab Emirates on the morning of December 2, 1971, and specifically on the ninth of December, the Council of Ministers was formed and His Highness Sheikh Dr. Sultan Al Qasimi was appointed Minister of Education that day.\r\n\r\nOn Tuesday, the ninth of Dhu al-Hijjah, the day of Arafah in the year 1391 AH, corresponding to the twenty-fifth of January 1972, His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi took over the reins of rule of the Emirate of Sharjah after the killing of the ruler of Sharjah at the time, Sheikh Khalid bin Muhammad Al Qasimi, after a coup led by Sheikh Saqr bin Sultan Al Qasimi. To be a member of the Supreme Council of the United Arab Emirates, His Highness was 32 years old at the time.\r\n\r\nHis Highness is the eighteenth ruler of the Emirate of Sharjah during the Qawasim rule, which dates back to the year 1600 AD.\r\n\r\nHis Highness led the cultural, economic and social development in the Emirate of Sharjah, and His Highness made an additional effort and provided resources to encourage cultural interaction and dialogue locally, regionally and internationally among all peoples.", "His Highness Sheikh Dr. Sultan Al Qasimi has many publications, including:\r\n\r\ninquisition\r\nBiography of a city (Part One).\r\nBiography of a city (Part Two).", "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000", "https://award-shj.ae/media/bxpppdue/ddddd.png?crop=0,0.12824379935491048,0,0.41253923275760135&cropmode=percentage&width=1903&height=424&rnd=132551077852800000", "https://award-shj.ae/media/bxpppdue/ddddd.png?crop=0,0.12824379935491048,0,0.41253923275760135&cropmode=percentage&width=1903&height=424&rnd=132551077852800000", null, null, false });

            migrationBuilder.InsertData(
                table: "Coordinators",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "Email", "EnglishName", "LastModifiedAt", "LastModifiedBy", "PhoneNumber", "isDeleted" },
                values: new object[,]
                {
                    { 10, "منسق 1", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5472), null, null, "Coordinator@Coordinator.com", "Coordinator 1", null, null, "0993521579", false },
                    { 11, "منسق 2", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5478), null, null, "Coordinator2@Coordinator2.com", "Coordinator 2", null, null, "0993521579", false },
                    { 12, "منسق 3", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5482), null, null, "Coordinator3@Coordinator3.com", "Coordinator 3", null, null, "0993521579", false },
                    { 13, "منسق 4", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5486), null, null, "Coordinator4@Coordinator4.com", "Coordinator 4", null, null, "0993521579", false }
                });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "CycleNumber", "DeletedAt", "EnglishName", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "GroupCategoryNumber", "IndividualCategoryNumber", "InitialArbitrationEndDate", "InitialArbitrationStartDate", "LastModifiedAt", "LastModifiedBy", "MarginOfDifferenceBetweenArbitrators", "RegistrationPortalClosingDate", "RegistrationPortalOpeningDate", "Status", "SubscriberPortalClosingDate", "TheUpperLimitForObtainingInformation", "Year", "isDeleted" },
                values: new object[] { 1, "جائزة الشارقة للتفوق والتميز التربوي", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8336), null, 31, null, "Sharjah Award for Educational Excellence", null, null, 1, 1, null, null, null, null, 10, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 10, "2024 - 2025", false });

            migrationBuilder.InsertData(
                table: "EducationalClasses",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "الصف الأول", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6979), null, null, "First class", null, null, false },
                    { 2, "الصف الثاني", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6985), null, null, "Second class", null, null, false },
                    { 3, "الصف الثالث", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6988), null, null, "Third class", null, null, false },
                    { 4, "الصف الرابع", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6991), null, null, "Forth class", null, null, false },
                    { 5, "الصف الخامس", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6996), null, null, "Fifth class", null, null, false },
                    { 6, "الصف السادس", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6999), null, null, "Sixth class", null, null, false },
                    { 7, "الصف السابع", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7003), null, null, "Seventh class", null, null, false },
                    { 8, "الصف الثامن", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7005), null, null, "Eighth class", null, null, false },
                    { 9, "الصف التاسع", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7009), null, null, "Ninth class", null, null, false },
                    { 10, "الصف العاشر", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7012), null, null, "Tenth class", null, null, false },
                    { 11, "الصف الحادي عشر", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7015), null, null, "Eleventh class", null, null, false },
                    { 12, "الصف الثاني عشر", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7034), null, null, "Twelfth class", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "EducationalEntities",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "جهة تعليمية 1", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5701), null, null, "Educational Entity 1", null, null, false },
                    { 2, "جهة تعليمية 2", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5707), null, null, "Educational Entity 2", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "ArabicDescription", "ArabicLocation", "ArabicName", "ArabicSiteName", "CreatedAt", "CreatedBy", "DeletedAt", "EndDate", "EnglishDescription", "EnglishLocation", "EnglishName", "EnglishSiteName", "EventDate", "LastModifiedAt", "LastModifiedBy", "StartDate", "UniqueIntegerId", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار وصف حدث 1", "اختبار موقع الفعالية 1", "اختبار اسم حدث 1", "اختبار اسم مكان الحدث 1", new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6775), null, null, new DateTime(2024, 6, 17, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6783), "Test Event Description 1", "Test Event Location 1", "Test Event Name 1", "Test Event Site Name 1", new DateTime(2024, 6, 14, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6800), null, null, new DateTime(2024, 6, 15, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6802), 1, false },
                    { 2, "اختبار وصف حدث 2", "اختبار موقع الفعالية 2", "اختبار اسم حدث 2", "اختبار اسم مكان الحدث 2", new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6805), null, null, new DateTime(2024, 6, 20, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6807), "Test Event Description 2", "Test Event Location 2", "Test Event Name 2", "Test Event Site Name 2", new DateTime(2024, 6, 17, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6811), null, null, new DateTime(2024, 6, 18, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6812), 2, false }
                });

            migrationBuilder.InsertData(
                table: "ExplanatoryMessages",
                columns: new[] { "Id", "ArabicText", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishText", "LastModifiedAt", "LastModifiedBy", "Type", "isDeleted" },
                values: new object[,]
                {
                    { 1, "يمكنك البحث عن منسق لإرشادك في عملية المشاركة في الجائزة من خلال نحديد المعلومات الموجودة أدناه لتتمكن من اختيار المنسق الذي تريده.", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(230), null, null, "You can search for a coordinator to guide you in the process of participating in the award by specifying the information below so that you can choose the coordinator you want.", null, null, 0, false },
                    { 2, "شاركنا إنجازاتك هنا، نحن نبحث عن الأفراد المميزين في مجالاتهم ليشاركونا مهاراتهم وخبراتهم.", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(235), null, null, "Share your achievements with us here. We are looking for distinguished individuals in their fields to share their skills and experiences with us.", null, null, 1, false },
                    { 3, "يمكنك ربط حسابك مع اشخاص آخرين عن طريق إرسال دعوة لهم عن طريق البريد الالكتروني .", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(238), null, null, "You can link your account with other people by sending them an invitation via email.", null, null, 2, false },
                    { 4, "20 يوماً باق لانتهاء مرحلة التحكيم النهائية للمشاركين.", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(241), null, null, "20 days remain until the end of the final judging phase for the participants.", null, null, 3, false },
                    { 5, "لقد اتممت خطوات التسجيل في الجائزة   -   الرجاء الذهاب إلى المراحل الخاصة بالاستمارة لإرسال الاستمارة .", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(243), null, null, "You have completed the steps to register for the award - please go to the application stages to submit the form.", null, null, 4, false },
                    { 6, "الرجاء إتمام جميع المراحل الخاصة بالاستمارة الجديدة لتتمكن من الاشتراك بنجاح     --  يمكن الاشتراك بفئتين فقط (فئة ذات طابع فردي وفئة ذات طابع جماعي )خلال الدورة الواحدة ورفع الملفات المطلوبة عند تعبئة الاستمارة.", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(246), null, null, "Please complete all stages of the new form to be able to participate successfully. You can participate in only two categories (an individual category and a group category) during one session and upload the required files when filling out the form.", null, null, 5, false },
                    { 7, "الرجاء الموافقة على الشروط الخاصة كل شرط على حدا ورفع البيانات المطلوبة  في الحقول الخاصة ليتم قبول استمارة الترشح الخاصة.", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(249), null, null, "Please agree to the special conditions one by one and upload the required data in the special fields for the special nomination form to be accepted.", null, null, 6, false },
                    { 8, "عزيزي المشترك الرجاء تأكيد الموافقة على كافة المعلومات الواردة ضمن الإستمارة الخاصة بك كون هذه الخطوة غير قابلة للتراجع.", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(253), null, null, "Dear subscriber, please confirm your approval of all the information contained in your form, as this step is irreversible.", null, null, 7, false }
                });

            migrationBuilder.InsertData(
                table: "GeneralFAQCategories",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار فئة أسئلة شائعة عامة 1", new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8369), null, null, "Test General FAQ Category 1", null, null, false },
                    { 2, "اختبار فئة أسئلة شائعة عامة 2", new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8374), null, null, "Test General FAQ Category 2", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "GeneralWorkshops",
                columns: new[] { "Id", "AgendaImage", "ArabicDescription", "ArabicTitle", "CreatedAt", "CreatedBy", "DateOfWorkShop", "DayName", "DeletedAt", "EnglishDescription", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "RegistrationUrl", "Thumbnale", "Time", "Video", "isDeleted" },
                values: new object[,]
                {
                    { 1, null, "اختبار وصف الورش العامة 1", "اختبار عنوان الورش العامة 1", new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(7961), null, new DateTime(2024, 6, 22, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(7966), "Saturday", null, "Test General Workshop Description 1", "Test General Workshop Title 1", null, null, null, "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg", "10:00 - 12:00", null, false },
                    { 2, null, "اختبار وصف الورش العامة 2", "اختبار عنوان الورش العامة 2", new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8232), null, new DateTime(2024, 7, 2, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8236), "Tuesday", null, "Test General Workshop Description 2", "Test General Workshop Title 2", null, null, null, "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg", "2:00 - 3:00", null, false }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Slug", "Title", "isDeleted" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7961), null, null, null, null, "events_index", "جدول الفعاليات", false },
                    { 2, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7965), null, null, null, null, "event_attendees_index", "جدول حضور الفعاليات", false },
                    { 3, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7969), null, null, null, null, "arbitrators_index", "جدول المًحكّمين", false },
                    { 4, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7972), null, null, null, null, "coordinators_index", "جدول المًنسقين", false },
                    { 5, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7975), null, null, null, null, "arbitrator_form", "إضافة أو تعديل معلومات مًحكّم", false },
                    { 6, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7979), null, null, null, null, "coordinator_form", "إضافة أو تعديل معلومات مًنسق", false },
                    { 7, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7983), null, null, null, null, "class_arbitrators_index", "جدول مًحكّمين الصف", false },
                    { 8, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7986), null, null, null, null, "class_form", "إضافة أو تعديل معلومات صف", false },
                    { 9, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7989), null, null, null, null, "classes_index", "جدول الصفوف", false },
                    { 10, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7993), null, null, null, null, "cycle_form", "إضافة أو تعديل معلومات دورة", false },
                    { 11, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7996), null, null, null, null, "cycles_index", "جدول الدورات", false },
                    { 12, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7999), null, null, null, null, "Agendas_index", "جدول الأجندة", false },
                    { 13, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8002), null, null, null, null, "categories_index", "جدول الفئات الرئيسية مع الفئات الفرعية التابعة له", false },
                    { 14, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8006), null, null, null, null, "subcategory_form", "إضافة أو تعديل معلومات فئة فرعية", false },
                    { 15, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8010), null, null, null, null, "cycle_specifications_form", "إضافة أو تعديل محددات الدورة", false },
                    { 16, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8012), null, null, null, null, "explanatory_guide", "عرض الدليل التفسيري مع الإجراءات الممكنة", false },
                    { 17, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8016), null, null, null, null, "faq_index", "جدول الأسئلة الشائعة", false },
                    { 18, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8020), null, null, null, null, "cycle_conditions_index", "جدول الشروط العامة للدورة", false },
                    { 19, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8023), null, null, null, null, "data_import", "صفحة استيراد المعلومات", false },
                    { 20, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8026), null, null, null, null, "subcategory_conditions_index", "جدول شروط الفئة الفرعية", false },
                    { 21, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8029), null, null, null, null, "subcategory_fields_index", "جدول حقول الفئة الفرعية", false },
                    { 22, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8032), null, null, null, null, "subcategory_workshops_index", "جدول الورشات التدريبية للفئة الفرعية", false },
                    { 23, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8035), null, null, null, null, "educational_entities_index", "جدول الجهات التعليمية", false },
                    { 24, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8038), null, null, null, null, "educational_entities_form", "إضافة أو تعديل جهة تعليمية مع عرض المؤسسات التابعة في حال التعديل", false },
                    { 25, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8041), null, null, null, null, "educational_institution_form", "إضافة أو تعديل مؤسسة تعليمية", false },
                    { 26, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8045), null, null, null, null, "home", "الصفحة الرئيسية", false },
                    { 27, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8048), null, null, null, null, "instructions_index", "جدول الإرشادات", false },
                    { 28, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8051), null, null, null, null, "instruction_form", "صفحة تعديل إرشاد", false },
                    { 29, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8055), null, null, null, null, "notifications_index", "جدول الإشعارات", false },
                    { 30, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8058), null, null, null, null, "notifications_form", "إضافة إشعار", false },
                    { 31, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8062), null, null, null, null, "roles_index", "جدول الأدوار", false },
                    { 32, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8065), null, null, null, null, "role_form", "إضافة أو تعديل دور", false },
                    { 33, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8069), null, null, null, null, "subscribers_accounts_index", "جدول حسابات المشتركين", false },
                    { 34, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8073), null, null, null, null, "users_index", "جدول المستخدمين", false },
                    { 35, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8076), null, null, null, null, "user_form", "إضافة أو تعديل معلومات مستخدم", false },
                    { 36, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8080), null, null, null, null, "notifications_templates_index", "جدول نماذج الإشعارات", false },
                    { 37, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8084), null, null, null, null, "notification_template_form", "إضافة أو تعديل نموذج إشعارات", false },
                    { 38, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8087), null, null, null, null, "contact_us_index", "جدول طلبات التواصل", false },
                    { 39, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8090), null, null, null, null, "contact_us_details", "تفاصيل طلب تواصل", false },
                    { 40, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8094), null, null, null, null, "committees_index", "جدول اللجان", false },
                    { 41, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8098), null, null, null, null, "committee_form", "إضافة أو تعديل لجنة", false },
                    { 42, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8102), null, null, null, null, "meetings_index", "جدول الاجتماعات", false },
                    { 43, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8105), null, null, null, null, "meeting_form", "إضافة اجتماع", false },
                    { 44, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8108), null, null, null, null, "circulars_index", "جدول التعاميم", false },
                    { 45, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8111), null, null, null, null, "circular_form", "إضافة أو تعديل تعميم", false },
                    { 46, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8115), null, null, null, null, "general_workshops_index", "جدول الورشات التدريبية العامة", false },
                    { 47, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8117), null, null, null, null, "general_workshops_form", "إضافة أو تعديل ورشة تدريبية عامة", false },
                    { 48, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8120), null, null, null, null, "app_versions_index", "جدول نسخ التطبيق", false },
                    { 49, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8124), null, null, null, null, "app_version_form", "إضافة نسخة تطبيق", false },
                    { 50, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8128), null, null, null, null, "subscribers_profiles_index", "جدول برفايلات المستخدمين", false },
                    { 51, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8132), null, null, null, null, "subscriber_profile", "بروفايل مستخدم", false }
                });

            migrationBuilder.InsertData(
                table: "OnePageText",
                columns: new[] { "Id", "ArabicText", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishText", "LastModifiedAt", "LastModifiedBy", "Slug", "Type", "isDeleted" },
                values: new object[,]
                {
                    { 1, "إن هذا الموقع تابع لجائزة الشارقة للتفوق والتميز التربوي وكغيره من المواقع التابعة للجائزة، ملتزمٌ بحماية حقوق جميع زوار هذا الموقع، أي إننا نلتزم بالحفاظ على سرية المعلومات الحساسة، وقد أعددنا هذا الإعلان الخاص بسياسة الخصوصية للإفصاح عن النهج الذي نتبعه في جمع ونشر المعلومات على هذا الموقع الإلكتروني.\r\n\r\nتعتبر سياسة الخصوصية الموضحة في هذه الصفحة، جزءاً من شروط استخدام الموقع الإلكتروني وأحكامه.\r\n\r\n\r\nجمع واستخدام المعلومات الإلكترونية\r\n\r\nتعمل الخوادم الخاصة بنا تلقائياً على التقاط وجمع عنوان بروتوكول الإنترنت الخاص بك عند زيارتك للموقع، إن عنوان بروتوكول الإنترنت الخاص بك هو الرقم الخاص بجهاز الكمبيوتر أو الجهاز اللوحي أو الهاتف الذكي الذي تستخدمه، والذي يسمح للأجهزة الأخرى الموصولة بشبكة الإنترنت بتحديد وجهة البيانات الصادرة عنها، لكن من دون التعرف عليك شخصياً.\r\nإن استخدامنا لبروتوكول الإنترنت الخاص بك يساعدنا على تشخيص المشكلات التي قد تحدث في الخادم الخاص بنا، وعلى إجراء الإحصاء اللازم لقياس استخدام الموقع، ونحن لا نسمح لأي جهة خارج إطار الفريق الفني المكلف من الجائزة بالاطلاع على بروتوكول الإنترنت الخاص بك.\r\nمن أجل تقديم خدمة أفضل، وموقع إلكتروني أكثر فاعلية، يمكن لبعض أقسام هذا الموقع استخدام برامج تعريف الارتباط (cookies) كجزء من التفاعل مع متصفحك، وهذا البرنامج هو عبارة عن ملف نصي صغير يرسل إلى القرص الصلب الخاص بك ليتمكن خادمنا من التعرف على الجهاز والمتصفح الذي تستخدمه لتحسين تعاملك مع موقعنا.\r\nلن يقوم برنامج تعريف الارتباط المرسل من قبلنا بمحاولة قراءة أي من المعلومات الخاصة الموجودة على قرصك الصلب، ونحن لا نقوم بتجميع هذه المعلومات من خلال هذا البرامج لمعرفة بيانات أو معلومات شخصية أخرى من أجل تحديد هويتك أو عنوان بريدك الإلكتروني.\r\nفي حال كانت زيارتك للموقع للحصول على خدمة أو معلومات محددة، فقد يطلب منك عند زيارتك لبعض أجزاء هذا الموقع، تقديم معلومات شخصية للتعريف بهويتك (مثل الاسم، رقم الهاتف، والعنوان،...)، وهي كلها معلومات ضرورية لإتمام معاملتك غير أن هذه المعلومات لن يتم مشاركتها أو إساءة استخدامها تحت أي ظرف، وفي حال رفضك تقديم تلك المعلومات، فللجائزة الحق في رفض تقديم تلك الخدمة، وفي كل الأحوال، فإننا لانزل ندعوك لزيارة موقعنا والاستفادة من المعلومات القيمة التي يوفرها.\r\n \r\n\r\nحماية المعلومات الشخصية\r\n\r\nباستخدامك لهذا الموقع فإنك توافق على شروط سياسة الخصوصية هذه، حيث تلتزم الجائزة من خلال إدارته لموقعه الإلكتروني، عند جمع معلومات شخصية عنك عندما تقوم بزيارة الموقع بأن يكون استخدام تلك المعلومات التي قدمتها، فقط من أجل إنجاز طلبك للحصول على معلومات أو خدمات عبر الموقع.\r\nيحتفظ جائزة الشارقة للتفوق والتميز التربوي بالحق في إجراء أي تعديل طفيف أو جذري لشروط سياسة الخصوصية من وقت لآخر دون الحاجة إلى تقديم إخطار، حيث يتم تعديل هذه السياسة ونشر هذه التعديلات بمجرد اعتمادها، لذا ننصحك بالاطلاع على هذه الصفحة من وقت لأخر لمعرفة التحديثات التي طرأت على سياسة الخصوصية، ولذلك فإن زيارتك واستخدامك لموقعنا بعد إدخال التعديلات على سياسة الخصوصية هذه، يعني قبولك لهذه التغييرات.\r\nلن تكون معلوماتك الشخصية متاحة إلا لموظفي الجائزة الذين يحتاجون للاطلاع على تلك المعلومات، ولن تكون تلك المعلومات متاحة لاطلاع الجمهور عليها بدون موافقتك على ذلك، وعلاوة على ذلك، لن يتم تبادل، أو تداول أي من تلك المعلومات أو بيعها لأي طرف آخر من دون موافقتك المسبقة، ولن يتم السماح بالوصول إلى المعلومات إلا لأولئك المؤهلين والمحترفين الذين يتولون تقديم خدمات الجائزة المتسقة مع تعاملاتك مع موقعنا.\r\n \r\n\r\nانتقال آمن للمعلومات\r\nهذا الموقع يمتلك إجراءات أمن لحماية المعلومات التي تقدمها لنا، فإننا نعمل على تشفير المعلومات التي تعتبر حساسة (مثل بياناتك الشخصية) أو البيانات التي يتعين الحفاظ على سريتها تماشياً مع المتطلبات القانونية.\r\n\r\n\r\nالمرجعية القانونية للجائزة\r\n\r\nيحق لجائزة الشارقة للتفوق والتميز التربوي اتخاذ التدابير التي يراها ملائمة لحماية أي فقدان أو إساءة استخدام أو تغيير للمعلومات الموجودة على الموقع الإلكتروني، وذلك دون أن تضمن الجائزة في هذه الحالة الاحتفاظ بسرية محتويات هذا الموقع الإلكتروني، ولا يعتبر مسؤولاً قانوناً عن أي ضرر قد تتعرض له أنت أو أي شخص نتيجة لانتهاك السرية بشأن المعلومات التي تكون قد نقلتها إلى الموقع.\r\nتكون قوانين دولة الإمارات العربية المتحدة وحدها هي القوانين واجبة التطبيق في كل ما يتعلق بالنزاعات التي قد تنشأ من جراء استخدام هذا الموقع الإلكتروني، أو أياً من أجزائه وأقسامه، كما تختص محاكم إمارة الشارقة حصرياً بالنظر في تلك النزاعات والبت فيها.", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8942), null, null, "This site is affiliated with the Sharjah Award for Excellence and Educational Excellence, and like other sites affiliated with the award, it is committed to protecting the rights of all visitors to this site. That is, we are committed to maintaining the confidentiality of sensitive information. We have prepared this announcement of the privacy policy to disclose the approach we follow in collecting and publishing information on this site. website.\r\n\r\nThe privacy policy shown on this page is considered part of the terms and conditions of use of the website.\r\n\r\n\r\nCollection and use of electronic information\r\n\r\nOur servers automatically capture and collect your Internet Protocol address when you visit the site. Your Internet Protocol address is the number for the computer, tablet, or smartphone that you use, which allows other devices connected to the Internet to determine the destination of the data issued by it. But without getting to know you personally.\r\nOur use of your Internet Protocol helps us diagnose problems that may occur in our server, and to conduct the necessary statistics to measure the use of the site, and we do not allow any party outside the framework of the technical team assigned by the award to view your Internet Protocol.\r\nIn order to provide better service and a more effective website, some sections of this site may use cookies as part of the interaction with your browser. This program is a small text file sent to your hard disk so that our server can recognize your device and browser. which you use to improve your interaction with our site.\r\nThe cookie software sent by us will not attempt to read any of the private information on your hard drive, and we do not collect this information through this software to find out other personal data or information in order to determine your identity or email address.\r\nIf your visit to the site is to obtain a specific service or information, when you visit some parts of this site, you may be asked to provide personal information to identify yourself (such as name, phone number, address,...), which are all necessary information to complete your transaction, but this The information will not be shared or misused under any circumstances, and if you refuse to provide that information, the award has the right to refuse to provide that service. In any case, we still invite you to visit our website and benefit from the valuable information it provides.\r\n \r\n\r\nProtection of personal information\r\n\r\nBy using this website, you agree to the terms of this privacy policy, as the award, through its management of its website, is committed to collecting personal information about you when you visit the site, to use that information that you provided, only in order to fulfill your request for information or services through the site.\r\nThe Sharjah Award for Excellence and Educational Excellence reserves the right to make any minor or radical amendment to the terms of the privacy policy from time to time without the need to provide notification. This policy is amended and these amendments are published as soon as they are approved. Therefore, we advise you to check this page from time to time to find out the updates that have occurred. On the Privacy Policy, therefore, your visit and use of our site after making amendments to this Privacy Policy means that you accept these changes.\r\nYour personal information will only be available to award employees who need to see that information, and that information will not be available for public access without your consent. Furthermore, none of that information will be exchanged, traded, or sold to any other party without your consent. Access to the information will only be granted to those qualified and professional people who provide award services consistent with your dealings with our website.\r\n \r\n\r\nSecure transmission of information\r\nThis site has security measures in place to protect the information you provide to us. We encrypt information that is considered sensitive (such as your personal data) or data that must be kept confidential in line with legal requirements.\r\n\r\n\r\nLegal reference for the award\r\n\r\nThe Sharjah Award for Educational Excellence and Excellence has the right to take the measures it deems appropriate to protect any loss, misuse, or change of information on the website, without the award in this case guaranteeing the confidentiality of the contents of this website, and it is not considered legally responsible for any damage you may be exposed to. You or any person as a result of a breach of confidentiality regarding information you have transmitted to the Site.\r\nThe laws of the United Arab Emirates alone are the applicable laws in all matters related to disputes that may arise as a result of the use of this website, or any of its parts and sections, and the courts of the Emirate of Sharjah have exclusive jurisdiction to consider and decide on these disputes.", null, null, "Privacy_Policy_Website", 0, false },
                    { 2, "إن هذا الموقع تابع لجائزة الشارقة للتفوق والتميز التربوي وكغيره من المواقع التابعة للجائزة، ملتزمٌ بحماية حقوق جميع زوار هذا الموقع، أي إننا نلتزم بالحفاظ على سرية المعلومات الحساسة، وقد أعددنا هذا الإعلان الخاص بسياسة الخصوصية للإفصاح عن النهج الذي نتبعه في جمع ونشر المعلومات على هذا الموقع الإلكتروني.\r\n\r\nتعتبر سياسة الخصوصية الموضحة في هذه الصفحة، جزءاً من شروط استخدام الموقع الإلكتروني وأحكامه.\r\n\r\n\r\nجمع واستخدام المعلومات الإلكترونية\r\n\r\nتعمل الخوادم الخاصة بنا تلقائياً على التقاط وجمع عنوان بروتوكول الإنترنت الخاص بك عند زيارتك للموقع، إن عنوان بروتوكول الإنترنت الخاص بك هو الرقم الخاص بجهاز الكمبيوتر أو الجهاز اللوحي أو الهاتف الذكي الذي تستخدمه، والذي يسمح للأجهزة الأخرى الموصولة بشبكة الإنترنت بتحديد وجهة البيانات الصادرة عنها، لكن من دون التعرف عليك شخصياً.\r\nإن استخدامنا لبروتوكول الإنترنت الخاص بك يساعدنا على تشخيص المشكلات التي قد تحدث في الخادم الخاص بنا، وعلى إجراء الإحصاء اللازم لقياس استخدام الموقع، ونحن لا نسمح لأي جهة خارج إطار الفريق الفني المكلف من الجائزة بالاطلاع على بروتوكول الإنترنت الخاص بك.\r\nمن أجل تقديم خدمة أفضل، وموقع إلكتروني أكثر فاعلية، يمكن لبعض أقسام هذا الموقع استخدام برامج تعريف الارتباط (cookies) كجزء من التفاعل مع متصفحك، وهذا البرنامج هو عبارة عن ملف نصي صغير يرسل إلى القرص الصلب الخاص بك ليتمكن خادمنا من التعرف على الجهاز والمتصفح الذي تستخدمه لتحسين تعاملك مع موقعنا.\r\nلن يقوم برنامج تعريف الارتباط المرسل من قبلنا بمحاولة قراءة أي من المعلومات الخاصة الموجودة على قرصك الصلب، ونحن لا نقوم بتجميع هذه المعلومات من خلال هذا البرامج لمعرفة بيانات أو معلومات شخصية أخرى من أجل تحديد هويتك أو عنوان بريدك الإلكتروني.\r\nفي حال كانت زيارتك للموقع للحصول على خدمة أو معلومات محددة، فقد يطلب منك عند زيارتك لبعض أجزاء هذا الموقع، تقديم معلومات شخصية للتعريف بهويتك (مثل الاسم، رقم الهاتف، والعنوان،...)، وهي كلها معلومات ضرورية لإتمام معاملتك غير أن هذه المعلومات لن يتم مشاركتها أو إساءة استخدامها تحت أي ظرف، وفي حال رفضك تقديم تلك المعلومات، فللجائزة الحق في رفض تقديم تلك الخدمة، وفي كل الأحوال، فإننا لانزل ندعوك لزيارة موقعنا والاستفادة من المعلومات القيمة التي يوفرها.\r\n \r\n\r\nحماية المعلومات الشخصية\r\n\r\nباستخدامك لهذا الموقع فإنك توافق على شروط سياسة الخصوصية هذه، حيث تلتزم الجائزة من خلال إدارته لموقعه الإلكتروني، عند جمع معلومات شخصية عنك عندما تقوم بزيارة الموقع بأن يكون استخدام تلك المعلومات التي قدمتها، فقط من أجل إنجاز طلبك للحصول على معلومات أو خدمات عبر الموقع.\r\nيحتفظ جائزة الشارقة للتفوق والتميز التربوي بالحق في إجراء أي تعديل طفيف أو جذري لشروط سياسة الخصوصية من وقت لآخر دون الحاجة إلى تقديم إخطار، حيث يتم تعديل هذه السياسة ونشر هذه التعديلات بمجرد اعتمادها، لذا ننصحك بالاطلاع على هذه الصفحة من وقت لأخر لمعرفة التحديثات التي طرأت على سياسة الخصوصية، ولذلك فإن زيارتك واستخدامك لموقعنا بعد إدخال التعديلات على سياسة الخصوصية هذه، يعني قبولك لهذه التغييرات.\r\nلن تكون معلوماتك الشخصية متاحة إلا لموظفي الجائزة الذين يحتاجون للاطلاع على تلك المعلومات، ولن تكون تلك المعلومات متاحة لاطلاع الجمهور عليها بدون موافقتك على ذلك، وعلاوة على ذلك، لن يتم تبادل، أو تداول أي من تلك المعلومات أو بيعها لأي طرف آخر من دون موافقتك المسبقة، ولن يتم السماح بالوصول إلى المعلومات إلا لأولئك المؤهلين والمحترفين الذين يتولون تقديم خدمات الجائزة المتسقة مع تعاملاتك مع موقعنا.\r\n \r\n\r\nانتقال آمن للمعلومات\r\nهذا الموقع يمتلك إجراءات أمن لحماية المعلومات التي تقدمها لنا، فإننا نعمل على تشفير المعلومات التي تعتبر حساسة (مثل بياناتك الشخصية) أو البيانات التي يتعين الحفاظ على سريتها تماشياً مع المتطلبات القانونية.\r\n\r\n\r\nالمرجعية القانونية للجائزة\r\n\r\nيحق لجائزة الشارقة للتفوق والتميز التربوي اتخاذ التدابير التي يراها ملائمة لحماية أي فقدان أو إساءة استخدام أو تغيير للمعلومات الموجودة على الموقع الإلكتروني، وذلك دون أن تضمن الجائزة في هذه الحالة الاحتفاظ بسرية محتويات هذا الموقع الإلكتروني، ولا يعتبر مسؤولاً قانوناً عن أي ضرر قد تتعرض له أنت أو أي شخص نتيجة لانتهاك السرية بشأن المعلومات التي تكون قد نقلتها إلى الموقع.\r\nتكون قوانين دولة الإمارات العربية المتحدة وحدها هي القوانين واجبة التطبيق في كل ما يتعلق بالنزاعات التي قد تنشأ من جراء استخدام هذا الموقع الإلكتروني، أو أياً من أجزائه وأقسامه، كما تختص محاكم إمارة الشارقة حصرياً بالنظر في تلك النزاعات والبت فيها.", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8948), null, null, "This site is affiliated with the Sharjah Award for Excellence and Educational Excellence, and like other sites affiliated with the award, it is committed to protecting the rights of all visitors to this site. That is, we are committed to maintaining the confidentiality of sensitive information. We have prepared this announcement of the privacy policy to disclose the approach we follow in collecting and publishing information on this site. website.\r\n\r\nThe privacy policy shown on this page is considered part of the terms and conditions of use of the website.\r\n\r\n\r\nCollection and use of electronic information\r\n\r\nOur servers automatically capture and collect your Internet Protocol address when you visit the site. Your Internet Protocol address is the number for the computer, tablet, or smartphone that you use, which allows other devices connected to the Internet to determine the destination of the data issued by it. But without getting to know you personally.\r\nOur use of your Internet Protocol helps us diagnose problems that may occur in our server, and to conduct the necessary statistics to measure the use of the site, and we do not allow any party outside the framework of the technical team assigned by the award to view your Internet Protocol.\r\nIn order to provide better service and a more effective website, some sections of this site may use cookies as part of the interaction with your browser. This program is a small text file sent to your hard disk so that our server can recognize your device and browser. which you use to improve your interaction with our site.\r\nThe cookie software sent by us will not attempt to read any of the private information on your hard drive, and we do not collect this information through this software to find out other personal data or information in order to determine your identity or email address.\r\nIf your visit to the site is to obtain a specific service or information, when you visit some parts of this site, you may be asked to provide personal information to identify yourself (such as name, phone number, address,...), which are all necessary information to complete your transaction, but this The information will not be shared or misused under any circumstances, and if you refuse to provide that information, the award has the right to refuse to provide that service. In any case, we still invite you to visit our website and benefit from the valuable information it provides.\r\n \r\n\r\nProtection of personal information\r\n\r\nBy using this website, you agree to the terms of this privacy policy, as the award, through its management of its website, is committed to collecting personal information about you when you visit the site, to use that information that you provided, only in order to fulfill your request for information or services through the site.\r\nThe Sharjah Award for Excellence and Educational Excellence reserves the right to make any minor or radical amendment to the terms of the privacy policy from time to time without the need to provide notification. This policy is amended and these amendments are published as soon as they are approved. Therefore, we advise you to check this page from time to time to find out the updates that have occurred. On the Privacy Policy, therefore, your visit and use of our site after making amendments to this Privacy Policy means that you accept these changes.\r\nYour personal information will only be available to award employees who need to see that information, and that information will not be available for public access without your consent. Furthermore, none of that information will be exchanged, traded, or sold to any other party without your consent. Access to the information will only be granted to those qualified and professional people who provide award services consistent with your dealings with our website.\r\n \r\n\r\nSecure transmission of information\r\nThis site has security measures in place to protect the information you provide to us. We encrypt information that is considered sensitive (such as your personal data) or data that must be kept confidential in line with legal requirements.\r\n\r\n\r\nLegal reference for the award\r\n\r\nThe Sharjah Award for Educational Excellence and Excellence has the right to take the measures it deems appropriate to protect any loss, misuse, or change of information on the website, without the award in this case guaranteeing the confidentiality of the contents of this website, and it is not considered legally responsible for any damage you may be exposed to. You or any person as a result of a breach of confidentiality regarding information you have transmitted to the Site.\r\nThe laws of the United Arab Emirates alone are the applicable laws in all matters related to disputes that may arise as a result of the use of this website, or any of its parts and sections, and the courts of the Emirate of Sharjah have exclusive jurisdiction to consider and decide on these disputes.", null, null, "Privacy_Policy_Subscriber", 0, false },
                    { 3, "إن دخولك واستخدامك الموقع الإلكتروني لجائزة الشارقة للتفوق والتميز التربوي يخضع للشروط والأحكام الآتية، إضافة إلى قوانين دولة الإمارات العربية المتحدة المتعلقة بالتعامل مع المواقع والمنصات الإلكترونية.\r\nدخولك إلى الموقع يعني موافقتك على هذه الشروط والأحكام، سواءً كنت مستخدماً مسجلاً أو غيرمسجل. وبدخولك وتصفحك واستخدامك الموقع تكون قد قبلت دون قيد أو شرط، أحكام وشروط الاستخدام الواردة في هذه الوثيقة.\r\n\r\n \r\n\r\nتعريفات:\r\n\r\nالدولة: دولة الامارات العربية المتحدة.\r\nالجائزة: جائزة الشارقة للتفوق والتميز التربوي.\r\nالموقع: موقع جائزة الشارقة للتفوق والتميز التربوي على الشبكة العنكبوتية (الانترنت).\r\nالقانون: هي أي أو كل قانون تصدره وتقره دولة الامارات العربية المتحدة التي يتعلق بالتعامل مع تقنية المعلومات، والجرائم المتعلقة بها.\r\n \r\n\r\nتعديل الاتفاقية\r\nللجائزة الحق في تعديل هذه الشروط والأحكام على أن يتم وضع إشعار بحدوث تعديلات على هذه الصفحة، وتدخل التعديلات حيز النفاذ بمجرد إعلانها ما لم ينَصّ على خلاف ذلك.\r\nإن استخدامك المتكرر للموقع بعد إحداث تلك التعديلات يعني موافقتك على التعديلات، ويتعين عليك القيام بزيارات دورية لهذه الصفحة لمراجعة الشروط والأحكام المستحدثة أو المعدلة.\r\n\r\n \r\n\r\nالتصرف\r\nإن دخولك واستخدامك للموقع يعتبر موافقة وإقرار منك على دخول واستخدام الموقع لأغراض مشروعة فقط، وأنت مسؤول مسؤولية كاملة عن العلم والعمل بأي من وكل القوانين والأنظمة والقواعد والأحكام المتعلقة باستخدامك له، وبمجرد دخولك إلى الموقع فإنك توافق على الامتناع عن ما يلي:\r\n\r\nإدخال أو نشر أي محتويات غير قانونية تتضمن تمييزاً أو تشهيراً أو إساءة أو قذفاً أو مواد غير لائقة.\r\nاستخدام الموقع من أجل انتحال شخصيات أو أطراف أخرى.\r\nاستخدام الموقع من أجل ارتكاب جرم أو تشجيع الآخرين على التورط في أي تصرف قد يعد جريمة أو ينطوي على مسؤولية مدنية.\r\nالإساءة للآخرين أفراداً أو مؤسسات بأي شكل من الإساءة.\r\nالتحزب أو العنصرية ضد الآخرين أو الإساءة إلى أي عرق أو دين أو لون أو جنسية أو وضع اجتماعي.\r\nاستخدام الموقع لتحميل أي مادة فيها برامج تحتوي على فيروسات، أو برامج خبيثة، أو أي شفرات حاسوبية أو ملفات أو برامج قد تعمل على تغيير أو إتلاف أو إعاقة عمل الموقع أو أي جهاز أو برنامج عائد إلى أي شخص يدخل إلى الموقع.\r\nإدخال أو إرسال أو تحميل أو بث أي مواد لا يحق لك بثها أو نشرها بموجب أي قانون أو علاقة تعاقدية.\r\nتغيير أو إتلاف أو شطب أو تعطيل أي محتوى على الموقع.\r\nإتلاف أو تعطيل أي من خطوط أو قنوات أو وسائل الاتصال أو التواصل الاعتيادية أو الإلكترونية بأي شكل كان.\r\nالادعاء بتمثيل أي شركة أو جمعية أو هيئة أو مؤسسة عامة أو خاصة أو الادعاء بأنك مرتبط بها، وذلك دون أن تكون مخولاً بادعاء تلك العلاقة أو ذلك التمثيل.\r\nنشر أو بث أي إعلان أو مادة دعائية أو تسويقية لأي منتج أو خدمة بأي شكل من أشكال الترويج أو التسويق.\r\nنشر أي مادة تتنافى أو تتعارض مع حقوق الملكية الفكرية للآخرين، أو جمع أو تخزين المعلومات الشخصية عن الآخرين.\r\n \r\n\r\nالتسجيل\r\nبعض أجزاء وخدمات الموقع لا تعمل ولا يمكن الوصول اليها إلا للأعضاء المسجلين و/ أو تتيح للمستخدم طلب الدعم أو الخدمات إلكترونياً عبر إدخال بعض المعلومات الشخصية، لذا ، فأنت توافق على أن أي معلومات تقدم لنا عبر تلك الأجزاء هي معلومات صحيحة وكاملة ودقيقة، وأنك لن تقوم بالتسجيل، أو تحاول دخول الموقع مستخدماً أو منتحلا اسم أو صفة شخص آخر، وأنك لم تدعي بامتلاكك اسم مستخدم أو بيانات مستخدم ليست لك، أو قد ترى الجائزة أنه (وفق حقه في حرية التصرف)، بأنه غير مناسب.\r\n\r\n \r\n\r\nإنهاء الاستخدام\r\nللجائزة كل الحق، وفق ما يراه مناسباً، منع أو إنهاء أو تعليق دخولك إلى واستخدامك لهذا الموقع من دون إشعار ولأي سبب كان، بما في ذلك انتهاك هذه الشروط والأحكام أو بسبب أي تصرف قد يرى للجائزة أنه مخالف للقانون أو مضر بالآخرين، وفي هذه الحالات لن يعود بإمكانك الدخول إلى الموقع، وللجائزة الحق في استخدام كل وسيلة متاحة لتطبيق هذا الأمر.\r\n\r\n\r\nوصلات المواقع الأخرى\r\nبعض الوصلات على الموقع تقود إلى مواقع إلكترونية أخرى لا يتم تشغيلها من قبل الجائزة، وليس له السيطرة عليها. كما أن الجائزة لا يقوم بمراجعة المحتوى الخاص بتلك المواقع أو التحكم بها، حيث إن الجائزة يوفر تلك الوصلات من باب التسهيل على مستخدمي وزوار موقعه، كما أن تلك المواقع الأخرى ليست لها أي مضامين ترويجية أو تسويقية خاصة بالسلع أو خدمات خاصة، إنما هي وصلات لمواقع ذات صلة بعمل الجائزة و / أو تقدم خدمات تتعلق بعمل الجائزة لخدمة زوار ومستخدمي الموقع، وعند الضغط على واختيارك وصلة خاصة بموقع خارجي، فإنك تكون خاضعاً للشروط والأحكام الخاصة بذلك الموقع الخارجي.\r\n\r\n \r\n\r\nالمحتوى\r\nتحتفظ الجائزة بالحق في مراقبة أي محتوى يتم إدخاله من قبلك، غير أنه ليس ملزماً بذلك، ومع أن الجائزة قد لا يستطيع مراقبة كل ما يتم إدخاله على الموقع، فإننا نحتفظ بالحق (من دون التزام) في شطب أو إزالة أو تحرير أي مواد مدخلة من شأنها انتهاك هذه الشروط والأحكام، إن قوانين حقوق النشر والتأليف الإماراتية والأجنبية والمعاهدات الدولية تحمي محتويات هذا الموقع، وأنت توافق على الالتزام بإشعارات حقوق النشر التي تظهر على هذا الموقع.\r\n\r\n \r\n\r\nالتعويض\r\nأنت توافق على الدفاع عن، وتأمين، والحفاظ على سلامة موقع الجائزة، وكل موظفيه ووكلائه تجاه أي وكل مسؤولية قد تترتب على أي مطالبة ناجمة عن أي خرق من قبلك لهذه الشروط والأحكام، بما في ذلك التكاليف والرسوم المقررة لهيئة الدفاع أو المحامين، كما أنك توافق على التعاون الكامل في الدفاع ضد تلك المطالبات، وللجائزة الحق في أن يتولى على حسابه الخاص، الدفاع الحصري والتحكم في أي مسألة خاضعة، بخلاف ذلك، للتعويض من قبلك، وأنت توافق على عدم تسوية أي قضية إلا بموافقة خطية من قبل الجائزة.\r\n\r\nتعتبر سياسة الخصوصية الموضحة في هذه الصفحة، جزءاً من شروط استخدام الموقع الإلكتروني وأحكامه.\r\n\r\n\r\nجمع واستخدام المعلومات الإلكترونية\r\n\r\nتعمل الخوادم الخاصة بنا تلقائياً على التقاط وجمع عنوان بروتوكول الإنترنت الخاص بك عند زيارتك للموقع، إن عنوان بروتوكول الإنترنت الخاص بك هو الرقم الخاص بجهاز الكمبيوتر أو الجهاز اللوحي أو الهاتف الذكي الذي تستخدمه، والذي يسمح للأجهزة الأخرى الموصولة بشبكة الإنترنت بتحديد وجهة البيانات الصادرة عنها، لكن من دون التعرف عليك شخصياً.\r\nإن استخدامنا لبروتوكول الإنترنت الخاص بك يساعدنا على تشخيص المشكلات التي قد تحدث في الخادم الخاص بنا، وعلى إجراء الإحصاء اللازم لقياس استخدام الموقع، ونحن لا نسمح لأي جهة خارج إطار الفريق الفني المكلف من الجائزة بالاطلاع على بروتوكول الإنترنت الخاص بك.\r\nمن أجل تقديم خدمة أفضل، وموقع إلكتروني أكثر فاعلية، يمكن لبعض أقسام هذا الموقع استخدام برامج تعريف الارتباط (cookies) كجزء من التفاعل مع متصفحك، وهذا البرنامج هو عبارة عن ملف نصي صغير يرسل إلى القرص الصلب الخاص بك ليتمكن خادمنا من التعرف على الجهاز والمتصفح الذي تستخدمه لتحسين تعاملك مع موقعنا.\r\nلن يقوم برنامج تعريف الارتباط المرسل من قبلنا بمحاولة قراءة أي من المعلومات الخاصة الموجودة على قرصك الصلب، ونحن لا نقوم بتجميع هذه المعلومات من خلال هذا البرامج لمعرفة بيانات أو معلومات شخصية أخرى من أجل تحديد هويتك أو عنوان بريدك الإلكتروني.\r\nفي حال كانت زيارتك للموقع للحصول على خدمة أو معلومات محددة، فقد يطلب منك عند زيارتك لبعض أجزاء هذا الموقع، تقديم معلومات شخصية للتعريف بهويتك (مثل الاسم، رقم الهاتف، والعنوان،...)، وهي كلها معلومات ضرورية لإتمام معاملتك غير أن هذه المعلومات لن يتم مشاركتها أو إساءة استخدامها تحت أي ظرف، وفي حال رفضك تقديم تلك المعلومات، فللجائزة الحق في رفض تقديم تلك الخدمة، وفي كل الأحوال، فإننا لانزل ندعوك لزيارة موقعنا والاستفادة من المعلومات القيمة التي يوفرها.\r\n \r\n\r\nحماية المعلومات الشخصية\r\n\r\nباستخدامك لهذا الموقع فإنك توافق على شروط سياسة الخصوصية هذه، حيث تلتزم الجائزة من خلال إدارته لموقعه الإلكتروني، عند جمع معلومات شخصية عنك عندما تقوم بزيارة الموقع بأن يكون استخدام تلك المعلومات التي قدمتها، فقط من أجل إنجاز طلبك للحصول على معلومات أو خدمات عبر الموقع.\r\nتحتفظ جائزة الشارقة للتفوق والتميز التربوي بالحق في إجراء أي تعديل طفيف أو جذري لشروط سياسة الخصوصية من وقت لآخر دون الحاجة إلى تقديم إخطار، حيث يتم تعديل هذه السياسة ونشر هذه التعديلات بمجرد اعتمادها، لذا ننصحك بالاطلاع على هذه الصفحة من وقت لأخر لمعرفة التحديثات التي طرأت على سياسة الخصوصية، ولذلك فإن زيارتك واستخدامك لموقعنا بعد إدخال التعديلات على سياسة الخصوصية هذه، يعني قبولك لهذه التغييرات.\r\nلن تكون معلوماتك الشخصية متاحة إلا لموظفي الجائزة الذين يحتاجون للاطلاع على تلك المعلومات، ولن تكون تلك المعلومات متاحة لاطلاع الجمهور عليها بدون موافقتك على ذلك، وعلاوة على ذلك، لن يتم تبادل، أو تداول أي من تلك المعلومات أو بيعها لأي طرف آخر من دون موافقتك المسبقة، ولن يتم السماح بالوصول إلى المعلومات إلا لأولئك المؤهلين والمحترفين الذين يتولون تقديم خدمات الجائزة المتسقة مع تعاملاتك مع موقعنا.\r\n \r\n\r\nانتقال آمن للمعلومات\r\nهذا الموقع يمتلك إجراءات أمن لحماية المعلومات التي تقدمها لنا، فإننا نعمل على تشفير المعلومات التي تعتبر حساسة (مثل بياناتك الشخصية) أو البيانات التي يتعين الحفاظ على سريتها تماشياً مع المتطلبات القانونية.\r\n\r\n\r\nالمرجعية القانونية للجائزة\r\n\r\nيحق لجائزة الشارقة للتفوق والتميز التربوي اتخاذ التدابير التي يراها ملائمة لحماية أي فقدان أو إساءة استخدام أو تغيير للمعلومات الموجودة على الموقع الإلكتروني، وذلك دون أن تضمن الجائزة في هذه الحالة الاحتفاظ بسرية محتويات هذا الموقع الإلكتروني، ولا يعتبر مسؤولاً قانوناً عن أي ضرر قد تتعرض له أنت أو أي شخص نتيجة لانتهاك السرية بشأن المعلومات التي تكون قد نقلتها إلى الموقع.\r\nتكون قوانين دولة الإمارات العربية المتحدة وحدها هي القوانين واجبة التطبيق في كل ما يتعلق بالنزاعات التي قد تنشأ من جراء استخدام هذا الموقع الإلكتروني، أو أياً من أجزائه وأقسامه، كما تختص محاكم إمارة الشارقة حصرياً بالنظر في تلك النزاعات والبت فيها.", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8952), null, null, "Your entry and use of the Sharjah Award for Excellence and Educational Excellence website is subject to the following terms and conditions, in addition to the laws of the United Arab Emirates related to dealing with websites and electronic platforms.\r\nYour access to the site means your acceptance of these terms and conditions, whether you are a registered user or not. By entering, browsing, and using the site, you have accepted, without restriction or condition, the terms and conditions of use contained in this document.\r\n\r\n \r\n\r\nDefinitions:\r\n\r\nCountry: United Arab Emirates.\r\nAward: Sharjah Award for Excellence and Educational Excellence.\r\nWebsite: The Sharjah Award for Excellence and Educational Excellence website on the Internet.\r\nLaw: Any or all laws issued and approved by the United Arab Emirates that relate to dealing with information technology and crimes related to it.\r\n \r\n\r\nAmending the agreement\r\nThe Award has the right to amend these terms and conditions, provided that notice of amendments is placed on this page. Amendments will enter into force as soon as they are announced, unless otherwise stated.\r\nYour repeated use of the site after these modifications are made means that you agree to the modifications, and you must make periodic visits to this page to review the updated or amended terms and conditions.\r\n\r\n \r\n\r\nAct\r\nYour entry and use of the site constitutes your agreement and acknowledgment to enter and use the site for lawful purposes only, and you are fully responsible for knowing and acting on any and all laws, regulations, rules and provisions related to your use of it. Once you enter the site, you agree to refrain from the following:\r\n\r\nEnter or publish any illegal content that includes discrimination, defamation, abuse, slander, or inappropriate material.\r\nUse the Site to impersonate other individuals or parties.\r\nUse the Site in order to commit an offense or encourage others to engage in any conduct that may constitute a criminal offense or give rise to civil liability.\r\nInsulting others, individuals or institutions, in any way.\r\nPartisanship or racism against others or insulting any race, religion, color, nationality or social status.\r\nUse the site to upload any material that contains programs that contain viruses, malicious programs, or any computer codes, files or programs that may alter, damage or impede the operation of the site or any device or program belonging to any person who accesses the site.\r\nInput, send, upload or broadcast any material that you do not have the right to broadcast or publish under any law or contractual relationship.\r\nAlter, damage, delete or disable any content on the Site.\r\nDamaging or disrupting any regular or electronic lines, channels, or means of communication or communication in any way.\r\nClaiming to represent any company, association, body, or public or private institution, or claiming to be connected to it, without being authorized to claim that relationship or that representation.\r\nPublish or broadcast any advertisement, promotional or marketing material for any product or service in any form of promotion or marketing.\r\nPost any material that infringes or conflicts with the intellectual property rights of others, or collect or store personal information about others.\r\n \r\n\r\nRegister\r\nSome parts and services of the site do not work and can only be accessed by registered members and/or allow the user to request support or services electronically by entering some personal information. Therefore, you agree that any information provided to us through those parts is true, complete and accurate information, and that you will not You register, or attempt to enter the site using or impersonating the name or capacity of another person, and that you do not claim to have a user name or user data that is not yours, or that the Award may find (according to its right to discretion) to be inappropriate.\r\n\r\n \r\n\r\nTermination of use\r\nThe Award has every right, as it deems appropriate, to prevent, terminate or suspend your access to and use of this site without notice and for any reason whatsoever, including violation of these terms and conditions or due to any behavior that the Award may deem to be contrary to the law or harmful to others, and in these cases You will no longer be able to access the site, and the award has the right to use every means available to implement this matter.\r\n\r\nLinks to other websites\r\nSome links on the site lead to other websites that are not operated by the Award, and it has no control over them. The Award also does not review or control the content of those sites, as the Award provides these links as a matter of convenience for the users and visitors of its site, and those other sites do not have any promotional or marketing content for goods or special services, but rather they are links to sites Related to the work of the award and/or providing services related to the work of the award to serve visitors and users of the site, and when you click on and choose a link to an external site, you are subject to the terms and conditions of that external site.\r\n\r\n \r\n\r\nContent\r\nThe Award reserves the right to monitor any content entered by you, but is not obligated to do so. Although the Award may not be able to monitor everything that is entered on the site, we reserve the right (but not the obligation) to delete, remove or edit any materials entered from the site. If you violate these terms and conditions, UAE and foreign copyright laws and international treaties protect the contents of this site, and you agree to abide by the copyright notices that appear on this site.\r\n\r\n \r\n\r\nCompensation\r\nYou agree to defend, insure, and maintain the integrity of the award website, and all its employees and agents against any and all liability that may arise from any claim resulting from any breach by you of these terms and conditions, including the costs and fees determined for the defense or lawyers, and you also agree You will cooperate fully in defending against such claims, and the Award has the right to assume, at its own expense, the exclusive defense and control of any matter otherwise subject to indemnification by you, and you agree not to settle any matter except with the written approval of the Award.\r\n\r\nThe privacy policy shown on this page is considered part of the terms and conditions of use of the website.\r\n\r\n\r\nCollection and use of electronic information\r\n\r\nOur servers automatically capture and collect your Internet Protocol address when you visit the site. Your Internet Protocol address is the number for the computer, tablet, or smartphone that you use, which allows other devices connected to the Internet to determine the destination of the data issued by it. But without getting to know you personally.\r\nOur use of your Internet Protocol helps us diagnose problems that may occur in our server, and to conduct the necessary statistics to measure the use of the site, and we do not allow any party outside the framework of the technical team assigned by the award to view your Internet Protocol.\r\nIn order to provide better service and a more effective website, some sections of this site may use cookies as part of the interaction with your browser. This program is a small text file sent to your hard disk so that our server can recognize your device and browser. which you use to improve your interaction with our site.\r\nThe cookie software sent by us will not attempt to read any of the private information on your hard drive, and we do not collect this information through this software to find out other personal data or information in order to determine your identity or email address.\r\nIf your visit to the site is to obtain a specific service or information, when you visit some parts of this site, you may be asked to provide personal information to identify yourself (such as name, phone number, address,...), which are all necessary information to complete your transaction, but this The information will not be shared or misused under any circumstances, and if you refuse to provide that information, the award has the right to refuse to provide that service. In any case, we still invite you to visit our website and benefit from the valuable information it provides.\r\n\r\n\r\nProtection of personal information\r\n\r\nBy using this website, you agree to the terms of this privacy policy, as the award, through its management of its website, is committed to collecting personal information about you when you visit the site, to use that information that you provided, only in order to fulfill your request for information or services through the site.\r\nThe Sharjah Award for Excellence and Educational Excellence reserves the right to make any minor or radical amendment to the terms of the privacy policy from time to time without the need to provide notification. This policy is amended and these amendments are published as soon as they are approved. Therefore, we advise you to check this page from time to time to find out the updates that have occurred. on the Privacy Policy. Therefore, your visit and use of our site after making changes to this Privacy Policy means that you accept these changes.\r\nYour personal information will only be available to award employees who need to see that information, and that information will not be available for public access without your consent. Moreover, none of that information will be exchanged, traded, or sold to any other party without your consent. Access to the information will only be granted to those qualified and professional people who provide award services consistent with your dealings with our website.\r\n \r\n\r\nSecure transmission of information\r\nThis site has security measures in place to protect the information you provide to us. We encrypt information that is considered sensitive (such as your personal data) or data that must be kept confidential in line with legal requirements.\r\n\r\n\r\nLegal reference for the award\r\n\r\nThe Sharjah Award for Educational Excellence and Excellence has the right to take the measures it deems appropriate to protect any loss, misuse, or change of information on the website, without the award in this case guaranteeing the confidentiality of the contents of this website, and it is not considered legally responsible for any damage you may be exposed to. You or any person as a result of a breach of confidentiality regarding information you have transmitted to the Site.\r\nThe laws of the United Arab Emirates alone are the applicable laws in all matters related to disputes that may arise as a result of the use of this website, or any of its parts and sections, and the courts of the Emirate of Sharjah have exclusive jurisdiction to consider and decide on these disputes.", null, null, "Terms_Of_Use_Website", 1, false },
                    { 4, "إن دخولك واستخدامك الموقع الإلكتروني لجائزة الشارقة للتفوق والتميز التربوي يخضع للشروط والأحكام الآتية، إضافة إلى قوانين دولة الإمارات العربية المتحدة المتعلقة بالتعامل مع المواقع والمنصات الإلكترونية.\r\nدخولك إلى الموقع يعني موافقتك على هذه الشروط والأحكام، سواءً كنت مستخدماً مسجلاً أو غيرمسجل. وبدخولك وتصفحك واستخدامك الموقع تكون قد قبلت دون قيد أو شرط، أحكام وشروط الاستخدام الواردة في هذه الوثيقة.\r\n\r\n \r\n\r\nتعريفات:\r\n\r\nالدولة: دولة الامارات العربية المتحدة.\r\nالجائزة: جائزة الشارقة للتفوق والتميز التربوي.\r\nالموقع: موقع جائزة الشارقة للتفوق والتميز التربوي على الشبكة العنكبوتية (الانترنت).\r\nالقانون: هي أي أو كل قانون تصدره وتقره دولة الامارات العربية المتحدة التي يتعلق بالتعامل مع تقنية المعلومات، والجرائم المتعلقة بها.\r\n \r\n\r\nتعديل الاتفاقية\r\nللجائزة الحق في تعديل هذه الشروط والأحكام على أن يتم وضع إشعار بحدوث تعديلات على هذه الصفحة، وتدخل التعديلات حيز النفاذ بمجرد إعلانها ما لم ينَصّ على خلاف ذلك.\r\nإن استخدامك المتكرر للموقع بعد إحداث تلك التعديلات يعني موافقتك على التعديلات، ويتعين عليك القيام بزيارات دورية لهذه الصفحة لمراجعة الشروط والأحكام المستحدثة أو المعدلة.\r\n\r\n \r\n\r\nالتصرف\r\nإن دخولك واستخدامك للموقع يعتبر موافقة وإقرار منك على دخول واستخدام الموقع لأغراض مشروعة فقط، وأنت مسؤول مسؤولية كاملة عن العلم والعمل بأي من وكل القوانين والأنظمة والقواعد والأحكام المتعلقة باستخدامك له، وبمجرد دخولك إلى الموقع فإنك توافق على الامتناع عن ما يلي:\r\n\r\nإدخال أو نشر أي محتويات غير قانونية تتضمن تمييزاً أو تشهيراً أو إساءة أو قذفاً أو مواد غير لائقة.\r\nاستخدام الموقع من أجل انتحال شخصيات أو أطراف أخرى.\r\nاستخدام الموقع من أجل ارتكاب جرم أو تشجيع الآخرين على التورط في أي تصرف قد يعد جريمة أو ينطوي على مسؤولية مدنية.\r\nالإساءة للآخرين أفراداً أو مؤسسات بأي شكل من الإساءة.\r\nالتحزب أو العنصرية ضد الآخرين أو الإساءة إلى أي عرق أو دين أو لون أو جنسية أو وضع اجتماعي.\r\nاستخدام الموقع لتحميل أي مادة فيها برامج تحتوي على فيروسات، أو برامج خبيثة، أو أي شفرات حاسوبية أو ملفات أو برامج قد تعمل على تغيير أو إتلاف أو إعاقة عمل الموقع أو أي جهاز أو برنامج عائد إلى أي شخص يدخل إلى الموقع.\r\nإدخال أو إرسال أو تحميل أو بث أي مواد لا يحق لك بثها أو نشرها بموجب أي قانون أو علاقة تعاقدية.\r\nتغيير أو إتلاف أو شطب أو تعطيل أي محتوى على الموقع.\r\nإتلاف أو تعطيل أي من خطوط أو قنوات أو وسائل الاتصال أو التواصل الاعتيادية أو الإلكترونية بأي شكل كان.\r\nالادعاء بتمثيل أي شركة أو جمعية أو هيئة أو مؤسسة عامة أو خاصة أو الادعاء بأنك مرتبط بها، وذلك دون أن تكون مخولاً بادعاء تلك العلاقة أو ذلك التمثيل.\r\nنشر أو بث أي إعلان أو مادة دعائية أو تسويقية لأي منتج أو خدمة بأي شكل من أشكال الترويج أو التسويق.\r\nنشر أي مادة تتنافى أو تتعارض مع حقوق الملكية الفكرية للآخرين، أو جمع أو تخزين المعلومات الشخصية عن الآخرين.\r\n \r\n\r\nالتسجيل\r\nبعض أجزاء وخدمات الموقع لا تعمل ولا يمكن الوصول اليها إلا للأعضاء المسجلين و/ أو تتيح للمستخدم طلب الدعم أو الخدمات إلكترونياً عبر إدخال بعض المعلومات الشخصية، لذا ، فأنت توافق على أن أي معلومات تقدم لنا عبر تلك الأجزاء هي معلومات صحيحة وكاملة ودقيقة، وأنك لن تقوم بالتسجيل، أو تحاول دخول الموقع مستخدماً أو منتحلا اسم أو صفة شخص آخر، وأنك لم تدعي بامتلاكك اسم مستخدم أو بيانات مستخدم ليست لك، أو قد ترى الجائزة أنه (وفق حقه في حرية التصرف)، بأنه غير مناسب.\r\n\r\n \r\n\r\nإنهاء الاستخدام\r\nللجائزة كل الحق، وفق ما يراه مناسباً، منع أو إنهاء أو تعليق دخولك إلى واستخدامك لهذا الموقع من دون إشعار ولأي سبب كان، بما في ذلك انتهاك هذه الشروط والأحكام أو بسبب أي تصرف قد يرى للجائزة أنه مخالف للقانون أو مضر بالآخرين، وفي هذه الحالات لن يعود بإمكانك الدخول إلى الموقع، وللجائزة الحق في استخدام كل وسيلة متاحة لتطبيق هذا الأمر.\r\n\r\n\r\nوصلات المواقع الأخرى\r\nبعض الوصلات على الموقع تقود إلى مواقع إلكترونية أخرى لا يتم تشغيلها من قبل الجائزة، وليس له السيطرة عليها. كما أن الجائزة لا يقوم بمراجعة المحتوى الخاص بتلك المواقع أو التحكم بها، حيث إن الجائزة يوفر تلك الوصلات من باب التسهيل على مستخدمي وزوار موقعه، كما أن تلك المواقع الأخرى ليست لها أي مضامين ترويجية أو تسويقية خاصة بالسلع أو خدمات خاصة، إنما هي وصلات لمواقع ذات صلة بعمل الجائزة و / أو تقدم خدمات تتعلق بعمل الجائزة لخدمة زوار ومستخدمي الموقع، وعند الضغط على واختيارك وصلة خاصة بموقع خارجي، فإنك تكون خاضعاً للشروط والأحكام الخاصة بذلك الموقع الخارجي.\r\n\r\n \r\n\r\nالمحتوى\r\nتحتفظ الجائزة بالحق في مراقبة أي محتوى يتم إدخاله من قبلك، غير أنه ليس ملزماً بذلك، ومع أن الجائزة قد لا يستطيع مراقبة كل ما يتم إدخاله على الموقع، فإننا نحتفظ بالحق (من دون التزام) في شطب أو إزالة أو تحرير أي مواد مدخلة من شأنها انتهاك هذه الشروط والأحكام، إن قوانين حقوق النشر والتأليف الإماراتية والأجنبية والمعاهدات الدولية تحمي محتويات هذا الموقع، وأنت توافق على الالتزام بإشعارات حقوق النشر التي تظهر على هذا الموقع.\r\n\r\n \r\n\r\nالتعويض\r\nأنت توافق على الدفاع عن، وتأمين، والحفاظ على سلامة موقع الجائزة، وكل موظفيه ووكلائه تجاه أي وكل مسؤولية قد تترتب على أي مطالبة ناجمة عن أي خرق من قبلك لهذه الشروط والأحكام، بما في ذلك التكاليف والرسوم المقررة لهيئة الدفاع أو المحامين، كما أنك توافق على التعاون الكامل في الدفاع ضد تلك المطالبات، وللجائزة الحق في أن يتولى على حسابه الخاص، الدفاع الحصري والتحكم في أي مسألة خاضعة، بخلاف ذلك، للتعويض من قبلك، وأنت توافق على عدم تسوية أي قضية إلا بموافقة خطية من قبل الجائزة.\r\n\r\nتعتبر سياسة الخصوصية الموضحة في هذه الصفحة، جزءاً من شروط استخدام الموقع الإلكتروني وأحكامه.\r\n\r\n\r\nجمع واستخدام المعلومات الإلكترونية\r\n\r\nتعمل الخوادم الخاصة بنا تلقائياً على التقاط وجمع عنوان بروتوكول الإنترنت الخاص بك عند زيارتك للموقع، إن عنوان بروتوكول الإنترنت الخاص بك هو الرقم الخاص بجهاز الكمبيوتر أو الجهاز اللوحي أو الهاتف الذكي الذي تستخدمه، والذي يسمح للأجهزة الأخرى الموصولة بشبكة الإنترنت بتحديد وجهة البيانات الصادرة عنها، لكن من دون التعرف عليك شخصياً.\r\nإن استخدامنا لبروتوكول الإنترنت الخاص بك يساعدنا على تشخيص المشكلات التي قد تحدث في الخادم الخاص بنا، وعلى إجراء الإحصاء اللازم لقياس استخدام الموقع، ونحن لا نسمح لأي جهة خارج إطار الفريق الفني المكلف من الجائزة بالاطلاع على بروتوكول الإنترنت الخاص بك.\r\nمن أجل تقديم خدمة أفضل، وموقع إلكتروني أكثر فاعلية، يمكن لبعض أقسام هذا الموقع استخدام برامج تعريف الارتباط (cookies) كجزء من التفاعل مع متصفحك، وهذا البرنامج هو عبارة عن ملف نصي صغير يرسل إلى القرص الصلب الخاص بك ليتمكن خادمنا من التعرف على الجهاز والمتصفح الذي تستخدمه لتحسين تعاملك مع موقعنا.\r\nلن يقوم برنامج تعريف الارتباط المرسل من قبلنا بمحاولة قراءة أي من المعلومات الخاصة الموجودة على قرصك الصلب، ونحن لا نقوم بتجميع هذه المعلومات من خلال هذا البرامج لمعرفة بيانات أو معلومات شخصية أخرى من أجل تحديد هويتك أو عنوان بريدك الإلكتروني.\r\nفي حال كانت زيارتك للموقع للحصول على خدمة أو معلومات محددة، فقد يطلب منك عند زيارتك لبعض أجزاء هذا الموقع، تقديم معلومات شخصية للتعريف بهويتك (مثل الاسم، رقم الهاتف، والعنوان،...)، وهي كلها معلومات ضرورية لإتمام معاملتك غير أن هذه المعلومات لن يتم مشاركتها أو إساءة استخدامها تحت أي ظرف، وفي حال رفضك تقديم تلك المعلومات، فللجائزة الحق في رفض تقديم تلك الخدمة، وفي كل الأحوال، فإننا لانزل ندعوك لزيارة موقعنا والاستفادة من المعلومات القيمة التي يوفرها.\r\n \r\n\r\nحماية المعلومات الشخصية\r\n\r\nباستخدامك لهذا الموقع فإنك توافق على شروط سياسة الخصوصية هذه، حيث تلتزم الجائزة من خلال إدارته لموقعه الإلكتروني، عند جمع معلومات شخصية عنك عندما تقوم بزيارة الموقع بأن يكون استخدام تلك المعلومات التي قدمتها، فقط من أجل إنجاز طلبك للحصول على معلومات أو خدمات عبر الموقع.\r\nتحتفظ جائزة الشارقة للتفوق والتميز التربوي بالحق في إجراء أي تعديل طفيف أو جذري لشروط سياسة الخصوصية من وقت لآخر دون الحاجة إلى تقديم إخطار، حيث يتم تعديل هذه السياسة ونشر هذه التعديلات بمجرد اعتمادها، لذا ننصحك بالاطلاع على هذه الصفحة من وقت لأخر لمعرفة التحديثات التي طرأت على سياسة الخصوصية، ولذلك فإن زيارتك واستخدامك لموقعنا بعد إدخال التعديلات على سياسة الخصوصية هذه، يعني قبولك لهذه التغييرات.\r\nلن تكون معلوماتك الشخصية متاحة إلا لموظفي الجائزة الذين يحتاجون للاطلاع على تلك المعلومات، ولن تكون تلك المعلومات متاحة لاطلاع الجمهور عليها بدون موافقتك على ذلك، وعلاوة على ذلك، لن يتم تبادل، أو تداول أي من تلك المعلومات أو بيعها لأي طرف آخر من دون موافقتك المسبقة، ولن يتم السماح بالوصول إلى المعلومات إلا لأولئك المؤهلين والمحترفين الذين يتولون تقديم خدمات الجائزة المتسقة مع تعاملاتك مع موقعنا.\r\n \r\n\r\nانتقال آمن للمعلومات\r\nهذا الموقع يمتلك إجراءات أمن لحماية المعلومات التي تقدمها لنا، فإننا نعمل على تشفير المعلومات التي تعتبر حساسة (مثل بياناتك الشخصية) أو البيانات التي يتعين الحفاظ على سريتها تماشياً مع المتطلبات القانونية.\r\n\r\n\r\nالمرجعية القانونية للجائزة\r\n\r\nيحق لجائزة الشارقة للتفوق والتميز التربوي اتخاذ التدابير التي يراها ملائمة لحماية أي فقدان أو إساءة استخدام أو تغيير للمعلومات الموجودة على الموقع الإلكتروني، وذلك دون أن تضمن الجائزة في هذه الحالة الاحتفاظ بسرية محتويات هذا الموقع الإلكتروني، ولا يعتبر مسؤولاً قانوناً عن أي ضرر قد تتعرض له أنت أو أي شخص نتيجة لانتهاك السرية بشأن المعلومات التي تكون قد نقلتها إلى الموقع.\r\nتكون قوانين دولة الإمارات العربية المتحدة وحدها هي القوانين واجبة التطبيق في كل ما يتعلق بالنزاعات التي قد تنشأ من جراء استخدام هذا الموقع الإلكتروني، أو أياً من أجزائه وأقسامه، كما تختص محاكم إمارة الشارقة حصرياً بالنظر في تلك النزاعات والبت فيها.", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8955), null, null, "Your entry and use of the Sharjah Award for Excellence and Educational Excellence website is subject to the following terms and conditions, in addition to the laws of the United Arab Emirates related to dealing with websites and electronic platforms.\r\nYour access to the site means your acceptance of these terms and conditions, whether you are a registered user or not. By entering, browsing, and using the site, you have accepted, without restriction or condition, the terms and conditions of use contained in this document.\r\n\r\n \r\n\r\nDefinitions:\r\n\r\nCountry: United Arab Emirates.\r\nAward: Sharjah Award for Excellence and Educational Excellence.\r\nWebsite: The Sharjah Award for Excellence and Educational Excellence website on the Internet.\r\nLaw: Any or all laws issued and approved by the United Arab Emirates that relate to dealing with information technology and crimes related to it.\r\n \r\n\r\nAmending the agreement\r\nThe Award has the right to amend these terms and conditions, provided that notice of amendments is placed on this page. Amendments will enter into force as soon as they are announced, unless otherwise stated.\r\nYour repeated use of the site after these modifications are made means that you agree to the modifications, and you must make periodic visits to this page to review the updated or amended terms and conditions.\r\n\r\n \r\n\r\nAct\r\nYour entry and use of the site constitutes your agreement and acknowledgment to enter and use the site for lawful purposes only, and you are fully responsible for knowing and acting on any and all laws, regulations, rules and provisions related to your use of it. Once you enter the site, you agree to refrain from the following:\r\n\r\nEnter or publish any illegal content that includes discrimination, defamation, abuse, slander, or inappropriate material.\r\nUse the Site to impersonate other individuals or parties.\r\nUse the Site in order to commit an offense or encourage others to engage in any conduct that may constitute a criminal offense or give rise to civil liability.\r\nInsulting others, individuals or institutions, in any way.\r\nPartisanship or racism against others or insulting any race, religion, color, nationality or social status.\r\nUse the site to upload any material that contains programs that contain viruses, malicious programs, or any computer codes, files or programs that may alter, damage or impede the operation of the site or any device or program belonging to any person who accesses the site.\r\nInput, send, upload or broadcast any material that you do not have the right to broadcast or publish under any law or contractual relationship.\r\nAlter, damage, delete or disable any content on the Site.\r\nDamaging or disrupting any regular or electronic lines, channels, or means of communication or communication in any way.\r\nClaiming to represent any company, association, body, or public or private institution, or claiming to be connected to it, without being authorized to claim that relationship or that representation.\r\nPublish or broadcast any advertisement, promotional or marketing material for any product or service in any form of promotion or marketing.\r\nPost any material that infringes or conflicts with the intellectual property rights of others, or collect or store personal information about others.\r\n \r\n\r\nRegister\r\nSome parts and services of the site do not work and can only be accessed by registered members and/or allow the user to request support or services electronically by entering some personal information. Therefore, you agree that any information provided to us through those parts is true, complete and accurate information, and that you will not You register, or attempt to enter the site using or impersonating the name or capacity of another person, and that you do not claim to have a user name or user data that is not yours, or that the Award may find (according to its right to discretion) to be inappropriate.\r\n\r\n \r\n\r\nTermination of use\r\nThe Award has every right, as it deems appropriate, to prevent, terminate or suspend your access to and use of this site without notice and for any reason whatsoever, including violation of these terms and conditions or due to any behavior that the Award may deem to be contrary to the law or harmful to others, and in these cases You will no longer be able to access the site, and the award has the right to use every means available to implement this matter.\r\n\r\nLinks to other websites\r\nSome links on the site lead to other websites that are not operated by the Award, and it has no control over them. The Award also does not review or control the content of those sites, as the Award provides these links as a matter of convenience for the users and visitors of its site, and those other sites do not have any promotional or marketing content for goods or special services, but rather they are links to sites Related to the work of the award and/or providing services related to the work of the award to serve visitors and users of the site, and when you click on and choose a link to an external site, you are subject to the terms and conditions of that external site.\r\n\r\n \r\n\r\nContent\r\nThe Award reserves the right to monitor any content entered by you, but is not obligated to do so. Although the Award may not be able to monitor everything that is entered on the site, we reserve the right (but not the obligation) to delete, remove or edit any materials entered from the site. If you violate these terms and conditions, UAE and foreign copyright laws and international treaties protect the contents of this site, and you agree to abide by the copyright notices that appear on this site.\r\n\r\n \r\n\r\nCompensation\r\nYou agree to defend, insure, and maintain the integrity of the award website, and all its employees and agents against any and all liability that may arise from any claim resulting from any breach by you of these terms and conditions, including the costs and fees determined for the defense or lawyers, and you also agree You will cooperate fully in defending against such claims, and the Award has the right to assume, at its own expense, the exclusive defense and control of any matter otherwise subject to indemnification by you, and you agree not to settle any matter except with the written approval of the Award.\r\n\r\nThe privacy policy shown on this page is considered part of the terms and conditions of use of the website.\r\n\r\n\r\nCollection and use of electronic information\r\n\r\nOur servers automatically capture and collect your Internet Protocol address when you visit the site. Your Internet Protocol address is the number for the computer, tablet, or smartphone that you use, which allows other devices connected to the Internet to determine the destination of the data issued by it. But without getting to know you personally.\r\nOur use of your Internet Protocol helps us diagnose problems that may occur in our server, and to conduct the necessary statistics to measure the use of the site, and we do not allow any party outside the framework of the technical team assigned by the award to view your Internet Protocol.\r\nIn order to provide better service and a more effective website, some sections of this site may use cookies as part of the interaction with your browser. This program is a small text file sent to your hard disk so that our server can recognize your device and browser. which you use to improve your interaction with our site.\r\nThe cookie software sent by us will not attempt to read any of the private information on your hard drive, and we do not collect this information through this software to find out other personal data or information in order to determine your identity or email address.\r\nIf your visit to the site is to obtain a specific service or information, when you visit some parts of this site, you may be asked to provide personal information to identify yourself (such as name, phone number, address,...), which are all necessary information to complete your transaction, but this The information will not be shared or misused under any circumstances, and if you refuse to provide that information, the award has the right to refuse to provide that service. In any case, we still invite you to visit our website and benefit from the valuable information it provides.\r\n\r\n\r\nProtection of personal information\r\n\r\nBy using this website, you agree to the terms of this privacy policy, as the award, through its management of its website, is committed to collecting personal information about you when you visit the site, to use that information that you provided, only in order to fulfill your request for information or services through the site.\r\nThe Sharjah Award for Excellence and Educational Excellence reserves the right to make any minor or radical amendment to the terms of the privacy policy from time to time without the need to provide notification. This policy is amended and these amendments are published as soon as they are approved. Therefore, we advise you to check this page from time to time to find out the updates that have occurred. on the Privacy Policy. Therefore, your visit and use of our site after making changes to this Privacy Policy means that you accept these changes.\r\nYour personal information will only be available to award employees who need to see that information, and that information will not be available for public access without your consent. Moreover, none of that information will be exchanged, traded, or sold to any other party without your consent. Access to the information will only be granted to those qualified and professional people who provide award services consistent with your dealings with our website.\r\n \r\n\r\nSecure transmission of information\r\nThis site has security measures in place to protect the information you provide to us. We encrypt information that is considered sensitive (such as your personal data) or data that must be kept confidential in line with legal requirements.\r\n\r\n\r\nLegal reference for the award\r\n\r\nThe Sharjah Award for Educational Excellence and Excellence has the right to take the measures it deems appropriate to protect any loss, misuse, or change of information on the website, without the award in this case guaranteeing the confidentiality of the contents of this website, and it is not considered legally responsible for any damage you may be exposed to. You or any person as a result of a breach of confidentiality regarding information you have transmitted to the Site.\r\nThe laws of the United Arab Emirates alone are the applicable laws in all matters related to disputes that may arise as a result of the use of this website, or any of its parts and sections, and the courts of the Emirate of Sharjah have exclusive jurisdiction to consider and decide on these disputes.", null, null, "Terms_Of_Use_Subscriber", 1, false }
                });

            migrationBuilder.InsertData(
                table: "PermissionHeaders",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7680), null, null, null, null, "AboutAward", false },
                    { 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7683), null, null, null, null, "Album", false },
                    { 3, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7687), null, null, null, null, "AppVersion", false },
                    { 4, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7690), null, null, null, null, "AwardPublication", false },
                    { 5, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7694), null, null, null, null, "AwardSponsor", false },
                    { 6, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7697), null, null, null, null, "Circular", false },
                    { 7, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7700), null, null, null, null, "Class", false },
                    { 8, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7704), null, null, null, null, "ClassArbitrator", false },
                    { 9, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7707), null, null, null, null, "Cycle", false },
                    { 10, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7710), null, null, null, null, "Agenda", false },
                    { 11, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7712), null, null, null, null, "Category", false },
                    { 12, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7716), null, null, null, null, "GeneralCondition", false },
                    { 13, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7719), null, null, null, null, "EducationalEntity", false },
                    { 14, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7722), null, null, null, null, "SystemFiles", false },
                    { 15, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7725), null, null, null, null, "GeneralWorkshop", false },
                    { 16, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7728), null, null, null, null, "Instruction", false },
                    { 17, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7731), null, null, null, null, "Meeting", false },
                    { 18, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7734), null, null, null, null, "News", false },
                    { 19, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7737), null, null, null, null, "Notification", false },
                    { 20, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7740), null, null, null, null, "NotificationTemplate", false },
                    { 21, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7743), null, null, null, null, "Role", false },
                    { 22, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7746), null, null, null, null, "User", false },
                    { 23, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7749), null, null, null, null, "Coordinator", false },
                    { 24, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7752), null, null, null, null, "Arbitrator", false },
                    { 25, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7755), null, null, null, null, "Committee", false },
                    { 26, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7758), null, null, null, null, "SubscriberAccount", false },
                    { 27, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7762), null, null, null, null, "SubscriberProfile", false },
                    { 28, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7765), null, null, null, null, "SubscriberForm", false },
                    { 29, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7768), null, null, null, null, "Event", false },
                    { 30, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7770), null, null, null, null, "ContactUs", false }
                });

            migrationBuilder.InsertData(
                table: "ReferenceSources",
                columns: new[] { "Id", "ArabicSources", "ArabicTitle", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishSources", "EnglishTitle", "ImageUrl", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "الدليل التفسيري لجائزة جوهرة اللغة العربية", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(119), null, null, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "Interpretive guide for the Jewel of the Arabic Language Award", "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000", null, null, false },
                    { 2, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "الأدلة التفسيرية لفئة الأفراد المتميزين", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(129), null, null, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "", "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000", null, null, false },
                    { 3, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "الأدلة التفسيرية لفئة المؤسسات المتميزة", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(132), null, null, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "", "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000", null, null, false },
                    { 4, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "الأدلة التفسيرية لفئة فرق العمل  المتميزة", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(136), null, null, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "", "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000", null, null, false },
                    { 5, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "المصادر التوضيحية لجميع الفئات", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(139), null, null, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "", "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "HaveFullAccess", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "ادمن", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Admin", false, null, null, false },
                    { 2, "مشترك", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Subscriber", false, null, null, false },
                    { 3, "مدير", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Manager", false, null, null, false },
                    { 4, "مستخدم", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "User", false, null, null, false },
                    { 5, "منسق", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Coordinator", false, null, null, false },
                    { 6, "محكم", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Arbitrator", false, null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ArabicName", "ConfirmationCodeForForgetPassword", "ConfirmationCodeForResetPassword", "ConfirmationCodeForSignUp", "CreatedAt", "CreatedBy", "DeletedAt", "Email", "EnglishName", "Gender", "ImageURL", "LastModifiedAt", "LastModifiedBy", "NumberOfGroupCategories", "NumberOfIndividualCategories", "Password", "PhoneNumber", "SubscriberId", "TrainingWorkshopId", "isDeleted", "isValidAccount" },
                values: new object[,]
                {
                    { 1, "ادمن 123", null, null, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6740), null, null, "ahmad.a.ahmad.100011@gmail.com", "Admin 123", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true },
                    { 2, "ادمن 123 #", null, null, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6745), null, null, "Ahmad@Ahmad.com", "Admin 123 #", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true },
                    { 3, "ادمن 123 ##", null, null, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6750), null, null, "Ahmad2@Ahmad2.com", "Admin 123 ##", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true },
                    { 4, "ادمن 123 ##@", null, null, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6755), null, null, "Ahmad3@Ahmad3.com", "Admin 123 ##@", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true },
                    { 5, "ادمن 123 ##@@", null, null, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6761), null, null, "Ahmad4@Ahmad4.com", "Admin 123 ##@@", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true },
                    { 6, "تامر", null, null, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6765), null, null, "tamer@gmail.com", "Tamer", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", "ABC123", null, false, true },
                    { 10, "منسق 1", null, null, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5588), null, null, "Coordinator@Coordinator.com", "Coordinator 1", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true },
                    { 11, "منسق 2", null, null, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5597), null, null, "Coordinator2@Coordinator2.com", "Coordinator 2", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true },
                    { 12, "منسق 3", null, null, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5602), null, null, "Coordinator3@Coordinator3.com", "Coordinator 3", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true },
                    { 13, "منسق 4", null, null, null, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5607), null, null, "Coordinator4@Coordinator4.com", "Coordinator 4", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true }
                });

            migrationBuilder.InsertData(
                table: "Agendas",
                columns: new[] { "Id", "ArabicTitle", "CreatedAt", "CreatedBy", "CurrentDate", "CycleId", "DateType", "DeletedAt", "EndDate", "EnglishTitle", "Icon", "IsPrivate", "LastModifiedAt", "LastModifiedBy", "StartDate", "Status", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار عنوان جدول أعمال 1", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5135), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null, new DateTime(2024, 6, 22, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5148), "Test Agenda Titile 1", "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1) (1).png", false, null, null, new DateTime(2024, 6, 17, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5165), 1, false },
                    { 2, "اختبار عنوان جدول أعمال 2", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5169), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, null, new DateTime(2024, 6, 27, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5171), "Test Agenda Titile 2", "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1) (2).png", false, null, null, new DateTime(2024, 6, 22, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5172), 0, false },
                    { 3, "اختبار عنوان جدول أعمال 3", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5174), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null, new DateTime(2024, 7, 2, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5177), "Test Agenda Titile 3", "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png", false, null, null, new DateTime(2024, 6, 27, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5179), 2, false },
                    { 4, "اختبار عنوان جدول أعمال 4", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5181), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null, new DateTime(2024, 7, 7, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5183), "Test Agenda Titile 4", "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png", false, null, null, new DateTime(2024, 7, 2, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5185), 2, false },
                    { 5, "اختبار عنوان جدول أعمال 5", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5187), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null, new DateTime(2024, 7, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5191), "Test Agenda Titile 5", "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png", false, null, null, new DateTime(2024, 7, 7, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5192), 2, false }
                });

            migrationBuilder.InsertData(
                table: "AwardStatistics",
                columns: new[] { "Id", "ArabicTitle", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "StatisticValue", "isDeleted" },
                values: new object[,]
                {
                    { 1, "المشتركين بالجائزة خلال الدورات 1", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(11), null, 1, null, "Award winners during training courses V1", null, null, 1000, false },
                    { 2, "المشتركين بالجائزة خلال الدورات 2", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(17), null, 1, null, "Award winners during training courses V2", null, null, 2000, false },
                    { 3, "المشتركين بالجائزة خلال الدورات 3", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(21), null, 1, null, "Award winners during training courses V3", null, null, 3000, false },
                    { 4, "المشتركين بالجائزة خلال الدورات 4", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(24), null, 1, null, "Award winners during training courses V4", null, null, 4000, false },
                    { 5, "المشتركين بالجائزة خلال الدورات 5", new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(28), null, 1, null, "Award winners during training courses V5", null, null, 5000, false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ArabicDescription", "ArabicName", "CategoryClassification", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationQualificationMark", "Icon", "LastModifiedAt", "LastModifiedBy", "MaximumAmountToObtainAStatement", "MaximumRequirementToObtainACertificate", "MinimumAmountToObtainAStatement", "MinimumRequirementToObtainACertificate", "MinimumWinningScore", "ParentId", "RelatedToClasses", "RelatedToEducationalEntities", "isDeleted" },
                values: new object[,]
                {
                    { 1, "", "جائزة جوهرة اللغة العربية", 0, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8475), null, 1, null, "", "The \"Gem\" of the Arabic Language", null, null, "https://award-shj.ae/media/cb2igx0d/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%A7%D9%84%D8%AC%D9%88%D9%87%D8%B1%D8%A9.png", null, null, null, null, null, null, null, null, null, null, false },
                    { 3, "", "فئة الأفراد المتميزين", 0, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8500), null, 1, null, "", "Distinguished Individuals Category", null, null, "https://award-shj.ae/media/iqzhrizm/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%82%D8%A7%D8%A6%D8%AF-%D8%A7%D9%84%D8%AA%D8%B1%D8%A8%D9%88%D9%8A-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2.png", null, null, null, null, null, null, null, null, false, null, false },
                    { 6, "", "فئة المؤسسات المتميزة", 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8527), null, 1, null, "", "Distinguished Institutions Category", null, null, "https://award-shj.ae/media/ceihv5g3/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%A4%D8%B3%D8%B3%D8%A7%D8%AA-%D8%A7%D9%84%D8%AA%D8%B9%D9%84%D9%8A%D9%85%D9%8A%D8%A9-%D8%A7%D9%84%D8%AD%D8%B6%D8%A7%D9%86%D8%A9-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2%D8%A9.png", null, null, null, null, null, null, null, null, false, null, false }
                });

            migrationBuilder.InsertData(
                table: "DynamicAttributeSections",
                columns: new[] { "Id", "ArabicName", "AttributeTableNameId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "OrderId", "RecordIdOnRelation", "TableTypeSection", "isDeleted" },
                values: new object[] { 1, "اختبار اسم 1", 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7328), null, null, "Test Name 1", null, null, 1, 2, false, false });

            migrationBuilder.InsertData(
                table: "EducationCoordinators",
                columns: new[] { "Id", "CoordinatorId", "CreatedAt", "CreatedBy", "DeletedAt", "EducationalEntityId", "LastModifiedAt", "LastModifiedBy", "RelatedDate", "isDeleted" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6002), null, null, 1, null, null, new DateTime(2024, 6, 12, 9, 41, 6, 388, DateTimeKind.Local).AddTicks(6016), false },
                    { 2, 11, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6138), null, null, 1, null, null, new DateTime(2024, 6, 12, 9, 41, 6, 388, DateTimeKind.Local).AddTicks(6140), false },
                    { 3, 12, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6155), null, null, 2, null, null, new DateTime(2024, 6, 12, 9, 41, 6, 388, DateTimeKind.Local).AddTicks(6158), false },
                    { 4, 13, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6164), null, null, 2, null, null, new DateTime(2024, 6, 12, 9, 41, 6, 388, DateTimeKind.Local).AddTicks(6167), false }
                });

            migrationBuilder.InsertData(
                table: "EducationalInstitutions",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EducationType", "EducationalEntityId", "Emirates", "EnglishName", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "مؤسسة تعليمية 1", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5916), null, null, 0, 1, 0, "Educational Entity 1", null, null, false },
                    { 2, "مؤسسة تعليمية 2", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5921), null, null, 0, 2, 0, "Educational Entity 2", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "GeneralFAQs",
                columns: new[] { "Id", "ArabicAnswer", "ArabicQuestion", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishAnswer", "EnglishQuestion", "GeneralFrequentlyAskedQuestionCategoryId", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار جواب 1", "اختبار سؤال 1", new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8458), null, null, "Test Answer 1", "Test Question 1", 1, null, null, false },
                    { 2, "اختبار جواب 2", "اختبار سؤال 2", new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8462), null, null, "Test Answer 2", "Test Question 2", 1, null, null, false },
                    { 3, "اختبار جواب 3", "اختبار سؤال 3", new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8466), null, null, "Test Answer 3", "Test Question 3", 2, null, null, false },
                    { 4, "اختبار جواب 4", "اختبار سؤال 4", new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8470), null, null, "Test Answer 4", "Test Question 4", 2, null, null, false }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "ArabicDescription", "ArabicTitle", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishDescription", "EnglishTitle", "Image", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "كرّم سموّ الشيخ سلطان بن أحمد بن سلطان القاسمي، نائب حاكم إمارة الشارقة، صباح الثلاثاء، الفائزين بجائزة الشارقة للتفوق والتميز التربوي في دورتها التاسعة والعشرين، في مركز الجواهر للمناسبات والمؤتمرات.\r\n\r\n\r\nاستهل الحفل بالسلام الوطني لدولة الإمارات، أعقبه تلاوة آيات بيّنات من الذكر الحكيم، ألقت بعدها الدكتورة محدّثة الهاشمي، رئيسة هيئة الشارقة للتعليم الخاص، كلمة قدمت فيها الشكر والامتنان إلى صاحب السموّ الشيخ الدكتور سلطان بن محمد القاسمي، عضو المجلس الأعلى، حاكم الشارقة، على دعمه المطلق، لكل ما يعزّز الواقع التعليمي والثقافي في الإمارة.\r\n\r\n\r\nكما قدمت الشكر والعرفان إلى سموّ الشيخ سلطان بن أحمد القاسمي، على تشريفه للحفل وتكريم الفائزين والفائزات.\r\n\r\n \r\n\r\nوأشارت إلى أن الجائزة، وهي الأولى تاريخياً التي تحتفي بالطلبة، لا تعدّ رمزاً للتفوق والإلهام فحسب، بل منصة تنطلق بها جسور الإبداع والبناء في مستقبل المنظومة التربوية.\r\n\r\n\r\nمشيدةً بمستوى مشاركات الطلبة في هذه الدورة التي بلغت 64%، ما يعكس نجاح الجائزة في تحقيق أهم أهدافها في تشجيع الطلبة وتحفيزهم على التطور والإبداع والابتكار.\r\n\r\n\r\nواختتمت محدّثة الهاشمي، كلمتها بتهنئة الفائزين الذين بذلوا جهوداً كبيرة، وعملوا بتفانٍ لتحقيق التميز، وأصبحوا يمثلون نماذج طيبة لروح العطاء الملهم في التعليم. لافتةً إلى أهمية الجائزة في تحفيز العقول، ونشر ثقافة التميّز، ومساندة المتميزين في الميدان التربوي بكل شرائحه وفئاته، والمجتمع المحلي. كما قدمت الشكر إلى لجنة التحكيم.\r\n\r\n\r\nوشاهد الحضور عرضاً عن مسيرة الجائزة، خلال السنوات الماضية وتطورها، وأدوارها في تعزيز التفوق التربوي والتعليمي في إمارة الشارقة.\r\n\r\n\r\nوتفضل سموّ نائب حاكم الشارقة، في نهاية الحفل بتكريم الفائزين، حيث فازت «مؤسسة الإمارات للتعليم المدرسي»، بجائزة أفضل جهة تعليمية.\r\n\r\n\r\nوفاز في الفئة الأولى للأفراد المتميزين، القائد التربوي المتميز: أميرة آل محمد، بالمركز الأول، ومريم اللوغاني، بالمركز الثاني. وفي فئة المعلم المتميز، فازت سها شعشاعة، بالمركز الأول، ومؤمن يونس، بالمركز الثاني، وعنود الحمادي، بالمركز الثالث، وخفية حمودة الكتبي، بالمركز الرابع.\r\n\r\n\r\nوفي فئة الوظائف الداعمة المتميزة، فازت خولة البلوشي، بالمركز الأول، وإكرامي سيد، بالمركز الثاني. وفي فئة ولي الأمر المتميّز، فاز أحمد مصبح النيادي.\r\n\r\n\r\nوفي فئة الطالب المتميّز في الصفوف من الثالث إلى الثاني عشر، فاز: ناكشاترا انطوني، وكانشيكا مانيكاندان، وشريماد سريراج، من الصف الثالث. وسليمان السيد، وهند النقبي، ومريم البدري، من الرابع. ونيلينا جونيش، وبريانكا جوبينات، وشمّا المرزوقي، من الخامس. وعلي حميد آل علي، وشهد السويدان، وسيلينا حامد، وسانفي راو، من السادس. وأنانيا أماني، ومير أظهار، وشهد المزروعي، من السابع. ومحمد النقبي، وهيام الحساني، من الثامن، وديتي غاندي، وسامفورد توماس، وجاش سانديب، من التاسع. وموزة الشامسي، ومريم الشحّي، وأنوباما بادينشاريتيل، من العاشر. وأديتيا غاندي، من الحادي عشر.\r\n\r\n\r\nوفاز في فئة الطالب المتميز من الفئات الخاصة: مريم المرزوقي، وشوق الشامسي، ومحمد العبدولي، وخميس العبدولي.\r\n\r\n\r\nوفي فئة المؤسسات المتميزة، فازت «مدرسة جيمس ميلينيوم»، الخاصة بفئة المؤسسات التعليمية المتميزة. وفي فرق العمل المتميزة، فاز مجلس طلبة المدرسة الثانوية النموذجية للبنين في فئة المجلس المتميّز.\r\n\r\n\r\nحضر الحفل بجانب سموّ نائب حاكم الشارقة: الشيخ المهندس محمد بن عبدالله بن ماجد القاسمي، مدير دائرة شؤون البلديات، والشيخ عبدالله بن محمد القاسمي، مدير هيئة الشؤون الإسلامية والأوقاف، وحميد محمد القطامي، رئيس مجلس أمناء مؤسسة حمدان بن راشد آل مكتوم للعلوم الطبية والتربوية، وجمال الطريفي، رئيس الجامعة القاسمية، والدكتورة محدّثة الهاشمي رئيسة هيئة الشارقة للتعليم الخاص، وعيسى الحزامي، رئيس مجلس الشارقة الرياضي، وعدد من المسؤولين والمديرين العامين، ومديري الدوائر المحلية، والتربويين ومديري المدارس والمعلمين.\r\n\r\n \r\n\r\nالمصدر: الخليج", "سلطان بن أحمد يكرّم فائزي «جائزة الشارقة للتفوق التربوي»", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9069), null, 1, null, "His Highness Sheikh Sultan bin Ahmed bin Sultan Al Qasimi, Deputy Ruler of the Emirate of Sharjah, on Tuesday morning, honored the winners of the Sharjah Award for Educational Excellence and Excellence in its twenty-ninth session, at Al Jawaher Center for Events and Conferences.\r\n\r\n\r\nThe ceremony began with the national anthem of the UAE, followed by the recitation of clear verses from the Holy Quran, after which Dr. Muhadditha Al Hashemi, President of the Sharjah Private Education Authority, delivered a speech in which she extended thanks and gratitude to His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council, Ruler of Sharjah, for His absolute support for everything that enhances the educational and cultural reality in the emirate.\r\n\r\n\r\nShe also extended thanks and gratitude to His Highness Sheikh Sultan bin Ahmed Al Qasimi, for honoring the ceremony and honoring the winners.\r\n\r\n \r\n\r\nShe pointed out that the award, which is the first in history to celebrate students, is not only a symbol of excellence and inspiration, but also a platform from which bridges of creativity and building in the future of the educational system will be launched.\r\n\r\n\r\nShe praised the level of student participation in this course, which reached 64%, which reflects the success of the award in achieving its most important goals of encouraging students and motivating them to develop, create and innovate.\r\n\r\n\r\nAl-Hashemi concluded her speech by congratulating the winners who made great efforts, worked with dedication to achieve excellence, and became good examples of the spirit of inspiring giving in education. Pointing to the importance of the award in stimulating minds, spreading the culture of excellence, and supporting distinguished people in the educational field in all its segments and categories, and the local community. She also thanked the jury.\r\n\r\n\r\nThe audience watched a presentation about the award’s progress over the past years, its development, and its roles in promoting educational excellence in the Emirate of Sharjah.\r\n\r\n\r\nAt the end of the ceremony, His Highness the Deputy Ruler of Sharjah honored the winners, as the Emirates School Education Foundation won the Best Educational Institution award.\r\n\r\n\r\nIn the first category of distinguished individuals, the distinguished educational leader: Amira Al Muhammad, won first place, and Maryam Al-Loughani, won second place. In the Distinguished Teacher category, Suha Shasha’a won first place, Moamen Younis won second place, Anoud Al Hammadi won third place, and Khafiya Hamouda Al Ketbi won fourth place.\r\n\r\n\r\nIn the Outstanding Support Jobs category, Khawla Al Balushi won first place, and Ekrami Sayed won second place. In the Distinguished Parent category, Ahmed Musabih Al Neyadi won.\r\n\r\n\r\nIn the Outstanding Student category in grades three to twelve, Nakshatra Anthony, Kanshika Manikandan, and Shrimad Sriraj, from third grade, won. Suleiman Al-Sayyed, Hind Al-Naqbi, and Maryam Al-Badri, from the fourth. And Nelina Gunesh, Priyanka Gobinath, and Shamma Al Marzouqi, from the fifth. Ali Hamid Al Ali, Shahad Al-Suwaidan, Selina Hamed, and Saanvi Rao, from the sixth. Ananya Amani, Mir Azhar, and Shahad Al Mazrouei, from the seventh. Muhammad Al-Naqbi and Hiyam Al-Hassani, from the eighth, and Diti Gandhi, Samford Thomas, and Jash Sandeep, from the ninth. Moza Al Shamsi, Maryam Al Shehhi, and Anupama Badincharitil, from the 10th. and Aditya Gandhi, from the 11th.\r\n\r\n\r\nThe winners in the Outstanding Student category from the special categories were: Mariam Al Marzouqi, Shouq Al Shamsi, Muhammad Al Abdouli, and Khamis Al Abdouli.\r\n\r\n\r\nIn the Distinguished Institutions category, GEMS Millennium Private School won the Distinguished Educational Institutions category. In the distinguished work teams, the Student Council of the Model Secondary School for Boys won in the Distinguished Council category.\r\n\r\n\r\nThe ceremony was attended, alongside His Highness the Deputy Ruler of Sharjah: Sheikh Engineer Mohammed bin Abdullah bin Majid Al Qasimi, Director of the Department of Municipalities Affairs, Sheikh Abdullah bin Mohammed Al Qasimi, Director of the Islamic Affairs and Endowments Authority, and Humaid Mohammed Al Qatami, Chairman of the Board of Trustees of the Hamdan Bin Rashid Al Maktoum Foundation for Medical and Educational Sciences. Jamal Al-Tarifi, President of Al Qasimia University, Dr. Muhaddith Al-Hashimi, President of the Sharjah Private Education Authority, Issa Al-Hazami, Chairman of the Sharjah Sports Council, and a number of officials, general directors, directors of local departments, educators, school principals, and teachers.\r\n\r\n \r\n\r\nSource: Al Khaleej", "Sultan bin Ahmed honors the winners of the “Sharjah Award for Educational Excellence”", "https://award-shj.ae/media/n1lb4exq/screenshot-2024-03-07-121511.png?anchor=center&mode=crop&width=593&height=338&rnd=133542874516370000", null, null, false },
                    { 2, "الشارقة: أمير السني\r\n\r\nأعلنت لجنة «جائزة الشارقة للتفوق والتميز التربوي» و«مجالس أولياء أمور الطلبة والطالبات»، إطلاق الدورة 29 للجائزة، خلال مؤتمر صحفي عقدته في «بيت الحكمة».\r\n\r\nحضر المؤتمر محمد الملّا، الأمين العام للجنة، وعلياء الحوسني، رئيسة لجنة الجائزة، وعدد من الشخصيات من المؤسسات ذات الصلة، والشركاء، ومنسقو الجائزة، وأعضاء اللجان التطويرية، وعدد من الإعلاميين.\r\n\r\nوقال الملّا إن إطلاق الدورة 29 هذا العام، جاء استمراراً لمسيرة الجائزة التربوية المتميزة، منذ إنشائها عام 1994 برعاية صاحب السموّ الشيخ الدكتور سلطان بن محمد القاسمي، عضو المجلس الأعلى حاكم الشارقة، ولدورها الكبير في إبراز الكفايات التعليمية المعطاءة التي قدمت مساهمات كبيرة في حقل التعليم، ولها بصمات واضحة، في النهوض به.\r\n\r\nوأضاف أن الجائزة، تستهدف رسالتها مهمّة الارتقاء بالعمل التربوي، في مراحله كافة، بتكريم المتميزين والمبدعين من المجالات التعليمية والتربوية المختلفة، إلى جانب نشر ثقافة التّميّز والابتكار، وتهيئة مناخ فكريّ نموذجيّ للميدان التّربوي بكلّ فئاته المبدعة المتميزة بطرحها لرؤية طموحة جديدة، تتكامل مع إستراتيجيتها وأهدافها المستقبلية الرائدة.\r\n\r\nوأوضح أن الفئات المستهدفة في الجائزة ثلاث: الأفراد المتميزون وضمت «المعلم المتميز»، و«القائد التربوي المتميز» (بفرعيه القيادة العليا والقيادة الوسطى)، و«الطالب المتميز» و«الطالب المتميز من الفئات الخاصة»، و«الوظائف الداعمة المتميزة» و«ولي الأمرالمتميز».\r\n\r\nوتضم الثانية المؤسسات المتميزة «المدرسة المتميزة»، و«الحضانات المتميزة»، و«المؤسسات والشراكات الداعمة للتعليم». وتضمّ الثالثة فرق العمل وشمل «فرق العمل المؤسسية المتميزة»، و«مجلس الطلبة المتميز»، و«فرق العمل المشتركة»، و«مجلس أولياء الأمور المتميز».\r\n\r\nوكشف الأمين العام، جائزة جديدة لهذا العام وهي «جوهرة اللغة العربية»، لأهمية اللغة العربية، وضرورة تربية النشء على إتقانها والمحافظة عليها، وتجسيداً للاهتمام الكبير الذي يوليه صاحب السموّ حاكم الشارقة باللغة العربية، بدعمه وتسخير كل الإمكانات للحفاظ عليها.\r\n\r\nوقالت علياء الحوسني: إن الجائزة تواصل أهدافها الطموحة لاستشراف المستقبل، والمساهمة في تطوير الميدان التربوي دورة إثر دورة، وبناء كوادر تربوية متميزة متخذة من الإبداع والابتكار والتّميّز والمنهج العلمي نهجاً، لتنمية هذا الميدان، وإعداده الإعداد المتميز الذي يؤهله للمساهمة في إنجازات الدولة.\r\n\r\nوأضافت أن لجنة الجائزة، تسعى إلى تطويرها وفق خطّة ممنهجة وأهداف ورؤى واضحة، تستقطب الخبرات المتميزة لتطوّر معاييرها ومنهجياتها وأنظمتها التي تصنع الفرق في عوالم التميز و الإبداع.\r\n\r\n \r\n\r\nالمصدر: الخليج", "إطلاق «جائزة الشارقة للتفوق والتميز التربوي» الدورة 29", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9076), null, 1, null, "Sharjah: Amir Al Sunni\r\n\r\nThe Sharjah Award for Educational Excellence and Distinction Committee and the Parents’ Councils of male and female students announced the launch of the 29th session of the award, during a press conference held at the House of Wisdom.\r\n\r\nThe conference was attended by Mohammed Al Mulla, Secretary General of the Committee, Alia Al Hosani, Chair of the Award Committee, and a number of personalities from relevant institutions, partners, award coordinators, members of development committees, and a number of media professionals.\r\n\r\nAl Mulla said that the launch of the 29th session this year was a continuation of the distinguished educational award’s journey, since its establishment in 1994 under the patronage of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of Sharjah, and its great role in highlighting the generous educational competencies that have made great contributions in the field of education. And it has clear fingerprints in its advancement.\r\n\r\nHe added that the award’s mission aims to advance educational work, in all its stages, by honoring distinguished and creative people from various educational and pedagogical fields, in addition to spreading the culture of excellence and innovation, and creating an exemplary intellectual climate for the educational field with all its distinguished creative categories by presenting a new ambitious vision, integrated with its strategy and goals. Leading future.\r\n\r\nHe explained that the target categories for the award are three: distinguished individuals, which include the “distinguished teacher,” the “distinguished educational leader” (in both the senior leadership and middle leadership branches), the “distinguished student,” the “distinguished student from special categories,” and the “distinguished supporting jobs.” And “the distinguished guardian.”\r\n\r\nThe second includes the distinguished institutions “Distinguished School,” “Distinguished Nurseries,” and “Institutions and Partnerships that Support Education.” The third includes work teams and includes “Distinguished Institutional Work Teams,” “Distinguished Student Council,” “Joint Work Teams,” and “Distinguished Parents Council.”\r\n\r\nThe Secretary-General revealed a new award for this year, which is “The Jewel of the Arabic Language,” in recognition of the importance of the Arabic language and the necessity of educating young people to master and preserve it, and as an embodiment of the great interest that His Highness the Ruler of Sharjah attaches to the Arabic language, with his support and harnessing all capabilities to preserve it.\r\n\r\nAlia Al Hosani said: The award continues its ambitious goals of anticipating the future, contributing to the development of the educational field, cycle after cycle, and building distinguished educational cadres that adopt creativity, innovation, excellence, and the scientific method as an approach, to develop this field, and prepare it with distinguished preparation that qualifies it to contribute to the state’s achievements.\r\n\r\nShe added that the award committee seeks to develop it according to a systematic plan with clear goals and visions, attracting distinguished expertise to develop its standards, methodologies and systems that make the difference in the worlds of excellence and creativity.\r\n\r\n \r\n\r\nSource: Al Khaleej", "Launching of the “Sharjah Award for Excellence and Educational Excellence”, the 29th session", "https://award-shj.ae/media/bx4famcb/5106559.jpeg?anchor=center&mode=crop&width=593&height=338&rnd=133280978690230000", null, null, false },
                    { 3, "كرم سمو الشيخ عبدالله بن سالم بن سلطان القاسمي نائب حاكم الشارقة، صباح اليوم الأربعاء، في مركز الجواهر للمناسبات والمؤتمرات، الفائزين بجائزة الشارقة للتميز التربوي في دورتها الـ 28، والتي ينظمها مجلس الشارقة للتعليم.\r\n\r\nاستهل حفل التكريم بالسلام الوطني لدولة الإمارات العربية المتحدة، عقبه تلاوة آيات بينات من الذكر الحكيم، ألقى بعدها الدكتور سعيد مصبح الكعبي رئيس مجلس الشارقة للتعليم كلمة قال فيها: \"عُدت إلى أرشيف الجائزة، ذلك الأرشيف الجميل، واستوقفتني بعض الصور والمشاهد الحّية، وأكثر ما شد انتباهي لقاء متلفز لصاحب السمو حاكم الشارقة وهو يتحدث عن أهمية الجائزة ودورها في تعزيز التميز والتفوق، ومشهد للطلبة المتفوقين وهم يستلمون شهاداتهم من سموه فرحين بما أتاهم الله من فضله، تعرفت على بعض من هذه الشخصيات وهم الآن يتقلدون مناصب عدة يقودون نهضة التطور والعمران لهذا البلد الجميل\".\r\n\r\nوأضاف الدكتور سعيد مصبح الكعبي: \"تمر السنوات ويأتي جيل بعد جيل، تتطور المعايير والخطط، سعياً لتحقيق الرؤية السامية التي وضعها صاحب السمو حاكم الشارقة، فالجائزة تاريخ عميق، بمفاهيم راسخة في الأذهان وميادين مليئة بالأمثلة المشرفة، ونحن على يقين أن هذا الجيل سيكون له شأن كبير في المستقبل وسيكملون مسيرة النهضة، فالذي يسير على طريق التميز لا يتوقف، والحقيقة أن هذه هي الاستدامة التي رسمها سلطان مبكراً، نقطف اليوم ثمرةً بتكريم كوكبة جديدة من المتميزين\".\r\n\r\nوعن الجائزة في دورتها الحالية، أشار رئيس مجلس التعليم إلى أنها شهدت إطلاق فئة جديدة وهي \"جائزة الجوهرة\"، قائلاً: \"شهدت الجائزة في هذه الدورة اطلاق جائزة الجوهرة ضمن فئاتها، وهو تكريم استثنائي لشخصية متميزة لها انجازات ومبادرات فرديّة ذات أثر فعّال في المجال التربوي، وساهمت في الارتقاء بالتعليم وتطويره لتحقيق الأهداف المرجوة، وهي قدوة لغيرها في التميز والبذل والعطاء، كما شهدت إقبالاً ملحوظاً، فقد بلغ عدد المشاركين في الدورة الحالية 1328 مشاركاً بنسبة ارتفاع 40% عن العام الماضي، فاز منهم 38 مشاركاً، ومن جانب آخر، تم تدشين مبادرات التحول الرقمي، حيث أطلقت الجائزة تطبيق الهاتف الذكي، واستحدثت آليات جديدة لبوابة المشترك الإلكتروني ابتداء من استلام الطلبات مروراً بعمليات التقييم والتحكيم، بالإضافة إلى الدورات الافتراضية وتسجيل جميع الأدلة التفسيريّة للفئات صوتياً\".\r\n\r\nوفي ختام حديثه، وجه الدكتور سعيد مصبح الكعبي، رسالة للفائزين بالجوائز جاء فيها: \"حبانا الله بوطن وقادة يعشقون التميز والابداع والعطاء، ويدعون للعلم والمعرفة، ويسعون دائماً للقاء وتقدير المتميزين في كل المحافل، وما الجائزة إلا خير دليل على ذلك، وأدعوكم لحفظ الأمانة وحمل راية العطاء معاً لخدمة هذا الوطن الغالي، وأشكر سمو الشيخ عبد الله بن سالم القاسمي نائب حاكم الشارقة، على حضوره وتشريفه الحفل، كما أوجه الشكر لجميع الحضور متمنياً لهم التوفيق والنجاح\".\r\n\r\nبعدها شاهد الحضور مادة فلمية بعنوان \"جائزة الشارقة للتميز التربوي مسيرة تميز، تطور، إبداع\"، تناولت خلالها مسيرة الجائزة منذ نشأتها والخطط التي تبنتها وساهمت في تطور مراحلها على مر الأعوام، بالإضافة إلى تعدد فئات الجائزة وتوظيف التكنولوجيا من خلال أتمتة التقديم والمشاركة، وذلك لضمان سهولة الوصول لجميع شرائح المجتمع المشاركين في الجائزة.\r\n\r\nكما شاهد الحضور عرضاً ثلاثي الأبعاد ومادة مرئية حملت عنوان \"صنّاع التميز\"، تطرقت فيها للجهود المبذولة من قبل المرشحين المشاركين في الجائزة ودعم أولياء الأمور لأبنائهم الطلبة.\r\n\r\nوتفضل سمو نائب حاكم الشارقة بتكريم الفائز بالجائزة الاستثنائية \"جائزة الجوهرة\" والتي فاز بها عبد الله عوض الهمامي اختصاصي إعاقة بصرية في وزارة التربية والتعليم، ومدرب معتمد من البورد الأميركي الكندي، كما يحمل الهمامي الإجازة بسند متصل إلى \"النبي صل الله عليه وسلم\" في ترتيل وتجويد القرآن الكريم برواية حفص عن عاصم، كما أسس الهمامي نادي لذوي الإعاقة في جامعة العين ويعتبر أحد الرواد المؤثرين على مستوى الوطن العربي وحاز على العديد من الجوائز على المستوى المحلي والخارجي.\r\n\r\nكما كرم سموه هيئة الشارقة للتعليم الخاص الحاصلة على المركز الأول كأفضل جهة تعليمية، فيما حلت مؤسسة الإمارات للتعليم المدرسي في المركز الثاني، ونالت القيادة العامة لشرطة الشارقة جائزة المركز الأول لفئة المؤسسات والشراكات الداعمة للتعليم المتميز.\r\n\r\nوفي فئة الطالب المتميز كرم سمو نائب حاكم الشارقة عن الصف الثالث كل من نوال علي جواس وفايش فيك، فيما نال جائزة الصف الرابع كل من كريستينا راكان ونصر عبد المجيد، وحازتا نورة المشتغل النقبي ومريم الناعور النقبي على جائزة الصف الخامس، فيما نال عائشة حميد الخيال وغاية سعيد الأحبابي وموزة محمد الهوتي جائزة الصف السادس، وفاز فيشناف سانتوش وريقاف كريشنا بجائزة الصف السابع، وعن الصف الثامن حصد كل من ساشني مانيكاندان ويوفام تاكار الجائزة، ونال سيف حسن كرم وبيسان محمد فراس جائزة الصف التاسع، وحصد راشد عمر الهارش ومريم حمد الغفلي جائزة الصف العاشر، فيما ذهبت جائزة الصف الحادي عشر لعبد الله محمد رمضان وميشال فراز الهاشمي، كما نالت جائزة الصف الثاني عشر مريم حسن الشامسي، وفي فئة الطالب المتميز – الفئات الخاصة تم تكريم كل من ميثه محمد الحمودي، ونورة محمد الحمادي، وتاله أحمد الأعمر، وحمدان حميد الزحمي، ورضا إسماعيل ثابت.\r\n\r\nوكرم سموه فضيلة عبد الله الخوري بجائزة المركز الأول عن فئة ولي الأمر المتميز، فيما حلت في المركز الثاني أمل عبد الله المهيري، وفازت سمر خالد الشبلي بجائزة القائد التربوي المتميز، فيما توّجت نورة مبارك الحمادي بالمركز الأول، وهدى محمد ربيع بالمركز الثاني، وإيمان مصطفى محمد في المركز الثالث وعائشة خليفة الغفلي بالمركز الرابع لفئة المعلم المتميز.\r\n\r\nكما كرم سمو نائب حاكم الشارقة كل من مروة خميس اليماحي الفائزة بالمركز الأول، ومحمد محمد مخلوف في المركز الثاني، عن فئة الوظائف الداعمة المتميزة.\r\n\r\nوحصدت روضة ومدرسة أسماء للتعليم الأساسي جائزة المركز الأول لفئة المؤسسات التعليمية المتميزة، وذهبت جائزة المركز الأول عن فئة فرق العمل المؤسسية المتميزة لفريق عيادة ابتسامة الضاد اللغوية.\r\n\r\nومع نهاية الحفل، كرّم سمو الشيخ عبد الله بن سالم القاسمي قادة ومؤسسي الجائزة التي انطلقت في عام 1994، مثمناً جهودهم التي أرست القواعد للجائزة وساهمت في استمرارها حتى يومنا هذا، ملتقطين مع سموه والمكرمين الصورة التذكارية، كما التقط سموه صورة جماعية مع لجنة التحكيم وفرق العمل القائمة على الجائزة الذين ساهموا في دعم الطلبة والعاملين في القطاع التعليمي.\r\n\r\nشهد حفل التكريم بجانب سمو نائب حاكم الشارقة كل من الشيخ سالم بن عبد الرحمن القاسمي رئيس مكتب سمو الحاكم، وسيف الزري الشامسي قائد عام شرطة الشارقة، وسليمان بن سرحان الزعابي رئيس دائرة شؤون البلديات، وخالد بطي الهاجري مدير عام المدينة الجامعية، وعدد من كبار المسؤولين في القطاع التعليمي ورؤساء مجالس أولياء الأمور والمعلمين وطلبة المدارس.\r\n\r\nالمصدر: الشارقة 24 - محمد الحمادي", "عبدالله بن سالم يكرم الفائزين بجائزة الشارقة للتميز التربوي", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9079), null, 1, null, "His Highness Sheikh Abdullah bin Salem bin Sultan Al Qasimi, Deputy Ruler of Sharjah, this Wednesday morning, at Al Jawaher Center for Events and Conferences, honored the winners of the Sharjah Award for Educational Excellence in its 28th session, which is organized by the Sharjah Education Council.\r\n\r\nThe honoring ceremony began with the national anthem of the United Arab Emirates, followed by the recitation of clear verses from the Holy Quran, after which Dr. Saeed Musabah Al Kaabi, Chairman of the Sharjah Education Council, gave a speech in which he said: “I returned to the award archive, that beautiful archive, and I was struck by some pictures and live scenes, and most of all.” My attention was caught by a televised interview of His Highness the Ruler of Sharjah, as he spoke about the importance of the award and its role in promoting distinction and superiority, and a scene of outstanding students receiving their diplomas from His Highness, rejoicing in what God has given them of His bounty. I got to know some of these figures and they now hold several positions leading the renaissance of development and urbanization for this reason. The beautiful country\".\r\n\r\nDr. Saeed Musabah Al Kaabi added: “Years pass and generation after generation comes, standards and plans develop, in an effort to achieve the lofty vision set by His Highness the Ruler of Sharjah. The award has a deep history, with concepts firmly established in the minds and fields full of honorable examples, and we are certain that this generation will have It is a great matter in the future and they will continue the path of renaissance, for those who walk on the path of excellence do not stop, and the truth is that this is the sustainability that Sultan envisioned early on. Today we are reaping the fruit by honoring a new group of distinguished people.”\r\n\r\nRegarding the award in its current session, the Chairman of the Education Council indicated that it witnessed the launch of a new category, which is the “Jawhara Award,” saying: “The award in this session witnessed the launch of the Al-Jawhara Award within its categories, which is an exceptional honor for a distinguished personality with individual achievements and initiatives that have an effective impact in the field.” Educational, and contributed to the advancement and development of education to achieve the desired goals, and it is a role model for others in excellence, effort, and giving. It also witnessed a remarkable turnout, as the number of participants in the current session reached 1,328 participants, an increase of 40% over last year, of whom 38 participants won. On the other hand, Digital transformation initiatives were launched, as the award launched the smartphone application, and created new mechanisms for the electronic participant portal, starting from receiving applications through evaluation and arbitration processes, in addition to virtual courses and audio recording of all interpretive evidence for the categories.”\r\n\r\nAt the conclusion of his speech, Dr. Saeed Musabah Al Kaabi sent a message to the award winners in which he said: “May God grant us a nation and leaders who love excellence, creativity, and giving, who call for science and knowledge, and who always strive to meet and appreciate the distinguished in all forums, and the award is nothing but the best evidence of that, and I invite you to preserve the trust.” Carrying the banner of giving together to serve this dear country, I thank His Highness Sheikh Abdullah bin Salem Al Qasimi, Deputy Ruler of Sharjah, for his presence and honoring the ceremony. I also thank all attendees, wishing them good luck and success.”\r\n\r\nThe audience then watched a film titled “Sharjah Award for Educational Excellence: A Journey of Excellence, Development, and Creativity,” during which it discussed the award’s journey since its inception and the plans it adopted and contributed to the development of its stages over the years, in addition to the multiple categories of the award and the use of technology through the automation of submission and participation. To ensure easy access to all segments of society participating in the award.\r\n\r\nThe audience also watched a 3D presentation and a visual material titled “Makers of Excellence,” in which it touched on the efforts made by the candidates participating in the award and the support parents have for their students.\r\n\r\nHis Highness the Deputy Ruler of Sharjah kindly honored the winner of the exceptional award, “The Jewel Award,” which was won by Abdullah Awad Al Hamami, a visual impairment specialist at the Ministry of Education, and a certified trainer from the American Canadian Board. Al Hamami also holds a license with a chain of transmission connected to “the Prophet, may God bless him and grant him peace.” Reciting and reciting the Holy Qur’an with the narration of Hafs on the authority of Asim. Al-Hammami also founded a club for people with disabilities at Al Ain University and is considered one of the influential pioneers in the Arab world and has won many awards at the local and international levels.\r\n\r\nHis Highness also honored the Sharjah Private Education Authority, which won first place as the best educational body, while the Emirates Foundation for School Education came in second place, and the Sharjah Police General Command won the first place award for the category of institutions and partnerships that support distinguished education.\r\n\r\nIn the Outstanding Student category, His Highness the Deputy Ruler of Sharjah honored Nawal Ali Jawas and Vaish Feek for the third grade, while Christina Rakan and Nasr Abdul Majeed won the fourth grade award, and Noura Al Mushtagal Al Naqbi and Mariam Al Naour Al Naqbi won the fifth grade award, while Aisha Hamid Al Khayal won. Ghaya Saeed Al-Ahbabi and Moza Muhammad Al-Hooti won the sixth grade award, Vaishnav Santosh and Rikaf Krishna won the seventh grade award, Sashni Manikandan and Yuvam Thakkar won the eighth grade award, Saif Hassan Karam and Bisan Muhammad Firas won the ninth grade award, and Rashid Omar Al-Harsh and Maryam Hamad Al-Ghafli won the award. The tenth grade award, while the eleventh grade award went to Abdullah Muhammad Ramadan and Michel Faraz Al Hashemi, and the twelfth grade award went to Maryam Hassan Al Shamsi, and in the Outstanding Student category - Special Categories, Maitha Muhammad Al Hamoudi, Noura Muhammad Al Hammadi, and Talah Ahmed Al Ammar were honored. Hamdan Hamid Al-Zahmi, and Reda Ismail Thabet.\r\n\r\nHis Highness honored His Eminence Abdullah Al Khouri with the first place award for the Distinguished Parent category, while Amal Abdullah Al Muhairi came in second place, and Samar Khaled Al Shibli won the Distinguished Educational Leader Award, while Noura Mubarak Al Hammadi was crowned in first place, Hoda Muhammad Rabie in second place, and Iman Mustafa. Muhammad is in third place and Aisha Khalifa Al-Ghafli is in fourth place for the Distinguished Teacher category.\r\n\r\nHis Highness the Deputy Ruler of Sharjah also honored Marwa Khamis Al Yamahi, winner of first place, and Mohammed Mohammed Makhlouf in second place, in the Outstanding Support Jobs category.\r\n\r\nAsmaa Kindergarten and Basic Education School won the first place award for the Distinguished Educational Institutions category, and the first place award for the Distinguished Institutional Work Teams category went to the Smile Al-Dhad Language Clinic team.\r\n\r\nAt the end of the ceremony, His Highness Sheikh Abdullah bin Salem Al Qasimi honored the leaders and founders of the award that was launched in 1994, praising their efforts that laid the foundations for the award and contributed to its continuation to this day, taking a memorial photo with His Highness and the honorees. His Highness also took a group photo with the jury and teams. Award-based work who have contributed to supporting students and workers in the educational sector.\r\n\r\nThe honoring ceremony was witnessed alongside His Highness the Deputy Ruler of Sharjah, Sheikh Salem bin Abdul Rahman Al Qasimi, Head of the Office of His Highness the Ruler, Saif Al Zari Al Shamsi, Commander-in-Chief of Sharjah Police, Sulaiman bin Sarhan Al Zaabi, Head of the Municipalities Affairs Department, Khalid Butti Al Hajri, Director General of the University City, and a number of senior officials. In the educational sector and heads of parents’, teachers’ and school students’ councils.\r\n\r\nSource: Sharjah 24 - Muhammad Al Hammadi", "Abdullah bin Salem honors the winners of the Sharjah Award for Educational Excellence", "https://award-shj.ae/media/n1lb4exq/screenshot-2024-03-07-121511.png?anchor=center&mode=crop&width=593&height=338&rnd=133542874516370000", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "OurGoals",
                columns: new[] { "Id", "AboutAwardPageId", "ArabicGoal", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishGoal", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[] { 1, 1, "1- تطوير القطاع التربوي من خلال بث روح التنافس بينهم؛ لتحقيق أفضل الممارسات التربوية. 2- تطوير أعمال الجائزة ومنهجياتها، ورفع الكفايات المهنية للعاملين بها. 3- دعم الطلاب المتميزين في مختلف المجالات، وإكسابهم مهارات متنوعة ومتكاملة. 4- تبني منهجية مبتكرة لاستقطاب وبناء الشراكات الداعمة للجائزة والتعليم.", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8845), null, null, "1- Developing the educational sector by spreading the spirit of competition among them; To achieve best educational practices. 2- Developing the Award’s work and methodologies, and raising the professional competencies of its employees. 3- Supporting distinguished students in various fields, and providing them with diverse and integrated skills. 4- Adopting an innovative methodology to attract and build partnerships that support the award and education.", null, null, false });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "PermissionHeaderId", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6327), null, null, null, null, "عرض الدورات", 9, false },
                    { 2, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6336), null, null, null, null, "إضافة دورة", 9, false },
                    { 3, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6339), null, null, null, null, "عرض معلومات دورة", 9, false },
                    { 4, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6342), null, null, null, null, "تعديل دورة", 9, false },
                    { 5, new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6347), null, null, null, null, "حذف دورة", 9, false }
                });

            migrationBuilder.InsertData(
                table: "RelatedAccountRequests",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "ReceiverId", "SenderId", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7136), null, null, null, null, 1, 2, false },
                    { 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7143), null, null, null, null, 1, 3, false }
                });

            migrationBuilder.InsertData(
                table: "RelatedAccounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "User1Id", "User2Id", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7232), null, null, null, null, 1, 4, false },
                    { 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7238), null, null, null, null, 1, 5, false }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "RoleId", "UserId", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 5, 10, false },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 5, 11, false },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 5, 12, false },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 5, 13, false },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, 1, false },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, 2, false },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, 3, false },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, 4, false },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, 5, false },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2, 6, false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ArabicDescription", "ArabicName", "CategoryClassification", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationQualificationMark", "Icon", "LastModifiedAt", "LastModifiedBy", "MaximumAmountToObtainAStatement", "MaximumRequirementToObtainACertificate", "MinimumAmountToObtainAStatement", "MinimumRequirementToObtainACertificate", "MinimumWinningScore", "ParentId", "RelatedToClasses", "RelatedToEducationalEntities", "isDeleted" },
                values: new object[,]
                {
                    { 2, "جائزة رائدة استثنائيّة تتسابق فيها المدارس الحكومية والخاصة في رعاية اللغة العربية، وتمكين المجتمع المدرسيّ (طالب، معلم، ولي الأمر...) من امتلاك مهارات اللغة العربية وتوظيفها في العلم والحياة.", "جائزة جوهرة اللغة العربية", 0, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8488), null, 1, null, "It is an exceptional pioneering award where both public and private schools compete to promote the Arabic language, empower the school community students, teachers, and parents and equip them with the Arabic language skills that they can utilize in life and knowledge acquisition.", "The \"Gem\" of the Arabic Language", 4, 100f, "https://award-shj.ae/media/cb2igx0d/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%A7%D9%84%D8%AC%D9%88%D9%87%D8%B1%D8%A9.png", null, null, 60, 80, 50, 65, 90, 1, false, null, false },
                    { 4, "تشمل جميع القيادات التّربويّة في القطاعين الحكوميّ والخاص من فئة القيادات العليا والقيادات الوسطى.\r\n\r\nتشمل القيادة العليا (مدير مدرسة).\r\nتشمل القيادة الوسطى (مساعد مدير أكاديمي، رئيس وحدة الشؤون الأكاديمية، رئيس وحدة شؤون الطلبة، رئيس وحدة الخدمات).", "فئة القائد التربوي المتميز", 0, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8508), null, 1, null, "This category consists of all educational leaders in the public and private sectors including senior leaders and middle leaders.\r\n\r\n- Senior leadership includes school principal.\r\n\r\n- Middle leadership includes Assistant Academic Principal, Head of Academic Affairs Unit, Head of Student Affairs Unit, Head of Services Unit.", "Distinguished Educational Leader Category", 3, 100f, "https://award-shj.ae/media/iqzhrizm/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%82%D8%A7%D8%A6%D8%AF-%D8%A7%D9%84%D8%AA%D8%B1%D8%A8%D9%88%D9%8A-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2.png", null, null, 60, 80, 50, 65, 90, 3, false, null, false },
                    { 5, "المعلم هو المحرك الأساسي لعملية التعليم والتعلم، فبمقدار جودة عطائه ترتقي العملية التعليمية، وخاصة مع المتغيرات الحديثة التي تقتضي من المعلم مواكبتها، لينتج التعليم ثماره المرجوة، ويمتزج بعصر المعرفة والثورات التكنولوجية، ويصبح جزءاً فاعلًا في الحياة والاقتصاد، وتهتم الجائزة بهذه الفئة وتأهيلها ليثبت المعلم المشارك إنجازه وقيادته الفاعلة، وتطوّره المهنيّ، ويبرهن على إبداعه وابتكاراته الوظيفيّة ومسؤولياته المجتمعيّة، ويحق لجميع المعلمين من مرحلة رياض الأطفال إلى الصف الثاني عشر ومن ذوي التّخصصات المختلفة في التعليم الحكومي والخاص والفنّي والتكنولوجي الترشح لهذه الفئة.", "فئة المعلم المتميز", 0, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8518), null, 1, null, "The teacher is the main guide of the teaching and learning process as the quality of his/her input elevates the educational process, especially with the new changes and the technological revolution that require teachers to keep up with in order to achieve the desired results in life and economy. The Sharjah Award for Educational Excellence acknowledges this category and requires participant teachers to underscore their distinguished performance, effective leadership, professional development, creativity and innovation in the job, and social responsibility. All teachers from kindergarten to the twelfth grade with various specializations in public, private, and applied technology schools are eligible to nominate for this category.", "Distinguished Teacher Category", 4, 100f, "https://award-shj.ae/media/5kbhcktn/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%B9%D9%84%D9%85-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2.png", null, null, 60, 80, 50, 65, 90, 3, false, null, false },
                    { 7, "تحرص الحكومة الرشيدة في دولة الامارات العربية المتحدة على جودة الخدمات المقدمة للطفل باعتباره اللبنة الأولى في بناء المجتمع وتلقينه الدروس الأولى للانطلاق إلى فضاء الحياة مسلحاً بالقيم والسلوكيات الإيجابية ومتمكنا من المهارات الأساسية الأولى لذا فقد أفردت الجائزة لهذه الفئة مجالًا لإبراز تميزها في مجال تطوير الأدوات وبيئة العمل وتقديم الخدمات المتميزة للعاملين فيها، وللطلبة ولأولياء الأمور، وللمجتمع ككل، ويحق لجميع الحضانات الحكومية والخاصة على مستوى دولة الإمارات التّقدّم للجائزة وفق معايير مخصّصة وضمن شروط محدّدة.", "فئة الحضانة المتميزة", 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8533), null, 1, null, "The rational government in the United Arab Emirates accentuates the quality of the services provided to the children as they are the first building block of the society and emphasizes on preparing them for life, equipping them with values and positive behavior, and mastering the key basic skills. Therefore, the Sharjah Award has devoted space to this category to highlight its excellence in developing the tools and work environment and providing distinguished services to its staff, students, parents, and the community. All nurseries at the UAE level are eligible to apply for the award according to specific criteria and conditions.", "Distinguished Nursery Category", 4, 100f, "https://award-shj.ae/media/ceihv5g3/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%A4%D8%B3%D8%B3%D8%A7%D8%AA-%D8%A7%D9%84%D8%AA%D8%B9%D9%84%D9%8A%D9%85%D9%8A%D8%A9-%D8%A7%D9%84%D8%AD%D8%B6%D8%A7%D9%86%D8%A9-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2%D8%A9.png", null, null, 60, 80, 50, 65, 90, 6, false, null, false },
                    { 8, "تسهم المدرسة الفاعلة في معالجة مشكلات المجتمع ومساعدته على التطوير؛ وتقوم بدور طليعي في خدمته، وتعمل على تعزيز الصلة والتلاحم بين أفراده وتوجيه التربية وجهة عملية تتصل بواقع الحياة ، وتدريب الطلاب على التنظيم والتخطيط والعمل الجماعي لذا حظيت المدرسة المتميزة على جل اهتمام القائمين على الجائزة وخصصوا لها فئة لتحدد المدارس المشاركة من خلالها قدرتها الفائقة على قيادة التعليم والتعلم والأمن والسلامة وتحقيق جودة الحياة لطلابها، ويحق لجميع المدارس الحكومية و الخاصة على مستوى دولة الإمارات التّقدّم للجائزة وفق معايير مخصّصة وضمن شروط محدّدة.", "فئة المدرسة المتميزة", 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8543), null, 1, null, "An effective school contributes to developing the community and addressing its problems. It plays a key role in serving the community, strengthening the links and relations between its members, directing education to address real life, as well as training the students on organization, planning and teamwork. The Sharjah Award paid special attention to this category through providing schools with opportunities to demonstrate their abilities in leading teaching and learning, security and safety as well as wellbeing for its students. All public and private schools in the UAE are eligible to apply for the award according to specific criteria and conditions.", "Distinguished School Category", 4, 100f, "https://award-shj.ae/media/1dlpga1u/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%A4%D8%B3%D8%B3%D8%A7%D8%AA-%D8%A7%D9%84%D8%AA%D8%B9%D9%84%D9%8A%D9%85%D9%8A%D8%A9-%D8%A7%D9%84%D9%85%D8%AF%D8%B1%D8%B3%D8%A9-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2%D8%A9.png", null, null, 60, 80, 50, 65, 90, 6, false, null, false }
                });

            migrationBuilder.InsertData(
                table: "DynamicAttributes",
                columns: new[] { "Id", "ArabicLabel", "ArabicPlaceHolder", "ArabicTitle", "AttributeDataTypeId", "CreatedAt", "CreatedBy", "DeletedAt", "DynamicAttributeSectionId", "EnglishLabel", "EnglishPlaceHolder", "EnglishTitle", "IsRequired", "IsUnique", "LastModifiedAt", "LastModifiedBy", "LinkedToAnotherAttribute", "MaxSizeInKB", "OrderId", "Status", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار نص 1", "اختبار نص 1", "اختبار نص 1", 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7424), null, null, 1, "Test Text 1", "Test Text 1", "Test Text 1", true, true, null, null, false, null, 1, 0, false },
                    { 2, "اختبار ايميل 1", "اختبار ايميل 1", "اختبار ايميل 1", 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7436), null, null, 1, "Test Email 1", "Test Email 1", "Test Email 1", true, true, null, null, false, null, 2, 0, false },
                    { 3, "اختبار صورة 1", "اختبار صورة 1", "اختبار صورة 1", 3, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7441), null, null, 1, "Test Image 1", "Test Image 1", "Test Image 1", false, false, null, null, false, 1028, 3, 0, false },
                    { 4, "اختبار ملف 1", "اختبار ملف 1", "اختبار ملف 1", 4, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7447), null, null, 1, "Test File 1", "Test File 1", "Test File 1", false, false, null, null, false, 4112, 4, 0, false },
                    { 5, "اختبار رقم متحرك 1", "اختبار رقم متحرك 1", "اختبار رقم متحرك 1", 5, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7452), null, null, 1, "Test Phone Number 1", "Test Phone Number 1", "Test Phone Number 1", false, false, null, null, false, null, 5, 0, false },
                    { 6, "اختبار رقم 1", "اختبار رقم 1", "اختبار رقم 1", 6, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7461), null, null, 1, "Test Number 1", "Test Number 1", "Test Number 1", false, false, null, null, false, null, 6, 0, false },
                    { 7, "اختبار تاريخ 1", "اختبار تاريخ 1", "اختبار تاريخ 1", 7, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7466), null, null, 1, "Test Date 1", "Test Date 1", "Test Date 1", false, false, null, null, false, null, 7, 0, false },
                    { 8, "اختبار قائمة 1", "اختبار قائمة 1", "اختبار قائمة 1", 8, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7471), null, null, 1, "Test List 1", "Test List 1", "Test List 1", false, false, null, null, false, null, 8, 0, false }
                });

            migrationBuilder.InsertData(
                table: "InstitutionCoordinators",
                columns: new[] { "Id", "CoordinatorId", "CreatedAt", "CreatedBy", "DeletedAt", "EducationalInstitutionId", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6296), null, null, 1, null, null, false },
                    { 2, 11, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6303), null, null, 1, null, null, false },
                    { 3, 12, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6306), null, null, 2, null, null, false },
                    { 4, 13, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6310), null, null, 2, null, null, false }
                });

            migrationBuilder.InsertData(
                table: "ArbitrationScales",
                columns: new[] { "Id", "ArabicTitle", "CategoryId", "CreatedAt", "CreatedBy", "DegreeScale", "DeletedAt", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[] { 1, "النماذج والأدلة", 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9812), null, "0 - 100", null, "Forms and evidence", null, null, false });

            migrationBuilder.InsertData(
                table: "CategoryFAQs",
                columns: new[] { "Id", "ArabicFile", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishFile", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9177), null, null, "https://award-shj.ae/media/ffgjcmvp/the-gem-of-the-arabic-language-award-30.pdf", null, null, false },
                    { 2, "https://award-shj.ae/media/i2flqxw5/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%82%D8%A7%D8%A6%D8%AF-%D8%A7%D9%84%D8%AA%D8%B1%D8%A8%D9%88%D9%8A-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2-%D8%A7%D9%84%D9%82%D9%8A%D8%A7%D8%AF%D8%A9-%D8%A7%D9%84%D8%B9%D9%84%D9%8A%D8%A7-30.pdf", 4, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9181), null, null, "https://award-shj.ae/media/tlrb5gxb/distinguished-educational-leader-category-senior-leadership-30.pdf", null, null, false },
                    { 3, "https://award-shj.ae/media/kovhdfgh/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%B9%D9%84%D9%85-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2-30.pdf", 5, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9185), null, null, "https://award-shj.ae/media/1n5b35ld/distinguished-teacher-category-30.pdf", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Criterions",
                columns: new[] { "Id", "ArabicTitle", "ArbitrationProcedureId", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "MaxAttachmentNumber", "OrderId", "ParentId", "Score", "SizeOfAttachmentInKB", "isDeleted" },
                values: new object[] { 1, "الأداء والإنجازات المؤثرة", null, 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9583), null, null, "Influential performance and achievements", null, null, null, 1, null, 500, 0, false });

            migrationBuilder.InsertData(
                table: "DynamicAttributeListValues",
                columns: new[] { "Id", "ArabicValue", "CreatedAt", "CreatedBy", "DeletedAt", "DynamicAttributeId", "EnglishValue", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "Test Value 1", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7565), null, null, 8, "Test Value 1", null, null, false },
                    { 2, "Test Value 2", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7571), null, null, 8, "Test Value 2", null, null, false },
                    { 3, "Test Value 3", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7574), null, null, 8, "Test Value 3", null, null, false },
                    { 4, "Test Value 4", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7578), null, null, 8, "Test Value 4", null, null, false },
                    { 5, "Test Value 5", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7582), null, null, 8, "Test Value 5", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "ExplanatoryGuides",
                columns: new[] { "Id", "ArabicFilePath", "ArabicTitle", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishFilePath", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "الدليل التفسيري", 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9270), null, null, "https://award-shj.ae/media/ffgjcmvp/the-gem-of-the-arabic-language-award-30.pdf", "Explanatory Guide", null, null, false },
                    { 2, "https://award-shj.ae/media/i2flqxw5/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%82%D8%A7%D8%A6%D8%AF-%D8%A7%D9%84%D8%AA%D8%B1%D8%A8%D9%88%D9%8A-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2-%D8%A7%D9%84%D9%82%D9%8A%D8%A7%D8%AF%D8%A9-%D8%A7%D9%84%D8%B9%D9%84%D9%8A%D8%A7-30.pdf", "الدليل التفسيري", 4, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9275), null, null, "https://award-shj.ae/media/tlrb5gxb/distinguished-educational-leader-category-senior-leadership-30.pdf", "Explanatory Guide", null, null, false },
                    { 3, "https://award-shj.ae/media/kovhdfgh/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%B9%D9%84%D9%85-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2-30.pdf", "الدليل التفسيري", 5, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9279), null, null, "https://award-shj.ae/media/1n5b35ld/distinguished-teacher-category-30.pdf", "Explanatory Guide", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "FrequentlyAskedQuestions",
                columns: new[] { "Id", "ArabicAnswer", "ArabicQuestion", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishAnswer", "EnglishQuestion", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\n\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة.", "كيف يمكنني المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟", 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9367), null, null, "You can participate in the award by following the following steps:\r\n\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria.", "How can I participate in the Sharjah Award for Educational Excellence and Excellence?", null, null, false },
                    { 2, "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\n\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة.", "كيف يمكنني المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟", 4, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9374), null, null, "You can participate in the award by following the following steps:\r\n\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria.", "How can I participate in the Sharjah Award for Educational Excellence and Excellence?", null, null, false },
                    { 3, "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\n\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة.", "كيف يمكنني المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟", 5, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9378), null, null, "You can participate in the award by following the following steps:\r\n\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria.", "How can I participate in the Sharjah Award for Educational Excellence and Excellence?", null, null, false },
                    { 4, "تنقسم شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي إلى قسمين:\r\n\r\nالشروط العامة: وهي شروط تنطبق على جميع فئات الجائزة.\r\nالشروط الخاصة: وهي شروط محددة لفئة معينة من فئات الجائزة.\r\n\r\nللاطلاع على الشروط العامة والخاصة لفئات الجائزة، الرجاء اتباع الخطوات التالية:\r\n\r\nالدخول إلى صفحة فئات الجائزة من القائمة الرئيسية للموقع.\r\nالنقر على \"تحميل الدليل التفسيري للفئة\" وذلك للفئة التي ترغب بالاطلاع عليها.\r\nمن خلال الدليل التفسيري يمكنك الاطلاع على الشروط العامة والخاصة للفئة.", "ما هي شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟", 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9382), null, null, "The conditions for participation in the Sharjah Award for Excellence and Educational Excellence are divided into two parts:\r\n\r\nGeneral conditions: These are conditions that apply to all categories of the award.\r\nSpecial Conditions: These are specific conditions for a specific award category.\r\n\r\nTo view the general and specific conditions for the award categories, please follow the following steps:\r\n\r\nAccess the award categories page from the main menu of the website.\r\nClick on “Download the category interpretive guide” for the category you wish to view.\r\nThrough the interpretive guide you can view the general and special conditions of the category.", "What are the conditions for participation in the Sharjah Award for Excellence and Educational Excellence?", null, null, false },
                    { 5, "تنقسم شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي إلى قسمين:\r\n\r\nالشروط العامة: وهي شروط تنطبق على جميع فئات الجائزة.\r\nالشروط الخاصة: وهي شروط محددة لفئة معينة من فئات الجائزة.\r\n\r\nللاطلاع على الشروط العامة والخاصة لفئات الجائزة، الرجاء اتباع الخطوات التالية:\r\n\r\nالدخول إلى صفحة فئات الجائزة من القائمة الرئيسية للموقع.\r\nالنقر على \"تحميل الدليل التفسيري للفئة\" وذلك للفئة التي ترغب بالاطلاع عليها.\r\nمن خلال الدليل التفسيري يمكنك الاطلاع على الشروط العامة والخاصة للفئة.", "ما هي شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟", 4, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9386), null, null, "The conditions for participation in the Sharjah Award for Excellence and Educational Excellence are divided into two parts:\r\n\r\nGeneral conditions: These are conditions that apply to all categories of the award.\r\nSpecial Conditions: These are specific conditions for a specific award category.\r\n\r\nTo view the general and specific conditions for the award categories, please follow the following steps:\r\n\r\nAccess the award categories page from the main menu of the website.\r\nClick on “Download the category interpretive guide” for the category you wish to view.\r\nThrough the interpretive guide you can view the general and special conditions of the category.", "What are the conditions for participation in the Sharjah Award for Excellence and Educational Excellence?", null, null, false },
                    { 6, "تنقسم شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي إلى قسمين:\r\n\r\nالشروط العامة: وهي شروط تنطبق على جميع فئات الجائزة.\r\nالشروط الخاصة: وهي شروط محددة لفئة معينة من فئات الجائزة.\r\n\r\nللاطلاع على الشروط العامة والخاصة لفئات الجائزة، الرجاء اتباع الخطوات التالية:\r\n\r\nالدخول إلى صفحة فئات الجائزة من القائمة الرئيسية للموقع.\r\nالنقر على \"تحميل الدليل التفسيري للفئة\" وذلك للفئة التي ترغب بالاطلاع عليها.\r\nمن خلال الدليل التفسيري يمكنك الاطلاع على الشروط العامة والخاصة للفئة.", "ما هي شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟", 5, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9390), null, null, "The conditions for participation in the Sharjah Award for Excellence and Educational Excellence are divided into two parts:\r\n\r\nGeneral conditions: These are conditions that apply to all categories of the award.\r\nSpecial Conditions: These are specific conditions for a specific award category.\r\n\r\nTo view the general and specific conditions for the award categories, please follow the following steps:\r\n\r\nAccess the award categories page from the main menu of the website.\r\nClick on “Download the category interpretive guide” for the category you wish to view.\r\nThrough the interpretive guide you can view the general and special conditions of the category.", "What are the conditions for participation in the Sharjah Award for Excellence and Educational Excellence?", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "TermsAndConditions",
                columns: new[] { "Id", "ArabicDescription", "ArabicTitle", "AttachmentType", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishDescription", "EnglishTitle", "IsAgree", "LastModifiedAt", "LastModifiedBy", "NeedAttachment", "RequiredAttachmentNumber", "SizeOfAttachmentInKB", "isDeleted" },
                values: new object[,]
                {
                    { 1, "يحق لجميع المدارس الحكومية والخاصة في الميدان التربوي في دولة الإمارات العربية المتحدة التقدم للمشاركة في الجائزة.\r\n- إرفاق أدلة توضح جهود المدرسة في رعاية اللغة العربية لثلاثة أعوام سابقة لعام الترشح, ويلغى طلب الترشح أو الفوز في حال ثبوت عدم صحة أحد الأدلة أو الوثائق المقدمة.\r\n- المشاركات جماعية وباسم المدرسة ولا تقبل المشاركات الفردية.\r\n- تقدم المدرسة رسالة مصدقة من الجهة المختصة بعدم وجود مخالفات إدارية ومالية عن اخر 3 سنوات سابقة لعام الترشح.\r\n- ترفق نسخة الهيكل التنظيمي للمدرسة و التوصيف الوظيفي لجميع الوظائف فيها.", "الشروط العامة للمشاركة", null, 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9484), null, null, "All public and private schools in the educational field in the United Arab Emirates are eligible to apply to participate in the award.\r\n- Attach evidence explaining the school’s efforts in sponsoring the Arabic language for three years prior to the year of candidacy. The application for candidacy or winning will be canceled if any of the evidence or documents submitted is proven incorrect.\r\n- Participations are group and in the name of the school. Individual entries are not accepted.\r\n- The school submits a certified letter from the competent authority stating that there are no administrative and financial violations for the last 3 years preceding the year of candidacy.\r\nA copy of the school’s organizational structure and job descriptions for all positions are attached.", "General conditions for participation", false, null, null, false, null, null, false },
                    { 2, "يحق لجميع المدارس الحكومية والخاصة في الميدان التربوي في دولة الإمارات العربية المتحدة التقدم للمشاركة في الجائزة.\r\n- إرفاق أدلة توضح جهود المدرسة في رعاية اللغة العربية لثلاثة أعوام سابقة لعام الترشح, ويلغى طلب الترشح أو الفوز في حال ثبوت عدم صحة أحد الأدلة أو الوثائق المقدمة.\r\n- المشاركات جماعية وباسم المدرسة ولا تقبل المشاركات الفردية.\r\n- تقدم المدرسة رسالة مصدقة من الجهة المختصة بعدم وجود مخالفات إدارية ومالية عن اخر 3 سنوات سابقة لعام الترشح.\r\n- ترفق نسخة الهيكل التنظيمي للمدرسة و التوصيف الوظيفي لجميع الوظائف فيها.", "الشروط العامة للمشاركة", null, 4, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9493), null, null, "All public and private schools in the educational field in the United Arab Emirates are eligible to apply to participate in the award.\r\n- Attach evidence explaining the school’s efforts in sponsoring the Arabic language for three years prior to the year of candidacy. The application for candidacy or winning will be canceled if any of the evidence or documents submitted is proven incorrect.\r\n- Participations are group and in the name of the school. Individual entries are not accepted.\r\n- The school submits a certified letter from the competent authority stating that there are no administrative and financial violations for the last 3 years preceding the year of candidacy.\r\nA copy of the school’s organizational structure and job descriptions for all positions are attached.", "General conditions for participation", false, null, null, false, null, null, false },
                    { 3, "يحق لجميع المدارس الحكومية والخاصة في الميدان التربوي في دولة الإمارات العربية المتحدة التقدم للمشاركة في الجائزة.\r\n- إرفاق أدلة توضح جهود المدرسة في رعاية اللغة العربية لثلاثة أعوام سابقة لعام الترشح, ويلغى طلب الترشح أو الفوز في حال ثبوت عدم صحة أحد الأدلة أو الوثائق المقدمة.\r\n- المشاركات جماعية وباسم المدرسة ولا تقبل المشاركات الفردية.\r\n- تقدم المدرسة رسالة مصدقة من الجهة المختصة بعدم وجود مخالفات إدارية ومالية عن اخر 3 سنوات سابقة لعام الترشح.\r\n- ترفق نسخة الهيكل التنظيمي للمدرسة و التوصيف الوظيفي لجميع الوظائف فيها.", "الشروط العامة للمشاركة", null, 5, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9498), null, null, "All public and private schools in the educational field in the United Arab Emirates are eligible to apply to participate in the award.\r\n- Attach evidence explaining the school’s efforts in sponsoring the Arabic language for three years prior to the year of candidacy. The application for candidacy or winning will be canceled if any of the evidence or documents submitted is proven incorrect.\r\n- Participations are group and in the name of the school. Individual entries are not accepted.\r\n- The school submits a certified letter from the competent authority stating that there are no administrative and financial violations for the last 3 years preceding the year of candidacy.\r\nA copy of the school’s organizational structure and job descriptions for all positions are attached.", "General conditions for participation", false, null, null, false, null, null, false }
                });

            migrationBuilder.InsertData(
                table: "TrainingWorkshops",
                columns: new[] { "Id", "ArabicDescription", "ArabicTitle", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishDescription", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "Thumbnail", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار وصف ورشة تدريبية 1", "اختبار عنوان ورشة تدريبية 1", 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5358), null, null, "Test Training Workshop Description 1", "Test Training Workshop Title 1", null, null, "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg", false },
                    { 2, "اختبار وصف ورشة تدريبية 2", "اختبار عنوان ورشة تدريبية 2", 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5369), null, null, "Test Training Workshop Description 2", "Test Training Workshop Title 2", null, null, "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg", false }
                });

            migrationBuilder.InsertData(
                table: "Criterions",
                columns: new[] { "Id", "ArabicTitle", "ArbitrationProcedureId", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "MaxAttachmentNumber", "OrderId", "ParentId", "Score", "SizeOfAttachmentInKB", "isDeleted" },
                values: new object[,]
                {
                    { 2, "جودة الأداء والإنجازات والمبادرات المؤثرة التي تبنتها المدرسة", null, 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9589), null, null, "The quality of performance, achievements and influential initiatives adopted by the school", null, null, null, 1, 1, 300, 5000, false },
                    { 3, "أثر الإنجازات والمبادرات في المجتمع المدرسي والمحلي، والقيمة المضافة لها", null, 2, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9593), null, null, "The impact of achievements and initiatives in the school and local community, and their added value", null, null, null, 2, 1, 200, 5000, false }
                });

            migrationBuilder.InsertData(
                table: "CriterionItems",
                columns: new[] { "Id", "ActualScore", "ArabicName", "CreatedAt", "CreatedBy", "CriterionId", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "MaxAttachmentNumber", "OrderId", "Score", "SizeOfAttachmentInKB", "isDeleted" },
                values: new object[,]
                {
                    { 1, 40, "التخطيط الاستراتيجي للمشاريع والمبادرات التي تخدم اللغة العربية", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9687), null, 2, null, "Strategic planning for projects and initiatives that serve the Arabic language", null, null, 0, 1, 40, 5000, false },
                    { 2, 120, "دعم المهارات اللغوية لدى جميع فئات الطلاب", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9694), null, 2, null, "Supporting language skills for all categories of students", null, null, 0, 2, 120, 5000, false },
                    { 3, 60, "قيادة تنمية الكفايات اللغوية للمجتمع المدرسي", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9698), null, 2, null, "Leading the development of the language competencies of the school community", null, null, 0, 3, 60, 5000, false },
                    { 4, 60, "إدارة رأس المال البشري والموارد بما يخدم اللغة العربية", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9702), null, 2, null, "Managing human capital and resources to serve the Arabic language", null, null, 0, 4, 60, 5000, false },
                    { 5, 40, "قيادة الأداء المؤسسي بما يثري المدرسة بنتاجات أدبية", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9706), null, 2, null, "Leading institutional performance to enrich the school with literary productions", null, null, 0, 5, 40, 5000, false },
                    { 6, 150, "إتقان المجتمع المدرسي لمهارات اللغة العربية تواصلاً وقراءةً وإبداعاً", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9712), null, 3, null, "The school community masters the Arabic language skills in communication, reading, and creativity", null, null, 0, 1, 150, 5000, false },
                    { 7, 50, "نشر ثقافة الاعتزاز باللغة العربية في المجتمع المدرسي والمحلي", new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9717), null, 3, null, "Spreading a culture of pride in the Arabic language in the school and local community", null, null, 0, 2, 50, 5000, false }
                });

            migrationBuilder.InsertData(
                table: "ArbitrationScalesCriterions",
                columns: new[] { "Id", "ArabicDescription", "ArbitrationScaleId", "CreatedAt", "CreatedBy", "CriterionId", "CriterionItemId", "DeletedAt", "EnglishDescription", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "نماذج للخطط المتعلقة بالمشاريع والمبادرات التي تخطط لها مكتملة العناصر عناصر الخطة لكل مشروع ومبادرة ونشاط يخدم اللغة العربية)، مع مراعاة أن تتضمن خطة المدرسة التشغيلية خطط مشاريع ومبادرات رعاية اللغة العربية.", 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9876), null, 2, 1, null, "Models of plans related to the projects and initiatives that you are planning, with complete elements (plan elements for each project, initiative, and activity that serves the Arabic language), taking into account that the school’s operational plan includes plans for projects and initiatives to support the Arabic language.", null, null, false },
                    { 2, "إرفاق أدلة مختلفة على ما تقوم به من خطط، أو أنشطة، أو برامج ، أو مشروعات مختلفة تمكن الطلاب من مهارات اللغة المختلفة.\r\nمدى تقدم الطلاب في المهارات وتمكنهم منها.\r\n- تحديد أدوات المتابعة والقياس التي تم توظيفها، مع مراعاة أن تشمل جميع فئات الطلاب الموهوبين، الفائقون، أصحاب الهمم،\r\nطلاب متدنو المستوى الطلاب كافة . بجميع المستويات).", 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9887), null, 2, 2, null, "Attach various evidence of the different plans, activities, programs, or projects you are undertaking that enable students with different language skills.\r\nThe extent of students’ progress in skills and their mastery of them.\r\n- Determine the monitoring and measurement tools that have been employed, taking into account that they include all categories of gifted students, exceptional students, people of determination,\r\nLow level students All students. at all levels).", null, null, false },
                    { 3, "- الخطط والبرامج والمشروعات والأنشطة التي نفذتها المدرسة وأثرها في رفع الكفايات اللغوية للمجتمع المدرسي المعلم سواء معلم\r\nاللغة العربية أو المواد المختلفة ، الوظائف المختلفة في المدرسة مثل مصادر التعلم والوظائف الداعمة ، الإداريون بمختلف أدوارهم، ولي\r\nالأمر).\r\n- الإحصائيات والأرقام و\r\nالمقارنات التي تبين التطور في الكفايات اللغوية للمجتمع المدرسي", 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9890), null, 2, 3, null, "- The plans, programmes, projects and activities implemented by the school and their impact in raising the linguistic competencies of the school community, whether teachers\r\nThe Arabic language or various subjects, various functions in the school such as learning resources and supporting functions, administrators in their various roles, and...\r\ncommand).\r\n- Statistics, numbers and\r\nComparisons that show the development in the linguistic competencies of the school community", null, null, false },
                    { 4, ". جودة توظيف الكوادر البشرية والموارد المختلفة في رعاية اللغة العربية وتمكين المجتمع المدرسي منها.\r\nخطط المدرسة والمنفذة مع معلمو اللغة العربية معلمو المواد الأخرى الطلاب ولي الأمر بما يخدم اللغة العربية.\r\n- توظيف الموارد المختلفة مثل مصادر التعلم والمختبرات والنوادي والمرافق المختلفة في خدمة اللغة العربية.", 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9895), null, 2, 4, null, ". The quality of employing human cadres and various resources in nurturing the Arabic language and empowering the school community with it.\r\nSchool plans implemented with Arabic language teachers, teachers of other subjects, students, and guardians to serve the Arabic language.\r\n- Employing various resources such as learning resources, laboratories, clubs and various facilities in serving the Arabic language.", null, null, false },
                    { 5, "المشاركة في عضويات ولجان أدبية، أو مؤسسات وروابط أدبية مثل اتحاد كتاب وأدباء الإمارات أو جمعية حماية اللغة العربية  أو مجمع اللغة العربية والتي تنعكس إيجابيا في رفع مستوى الكفايات اللغوية للطلاب والمعلمين وغيرهم في المجتمع المدرسي", 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9898), null, 2, 5, null, "Participation in memberships and literary committees, or literary institutions and associations such as the Emirates Writers and Writers Union, the Society for the Protection of the Arabic Language, or the Arabic Language Academy, which is reflected positively in raising the level of linguistic competencies of students, teachers, and others in the school community.", null, null, false },
                    { 6, "- نتائج الطلاب في الاختبارات المختلفة (المركزية الوطنية، الدولية).\r\n- تقارير لجان الجودة والرقابة والمتابعة ولجان الدعم الأكاديمي.\r\n- مشاركة المجتمع المدرسي في الفعاليات والمسابقات والمبادرات والأنشطة اللغوية والأدبية المختلفة وعلى جميع المستويات\r\nوحصولهم على مراكز متقدمة.", 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9903), null, 3, 6, null, "- Students’ results in various tests (central, national, international).\r\n- Reports of the quality, oversight and follow-up committees and academic support committees.\r\n- Participation of the school community in various events, competitions, initiatives, and linguistic and literary activities at all levels\r\nAnd they achieved advanced positions.", null, null, false },
                    { 7, "رصد الممارسات والانشطة التي تدل على نشر وتأصيل اعتزاز المجتمع المدرسي بلغته العربية على مستوى المدرسة، والمجتمع المحلي\r\nوالدولي، والعالمي.\r\n- رصد الممارسات والبرامج والفعاليات والأنشطة التي تتبناها لأجل تأصيل حب اللغة العربية في المجتمع المدرسي تواصلاً وإبداعاً.", 1, new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9907), null, 3, 7, null, "Monitoring practices and activities that demonstrate the dissemination and consolidation of the school community’s pride in its Arabic language at the school and local community levels\r\nInternational, and global.\r\n- Monitoring the practices, programmes, events and activities it adopts in order to establish the love of the Arabic language in the school community through communication and creativity.", null, null, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_UserId",
                table: "Achievements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderGeneralValidations_AdvancedFormBuilderId",
                table: "AdvancedFormBuilderGeneralValidations",
                column: "AdvancedFormBuilderId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderGeneralValidations_AttributeOperationId",
                table: "AdvancedFormBuilderGeneralValidations",
                column: "AttributeOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderListValues_AdvancedFormBuilderId",
                table: "AdvancedFormBuilderListValues",
                column: "AdvancedFormBuilderId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderPatternValues_AdvancedFormBuilderPatternId",
                table: "AdvancedFormBuilderPatternValues",
                column: "AdvancedFormBuilderPatternId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilders_AdvancedFormBuilderSectionId",
                table: "AdvancedFormBuilders",
                column: "AdvancedFormBuilderSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilders_AttributeDataTypeId",
                table: "AdvancedFormBuilders",
                column: "AttributeDataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderSections_VirtualTableForSectionId",
                table: "AdvancedFormBuilderSections",
                column: "VirtualTableForSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderTableValues_AdvancedFormBuilderId",
                table: "AdvancedFormBuilderTableValues",
                column: "AdvancedFormBuilderId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderTableValues_VirtualTableId",
                table: "AdvancedFormBuilderTableValues",
                column: "VirtualTableId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderValues_AdvancedFormBuilderId",
                table: "AdvancedFormBuilderValues",
                column: "AdvancedFormBuilderId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderValues_VirtualTableId",
                table: "AdvancedFormBuilderValues",
                column: "VirtualTableId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_CycleId",
                table: "Agendas",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_CycleId",
                table: "Albums",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationProcedure_CreatedById",
                table: "ArbitrationProcedure",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationProcedure_UpdatedById",
                table: "ArbitrationProcedure",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationResults_ProvidedFormId",
                table: "ArbitrationResults",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Arbitrations_ArbitratorId",
                table: "Arbitrations",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Arbitrations_ProvidedFormId",
                table: "Arbitrations",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationScales_CategoryId",
                table: "ArbitrationScales",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationScalesCriterions_ArbitrationScaleId",
                table: "ArbitrationScalesCriterions",
                column: "ArbitrationScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationScalesCriterions_CriterionId",
                table: "ArbitrationScalesCriterions",
                column: "CriterionId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationScalesCriterions_CriterionItemId",
                table: "ArbitrationScalesCriterions",
                column: "CriterionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorClasses_ArbitratorId",
                table: "ArbitratorClasses",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorClasses_EducationalClassId",
                table: "ArbitratorClasses",
                column: "EducationalClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorForms_ArbitratorId",
                table: "ArbitratorForms",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorForms_ProvidedFormId",
                table: "ArbitratorForms",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_AwardPublications_CycleId",
                table: "AwardPublications",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_AwardStatistics_CycleId",
                table: "AwardStatistics",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CycleId",
                table: "Categories",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesArbitrators_ArbitratorId",
                table: "CategoriesArbitrators",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesArbitrators_CategoryId",
                table: "CategoriesArbitrators",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCommittees_CategoryId",
                table: "CategoryCommittees",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCommittees_CommitteeId",
                table: "CategoryCommittees",
                column: "CommitteeId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEducationalClasses_CategoryId",
                table: "CategoryEducationalClasses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEducationalClasses_EducationalClassId",
                table: "CategoryEducationalClasses",
                column: "EducationalClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEducationalEntities_CategoryId",
                table: "CategoryEducationalEntities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEducationalEntities_EducationalEntityId",
                table: "CategoryEducationalEntities",
                column: "EducationalEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFAQs_CategoryId",
                table: "CategoryFAQs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ChairmanNotesOnFinalArbitrationScores_FinalArbitrationScoreId",
                table: "ChairmanNotesOnFinalArbitrationScores",
                column: "FinalArbitrationScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ChairmanNotesOnInitialArbitrations_InitialArbitrationId",
                table: "ChairmanNotesOnInitialArbitrations",
                column: "InitialArbitrationId");

            migrationBuilder.CreateIndex(
                name: "IX_ComitteesArbitrators_ArbitratorId",
                table: "ComitteesArbitrators",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_ComitteesArbitrators_CommitteeId",
                table: "ComitteesArbitrators",
                column: "CommitteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Committees_CategoryId",
                table: "Committees",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Committees_ChairmanId",
                table: "Committees",
                column: "ChairmanId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionAttachments_ConditionsProvidedFormsId",
                table: "ConditionAttachments",
                column: "ConditionsProvidedFormsId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionsProvidedForms_ProvidedFormId",
                table: "ConditionsProvidedForms",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionsProvidedForms_TermAndConditionId",
                table: "ConditionsProvidedForms",
                column: "TermAndConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_CoordinatorForms_CoordinatorId",
                table: "CoordinatorForms",
                column: "CoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_CoordinatorForms_ProvidedFormId",
                table: "CoordinatorForms",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionAttachments_CriterionId",
                table: "CriterionAttachments",
                column: "CriterionId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionAttachments_ProvidedFormId",
                table: "CriterionAttachments",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemAttachments_CriterionItemId",
                table: "CriterionItemAttachments",
                column: "CriterionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemAttachments_ProvidedFormId",
                table: "CriterionItemAttachments",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItems_CriterionId",
                table: "CriterionItems",
                column: "CriterionId");

            migrationBuilder.CreateIndex(
                name: "IX_Criterions_ArbitrationProcedureId",
                table: "Criterions",
                column: "ArbitrationProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_Criterions_CategoryId",
                table: "Criterions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Criterions_ParentId",
                table: "Criterions",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleCondition_CycleId",
                table: "CycleCondition",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleConditionAttachments_CycleConditionsProvidedFormId",
                table: "CycleConditionAttachments",
                column: "CycleConditionsProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleConditionsProvidedForms_CycleConditionId",
                table: "CycleConditionsProvidedForms",
                column: "CycleConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleConditionsProvidedForms_ProvidedFormId",
                table: "CycleConditionsProvidedForms",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_DarkCards_PageId",
                table: "DarkCards",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_Dependencies_AttributeOperationId",
                table: "Dependencies",
                column: "AttributeOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Dependencies_DependencyGroupId",
                table: "Dependencies",
                column: "DependencyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Dependencies_DynamicAttributeId",
                table: "Dependencies",
                column: "DynamicAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dependencies_MainDynamicAttributeId",
                table: "Dependencies",
                column: "MainDynamicAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dependencies_StaticAttributeId",
                table: "Dependencies",
                column: "StaticAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_DependencyValidations_AttributeOperationId",
                table: "DependencyValidations",
                column: "AttributeOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_DependencyValidations_DependencyGroupId",
                table: "DependencyValidations",
                column: "DependencyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeGeneralValidations_AttributeOperationId",
                table: "DynamicAttributeGeneralValidations",
                column: "AttributeOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeGeneralValidations_DynamicAttributeId",
                table: "DynamicAttributeGeneralValidations",
                column: "DynamicAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeListValues_DynamicAttributeId",
                table: "DynamicAttributeListValues",
                column: "DynamicAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributePatternValues_DynamicAttributePatternId",
                table: "DynamicAttributePatternValues",
                column: "DynamicAttributePatternId");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributes_AttributeDataTypeId",
                table: "DynamicAttributes",
                column: "AttributeDataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributes_DynamicAttributeSectionId",
                table: "DynamicAttributes",
                column: "DynamicAttributeSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeSections_AttributeTableNameId",
                table: "DynamicAttributeSections",
                column: "AttributeTableNameId");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeTableValue_DynamicAttributeId",
                table: "DynamicAttributeTableValue",
                column: "DynamicAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeValues_DynamicAttributeId",
                table: "DynamicAttributeValues",
                column: "DynamicAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalInstitutions_EducationalEntityId",
                table: "EducationalInstitutions",
                column: "EducationalEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationCoordinators_CoordinatorId",
                table: "EducationCoordinators",
                column: "CoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationCoordinators_EducationalEntityId",
                table: "EducationCoordinators",
                column: "EducationalEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAttachments_MessageId",
                table: "EmailAttachments",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessages_MessageId",
                table: "EmailMessages",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessages_TypeId",
                table: "EmailMessages",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessages_UserId",
                table: "EmailMessages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryGuides_CategoryId",
                table: "ExplanatoryGuides",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraAttachments_ProvidedFormId",
                table: "ExtraAttachments",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraAttachmentsProvidedForms_ExtraAttachmentId",
                table: "ExtraAttachmentsProvidedForms",
                column: "ExtraAttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalArbitrations_ArbitratorId",
                table: "FinalArbitrations",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalArbitrations_ProvidedFormId",
                table: "FinalArbitrations",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalArbitrationScores_CriterionId",
                table: "FinalArbitrationScores",
                column: "CriterionId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalArbitrationScores_CriterionItemId",
                table: "FinalArbitrationScores",
                column: "CriterionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalArbitrationScores_FinalArbitrationId",
                table: "FinalArbitrationScores",
                column: "FinalArbitrationId");

            migrationBuilder.CreateIndex(
                name: "IX_FrequentlyAskedQuestions_CategoryId",
                table: "FrequentlyAskedQuestions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_AlbumId",
                table: "Galleries",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralFAQs_GeneralFrequentlyAskedQuestionCategoryId",
                table: "GeneralFAQs",
                column: "GeneralFrequentlyAskedQuestionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupInvitees_Email_isDeleted",
                table: "GroupInvitees",
                columns: new[] { "Email", "isDeleted" },
                unique: true,
                filter: "[isDeleted] = 0");

            migrationBuilder.CreateIndex(
                name: "IX_GroupInvitees_EventId",
                table: "GroupInvitees",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialArbitrations_ArbitrationId",
                table: "InitialArbitrations",
                column: "ArbitrationId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialArbitrations_CriterionId",
                table: "InitialArbitrations",
                column: "CriterionId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialArbitrations_CriterionItemId",
                table: "InitialArbitrations",
                column: "CriterionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionCoordinators_CoordinatorId",
                table: "InstitutionCoordinators",
                column: "CoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionCoordinators_EducationalInstitutionId",
                table: "InstitutionCoordinators",
                column: "EducationalInstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_Slug",
                table: "Instructions",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InterviewAttachments_InterviewId",
                table: "InterviewAttachments",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewCategories_CategoryId",
                table: "InterviewCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewCategories_InterviewId",
                table: "InterviewCategories",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewNotes_InterviewId",
                table: "InterviewNotes",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewQuestions_InterviewId",
                table: "InterviewQuestions",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewUsers_InterviewId",
                table: "InterviewUsers",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingCategories_CategoryId",
                table: "MeetingCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingCategories_MeetingId",
                table: "MeetingCategories",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_CategoryId",
                table: "Meetings",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingUsers_MeetingId",
                table: "MeetingUsers",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingUsers_UserId",
                table: "MeetingUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CycleId",
                table: "News",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_ArbitrationId",
                table: "Note",
                column: "ArbitrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_UserId",
                table: "Note",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OurGoals_AboutAwardPageId",
                table: "OurGoals",
                column: "AboutAwardPageId");

            migrationBuilder.CreateIndex(
                name: "IX_PageStructures_ParentId",
                table: "PageStructures",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ParagraphCards_PageId",
                table: "ParagraphCards",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermissionHeaderId",
                table: "Permissions",
                column: "PermissionHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Personalnvitees_Email_isDeleted",
                table: "Personalnvitees",
                columns: new[] { "Email", "isDeleted" },
                unique: true,
                filter: "[isDeleted] = 0");

            migrationBuilder.CreateIndex(
                name: "IX_Personalnvitees_EventId",
                table: "Personalnvitees",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForms_CategoryEducationalClassId",
                table: "ProvidedForms",
                column: "CategoryEducationalClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForms_CategoryEducationalEntityId",
                table: "ProvidedForms",
                column: "CategoryEducationalEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForms_categoryId",
                table: "ProvidedForms",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForms_Id",
                table: "ProvidedForms",
                column: "Id",
                unique: true,
                filter: "[isDeleted] = 0");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForms_userId",
                table: "ProvidedForms",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccountRequests_ReceiverId",
                table: "RelatedAccountRequests",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccountRequests_SenderId",
                table: "RelatedAccountRequests",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccounts_User1Id",
                table: "RelatedAccounts",
                column: "User1Id");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccounts_User2Id",
                table: "RelatedAccounts",
                column: "User2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Responsibilities_RoleId",
                table: "Responsibilities",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibilitiesUsers_ResponsibilityId",
                table: "ResponsibilitiesUsers",
                column: "ResponsibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibilitiesUsers_UserId",
                table: "ResponsibilitiesUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rewards_CategoryId",
                table: "Rewards",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMessageTypes_MessageTypeId",
                table: "RoleMessageTypes",
                column: "MessageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMessageTypes_RoleId",
                table: "RoleMessageTypes",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RoleId",
                table: "RolePermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_StaticAttributes_AttributeDataTypeId",
                table: "StaticAttributes",
                column: "AttributeDataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StaticAttributes_AttributeTableNameId",
                table: "StaticAttributes",
                column: "AttributeTableNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupInviteeId",
                table: "Students",
                column: "GroupInviteeId");

            migrationBuilder.CreateIndex(
                name: "IX_TermsAndConditions_CategoryId",
                table: "TermsAndConditions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshops_CategoryId",
                table: "TrainingWorkshops",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshopSubscribers_CreatedById",
                table: "TrainingWorkshopSubscribers",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshopSubscribers_TrainingWorkshopsId",
                table: "TrainingWorkshopSubscribers",
                column: "TrainingWorkshopsId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshopSubscribers_UpdatedById",
                table: "TrainingWorkshopSubscribers",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshopSubscribers_UserId",
                table: "TrainingWorkshopSubscribers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWrokshopeAttachment_WorkshopeId",
                table: "TrainingWrokshopeAttachment",
                column: "WorkshopeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotifications_NotificationId",
                table: "UserNotifications",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotifications_UserId",
                table: "UserNotifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SubscriberId",
                table: "Users",
                column: "SubscriberId",
                unique: true,
                filter: "[SubscriberId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TrainingWorkshopId",
                table: "Users",
                column: "TrainingWorkshopId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersRoles_RoleId",
                table: "UsersRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersRoles_UserId",
                table: "UsersRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTokens_UserId",
                table: "UserTokens",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderGeneralValidations");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderListValues");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderPatternValues");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderTableValues");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderValues");

            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "AppVersions");

            migrationBuilder.DropTable(
                name: "ArbitrationResults");

            migrationBuilder.DropTable(
                name: "ArbitrationScalesCriterions");

            migrationBuilder.DropTable(
                name: "ArbitratorClasses");

            migrationBuilder.DropTable(
                name: "ArbitratorForms");

            migrationBuilder.DropTable(
                name: "AwardPublications");

            migrationBuilder.DropTable(
                name: "AwardSponsors");

            migrationBuilder.DropTable(
                name: "AwardStatistics");

            migrationBuilder.DropTable(
                name: "CategoriesArbitrators");

            migrationBuilder.DropTable(
                name: "CategoryCommittees");

            migrationBuilder.DropTable(
                name: "CategoryFAQs");

            migrationBuilder.DropTable(
                name: "ChairmanNotesOnFinalArbitrationScores");

            migrationBuilder.DropTable(
                name: "ChairmanNotesOnInitialArbitrations");

            migrationBuilder.DropTable(
                name: "Circulars");

            migrationBuilder.DropTable(
                name: "ComitteesArbitrators");

            migrationBuilder.DropTable(
                name: "ConditionAttachments");

            migrationBuilder.DropTable(
                name: "CoordinatorForms");

            migrationBuilder.DropTable(
                name: "CriterionAttachments");

            migrationBuilder.DropTable(
                name: "CriterionItemAttachments");

            migrationBuilder.DropTable(
                name: "CycleConditionAttachments");

            migrationBuilder.DropTable(
                name: "DarkCards");

            migrationBuilder.DropTable(
                name: "Dependencies");

            migrationBuilder.DropTable(
                name: "DependencyValidations");

            migrationBuilder.DropTable(
                name: "DynamicAttributeGeneralValidations");

            migrationBuilder.DropTable(
                name: "DynamicAttributeListValues");

            migrationBuilder.DropTable(
                name: "DynamicAttributePatternValues");

            migrationBuilder.DropTable(
                name: "DynamicAttributeTableValue");

            migrationBuilder.DropTable(
                name: "DynamicAttributeValues");

            migrationBuilder.DropTable(
                name: "EducationCoordinators");

            migrationBuilder.DropTable(
                name: "EmailAttachments");

            migrationBuilder.DropTable(
                name: "ExplanatoryGuides");

            migrationBuilder.DropTable(
                name: "ExplanatoryMessages");

            migrationBuilder.DropTable(
                name: "ExtraAttachmentsProvidedForms");

            migrationBuilder.DropTable(
                name: "FrequentlyAskedQuestions");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "GeneralFAQs");

            migrationBuilder.DropTable(
                name: "GeneralWorkshops");

            migrationBuilder.DropTable(
                name: "HomePageSliders");

            migrationBuilder.DropTable(
                name: "InstitutionCoordinators");

            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "InterviewAttachments");

            migrationBuilder.DropTable(
                name: "InterviewCategories");

            migrationBuilder.DropTable(
                name: "InterviewNotes");

            migrationBuilder.DropTable(
                name: "InterviewQuestions");

            migrationBuilder.DropTable(
                name: "InterviewUsers");

            migrationBuilder.DropTable(
                name: "LogUserActions");

            migrationBuilder.DropTable(
                name: "MeetingCategories");

            migrationBuilder.DropTable(
                name: "MeetingUsers");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "NotificationTemplates");

            migrationBuilder.DropTable(
                name: "OnePageText");

            migrationBuilder.DropTable(
                name: "OurGoals");

            migrationBuilder.DropTable(
                name: "ParagraphCards");

            migrationBuilder.DropTable(
                name: "Personalnvitees");

            migrationBuilder.DropTable(
                name: "ReferenceSources");

            migrationBuilder.DropTable(
                name: "RelatedAccountRequests");

            migrationBuilder.DropTable(
                name: "RelatedAccounts");

            migrationBuilder.DropTable(
                name: "ResponsibilitiesUsers");

            migrationBuilder.DropTable(
                name: "Rewards");

            migrationBuilder.DropTable(
                name: "RoleMessageTypes");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "StrategicPartners");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TrainingWorkshopSubscribers");

            migrationBuilder.DropTable(
                name: "TrainingWrokshopeAttachment");

            migrationBuilder.DropTable(
                name: "UserNotifications");

            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderPatterns");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilders");

            migrationBuilder.DropTable(
                name: "VirtualTables");

            migrationBuilder.DropTable(
                name: "ArbitrationScales");

            migrationBuilder.DropTable(
                name: "FinalArbitrationScores");

            migrationBuilder.DropTable(
                name: "InitialArbitrations");

            migrationBuilder.DropTable(
                name: "Committees");

            migrationBuilder.DropTable(
                name: "ConditionsProvidedForms");

            migrationBuilder.DropTable(
                name: "CycleConditionsProvidedForms");

            migrationBuilder.DropTable(
                name: "StaticAttributes");

            migrationBuilder.DropTable(
                name: "DependencyGroup");

            migrationBuilder.DropTable(
                name: "AttributeOperations");

            migrationBuilder.DropTable(
                name: "DynamicAttributePatterns");

            migrationBuilder.DropTable(
                name: "DynamicAttributes");

            migrationBuilder.DropTable(
                name: "EmailMessages");

            migrationBuilder.DropTable(
                name: "ExtraAttachments");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "GeneralFAQCategories");

            migrationBuilder.DropTable(
                name: "Coordinators");

            migrationBuilder.DropTable(
                name: "EducationalInstitutions");

            migrationBuilder.DropTable(
                name: "Interviews");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "AboutAwardPage");

            migrationBuilder.DropTable(
                name: "PageStructures");

            migrationBuilder.DropTable(
                name: "Responsibilities");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "GroupInvitees");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderSections");

            migrationBuilder.DropTable(
                name: "FinalArbitrations");

            migrationBuilder.DropTable(
                name: "Arbitrations");

            migrationBuilder.DropTable(
                name: "CriterionItems");

            migrationBuilder.DropTable(
                name: "TermsAndConditions");

            migrationBuilder.DropTable(
                name: "CycleCondition");

            migrationBuilder.DropTable(
                name: "AttributeDataTypes");

            migrationBuilder.DropTable(
                name: "DynamicAttributeSections");

            migrationBuilder.DropTable(
                name: "MessageTypes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "PermissionHeaders");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "VirtualTableForSections");

            migrationBuilder.DropTable(
                name: "Arbitrators");

            migrationBuilder.DropTable(
                name: "ProvidedForms");

            migrationBuilder.DropTable(
                name: "Criterions");

            migrationBuilder.DropTable(
                name: "AttributeTableNames");

            migrationBuilder.DropTable(
                name: "CategoryEducationalClasses");

            migrationBuilder.DropTable(
                name: "CategoryEducationalEntities");

            migrationBuilder.DropTable(
                name: "ArbitrationProcedure");

            migrationBuilder.DropTable(
                name: "EducationalClasses");

            migrationBuilder.DropTable(
                name: "EducationalEntities");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TrainingWorkshops");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Cycles");
        }
    }
}
