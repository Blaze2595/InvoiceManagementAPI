using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceGenAPI.Data.Migrations
{
    public partial class TableAdjusted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentGatewayId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Paymentgateway",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Paymentgateway");

            migrationBuilder.AddColumn<int>(
                name: "PaymentGatewayId",
                table: "Customers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
