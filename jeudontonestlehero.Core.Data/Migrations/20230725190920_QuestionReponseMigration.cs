using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jeudontonestlehero.Core.Data.Migrations
{
    public partial class QuestionReponseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Reponse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reponse_QuestionId",
                table: "Reponse",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reponse_Question_QuestionId",
                table: "Reponse",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reponse_Question_QuestionId",
                table: "Reponse");

            migrationBuilder.DropIndex(
                name: "IX_Reponse_QuestionId",
                table: "Reponse");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Reponse");
        }
    }
}
