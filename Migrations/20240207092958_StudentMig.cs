using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStudentDatabaseAPI.Migrations
{
    public partial class StudentMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mark = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StuId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
