using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2_ModelProperties.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DevProp",
                table: "Objectives");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DevProp",
                table: "Objectives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
