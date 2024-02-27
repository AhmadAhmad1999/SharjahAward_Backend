using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Ahmad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "cycles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "EducationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationTypes", x => x.Id);
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
                name: "DynamicAttributeSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
                    LinkedToAnotherAttribute = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                name: "trainingWorkshops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfAttachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicWorkshopAttachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishWorkshopAttachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    RecordId = table.Column<int>(type: "int", nullable: false),
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
                name: "Coordinator",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coordinator_EducationTypes_EducationTypeId",
                        column: x => x.EducationTypeId,
                        principalTable: "EducationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Coordinator_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Coordinator_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CycleCondition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CycleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_CycleCondition_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CycleCondition_users_UpdatedById",
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
                name: "TermsAndConditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeedAttachment = table.Column<bool>(type: "bit", nullable: false),
                    RequiredAttachmentNumber = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_TermsAndConditions_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TermsAndConditions_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Criterion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArbitrationProcedureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criterion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criterion_ArbitrationProcedure_ArbitrationProcedureId",
                        column: x => x.ArbitrationProcedureId,
                        principalTable: "ArbitrationProcedure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Criterion_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Criterion_Criterion_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Criterion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Criterion_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Criterion_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
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
                name: "Achievement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    classificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    subscriberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achievement_AchievementClassification_classificationId",
                        column: x => x.classificationId,
                        principalTable: "AchievementClassification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Achievement_subscribers_subscriberId",
                        column: x => x.subscriberId,
                        principalTable: "subscribers",
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Arabic_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    English_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Male = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identity_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationTypeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    subscriberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    categoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                        name: "FK_ProvidedForms_EducationTypes_EducationTypeId",
                        column: x => x.EducationTypeId,
                        principalTable: "EducationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProvidedForms_subscribers_subscriberId",
                        column: x => x.subscriberId,
                        principalTable: "subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProvidedForms_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProvidedForms_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RelatedAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedAccount_subscribers_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedAccount_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RelatedAccount_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
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
                name: "CriterionItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    ActualScore = table.Column<int>(type: "int", nullable: false),
                    CriterionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterionItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriterionItem_Criterion_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "Criterion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriterionItem_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CriterionItem_users_UpdatedById",
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
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scale_Criterion_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "Criterion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scale_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Scale_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
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
                    ProvidedFormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                name: "CoordinatorProvidedForm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoordinatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvidedFormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoordinatorProvidedForm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoordinatorProvidedForm_Coordinator_CoordinatorId",
                        column: x => x.CoordinatorId,
                        principalTable: "Coordinator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoordinatorProvidedForm_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FormCondition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgreeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsSpecial = table.Column<bool>(type: "bit", nullable: false),
                    ProvidedFormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormCondition_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CriterionItemScale",
                columns: table => new
                {
                    CriterionItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScalesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterionItemScale", x => new { x.CriterionItemsId, x.ScalesId });
                    table.ForeignKey(
                        name: "FK_CriterionItemScale_CriterionItem_CriterionItemsId",
                        column: x => x.CriterionItemsId,
                        principalTable: "CriterionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriterionItemScale_Scale_ScalesId",
                        column: x => x.ScalesId,
                        principalTable: "Scale",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "criterionItemScales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScalesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CriterionItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_criterionItemScales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_criterionItemScales_CriterionItem_CriterionItemsId",
                        column: x => x.CriterionItemsId,
                        principalTable: "CriterionItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_criterionItemScales_Scale_ScalesId",
                        column: x => x.ScalesId,
                        principalTable: "Scale",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_criterionItemScales_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_criterionItemScales_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
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
                table: "Roles",
                columns: new[] { "RoleId", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "RoleName", "RolePermissionId", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Admin", null, false },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Subscriber", null, false },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Manager", null, false },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "User", null, false }
                });

            migrationBuilder.InsertData(
                table: "cycles",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "GroupCategoryNumber", "IndividualCategoryNumber", "LastModifiedAt", "LastModifiedBy", "RegistrationPortalClosingDate", "RegistrationPortalOpeningDate", "Status", "Year", "isDeleted" },
                values: new object[] { new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"), "جائزة الشارقة", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "SharijhaAward", 0, 0, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "2023-2024", false });

            migrationBuilder.CreateIndex(
                name: "IX_Achievement_classificationId",
                table: "Achievement",
                column: "classificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Achievement_subscriberId",
                table: "Achievement",
                column: "subscriberId");

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
                name: "IX_Coordinator_CreatedById",
                table: "Coordinator",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinator_EducationTypeId",
                table: "Coordinator",
                column: "EducationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinator_UpdatedById",
                table: "Coordinator",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CoordinatorProvidedForm_CoordinatorId",
                table: "CoordinatorProvidedForm",
                column: "CoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_CoordinatorProvidedForm_ProvidedFormId",
                table: "CoordinatorProvidedForm",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Criterion_ArbitrationProcedureId",
                table: "Criterion",
                column: "ArbitrationProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_Criterion_CategoryId",
                table: "Criterion",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Criterion_CreatedById",
                table: "Criterion",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Criterion_ParentId",
                table: "Criterion",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Criterion_UpdatedById",
                table: "Criterion",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItem_CreatedById",
                table: "CriterionItem",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItem_CriterionId",
                table: "CriterionItem",
                column: "CriterionId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItem_UpdatedById",
                table: "CriterionItem",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemScale_ScalesId",
                table: "CriterionItemScale",
                column: "ScalesId");

            migrationBuilder.CreateIndex(
                name: "IX_criterionItemScales_CreatedById",
                table: "criterionItemScales",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_criterionItemScales_CriterionItemsId",
                table: "criterionItemScales",
                column: "CriterionItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_criterionItemScales_ScalesId",
                table: "criterionItemScales",
                column: "ScalesId");

            migrationBuilder.CreateIndex(
                name: "IX_criterionItemScales_UpdatedById",
                table: "criterionItemScales",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CycleClass_CycleId",
                table: "CycleClass",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleClass_EducationalClassId",
                table: "CycleClass",
                column: "EducationalClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleCondition_CreatedById",
                table: "CycleCondition",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CycleCondition_CycleId",
                table: "CycleCondition",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleCondition_UpdatedById",
                table: "CycleCondition",
                column: "UpdatedById");

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
                name: "IX_FormCondition_ProvidedFormId",
                table: "FormCondition",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_frequentlyAskedQuestions_CategoryId",
                table: "frequentlyAskedQuestions",
                column: "CategoryId");

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
                name: "IX_ProvidedForms_CreatedById",
                table: "ProvidedForms",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForms_EducationTypeId",
                table: "ProvidedForms",
                column: "EducationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForms_subscriberId",
                table: "ProvidedForms",
                column: "subscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForms_UpdatedById",
                table: "ProvidedForms",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccount_CreatedById",
                table: "RelatedAccount",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccount_SubscriberId",
                table: "RelatedAccount",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccount_UpdatedById",
                table: "RelatedAccount",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_RolePermissionId",
                table: "Roles",
                column: "RolePermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Scale_CreatedById",
                table: "Scale",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Scale_CriterionId",
                table: "Scale",
                column: "CriterionId");

            migrationBuilder.CreateIndex(
                name: "IX_Scale_UpdatedById",
                table: "Scale",
                column: "UpdatedById");

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
                name: "IX_TermsAndConditions_CreatedById",
                table: "TermsAndConditions",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TermsAndConditions_UpdatedById",
                table: "TermsAndConditions",
                column: "UpdatedById");

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
                name: "CoordinatorProvidedForm");

            migrationBuilder.DropTable(
                name: "CriterionItemScale");

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
                name: "DynamicAttributeValues");

            migrationBuilder.DropTable(
                name: "FormCondition");

            migrationBuilder.DropTable(
                name: "frequentlyAskedQuestions");

            migrationBuilder.DropTable(
                name: "MeetingSubscriber");

            migrationBuilder.DropTable(
                name: "MeetingUser");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Personalnvitees");

            migrationBuilder.DropTable(
                name: "RelatedAccount");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "SubscriberAchievement");

            migrationBuilder.DropTable(
                name: "SubscriberInterview");

            migrationBuilder.DropTable(
                name: "SubscriberTrainingWorkshop");

            migrationBuilder.DropTable(
                name: "TermsAndConditions");

            migrationBuilder.DropTable(
                name: "trainingWorkshopSubscribers");

            migrationBuilder.DropTable(
                name: "CycleClass");

            migrationBuilder.DropTable(
                name: "Arbitrator");

            migrationBuilder.DropTable(
                name: "Committee");

            migrationBuilder.DropTable(
                name: "Coordinator");

            migrationBuilder.DropTable(
                name: "CriterionItem");

            migrationBuilder.DropTable(
                name: "Scale");

            migrationBuilder.DropTable(
                name: "StaticAttributes");

            migrationBuilder.DropTable(
                name: "DependencyGroup");

            migrationBuilder.DropTable(
                name: "AttributeOperations");

            migrationBuilder.DropTable(
                name: "DynamicAttributes");

            migrationBuilder.DropTable(
                name: "ProvidedForms");

            migrationBuilder.DropTable(
                name: "Meeting");

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
                name: "Criterion");

            migrationBuilder.DropTable(
                name: "AttributeDataTypes");

            migrationBuilder.DropTable(
                name: "DynamicAttributeSections");

            migrationBuilder.DropTable(
                name: "EducationTypes");

            migrationBuilder.DropTable(
                name: "subscribers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "ArbitrationProcedure");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AttributeTableNames");

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
