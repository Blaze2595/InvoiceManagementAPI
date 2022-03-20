using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceGenAPI.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paymentgateway",
                columns: table => new
                {
                    PaymentGatewayId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Configured = table.Column<bool>(type: "INTEGER", nullable: false),
                    Additional_field = table.Column<string>(type: "TEXT", nullable: true),
                    Gateway_name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paymentgateway", x => x.PaymentGatewayId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paymentgateway");
        }
    }
}
