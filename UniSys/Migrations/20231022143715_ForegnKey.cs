using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniSys.Migrations
{
    /// <inheritdoc />
    public partial class ForegnKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCourse",
                table: "Suplie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSuplie",
                table: "Information",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSuplie",
                table: "Exercise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Suplie_IdCourse",
                table: "Suplie",
                column: "IdCourse");

            migrationBuilder.CreateIndex(
                name: "IX_Information_IdSuplie",
                table: "Information",
                column: "IdSuplie");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_IdSuplie",
                table: "Exercise",
                column: "IdSuplie");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_Courses_IdSuplie",
                table: "Exercise",
                column: "IdSuplie",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Information_Courses_IdSuplie",
                table: "Information",
                column: "IdSuplie",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suplie_Courses_IdCourse",
                table: "Suplie",
                column: "IdCourse",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_Courses_IdSuplie",
                table: "Exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_Information_Courses_IdSuplie",
                table: "Information");

            migrationBuilder.DropForeignKey(
                name: "FK_Suplie_Courses_IdCourse",
                table: "Suplie");

            migrationBuilder.DropIndex(
                name: "IX_Suplie_IdCourse",
                table: "Suplie");

            migrationBuilder.DropIndex(
                name: "IX_Information_IdSuplie",
                table: "Information");

            migrationBuilder.DropIndex(
                name: "IX_Exercise_IdSuplie",
                table: "Exercise");

            migrationBuilder.DropColumn(
                name: "IdCourse",
                table: "Suplie");

            migrationBuilder.DropColumn(
                name: "IdSuplie",
                table: "Information");

            migrationBuilder.DropColumn(
                name: "IdSuplie",
                table: "Exercise");
        }
    }
}
