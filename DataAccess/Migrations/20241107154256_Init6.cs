using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Groups");

            migrationBuilder.RenameColumn(
                name: "JoinDate",
                table: "Groups",
                newName: "CreatedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Groups",
                newName: "JoinDate");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Groups",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
