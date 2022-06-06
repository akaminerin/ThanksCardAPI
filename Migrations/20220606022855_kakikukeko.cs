using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ThanksCardAPI.Migrations
{
    public partial class kakikukeko : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCardTag_ThanksCards_ThanksCardId",
                table: "ThanksCardTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThanksCards",
                table: "ThanksCards");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ThanksCards",
                newName: "ThanksCardtitle");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ThanksCards",
                newName: "TitleiD");

            migrationBuilder.AlterColumn<long>(
                name: "TitleiD",
                table: "ThanksCards",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<long>(
                name: "ThanksCardid",
                table: "ThanksCards",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Countiine",
                table: "ThanksCards",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Countkaizen",
                table: "ThanksCards",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "TemplateameTemplateid",
                table: "ThanksCards",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThanksCards",
                table: "ThanksCards",
                column: "ThanksCardid");

            migrationBuilder.CreateTable(
                name: "Template",
                columns: table => new
                {
                    Templateid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Templateame = table.Column<string>(type: "text", nullable: false),
                    Templatemessage = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Template", x => x.Templateid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThanksCards_TemplateameTemplateid",
                table: "ThanksCards",
                column: "TemplateameTemplateid");

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_Template_TemplateameTemplateid",
                table: "ThanksCards",
                column: "TemplateameTemplateid",
                principalTable: "Template",
                principalColumn: "Templateid");

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCardTag_ThanksCards_ThanksCardId",
                table: "ThanksCardTag",
                column: "ThanksCardId",
                principalTable: "ThanksCards",
                principalColumn: "ThanksCardid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Template_TemplateameTemplateid",
                table: "ThanksCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCardTag_ThanksCards_ThanksCardId",
                table: "ThanksCardTag");

            migrationBuilder.DropTable(
                name: "Template");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThanksCards",
                table: "ThanksCards");

            migrationBuilder.DropIndex(
                name: "IX_ThanksCards_TemplateameTemplateid",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "ThanksCardid",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "Countiine",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "Countkaizen",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "TemplateameTemplateid",
                table: "ThanksCards");

            migrationBuilder.RenameColumn(
                name: "TitleiD",
                table: "ThanksCards",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ThanksCardtitle",
                table: "ThanksCards",
                newName: "Title");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "ThanksCards",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThanksCards",
                table: "ThanksCards",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCardTag_ThanksCards_ThanksCardId",
                table: "ThanksCardTag",
                column: "ThanksCardId",
                principalTable: "ThanksCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
