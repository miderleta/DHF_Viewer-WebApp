using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHF_Viewer_WebApp.Migrations
{
    public partial class ModelRevisions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Infocard",
                table: "Documents",
                type: "TEXT",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Infocard",
                table: "Documents",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 12);
        }
    }
}
