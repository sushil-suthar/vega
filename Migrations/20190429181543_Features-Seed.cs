using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class FeaturesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Features(Name) Values('Self Drive')");
            migrationBuilder.Sql("Insert into Features(Name) Values('Power Steering')");
            migrationBuilder.Sql("Insert into Features(Name) Values('ABS')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from features");
        }
    }
}
