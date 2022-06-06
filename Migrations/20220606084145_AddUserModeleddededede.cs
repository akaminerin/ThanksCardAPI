using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThanksCardAPI.Migrations
{
    public partial class AddUserModeleddededede : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Securities",
                table: "Securities");

            migrationBuilder.RenameTable(
                name: "Securities",
                newName: "Security");

            migrationBuilder.RenameColumn(
                name: "TemplateId",
                table: "Template",
                newName: "Id");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Security",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityName",
                table: "Security",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Security",
                table: "Security",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Security",
                table: "Security");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Security");

            migrationBuilder.DropColumn(
                name: "SecurityName",
                table: "Security");

            migrationBuilder.RenameTable(
                name: "Security",
                newName: "Securities");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Template",
                newName: "TemplateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Securities",
                table: "Securities",
                column: "id");
        }
    }
}
