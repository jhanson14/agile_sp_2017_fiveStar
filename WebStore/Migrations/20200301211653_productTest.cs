using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
	public partial class productTest : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.UpdateData(
				table: "Products",
				keyColumn: "Id",
				keyValue: 1,
				column: "FilePath",
				value: "/images/basicMonitor.jpg");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.UpdateData(
				table: "Products",
				keyColumn: "Id",
				keyValue: 1,
				column: "FilePath",
				value: "/ images / basicMonitor.jpg");
		}
	}
}
