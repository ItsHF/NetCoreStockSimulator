using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreStockChart.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "paidamount",
                table: "orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "paidamount",
                table: "orders");
        }
    }
}
