using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class changeNameOfCoulms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "users",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "users",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "trainingWorkshops",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "trainingWorkshops",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Roles",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Roles",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Personalnvitees",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Personalnvitees",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "News",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "News",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "GroupInvitees",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "GroupInvitees",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "frequentlyAskedQuestions",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "frequentlyAskedQuestions",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Events",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Events",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "cycles",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "cycles",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Categories",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Categories",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Agenda",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Agenda",
                newName: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "users",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "users",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "trainingWorkshops",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "trainingWorkshops",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Roles",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Roles",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Personalnvitees",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Personalnvitees",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "News",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "News",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "GroupInvitees",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "GroupInvitees",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "frequentlyAskedQuestions",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "frequentlyAskedQuestions",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Events",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Events",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "cycles",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "cycles",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Categories",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Categories",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Agenda",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Agenda",
                newName: "CreatedDate");
        }
    }
}
