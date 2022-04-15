using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningEfc.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TestBarId",
                table: "Foos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foos_TestBarId",
                table: "Foos",
                column: "TestBarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foos_Bars_TestBarId",
                table: "Foos",
                column: "TestBarId",
                principalTable: "Bars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foos_Bars_TestBarId",
                table: "Foos");

            migrationBuilder.DropIndex(
                name: "IX_Foos_TestBarId",
                table: "Foos");

            migrationBuilder.DropColumn(
                name: "TestBarId",
                table: "Foos");
        }
    }
}
