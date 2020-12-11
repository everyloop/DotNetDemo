using Microsoft.EntityFrameworkCore.Migrations;

namespace EFViewAndSPDemo.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 1, 39, "Fredrik", "Johansson" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 2, 29, "Per", "Andersson" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 3, 19, "Anna", "Hansson" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
