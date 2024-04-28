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
                name: "AppVersions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GooglePlayLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppleLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    EducationType = table.Column<int>(type: "int", nullable: false),
                    Emirates = table.Column<int>(type: "int", nullable: false),
                    PersonalPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "MessageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sources = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "DynamicAttributeSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordIdOnRelation = table.Column<int>(type: "int", nullable: true),
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    WinningScore = table.Column<float>(type: "real", nullable: true),
                    MinimumAmountToParticipateInTheAward = table.Column<float>(type: "real", nullable: true),
                    MinimumAmountToObtainACertificateOfParticipation = table.Column<float>(type: "real", nullable: true),
                    ExpectedNumberOfWinners = table.Column<int>(type: "int", nullable: true),
                    RelatedToClasses = table.Column<bool>(type: "bit", nullable: true),
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
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "DynamicAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "Meetings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    isImplemented = table.Column<bool>(type: "bit", nullable: false),
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
                    IsSpecial = table.Column<bool>(type: "bit", nullable: true),
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
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "DynamicAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordId = table.Column<int>(type: "int", nullable: true),
                    RecordIdAsGuid = table.Column<int>(type: "int", nullable: true),
                    isAccepted = table.Column<bool>(type: "bit", nullable: false),
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
                    lang = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Interview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    UpdatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interview_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Interview_Users_UpdatedById",
                        column: x => x.UpdatedById,
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
                    userId = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryEducationalClassId = table.Column<int>(type: "int", nullable: true),
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
                name: "Criterions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
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
                name: "ArbitratorInterview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArbitratorId = table.Column<int>(type: "int", nullable: false),
                    InterviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitratorInterview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitratorInterview_Arbitrators_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArbitratorInterview_Interview_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriberInterview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InterviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriberInterview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriberInterview_Interview_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriberInterview_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                    ArbitratorId = table.Column<int>(type: "int", nullable: false),
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
                name: "Attachments",
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
                    table.PrimaryKey("PK_Attachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachments_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attachments_TermsAndConditions_TermAndConditionId",
                        column: x => x.TermAndConditionId,
                        principalTable: "TermsAndConditions",
                        principalColumn: "Id");
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
                name: "Scale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinScore = table.Column<int>(type: "int", nullable: false),
                    MaxScore = table.Column<int>(type: "int", nullable: false),
                    CriterionId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scale_Criterions_CriterionId",
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
                        name: "FK_ConditionAttachments_Attachments_ConditionsProvidedFormsId",
                        column: x => x.ConditionsProvidedFormsId,
                        principalTable: "Attachments",
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
                name: "CriterionItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    ActualScore = table.Column<int>(type: "int", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: true),
                    CriterionId = table.Column<int>(type: "int", nullable: false),
                    ScaleId = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_CriterionItems_Scale_ScaleId",
                        column: x => x.ScaleId,
                        principalTable: "Scale",
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
                name: "CriterionItemScales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScalesId = table.Column<int>(type: "int", nullable: false),
                    ScaleId = table.Column<int>(type: "int", nullable: false),
                    CriterionItemsId = table.Column<int>(type: "int", nullable: false),
                    CriterionItemId = table.Column<int>(type: "int", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterionItemScales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriterionItemScales_CriterionItems_CriterionItemId",
                        column: x => x.CriterionItemId,
                        principalTable: "CriterionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriterionItemScales_Scale_ScaleId",
                        column: x => x.ScaleId,
                        principalTable: "Scale",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AboutAwardPage",
                columns: new[] { "Id", "AboutImage", "ArabicAboutDescription", "ArabicAboutTitle", "ArabicOurVisionDescription", "ArabicOurVisionTitle", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishAboutDescription", "EnglishAboutTitle", "EnglishOurVisionDescription", "EnglishOurVisionTitle", "LastModifiedAt", "LastModifiedBy", "OurVisionImage", "isDeleted" },
                values: new object[] { 1, "https://backend.stg.award-shj.ae/UploadedFiles/02ef2561-b108-4b12-8a3f-6734b4e0345f.jpg", "تأسست جائزة الشارقة للتفوق والتميز التربوي عام 1994-1995 برعاية كريمة من صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الاعلى حاكم إمارة الشارقة حفظه الله ورعاه... وتعتبر أول جائزة تربوية على مستوى الدولة", "نبذة عن الجائزة", "تأسست جائزة الشارقة للتفوق والتميز التربوي عام 1994-1995 برعاية كريمة من صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الاعلى حاكم إمارة الشارقة حفظه الله ورعاه... وتعتبر أول جائزة تربوية على مستوى الدولة", "رؤيتنا", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(5999), null, null, "The Sharjah Award for Educational Excellence and Excellence was established in 1994-1995 under the generous patronage of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of the Emirate of Sharjah, may God protect and preserve him... It is considered the first educational award at the state level.", "About the award", "The Sharjah Award for Educational Excellence and Excellence was established in 1994-1995 under the generous patronage of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of the Emirate of Sharjah, may God protect and preserve him... It is considered the first educational award at the state level.", "Our Vision", null, null, "https://backend.stg.award-shj.ae/UploadedFiles/02ef2561-b108-4b12-8a3f-6734b4e0345f.jpg", false });

            migrationBuilder.InsertData(
                table: "AttributeDataTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6922), null, null, null, null, "Text", false },
                    { 2, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6928), null, null, null, null, "Email", false },
                    { 3, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6933), null, null, null, null, "Image", false },
                    { 4, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6938), null, null, null, null, "File", false },
                    { 5, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6943), null, null, null, null, "Phone Number", false },
                    { 6, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6948), null, null, null, null, "Number", false },
                    { 7, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6952), null, null, null, null, "Date", false },
                    { 8, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6957), null, null, null, null, "List", false }
                });

            migrationBuilder.InsertData(
                table: "AttributeOperations",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "OperationAsString", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7111), null, null, null, null, ">", false },
                    { 2, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7117), null, null, null, null, ">=", false },
                    { 3, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7122), null, null, null, null, "<", false },
                    { 4, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7129), null, null, null, null, "<=", false },
                    { 5, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7134), null, null, null, null, "=", false },
                    { 6, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7139), null, null, null, null, "!=", false },
                    { 7, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7143), null, null, null, null, "is Empty", false },
                    { 8, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7150), null, null, null, null, "is not Empty", false }
                });

            migrationBuilder.InsertData(
                table: "AttributeTableNames",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6791), null, null, null, null, "ProvidedForm", false },
                    { 2, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6797), null, null, null, null, "Coordinator", false },
                    { 3, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6803), null, null, null, null, "Arbitrator", false }
                });

            migrationBuilder.InsertData(
                table: "Coordinators",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EducationType", "Email", "Emirates", "EnglishName", "LastModifiedAt", "LastModifiedBy", "PersonalPhoto", "PhoneNumber", "isDeleted" },
                values: new object[,]
                {
                    { 10, "منسق 1", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7817), null, null, 0, "Coordinator@Coordinator.com", 5, "Coordinator 1", null, null, "https://backend.stg.award-shj.ae/UploadedFiles/02ef2561-b108-4b12-8a3f-6734b4e0345f.jpg", "0993521579", false },
                    { 11, "منسق 2", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7829), null, null, 0, "Coordinator2@Coordinator2.com", 2, "Coordinator 2", null, null, "https://backend.stg.award-shj.ae/UploadedFiles/e6258b6f-5ca5-4168-bb7c-fe1f24a6e553.jpg", "0993521579", false },
                    { 12, "منسق 3", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7837), null, null, 1, "Coordinator3@Coordinator3.com", 1, "Coordinator 3", null, null, "https://backend.stg.award-shj.ae/UploadedFiles/eecad556-2d56-4010-b10a-780f7500f693.png", "0993521579", false },
                    { 13, "منسق 4", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7845), null, null, 1, "Coordinator4@Coordinator4.com", 2, "Coordinator 4", null, null, "https://backend.stg.award-shj.ae/UploadedFiles/eecad556-2d56-4010-b10a-780f7500f693.png", "0993521579", false }
                });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "CycleNumber", "DeletedAt", "EnglishName", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "GroupCategoryNumber", "IndividualCategoryNumber", "InitialArbitrationEndDate", "InitialArbitrationStartDate", "LastModifiedAt", "LastModifiedBy", "MarginOfDifferenceBetweenArbitrators", "RegistrationPortalClosingDate", "RegistrationPortalOpeningDate", "Status", "SubscriberPortalClosingDate", "TheUpperLimitForObtainingInformation", "Year", "isDeleted" },
                values: new object[] { 1, "جائزة الشارقة", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null, "SharijhaAward", null, null, 10, 10, null, null, null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 0, "2023-2024", false });

            migrationBuilder.InsertData(
                table: "EducationalClasses",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "الصف الأول", new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(461), null, null, "First class", null, null, false },
                    { 2, "الصف الثاني", new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(469), null, null, "Second class", null, null, false },
                    { 3, "الصف الثالث", new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(476), null, null, "Third class", null, null, false },
                    { 4, "الصف الرابع", new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(482), null, null, "Forth class", null, null, false },
                    { 5, "الصف الخامس", new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(489), null, null, "Fifth class", null, null, false },
                    { 6, "الصف السادس", new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(494), null, null, "Sixth class", null, null, false },
                    { 7, "الصف السابع", new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(500), null, null, "Seventh class", null, null, false },
                    { 8, "الصف الثامن", new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(504), null, null, "Eighth class", null, null, false },
                    { 9, "الصف التاسع", new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(509), null, null, "Ninth class", null, null, false },
                    { 10, "الصف العاشر", new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(515), null, null, "Tenth class", null, null, false },
                    { 11, "الصف الحادي عشر", new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(520), null, null, "Eleventh class", null, null, false },
                    { 12, "الصف الثاني عشر", new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(525), null, null, "Twelfth class", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "EducationalEntities",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "جهة تعليمية 1", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8168), null, null, "Educational Entity 1", null, null, false },
                    { 2, "جهة تعليمية 2", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8176), null, null, "Educational Entity 2", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "ArabicDescription", "ArabicLocation", "ArabicName", "ArabicSiteName", "CreatedAt", "CreatedBy", "DeletedAt", "EndDate", "EnglishDescription", "EnglishLocation", "EnglishName", "EnglishSiteName", "EventDate", "LastModifiedAt", "LastModifiedBy", "StartDate", "UniqueIntegerId", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار وصف حدث 1", "اختبار موقع الفعالية 1", "اختبار اسم حدث 1", "اختبار اسم مكان الحدث 1", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3677), null, null, new DateTime(2024, 5, 3, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3684), "Test Event Description 1", "Test Event Location 1", "Test Event Name 1", "Test Event Site Name 1", new DateTime(2024, 4, 30, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3699), null, null, new DateTime(2024, 5, 1, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3701), 1, false },
                    { 2, "اختبار وصف حدث 2", "اختبار موقع الفعالية 2", "اختبار اسم حدث 2", "اختبار اسم مكان الحدث 2", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3707), null, null, new DateTime(2024, 5, 6, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3712), "Test Event Description 2", "Test Event Location 2", "Test Event Name 2", "Test Event Site Name 2", new DateTime(2024, 5, 3, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3716), null, null, new DateTime(2024, 5, 4, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3718), 2, false }
                });

            migrationBuilder.InsertData(
                table: "GeneralFAQCategories",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار فئة أسئلة شائعة عامة 1", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6433), null, null, "Test General FAQ Category 1", null, null, false },
                    { 2, "اختبار فئة أسئلة شائعة عامة 2", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6440), null, null, "Test General FAQ Category 2", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "GeneralWorkshops",
                columns: new[] { "Id", "AgendaImage", "ArabicDescription", "ArabicTitle", "CreatedAt", "CreatedBy", "DateOfWorkShop", "DayName", "DeletedAt", "EnglishDescription", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "RegistrationUrl", "Thumbnale", "Time", "Video", "isDeleted" },
                values: new object[,]
                {
                    { 1, null, "اختبار وصف الورش العامة 1", "اختبار عنوان الورش العامة 1", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(5437), null, new DateTime(2024, 5, 8, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(5448), "Wednesday", null, "Test General Workshop Description 1", "Test General Workshop Title 1", null, null, null, "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg", "10:00 - 12:00", null, false },
                    { 2, null, "اختبار وصف الورش العامة 2", "اختبار عنوان الورش العامة 2", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(5812), null, new DateTime(2024, 5, 18, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(5819), "Saturday", null, "Test General Workshop Description 2", "Test General Workshop Title 2", null, null, null, "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg", "2:00 - 3:00", null, false }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Slug", "Title", "isDeleted" },
                values: new object[,]
                {
                    { 1, "Content 1", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(2292), null, null, null, null, "Slug 1", "Title 1", false },
                    { 2, "Content 2", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(2304), null, null, null, null, "Slug 2", "Title 2", false }
                });

            migrationBuilder.InsertData(
                table: "OnePageText",
                columns: new[] { "Id", "ArabicText", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishText", "LastModifiedAt", "LastModifiedBy", "Slug", "Type", "isDeleted" },
                values: new object[,]
                {
                    { 1, "سياسة الخصوصية", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6282), null, null, "Privacy Policy", null, null, "Privacy_Policy_Website", 0, false },
                    { 2, "سياسة الخصوصية", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6289), null, null, "Privacy Policy", null, null, "Privacy_Policy_Subscriber", 0, false },
                    { 3, "شروط الاستخدام", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6297), null, null, "Terms Of Use", null, null, "Terms_Of_Use_Website", 1, false },
                    { 4, "شروط الاستخدام", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6302), null, null, "Terms Of Use", null, null, "Terms_Of_Use_Subscriber", 1, false }
                });

            migrationBuilder.InsertData(
                table: "PermissionHeaders",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[] { 1, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3319), null, null, null, null, "إدارة الدورات", false });

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
                columns: new[] { "Id", "ArabicName", "ConfirmationCodeForForgetPassword", "ConfirmationCodeForResetPassword", "ConfirmationCodeForSignUp", "CreatedAt", "CreatedBy", "DeletedAt", "Email", "EnglishName", "Gender", "ImageURL", "LastModifiedAt", "LastModifiedBy", "NumberOfGroupCategories", "NumberOfIndividualCategories", "Password", "PhoneNumber", "SubscriberId", "TrainingWorkshopId", "isDeleted", "isValidAccount", "lang" },
                values: new object[,]
                {
                    { 1, "ادمن 123", null, null, null, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9854), null, null, "ahmad.a.ahmad.100011@gmail.com", "Admin 123", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true, null },
                    { 2, "ادمن 123 #", null, null, null, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9866), null, null, "Ahmad@Ahmad.com", "Admin 123 #", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true, null },
                    { 3, "ادمن 123 ##", null, null, null, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9874), null, null, "Ahmad2@Ahmad2.com", "Admin 123 ##", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true, null },
                    { 4, "ادمن 123 ##@", null, null, null, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9881), null, null, "Ahmad3@Ahmad3.com", "Admin 123 ##@", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true, null },
                    { 5, "ادمن 123 ##@@", null, null, null, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9890), null, null, "Ahmad4@Ahmad4.com", "Admin 123 ##@@", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true, null },
                    { 6, "تامر", null, null, null, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9899), null, null, "tamer@gmail.com", "Tamer", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", "ABC123", null, false, true, null },
                    { 10, "منسق 1", null, null, null, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7994), null, null, "Coordinator@Coordinator.com", "Coordinator 1", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true, null },
                    { 11, "منسق 2", null, null, null, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8009), null, null, "Coordinator2@Coordinator2.com", "Coordinator 2", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true, null },
                    { 12, "منسق 3", null, null, null, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8018), null, null, "Coordinator3@Coordinator3.com", "Coordinator 3", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true, null },
                    { 13, "منسق 4", null, null, null, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8025), null, null, "Coordinator4@Coordinator4.com", "Coordinator 4", 0, null, null, null, 0, 0, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", null, null, false, true, null }
                });

            migrationBuilder.InsertData(
                table: "Agendas",
                columns: new[] { "Id", "ArabicTitle", "CreatedAt", "CreatedBy", "CurrentDate", "CycleId", "DateType", "DeletedAt", "EndDate", "EnglishTitle", "Icon", "LastModifiedAt", "LastModifiedBy", "StartDate", "Status", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار عنوان جدول أعمال 1", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6626), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null, new DateTime(2024, 5, 8, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6642), "Test Agenda Titile 1", "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1) (1).png", null, null, new DateTime(2024, 5, 3, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6654), 1, false },
                    { 2, "اختبار عنوان جدول أعمال 2", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6659), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, null, new DateTime(2024, 5, 13, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6664), "Test Agenda Titile 2", "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1) (2).png", null, null, new DateTime(2024, 5, 8, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6666), 0, false },
                    { 3, "اختبار عنوان جدول أعمال 3", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6670), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null, new DateTime(2024, 5, 18, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6674), "Test Agenda Titile 3", "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png", null, null, new DateTime(2024, 5, 13, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6677), 2, false },
                    { 4, "اختبار عنوان جدول أعمال 4", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6680), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null, new DateTime(2024, 5, 23, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6685), "Test Agenda Titile 4", "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png", null, null, new DateTime(2024, 5, 18, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6687), 2, false },
                    { 5, "اختبار عنوان جدول أعمال 5", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6691), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null, new DateTime(2024, 5, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6695), "Test Agenda Titile 5", "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png", null, null, new DateTime(2024, 5, 23, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6697), 2, false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ArabicDescription", "ArabicName", "CategoryClassification", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationQualificationMark", "Icon", "LastModifiedAt", "LastModifiedBy", "MinimumAmountToObtainACertificateOfParticipation", "MinimumAmountToParticipateInTheAward", "ParentId", "RelatedToClasses", "WinningScore", "isDeleted" },
                values: new object[] { 1, "اختبار وصف 1", "اختبار اسم 1", 0, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7194), null, 1, null, "Test Description 1", "Test Name 1", 1, 0f, "string", null, null, null, null, null, false, 0f, false });

            migrationBuilder.InsertData(
                table: "DynamicAttributeSections",
                columns: new[] { "Id", "ArabicName", "AttributeTableNameId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "RecordIdOnRelation", "isDeleted" },
                values: new object[] { 1, "اختبار اسم 1", 1, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1091), null, null, "Test Name 1", null, null, 2, false });

            migrationBuilder.InsertData(
                table: "EducationCoordinators",
                columns: new[] { "Id", "CoordinatorId", "CreatedAt", "CreatedBy", "DeletedAt", "EducationalEntityId", "LastModifiedAt", "LastModifiedBy", "RelatedDate", "isDeleted" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8496), null, null, 1, null, null, new DateTime(2024, 4, 28, 11, 23, 26, 238, DateTimeKind.Local).AddTicks(8506), false },
                    { 2, 11, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8629), null, null, 1, null, null, new DateTime(2024, 4, 28, 11, 23, 26, 238, DateTimeKind.Local).AddTicks(8633), false },
                    { 3, 12, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8644), null, null, 2, null, null, new DateTime(2024, 4, 28, 11, 23, 26, 238, DateTimeKind.Local).AddTicks(8647), false },
                    { 4, 13, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8656), null, null, 2, null, null, new DateTime(2024, 4, 28, 11, 23, 26, 238, DateTimeKind.Local).AddTicks(8660), false }
                });

            migrationBuilder.InsertData(
                table: "EducationalInstitutions",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EducationalEntityId", "EnglishName", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "مؤسسة تعليمية 1", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8343), null, null, 1, "Educational Entity 1", null, null, false },
                    { 2, "مؤسسة تعليمية 2", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8352), null, null, 2, "Educational Entity 2", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "GeneralFAQs",
                columns: new[] { "Id", "ArabicAnswer", "ArabicQuestion", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishAnswer", "EnglishQuestion", "GeneralFrequentlyAskedQuestionCategoryId", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار جواب 1", "اختبار سؤال 1", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6577), null, null, "Test Answer 1", "Test Question 1", 1, null, null, false },
                    { 2, "اختبار جواب 2", "اختبار سؤال 2", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6585), null, null, "Test Answer 2", "Test Question 2", 1, null, null, false },
                    { 3, "اختبار جواب 3", "اختبار سؤال 3", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6624), null, null, "Test Answer 3", "Test Question 3", 2, null, null, false },
                    { 4, "اختبار جواب 4", "اختبار سؤال 4", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6631), null, null, "Test Answer 4", "Test Question 4", 2, null, null, false }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "ArabicDescription", "ArabicTitle", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishDescription", "EnglishTitle", "Image", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار وصف أخبار 1", "اختبار عنوان أخبار 1", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6870), null, 1, null, "Test News Description 1", "Test News Title 1", "https://backend.stg.award-shj.ae/UploadedFiles/02ef2561-b108-4b12-8a3f-6734b4e0345f.jpg", null, null, false },
                    { 2, "اختبار وصف أخبار 2", "اختبار عنوان أخبار 2", new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6882), null, 1, null, "Test News Description 2", "Test News Title 2", "https://backend.stg.award-shj.ae/UploadedFiles/1dd2958e-d80c-48d0-9a28-899d66fded8d.jpg", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "OurGoals",
                columns: new[] { "Id", "AboutAwardPageId", "ArabicGoal", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishGoal", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, 1, "تطوير القطاع التربوي من خلال بث روح التنافس بينهم؛ لتحقيق أفضل الممارسات التربوية.", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6143), null, null, "Developing the educational sector by spreading the spirit of competition among them; To achieve best educational practices.", null, null, false },
                    { 2, 1, "طوير أعمال الجائزة ومنهجياتها، ورفع الكفايات المهنية للعاملين بها.", new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6151), null, null, "Developing the Award’s work and methodologies, and raising the professional competencies of its employees.", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "PermissionHeaderId", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3511), null, null, null, null, "عرض الدورات", 1, false },
                    { 2, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3519), null, null, null, null, "إضافة دورة", 1, false },
                    { 3, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3524), null, null, null, null, "عرض معلومات دورة", 1, false },
                    { 4, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3529), null, null, null, null, "تعديل دورة", 1, false },
                    { 5, new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3534), null, null, null, null, "حذف دورة", 1, false }
                });

            migrationBuilder.InsertData(
                table: "RelatedAccountRequests",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "ReceiverId", "SenderId", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(685), null, null, null, null, 1, 2, false },
                    { 2, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(693), null, null, null, null, 1, 3, false }
                });

            migrationBuilder.InsertData(
                table: "RelatedAccounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "User1Id", "User2Id", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(826), null, null, null, null, 1, 4, false },
                    { 2, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(834), null, null, null, null, 1, 5, false }
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
                columns: new[] { "Id", "ArabicDescription", "ArabicName", "CategoryClassification", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationQualificationMark", "Icon", "LastModifiedAt", "LastModifiedBy", "MinimumAmountToObtainACertificateOfParticipation", "MinimumAmountToParticipateInTheAward", "ParentId", "RelatedToClasses", "WinningScore", "isDeleted" },
                values: new object[] { 2, "اختبار وصف 2", "اختبار اسم 2", 0, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7229), null, 1, null, "Test Description 2", "Test Name 2", 1, 0f, "string", null, null, null, null, 1, false, 0f, false });

            migrationBuilder.InsertData(
                table: "DynamicAttributes",
                columns: new[] { "Id", "ArabicLabel", "ArabicPlaceHolder", "AttributeDataTypeId", "CreatedAt", "CreatedBy", "DeletedAt", "DynamicAttributeSectionId", "EnglishLabel", "EnglishPlaceHolder", "IsRequired", "IsUnique", "LastModifiedAt", "LastModifiedBy", "LinkedToAnotherAttribute", "MaxSizeInKB", "Status", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار نص 1", "اختبار نص 1", 1, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1230), null, null, 1, "Test Text 1", "Test Text 1", true, true, null, null, false, null, 0, false },
                    { 2, "اختبار ايميل 1", "اختبار ايميل 1", 2, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1245), null, null, 1, "Test Email 1", "Test Email 1", true, true, null, null, false, null, 0, false },
                    { 3, "اختبار صورة 1", "اختبار صورة 1", 3, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1252), null, null, 1, "Test Image 1", "Test Image 1", false, false, null, null, false, 1028, 0, false },
                    { 4, "اختبار ملف 1", "اختبار ملف 1", 4, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1262), null, null, 1, "Test File 1", "Test File 1", false, false, null, null, false, 4112, 0, false },
                    { 5, "اختبار رقم متحرك 1", "اختبار رقم متحرك 1", 5, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1270), null, null, 1, "Test Phone Number 1", "Test Phone Number 1", false, false, null, null, false, null, 0, false },
                    { 6, "اختبار رقم 1", "اختبار رقم 1", 6, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1277), null, null, 1, "Test Number 1", "Test Number 1", false, false, null, null, false, null, 0, false },
                    { 7, "اختبار تاريخ 1", "اختبار تاريخ 1", 7, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1284), null, null, 1, "Test Date 1", "Test Date 1", false, false, null, null, false, null, 0, false },
                    { 8, "اختبار قائمة 1", "اختبار قائمة 1", 8, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1292), null, null, 1, "Test List 1", "Test List 1", false, false, null, null, false, null, 0, false }
                });

            migrationBuilder.InsertData(
                table: "InstitutionCoordinators",
                columns: new[] { "Id", "CoordinatorId", "CreatedAt", "CreatedBy", "DeletedAt", "EducationalInstitutionId", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8814), null, null, 1, null, null, false },
                    { 2, 11, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8822), null, null, 1, null, null, false },
                    { 3, 12, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8828), null, null, 2, null, null, false },
                    { 4, 13, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8832), null, null, 2, null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Criterions",
                columns: new[] { "Id", "ArabicTitle", "ArbitrationProcedureId", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "ParentId", "Score", "SizeOfAttachmentInKB", "isDeleted" },
                values: new object[] { 1, "معيار رئيسي 1", null, 2, new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3551), null, null, "Main Criterion 1", null, null, null, 100, 0, false });

            migrationBuilder.InsertData(
                table: "DynamicAttributeListValues",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DynamicAttributeId", "LastModifiedAt", "LastModifiedBy", "Value", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1445), null, null, 8, null, null, "Test Value 1", false },
                    { 2, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1452), null, null, 8, null, null, "Test Value 2", false },
                    { 3, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1457), null, null, 8, null, null, "Test Value 3", false },
                    { 4, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1462), null, null, 8, null, null, "Test Value 4", false },
                    { 5, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1467), null, null, 8, null, null, "Test Value 5", false }
                });

            migrationBuilder.InsertData(
                table: "FrequentlyAskedQuestions",
                columns: new[] { "Id", "ArabicAnswer", "ArabicQuestion", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishAnswer", "EnglishQuestion", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة.", "كيف يمكنني الاشتراك بجائزة الشارقة للتفوق والتميز التربوي", 2, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7657), null, null, "You can participate in the award by following the following steps:\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria.", "How can I participate in the Sharjah Award for Excellence and Educational Excellence?", null, null, false },
                    { 2, "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة. 2", "كيف يمكنني الاشتراك بجائزة الشارقة للتفوق والتميز التربوي 2", 2, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7668), null, null, "You can participate in the award by following the following steps:\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria 2.", "How can I participate in the Sharjah Award for Excellence and Educational Excellence? 2", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "ProvidedForms",
                columns: new[] { "Id", "CategoryEducationalClassId", "CreatedAt", "CreatedBy", "CurrentStep", "CycleNumber", "CycleYear", "DeletedAt", "FinalScore", "LastModifiedAt", "LastModifiedBy", "PercentCompletion", "Status", "SubscriberType", "TotalStep", "Type", "categoryId", "isDeleted", "userId" },
                values: new object[] { 1, null, new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(950), null, 1, 1, "2023-2024", null, 0f, null, null, 1, 0, 0, 7, 0, 2, false, 1 });

            migrationBuilder.InsertData(
                table: "TermsAndConditions",
                columns: new[] { "Id", "ArabicDescription", "ArabicTitle", "AttachmentType", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishDescription", "EnglishTitle", "IsAgree", "IsSpecial", "LastModifiedAt", "LastModifiedBy", "NeedAttachment", "RequiredAttachmentNumber", "SizeOfAttachmentInKB", "isDeleted" },
                values: new object[,]
                {
                    { 1, "الموافقة على سياسة الخصوصية لهذه الفئة", "الموافقة على سياسة الخصوصة", 0, 2, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8966), null, null, "Accept on Privacy Term", "Accept on Privacy Term", false, true, null, null, false, 0, 0, false },
                    { 2, "الموافقة على سياسة الخصوصية لهذه الفئة", "الموافقة على سياسة الخصوصة", 0, 2, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8982), null, null, "Accept on Privacy Term", "Accept on Privacy Term", false, false, null, null, false, 0, 0, false },
                    { 3, "الهوية الشخصية", "رفع صورة الهوية الشخصية (الامامي و الخلفي)", 0, 2, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8991), null, null, "Id Card", "Upload Photos of Id Card (Front and Back)", false, false, null, null, true, 2, 1000, false },
                    { 4, "الهوية الشخصية", "رفع صورة الهوية الشخصية (الامامي و الخلفي)", 0, 2, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9000), null, null, "Id Card", "Upload Photos of Id Card (Front and Back)", false, true, null, null, true, 2, 1000, false },
                    { 5, "رفع الاثباتات العلمية", "رفع الاثباتات العلمية", 1, 2, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9011), null, null, "Upload Confirmation Documents", "Upload Confirmation Documents", false, true, null, null, true, 0, 1000, false },
                    { 6, "رفع الاثباتات العلمية", "رفع الاثباتات العلمية", 1, 2, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9021), null, null, "Upload Confirmation Documents", "Upload Confirmation Documents", false, false, null, null, true, 0, 1000, false }
                });

            migrationBuilder.InsertData(
                table: "TrainingWorkshops",
                columns: new[] { "Id", "ArabicDescription", "ArabicTitle", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishDescription", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "Thumbnail", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار وصف ورشة تدريبية 1", "اختبار عنوان ورشة تدريبية 1", 2, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7441), null, null, "Test Training Workshop Description 1", "Test Training Workshop Title 1", null, null, "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg", false },
                    { 2, "اختبار وصف ورشة تدريبية 2", "اختبار عنوان ورشة تدريبية 2", 2, new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7458), null, null, "Test Training Workshop Description 2", "Test Training Workshop Title 2", null, null, "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg", false }
                });

            migrationBuilder.InsertData(
                table: "Criterions",
                columns: new[] { "Id", "ArabicTitle", "ArbitrationProcedureId", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "ParentId", "Score", "SizeOfAttachmentInKB", "isDeleted" },
                values: new object[,]
                {
                    { 2, "معيار فرعي 1", null, 2, new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3569), null, null, "Sub Criterion 1", null, null, 1, 50, 5000, false },
                    { 3, "معيار فرعي 2", null, 2, new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3578), null, null, "Sub Criterion 2", null, null, 1, 50, 5000, false }
                });

            migrationBuilder.InsertData(
                table: "CriterionItems",
                columns: new[] { "Id", "ActualScore", "ArabicName", "CreatedAt", "CreatedBy", "CriterionId", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "ScaleId", "Score", "SizeOfAttachmentInKB", "isDeleted" },
                values: new object[,]
                {
                    { 1, 0, "بند معيار فرعي 11", new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3788), null, 2, null, "Sub Criterion Item 11", null, null, null, 50, 5000, false },
                    { 2, 0, "بند معيار فرعي 12", new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3801), null, 2, null, "Sub Criterion Item 12", null, null, null, 50, 5000, false },
                    { 3, 0, "بند معيار فرعي 21", new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3809), null, 3, null, "Sub Criterion Item 21", null, null, null, 50, 5000, false },
                    { 4, 0, "بند معيار فرعي 22", new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3816), null, 3, null, "Sub Criterion Item 22", null, null, null, 50, 5000, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_UserId",
                table: "Achievements",
                column: "UserId");

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
                name: "IX_Arbitrations_ArbitratorId",
                table: "Arbitrations",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Arbitrations_ProvidedFormId",
                table: "Arbitrations",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorClasses_ArbitratorId",
                table: "ArbitratorClasses",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorClasses_EducationalClassId",
                table: "ArbitratorClasses",
                column: "EducationalClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorInterview_ArbitratorId",
                table: "ArbitratorInterview",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorInterview_InterviewId",
                table: "ArbitratorInterview",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_ProvidedFormId",
                table: "Attachments",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_TermAndConditionId",
                table: "Attachments",
                column: "TermAndConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_AwardPublications_CycleId",
                table: "AwardPublications",
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
                name: "IX_CategoryFAQs_CategoryId",
                table: "CategoryFAQs",
                column: "CategoryId");

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
                name: "IX_CriterionItems_ScaleId",
                table: "CriterionItems",
                column: "ScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemScales_CriterionItemId",
                table: "CriterionItemScales",
                column: "CriterionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemScales_ScaleId",
                table: "CriterionItemScales",
                column: "ScaleId");

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
                name: "IX_Interview_CreatedById",
                table: "Interview",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_UpdatedById",
                table: "Interview",
                column: "UpdatedById");

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
                name: "IX_Scale_CriterionId",
                table: "Scale",
                column: "CriterionId");

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
                name: "IX_SubscriberInterview_InterviewId",
                table: "SubscriberInterview",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriberInterview_UserId",
                table: "SubscriberInterview",
                column: "UserId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "AppVersions");

            migrationBuilder.DropTable(
                name: "Arbitrations");

            migrationBuilder.DropTable(
                name: "ArbitratorClasses");

            migrationBuilder.DropTable(
                name: "ArbitratorInterview");

            migrationBuilder.DropTable(
                name: "AwardPublications");

            migrationBuilder.DropTable(
                name: "CategoriesArbitrators");

            migrationBuilder.DropTable(
                name: "CategoryCommittees");

            migrationBuilder.DropTable(
                name: "CategoryFAQs");

            migrationBuilder.DropTable(
                name: "Circulars");

            migrationBuilder.DropTable(
                name: "ComitteesArbitrators");

            migrationBuilder.DropTable(
                name: "ConditionAttachments");

            migrationBuilder.DropTable(
                name: "CriterionAttachments");

            migrationBuilder.DropTable(
                name: "CriterionItemAttachments");

            migrationBuilder.DropTable(
                name: "CriterionItemScales");

            migrationBuilder.DropTable(
                name: "CycleConditionAttachments");

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
                name: "DynamicAttributeValues");

            migrationBuilder.DropTable(
                name: "EducationCoordinators");

            migrationBuilder.DropTable(
                name: "EmailAttachments");

            migrationBuilder.DropTable(
                name: "ExplanatoryGuides");

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
                name: "MeetingCategories");

            migrationBuilder.DropTable(
                name: "MeetingUsers");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "NotificationTemplates");

            migrationBuilder.DropTable(
                name: "OnePageText");

            migrationBuilder.DropTable(
                name: "OurGoals");

            migrationBuilder.DropTable(
                name: "Personalnvitees");

            migrationBuilder.DropTable(
                name: "ReferenceSources");

            migrationBuilder.DropTable(
                name: "RelatedAccountRequests");

            migrationBuilder.DropTable(
                name: "RelatedAccounts");

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
                name: "SubscriberInterview");

            migrationBuilder.DropTable(
                name: "TrainingWorkshopSubscribers");

            migrationBuilder.DropTable(
                name: "TrainingWrokshopeAttachment");

            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropTable(
                name: "Committees");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "CriterionItems");

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
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "AboutAwardPage");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "GroupInvitees");

            migrationBuilder.DropTable(
                name: "Interview");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Arbitrators");

            migrationBuilder.DropTable(
                name: "TermsAndConditions");

            migrationBuilder.DropTable(
                name: "Scale");

            migrationBuilder.DropTable(
                name: "CycleCondition");

            migrationBuilder.DropTable(
                name: "AttributeDataTypes");

            migrationBuilder.DropTable(
                name: "DynamicAttributeSections");

            migrationBuilder.DropTable(
                name: "MessageTypes");

            migrationBuilder.DropTable(
                name: "ProvidedForms");

            migrationBuilder.DropTable(
                name: "EducationalEntities");

            migrationBuilder.DropTable(
                name: "PermissionHeaders");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Criterions");

            migrationBuilder.DropTable(
                name: "AttributeTableNames");

            migrationBuilder.DropTable(
                name: "CategoryEducationalClasses");

            migrationBuilder.DropTable(
                name: "ArbitrationProcedure");

            migrationBuilder.DropTable(
                name: "EducationalClasses");

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
