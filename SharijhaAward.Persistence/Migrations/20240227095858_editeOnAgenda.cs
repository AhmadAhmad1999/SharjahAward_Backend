using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnAgenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
 

            migrationBuilder.DropColumn(
                name: "ArabicNote",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "EnglishNote",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Agenda");

 

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Agenda",
                type: "bit",
                nullable: false,
                defaultValue: false);


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {



            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Agenda");

   

            migrationBuilder.AddColumn<string>(
                name: "ArabicNote",
                table: "Agenda",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnglishNote",
                table: "Agenda",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Slug",
                table: "Agenda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Agenda",
                type: "int",
                nullable: false,
                defaultValue: 0);

        }
    }
}
