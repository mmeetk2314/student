using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace student.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_Name = table.Column<string>(nullable: true),
                    student_Email = table.Column<string>(nullable: true),
                    student_Mobile = table.Column<string>(nullable: true),
                    course_Name = table.Column<string>(nullable: true),
                    course_Duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
            var sqlFile = Path.Combine(".\\Database Script", @"data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
