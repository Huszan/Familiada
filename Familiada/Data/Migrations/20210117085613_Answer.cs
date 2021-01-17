using Microsoft.EntityFrameworkCore.Migrations;

namespace Familiada.Data.Migrations
{
    public partial class Answer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnsferText",
                table: "Ansfers");

            migrationBuilder.AddColumn<string>(
                name: "AnswerText",
                table: "Ansfers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "QuestionVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnswerVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerText = table.Column<string>(nullable: true),
                    Points = table.Column<string>(nullable: true),
                    QuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerVM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerVM_QuestionVM_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionVM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Tries = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false),
                    Finished = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameVM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameVM_QuestionVM_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionVM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserVM_GameVM_GameId",
                        column: x => x.GameId,
                        principalTable: "GameVM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerVM_QuestionId",
                table: "AnswerVM",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_GameVM_QuestionId",
                table: "GameVM",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVM_GameId",
                table: "UserVM",
                column: "GameId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerVM");

            migrationBuilder.DropTable(
                name: "UserVM");

            migrationBuilder.DropTable(
                name: "GameVM");

            migrationBuilder.DropTable(
                name: "QuestionVM");

            migrationBuilder.DropColumn(
                name: "AnswerText",
                table: "Ansfers");

            migrationBuilder.AddColumn<string>(
                name: "AnsferText",
                table: "Ansfers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
