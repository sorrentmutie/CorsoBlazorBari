using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoBlazorApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class seconda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clienti",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clienti");
        }
    }
}
