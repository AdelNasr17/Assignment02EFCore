using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment02EFCore.Migrations
{
    /// <inheritdoc />
    public partial class CreateCourseInstructorAndStudentCourseTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses_Instructors",
                columns: table => new
                {
                    Inst_Id = table.Column<int>(type: "int", nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Evaluate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses_Instructors", x => new { x.Course_Id, x.Inst_Id });
                });

            migrationBuilder.CreateTable(
                name: "Students_Courses",
                columns: table => new
                {
                    Stud_Id = table.Column<int>(type: "int", nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students_Courses", x => new { x.Course_Id, x.Stud_Id });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses_Instructors");

            migrationBuilder.DropTable(
                name: "Students_Courses");
        }
    }
}
