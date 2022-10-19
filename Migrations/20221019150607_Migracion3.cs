using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class Migracion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bookid",
                table: "Prestamo",
                newName: "bookid");

            migrationBuilder.AlterColumn<string>(
                name: "Devolucion",
                table: "Prestamo",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_bookid",
                table: "Prestamo",
                column: "bookid");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Books_bookid",
                table: "Prestamo",
                column: "bookid",
                principalTable: "Books",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Books_bookid",
                table: "Prestamo");

            migrationBuilder.DropIndex(
                name: "IX_Prestamo_bookid",
                table: "Prestamo");

            migrationBuilder.RenameColumn(
                name: "bookid",
                table: "Prestamo",
                newName: "Bookid");

            migrationBuilder.AlterColumn<bool>(
                name: "Devolucion",
                table: "Prestamo",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
