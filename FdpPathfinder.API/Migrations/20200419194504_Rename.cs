using Microsoft.EntityFrameworkCore.Migrations;

namespace FdpPathfinder.API.Migrations
{
    public partial class Rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charaters_Players_PlayerId",
                table: "Charaters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Charaters",
                table: "Charaters");

            migrationBuilder.RenameTable(
                name: "Charaters",
                newName: "Characters");

            migrationBuilder.RenameIndex(
                name: "IX_Charaters_PlayerId",
                table: "Characters",
                newName: "IX_Characters_PlayerId");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Players",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nom",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "People",
                table: "Characters",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Players_PlayerId",
                table: "Characters",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Players_PlayerId",
                table: "Characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "People",
                table: "Characters");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "Charaters");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_PlayerId",
                table: "Charaters",
                newName: "IX_Charaters_PlayerId");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "nom",
                table: "Charaters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Charaters",
                table: "Charaters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Charaters_Players_PlayerId",
                table: "Charaters",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
