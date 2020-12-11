using Microsoft.EntityFrameworkCore.Migrations;

namespace EFViewAndSPDemo.Migrations
{
    public partial class AddViewUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                create view users as
                select
	                lower(Left(Firstname, 3) + left(LastName, 3)) as 'UserName',
	                Firstname + ' ' + LastName as 'FullName',
	                lower(reverse(firstname)) as 'Password'
                from
	                People;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                drop view users;
            ");
        }
    }
}
