using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediaWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddTotalRatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalRatings",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalRatings",
                table: "Books");
        }
    }
}
