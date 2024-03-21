using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ahmad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutAwardPage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "Coordinators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "cycles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CycleNumber = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RegistrationPortalOpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationPortalClosingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndividualCategoryNumber = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_cycles", x => x.Id);
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
                name: "EducationalEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_EducationalEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "GeneralFrequentlyAskedQuestionCategories",
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
                    table.PrimaryKey("PK_GeneralFrequentlyAskedQuestionCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralWorkshops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "PrivacyPolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivacyPolicies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TermsOfUses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermsOfUses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OurGoals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicGoal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishGoal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutAwardPageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    RecordIdOnRelation = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CycleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agenda_cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryClassification = table.Column<int>(type: "int", nullable: false),
                    SubscriberPortalClosingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InitialArbitrationStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InitialArbitrationEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinalArbitrationStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinalArbitrationEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinalArbitrationQualificationMark = table.Column<int>(type: "int", nullable: false),
                    WinningScore = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RelatedToClasses = table.Column<bool>(type: "bit", nullable: false),
                    ExpectedNumberOfWinners = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CycleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_Categories_cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CycleCondition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CycleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_CycleCondition_cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CycleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_News_cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "cycles",
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
                name: "EducationalInstitutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationalEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoordinatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EducationalEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UniqueIntegerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedNumberOfAttendees = table.Column<int>(type: "int", nullable: false),
                    ActualNumberOfAttendees = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UniqueIntegerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Employer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfInvitee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAttend = table.Column<bool>(type: "bit", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "GeneralFrequentlyAskedQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_GeneralFrequentlyAskedQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralFrequentlyAskedQuestions_GeneralFrequentlyAskedQuestionCategories_GeneralFrequentlyAskedQuestionCategoryId",
                        column: x => x.GeneralFrequentlyAskedQuestionCategoryId,
                        principalTable: "GeneralFrequentlyAskedQuestionCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolePermissionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_RolePermissions_RolePermissionId",
                        column: x => x.RolePermissionId,
                        principalTable: "RolePermissions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolePermissionId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Roles_RolePermissions_RolePermissionId",
                        column: x => x.RolePermissionId,
                        principalTable: "RolePermissions",
                        principalColumn: "Id");
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
                name: "categoryFAQs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnglishFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryFAQs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_categoryFAQs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "explanatoryGuides",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishFilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicFilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_explanatoryGuides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_explanatoryGuides_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "frequentlyAskedQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_frequentlyAskedQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_frequentlyAskedQuestions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TermsAndConditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSpecial = table.Column<bool>(type: "bit", nullable: true),
                    NeedAttachment = table.Column<bool>(type: "bit", nullable: false),
                    RequiredAttachmentNumber = table.Column<int>(type: "int", nullable: true),
                    AttachmentType = table.Column<int>(type: "int", nullable: true),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: true),
                    IsAgree = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "trainingWorkshops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfAttachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainingWorkshops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainingWorkshops_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionCoordinators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoordinatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EducationalInstitutionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupInviteeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConfirmationCodeForResetPassword = table.Column<int>(type: "int", nullable: true),
                    ConfirmationCodeForSignUp = table.Column<int>(type: "int", nullable: true),
                    isValidAccount = table.Column<bool>(type: "bit", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
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
                name: "TrainingWrokshopeAttachment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    AttachmentType = table.Column<int>(type: "int", nullable: false),
                    WorkshopeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_TrainingWrokshopeAttachment_trainingWorkshops_WorkshopeId",
                        column: x => x.WorkshopeId,
                        principalTable: "trainingWorkshops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AchievementClassification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchievementClassification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AchievementClassification_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AchievementClassification_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ArbitrationProcedure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicGuidDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishGuidDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    StrengthPoints = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImprovementAreas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitrationProcedure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitrationProcedure_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArbitrationProcedure_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Arbitrator",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitrator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arbitrator_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Arbitrator_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Committee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ChairmanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Committee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Committee_users_ChairmanId",
                        column: x => x.ChairmanId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Committee_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Committee_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EducationalClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalClass_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EducationalClass_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Interview",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interview_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Interview_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    categoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meeting_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meeting_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Meeting_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "subscribers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscribers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subscribers_users_Id",
                        column: x => x.Id,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Achievement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FieldOfDiscrimination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Projects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillsAndExperiences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Youtube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Snapchat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tiktok = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AchievementClassificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achievement_AchievementClassification_AchievementClassificationId",
                        column: x => x.AchievementClassificationId,
                        principalTable: "AchievementClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Achievement_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criterions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArbitrationProcedureId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    ArbitrationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_Note_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryArbitrator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArbitratorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryArbitrator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryArbitrator_Arbitrator_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryArbitrator_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryCommittee",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommitteesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryCommittee", x => new { x.CategoriesId, x.CommitteesId });
                    table.ForeignKey(
                        name: "FK_CategoryCommittee_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryCommittee_Committee_CommitteesId",
                        column: x => x.CommitteesId,
                        principalTable: "Committee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "categoryCommittees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommitteesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryCommittees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_categoryCommittees_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_categoryCommittees_Committee_CommitteesId",
                        column: x => x.CommitteesId,
                        principalTable: "Committee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_categoryCommittees_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_categoryCommittees_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CycleClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CycleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EducationalClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CycleClass_EducationalClass_EducationalClassId",
                        column: x => x.EducationalClassId,
                        principalTable: "EducationalClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CycleClass_cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArbitratorInterview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArbitratorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InterviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitratorInterview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitratorInterview_Arbitrator_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrator",
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
                name: "MeetingUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MeetingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingUser_Meeting_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meeting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetingUser_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeetingSubscriber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subscriberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    meetingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingSubscriber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingSubscriber_Meeting_meetingId",
                        column: x => x.meetingId,
                        principalTable: "Meeting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetingSubscriber_subscribers_subscriberId",
                        column: x => x.subscriberId,
                        principalTable: "subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    categoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriberId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_ProvidedForms_subscribers_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "subscribers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProvidedForms_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatedAccountRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_RelatedAccountRequests_subscribers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedAccountRequests_subscribers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "subscribers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RelatedAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subscriber1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subscriber2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_RelatedAccounts_subscribers_Subscriber1Id",
                        column: x => x.Subscriber1Id,
                        principalTable: "subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedAccounts_subscribers_Subscriber2Id",
                        column: x => x.Subscriber2Id,
                        principalTable: "subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SubscriberAchievement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AchievementClassificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriberAchievement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriberAchievement_AchievementClassification_AchievementClassificationId",
                        column: x => x.AchievementClassificationId,
                        principalTable: "AchievementClassification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriberAchievement_subscribers_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriberAchievement_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubscriberAchievement_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubscriberInterview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InterviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_SubscriberInterview_subscribers_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriberTrainingWorkshop",
                columns: table => new
                {
                    SubscribersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrainingWorkshopsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriberTrainingWorkshop", x => new { x.SubscribersId, x.TrainingWorkshopsId });
                    table.ForeignKey(
                        name: "FK_SubscriberTrainingWorkshop_subscribers_SubscribersId",
                        column: x => x.SubscribersId,
                        principalTable: "subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriberTrainingWorkshop_trainingWorkshops_TrainingWorkshopsId",
                        column: x => x.TrainingWorkshopsId,
                        principalTable: "trainingWorkshops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trainingWorkshopSubscribers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscribersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrainingWorkshopsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainingWorkshopSubscribers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainingWorkshopSubscribers_subscribers_SubscribersId",
                        column: x => x.SubscribersId,
                        principalTable: "subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trainingWorkshopSubscribers_trainingWorkshops_TrainingWorkshopsId",
                        column: x => x.TrainingWorkshopsId,
                        principalTable: "trainingWorkshops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trainingWorkshopSubscribers_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_trainingWorkshopSubscribers_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Scale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinScore = table.Column<int>(type: "int", nullable: false),
                    MaxScore = table.Column<int>(type: "int", nullable: false),
                    CriterionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "ArbitratorClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CycleClassId = table.Column<int>(type: "int", nullable: false),
                    ArbitratorClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitratorClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitratorClass_Arbitrator_ArbitratorClassId",
                        column: x => x.ArbitratorClassId,
                        principalTable: "Arbitrator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArbitratorClass_CycleClass_CycleClassId",
                        column: x => x.CycleClassId,
                        principalTable: "CycleClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Arbitration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArbitratorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arbitration_Arbitrator_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arbitration_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsAgree = table.Column<bool>(type: "bit", nullable: false),
                    TermAndConditionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "CriterionAttachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriterionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    ActualScore = table.Column<int>(type: "int", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: true),
                    CriterionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                name: "ConditionAttachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    ConditionsProvidedFormsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CriterionItemAttachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriterionItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "criterionItemScales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScalesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CriterionItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CriterionItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_criterionItemScales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_criterionItemScales_CriterionItems_CriterionItemId",
                        column: x => x.CriterionItemId,
                        principalTable: "CriterionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_criterionItemScales_Scale_ScaleId",
                        column: x => x.ScaleId,
                        principalTable: "Scale",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AttributeDataTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6782), null, null, null, null, "Text", false },
                    { 2, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6790), null, null, null, null, "Email", false },
                    { 3, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6797), null, null, null, null, "Image", false },
                    { 4, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6802), null, null, null, null, "File", false },
                    { 5, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6808), null, null, null, null, "Phone Number", false },
                    { 6, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6814), null, null, null, null, "Number", false },
                    { 7, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6820), null, null, null, null, "Date", false },
                    { 8, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6825), null, null, null, null, "List", false }
                });

            migrationBuilder.InsertData(
                table: "AttributeOperations",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "OperationAsString", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6984), null, null, null, null, ">", false },
                    { 2, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6992), null, null, null, null, ">=", false },
                    { 3, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6998), null, null, null, null, "<", false },
                    { 4, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(7004), null, null, null, null, "<=", false },
                    { 5, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(7010), null, null, null, null, "=", false },
                    { 6, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(7015), null, null, null, null, "!=", false },
                    { 7, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(7022), null, null, null, null, "is Empty", false },
                    { 8, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(7028), null, null, null, null, "is not Empty", false }
                });

            migrationBuilder.InsertData(
                table: "AttributeTableNames",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[] { 1, new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6641), null, null, null, null, "ProvidedForm", false });

            migrationBuilder.InsertData(
                table: "GeneralFrequentlyAskedQuestionCategories",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار فئة أسئلة شائعة عامة 1", new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6251), null, null, "Test General FAQ Category 1", null, null, false },
                    { 2, "اختبار فئة أسئلة شائعة عامة 2", new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6260), null, null, "Test General FAQ Category 2", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name", "RolePermissionId" },
                values: new object[,]
                {
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db10"), "AccessPermissions", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db11"), "ViewPermissions", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db12"), "ShowPermission", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db13"), "CreatePermission", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db14"), "EditPermission", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db15"), "RemovePermission", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db16"), "All", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba0"), "ShowUser", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba1"), "CreateUser", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba2"), "EditUser", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba3"), "RemoveUser", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba4"), "AccessRoles", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba5"), "ViewRoles", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba6"), "ViewRole", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba7"), "EditRole", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba8"), "RemoveRole", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba9"), "AssignRole", null },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"), "AccessUsers", null },
                    { new Guid("f00b7eb9-c7b9-4f35-8085-cdc97b8a0b47"), "ViewUsers", null }
                });

            migrationBuilder.InsertData(
                table: "PrivacyPolicies",
                columns: new[] { "Id", "ArabicText", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishText", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[] { 1, "سياسة الخصوصية", new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(5282), null, null, "Privacy Policy", null, null, false });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "RoleName", "RolePermissionId", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Admin", null, false },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Subscriber", null, false },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Manager", null, false },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "User", null, false },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Coordinator", null, false }
                });

            migrationBuilder.InsertData(
                table: "TermsOfUses",
                columns: new[] { "Id", "ArabicText", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishText", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[] { 1, "شروط الاستخدام", new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6109), null, null, "Terms Of Use", null, null, false });

            migrationBuilder.InsertData(
                table: "cycles",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "CycleNumber", "DeletedAt", "EnglishName", "GroupCategoryNumber", "IndividualCategoryNumber", "LastModifiedAt", "LastModifiedBy", "RegistrationPortalClosingDate", "RegistrationPortalOpeningDate", "Status", "Year", "isDeleted" },
                values: new object[] { new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"), "جائزة الشارقة", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null, "SharijhaAward", 0, 0, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "2023-2024", false });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ArabicDescription", "ArabicName", "CategoryClassification", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationEndDate", "FinalArbitrationQualificationMark", "FinalArbitrationStartDate", "Icon", "InitialArbitrationEndDate", "InitialArbitrationStartDate", "LastModifiedAt", "LastModifiedBy", "ParentId", "RelatedToClasses", "Status", "SubscriberPortalClosingDate", "WinningScore", "isDeleted" },
                values: new object[] { new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"), "اختبار وصف 1", "اختبار اسم 1", 0, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(1596), null, new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"), null, "Test Description 1", "Test Name 1", 1, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(1609), 0, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(1622), "string", null, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(1627), null, null, null, false, 0, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(1634), 0, false });

            migrationBuilder.InsertData(
                table: "DynamicAttributeSections",
                columns: new[] { "Id", "ArabicName", "AttributeTableNameId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "RecordIdOnRelation", "isDeleted" },
                values: new object[] { 1, "اختبار اسم 1", 1, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3052), null, null, "Test Name 1", null, null, new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"), false });

            migrationBuilder.InsertData(
                table: "GeneralFrequentlyAskedQuestions",
                columns: new[] { "Id", "ArabicAnswer", "ArabicQuestion", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishAnswer", "EnglishQuestion", "GeneralFrequentlyAskedQuestionCategoryId", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"), "اختبار جواب 1", "اختبار سؤال 1", new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6451), null, null, "Test Answer 1", "Test Question 1", 1, null, null, false },
                    { new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"), "اختبار جواب 4", "اختبار سؤال 4", new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6483), null, null, "Test Answer 4", "Test Question 4", 2, null, null, false },
                    { new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"), "اختبار جواب 3", "اختبار سؤال 3", new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6472), null, null, "Test Answer 3", "Test Question 3", 2, null, null, false },
                    { new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"), "اختبار جواب 2", "اختبار سؤال 2", new DateTime(2024, 3, 21, 8, 42, 39, 303, DateTimeKind.Utc).AddTicks(6463), null, null, "Test Answer 2", "Test Question 2", 1, null, null, false }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "ArabicName", "ConfirmationCodeForResetPassword", "ConfirmationCodeForSignUp", "CreatedAt", "CreatedBy", "DeletedAt", "Email", "EnglishName", "Gender", "ImageURL", "LastModifiedAt", "LastModifiedBy", "Password", "PhoneNumber", "RoleId", "isDeleted", "isValidAccount" },
                values: new object[] { new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"), "ادمن 123", null, null, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(2735), null, null, "ahmad.a.ahmad.100011@gmail.com", "Admin 123", 0, null, null, null, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"), false, true });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ArabicDescription", "ArabicName", "CategoryClassification", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationEndDate", "FinalArbitrationQualificationMark", "FinalArbitrationStartDate", "Icon", "InitialArbitrationEndDate", "InitialArbitrationStartDate", "LastModifiedAt", "LastModifiedBy", "ParentId", "RelatedToClasses", "Status", "SubscriberPortalClosingDate", "WinningScore", "isDeleted" },
                values: new object[] { new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"), "اختبار وصف 2", "اختبار اسم 2", 0, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(1650), null, new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"), null, "Test Description 2", "Test Name 2", 1, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(1657), 0, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(1661), "string", null, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(1664), null, null, new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"), false, 0, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(1668), 0, false });

            migrationBuilder.InsertData(
                table: "DynamicAttributes",
                columns: new[] { "Id", "ArabicLabel", "ArabicPlaceHolder", "AttributeDataTypeId", "CreatedAt", "CreatedBy", "DeletedAt", "DynamicAttributeSectionId", "EnglishLabel", "EnglishPlaceHolder", "IsRequired", "IsUnique", "LastModifiedAt", "LastModifiedBy", "LinkedToAnotherAttribute", "MaxSizeInKB", "Status", "isDeleted" },
                values: new object[,]
                {
                    { 1, "اختبار نص 1", "اختبار نص 1", 1, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3216), null, null, 1, "Test Text 1", "Test Text 1", false, false, null, null, false, null, 0, false },
                    { 2, "اختبار ايميل 1", "اختبار ايميل 1", 2, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3236), null, null, 1, "Test Email 1", "Test Email 1", false, false, null, null, false, null, 0, false },
                    { 3, "اختبار صورة 1", "اختبار صورة 1", 3, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3245), null, null, 1, "Test Image 1", "Test Image 1", false, false, null, null, false, 1028, 0, false },
                    { 4, "اختبار ملف 1", "اختبار ملف 1", 4, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3255), null, null, 1, "Test File 1", "Test File 1", false, false, null, null, false, 4112, 0, false },
                    { 5, "اختبار رقم متحرك 1", "اختبار رقم متحرك 1", 5, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3264), null, null, 1, "Test Phone Number 1", "Test Phone Number 1", false, false, null, null, false, null, 0, false },
                    { 6, "اختبار رقم 1", "اختبار رقم 1", 6, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3273), null, null, 1, "Test Number 1", "Test Number 1", false, false, null, null, false, null, 0, false },
                    { 7, "اختبار تاريخ 1", "اختبار تاريخ 1", 7, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3282), null, null, 1, "Test Date 1", "Test Date 1", false, false, null, null, false, null, 0, false },
                    { 8, "اختبار قائمة 1", "اختبار قائمة 1", 8, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3291), null, null, 1, "Test List 1", "Test List 1", false, false, null, null, false, null, 0, false }
                });

            migrationBuilder.InsertData(
                table: "Criterions",
                columns: new[] { "Id", "ArabicTitle", "ArbitrationProcedureId", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "ParentId", "Score", "SizeOfAttachmentInKB", "isDeleted" },
                values: new object[] { new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"), "معيار رئيسي 1", null, new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"), new DateTime(2024, 3, 21, 8, 42, 39, 304, DateTimeKind.Utc).AddTicks(8675), null, null, "Main Criterion 1", null, null, null, 100, 0, false });

            migrationBuilder.InsertData(
                table: "DynamicAttributeListValues",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DynamicAttributeId", "LastModifiedAt", "LastModifiedBy", "Value", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3470), null, null, 8, null, null, "Test Value 1", false },
                    { 2, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3481), null, null, 8, null, null, "Test Value 2", false },
                    { 3, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3487), null, null, 8, null, null, "Test Value 3", false },
                    { 4, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3494), null, null, 8, null, null, "Test Value 4", false },
                    { 5, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(3501), null, null, 8, null, null, "Test Value 5", false }
                });

            migrationBuilder.InsertData(
                table: "ProvidedForms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "CurrentStep", "CycleNumber", "CycleYear", "DeletedAt", "FinalScore", "LastModifiedAt", "LastModifiedBy", "PercentCompletion", "Status", "SubscriberId", "SubscriberType", "TotalStep", "Type", "categoryId", "isDeleted", "userId" },
                values: new object[] { 1, new DateTime(2024, 3, 21, 8, 42, 39, 307, DateTimeKind.Utc).AddTicks(2889), null, 1, 1, "2023-2024", null, 0f, null, null, 1, 0, null, 0, 7, 0, new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"), false, new Guid("81a2c75e-c71c-4213-a372-7626db57e79d") });

            migrationBuilder.InsertData(
                table: "Criterions",
                columns: new[] { "Id", "ArabicTitle", "ArbitrationProcedureId", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "ParentId", "Score", "SizeOfAttachmentInKB", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"), "معيار فرعي 2", null, new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"), new DateTime(2024, 3, 21, 8, 42, 39, 304, DateTimeKind.Utc).AddTicks(8727), null, null, "Sub Criterion 2", null, null, new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"), 50, 5000, false },
                    { new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"), "معيار فرعي 1", null, new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"), new DateTime(2024, 3, 21, 8, 42, 39, 304, DateTimeKind.Utc).AddTicks(8708), null, null, "Sub Criterion 1", null, null, new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"), 50, 5000, false }
                });

            migrationBuilder.InsertData(
                table: "CriterionItems",
                columns: new[] { "Id", "ActualScore", "ArabicName", "CreatedAt", "CreatedBy", "CriterionId", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "ScaleId", "Score", "SizeOfAttachmentInKB", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"), 0, "بند معيار فرعي 22", new DateTime(2024, 3, 21, 8, 42, 39, 304, DateTimeKind.Utc).AddTicks(9002), null, new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"), null, "Sub Criterion Item 22", null, null, null, 50, 5000, false },
                    { new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"), 0, "بند معيار فرعي 21", new DateTime(2024, 3, 21, 8, 42, 39, 304, DateTimeKind.Utc).AddTicks(8988), null, new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"), null, "Sub Criterion Item 21", null, null, null, 50, 5000, false },
                    { new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"), 0, "بند معيار فرعي 11", new DateTime(2024, 3, 21, 8, 42, 39, 304, DateTimeKind.Utc).AddTicks(8952), null, new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"), null, "Sub Criterion Item 11", null, null, null, 50, 5000, false },
                    { new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"), 0, "بند معيار فرعي 12", new DateTime(2024, 3, 21, 8, 42, 39, 304, DateTimeKind.Utc).AddTicks(8973), null, new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"), null, "Sub Criterion Item 12", null, null, null, 50, 5000, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achievement_AchievementClassificationId",
                table: "Achievement",
                column: "AchievementClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Achievement_UserId",
                table: "Achievement",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AchievementClassification_CreatedById",
                table: "AchievementClassification",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AchievementClassification_UpdatedById",
                table: "AchievementClassification",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_CycleId",
                table: "Agenda",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Arbitration_ArbitratorId",
                table: "Arbitration",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Arbitration_ProvidedFormId",
                table: "Arbitration",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationProcedure_CreatedById",
                table: "ArbitrationProcedure",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationProcedure_UpdatedById",
                table: "ArbitrationProcedure",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Arbitrator_CreatedById",
                table: "Arbitrator",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Arbitrator_UpdatedById",
                table: "Arbitrator",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorClass_ArbitratorClassId",
                table: "ArbitratorClass",
                column: "ArbitratorClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorClass_CycleClassId",
                table: "ArbitratorClass",
                column: "CycleClassId");

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
                name: "IX_Categories_CycleId",
                table: "Categories",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryArbitrator_ArbitratorId",
                table: "CategoryArbitrator",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryArbitrator_CategoryId",
                table: "CategoryArbitrator",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCommittee_CommitteesId",
                table: "CategoryCommittee",
                column: "CommitteesId");

            migrationBuilder.CreateIndex(
                name: "IX_categoryCommittees_CategoryId",
                table: "categoryCommittees",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_categoryCommittees_CommitteesId",
                table: "categoryCommittees",
                column: "CommitteesId");

            migrationBuilder.CreateIndex(
                name: "IX_categoryCommittees_CreatedById",
                table: "categoryCommittees",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_categoryCommittees_UpdatedById",
                table: "categoryCommittees",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_categoryFAQs_CategoryId",
                table: "categoryFAQs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Committee_ChairmanId",
                table: "Committee",
                column: "ChairmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Committee_CreatedById",
                table: "Committee",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Committee_UpdatedById",
                table: "Committee",
                column: "UpdatedById");

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
                name: "IX_criterionItemScales_CriterionItemId",
                table: "criterionItemScales",
                column: "CriterionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_criterionItemScales_ScaleId",
                table: "criterionItemScales",
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
                name: "IX_CycleClass_CycleId",
                table: "CycleClass",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleClass_EducationalClassId",
                table: "CycleClass",
                column: "EducationalClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleCondition_CycleId",
                table: "CycleCondition",
                column: "CycleId");

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
                name: "IX_EducationalClass_CreatedById",
                table: "EducationalClass",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalClass_UpdatedById",
                table: "EducationalClass",
                column: "UpdatedById");

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
                name: "IX_explanatoryGuides_CategoryId",
                table: "explanatoryGuides",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_frequentlyAskedQuestions_CategoryId",
                table: "frequentlyAskedQuestions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralFrequentlyAskedQuestions_GeneralFrequentlyAskedQuestionCategoryId",
                table: "GeneralFrequentlyAskedQuestions",
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
                name: "IX_Interview_CreatedById",
                table: "Interview",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_UpdatedById",
                table: "Interview",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_categoryId",
                table: "Meeting",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_CreatedById",
                table: "Meeting",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_UpdatedById",
                table: "Meeting",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingSubscriber_meetingId",
                table: "MeetingSubscriber",
                column: "meetingId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingSubscriber_subscriberId",
                table: "MeetingSubscriber",
                column: "subscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingUser_MeetingId",
                table: "MeetingUser",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingUser_UserId",
                table: "MeetingUser",
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
                name: "IX_Permissions_RolePermissionId",
                table: "Permissions",
                column: "RolePermissionId");

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
                name: "IX_ProvidedForms_SubscriberId",
                table: "ProvidedForms",
                column: "SubscriberId");

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
                name: "IX_RelatedAccounts_Subscriber1Id",
                table: "RelatedAccounts",
                column: "Subscriber1Id");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccounts_Subscriber2Id",
                table: "RelatedAccounts",
                column: "Subscriber2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_RolePermissionId",
                table: "Roles",
                column: "RolePermissionId");

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
                name: "IX_SubscriberAchievement_AchievementClassificationId",
                table: "SubscriberAchievement",
                column: "AchievementClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriberAchievement_CreatedById",
                table: "SubscriberAchievement",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriberAchievement_SubscriberId",
                table: "SubscriberAchievement",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriberAchievement_UpdatedById",
                table: "SubscriberAchievement",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriberInterview_InterviewId",
                table: "SubscriberInterview",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriberInterview_SubscriberId",
                table: "SubscriberInterview",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriberTrainingWorkshop_TrainingWorkshopsId",
                table: "SubscriberTrainingWorkshop",
                column: "TrainingWorkshopsId");

            migrationBuilder.CreateIndex(
                name: "IX_TermsAndConditions_CategoryId",
                table: "TermsAndConditions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_trainingWorkshops_CategoryId",
                table: "trainingWorkshops",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_trainingWorkshopSubscribers_CreatedById",
                table: "trainingWorkshopSubscribers",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_trainingWorkshopSubscribers_SubscribersId",
                table: "trainingWorkshopSubscribers",
                column: "SubscribersId");

            migrationBuilder.CreateIndex(
                name: "IX_trainingWorkshopSubscribers_TrainingWorkshopsId",
                table: "trainingWorkshopSubscribers",
                column: "TrainingWorkshopsId");

            migrationBuilder.CreateIndex(
                name: "IX_trainingWorkshopSubscribers_UpdatedById",
                table: "trainingWorkshopSubscribers",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWrokshopeAttachment_WorkshopeId",
                table: "TrainingWrokshopeAttachment",
                column: "WorkshopeId");

            migrationBuilder.CreateIndex(
                name: "IX_users_RoleId",
                table: "users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievement");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "Arbitration");

            migrationBuilder.DropTable(
                name: "ArbitratorClass");

            migrationBuilder.DropTable(
                name: "ArbitratorInterview");

            migrationBuilder.DropTable(
                name: "CategoryArbitrator");

            migrationBuilder.DropTable(
                name: "CategoryCommittee");

            migrationBuilder.DropTable(
                name: "categoryCommittees");

            migrationBuilder.DropTable(
                name: "categoryFAQs");

            migrationBuilder.DropTable(
                name: "ConditionAttachments");

            migrationBuilder.DropTable(
                name: "CriterionAttachments");

            migrationBuilder.DropTable(
                name: "CriterionItemAttachments");

            migrationBuilder.DropTable(
                name: "criterionItemScales");

            migrationBuilder.DropTable(
                name: "CycleCondition");

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
                name: "explanatoryGuides");

            migrationBuilder.DropTable(
                name: "frequentlyAskedQuestions");

            migrationBuilder.DropTable(
                name: "GeneralFrequentlyAskedQuestions");

            migrationBuilder.DropTable(
                name: "GeneralWorkshops");

            migrationBuilder.DropTable(
                name: "InstitutionCoordinators");

            migrationBuilder.DropTable(
                name: "MeetingSubscriber");

            migrationBuilder.DropTable(
                name: "MeetingUser");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "OurGoals");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Personalnvitees");

            migrationBuilder.DropTable(
                name: "PrivacyPolicies");

            migrationBuilder.DropTable(
                name: "RelatedAccountRequests");

            migrationBuilder.DropTable(
                name: "RelatedAccounts");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "SubscriberAchievement");

            migrationBuilder.DropTable(
                name: "SubscriberInterview");

            migrationBuilder.DropTable(
                name: "SubscriberTrainingWorkshop");

            migrationBuilder.DropTable(
                name: "TermsOfUses");

            migrationBuilder.DropTable(
                name: "trainingWorkshopSubscribers");

            migrationBuilder.DropTable(
                name: "TrainingWrokshopeAttachment");

            migrationBuilder.DropTable(
                name: "CycleClass");

            migrationBuilder.DropTable(
                name: "Arbitrator");

            migrationBuilder.DropTable(
                name: "Committee");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "CriterionItems");

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
                name: "GeneralFrequentlyAskedQuestionCategories");

            migrationBuilder.DropTable(
                name: "Coordinators");

            migrationBuilder.DropTable(
                name: "EducationalInstitutions");

            migrationBuilder.DropTable(
                name: "Meeting");

            migrationBuilder.DropTable(
                name: "AboutAwardPage");

            migrationBuilder.DropTable(
                name: "GroupInvitees");

            migrationBuilder.DropTable(
                name: "AchievementClassification");

            migrationBuilder.DropTable(
                name: "Interview");

            migrationBuilder.DropTable(
                name: "trainingWorkshops");

            migrationBuilder.DropTable(
                name: "EducationalClass");

            migrationBuilder.DropTable(
                name: "ProvidedForms");

            migrationBuilder.DropTable(
                name: "TermsAndConditions");

            migrationBuilder.DropTable(
                name: "Scale");

            migrationBuilder.DropTable(
                name: "AttributeDataTypes");

            migrationBuilder.DropTable(
                name: "DynamicAttributeSections");

            migrationBuilder.DropTable(
                name: "EducationalEntities");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "subscribers");

            migrationBuilder.DropTable(
                name: "Criterions");

            migrationBuilder.DropTable(
                name: "AttributeTableNames");

            migrationBuilder.DropTable(
                name: "ArbitrationProcedure");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "cycles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "RolePermissions");
        }
    }
}
