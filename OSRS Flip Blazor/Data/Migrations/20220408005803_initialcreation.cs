using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSRS_Flip_Blazor.Data.Migrations
{
    public partial class initialcreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(type: "TEXT", nullable: false),
                    BuyPrice = table.Column<int>(type: "INTEGER", nullable: false),
                    SellPrice = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Margin = table.Column<int>(type: "INTEGER", nullable: false),
                    Profit = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flips");
        }
    }
}
