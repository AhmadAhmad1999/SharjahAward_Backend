using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateGroupInviteesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupInvitees");
        }
    }
}
