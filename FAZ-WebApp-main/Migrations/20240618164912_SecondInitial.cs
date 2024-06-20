using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FAZ.Migrations
{
    /// <inheritdoc />
    public partial class SecondInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MatchParticipations",
                table: "MatchParticipations");

            migrationBuilder.DropColumn(
                name: "RedCard",
                table: "MatchParticipations");

            migrationBuilder.DropColumn(
                name: "YellowCard",
                table: "MatchParticipations");

            migrationBuilder.RenameTable(
                name: "MatchParticipations",
                newName: "MatchParticipation");

            migrationBuilder.RenameColumn(
                name: "GoalsScored",
                table: "MatchParticipation",
                newName: "GoalScored");

            migrationBuilder.AddColumn<int>(
                name: "RefereeId",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Card",
                table: "MatchParticipation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatchParticipation",
                table: "MatchParticipation",
                column: "MatchParticipationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MatchParticipation",
                table: "MatchParticipation");

            migrationBuilder.DropColumn(
                name: "RefereeId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Card",
                table: "MatchParticipation");

            migrationBuilder.RenameTable(
                name: "MatchParticipation",
                newName: "MatchParticipations");

            migrationBuilder.RenameColumn(
                name: "GoalScored",
                table: "MatchParticipations",
                newName: "GoalsScored");

            migrationBuilder.AddColumn<string>(
                name: "RedCard",
                table: "MatchParticipations",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "YellowCard",
                table: "MatchParticipations",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatchParticipations",
                table: "MatchParticipations",
                column: "MatchParticipationId");
        }
    }
}
