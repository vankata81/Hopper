using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hopper.Data.Migrations
{
    /// <inheritdoc />
    public partial class Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Practices_Sports_SportNamesId",
                table: "Practices");

            migrationBuilder.RenameColumn(
                name: "SportNamesId",
                table: "Practices",
                newName: "SportNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Practices_SportNamesId",
                table: "Practices",
                newName: "IX_Practices_SportNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Practices_Sports_SportNameId",
                table: "Practices",
                column: "SportNameId",
                principalTable: "Sports",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Practices_Sports_SportNameId",
                table: "Practices");

            migrationBuilder.RenameColumn(
                name: "SportNameId",
                table: "Practices",
                newName: "SportNamesId");

            migrationBuilder.RenameIndex(
                name: "IX_Practices_SportNameId",
                table: "Practices",
                newName: "IX_Practices_SportNamesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Practices_Sports_SportNamesId",
                table: "Practices",
                column: "SportNamesId",
                principalTable: "Sports",
                principalColumn: "Id");
        }
    }
}
