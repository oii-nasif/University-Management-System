using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class RemainingCreditRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemainingCredit",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "CourseAssignments");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Courses");

            migrationBuilder.AddColumn<double>(
                name: "RemainingCredit",
                table: "Teachers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "CourseAssignments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
