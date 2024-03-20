using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addGeneralFaq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

  



           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
