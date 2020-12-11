using Microsoft.EntityFrameworkCore.Migrations;

namespace EFViewAndSPDemo.Migrations
{
    public partial class AddSPRandom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                create procedure [dbo].[random] (@rows int = 10) as
                begin

	                -- Test kommentar
	                declare @i int = 1;

	                declare @myTable table
	                (
		                n int,
		                r float
	                );

	                while @i <= @rows
	                begin
		                insert into @myTable values(@i, rand());
		                set @i += 1;
	                end

	                select * from @myTable;
                end;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                drop procedure random;
            ");
        }
    }
}
