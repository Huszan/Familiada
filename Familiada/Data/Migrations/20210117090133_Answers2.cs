using Microsoft.EntityFrameworkCore.Migrations;

namespace Familiada.Data.Migrations
{
    public partial class Answers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ansfers_Questions_QuestionId",
                table: "Ansfers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ansfers",
                table: "Ansfers");

            migrationBuilder.RenameTable(
                name: "Ansfers",
                newName: "Answers");

            migrationBuilder.RenameIndex(
                name: "IX_Ansfers_QuestionId",
                table: "Answers",
                newName: "IX_Answers_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "Ansfers");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionId",
                table: "Ansfers",
                newName: "IX_Ansfers_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ansfers",
                table: "Ansfers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ansfers_Questions_QuestionId",
                table: "Ansfers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
