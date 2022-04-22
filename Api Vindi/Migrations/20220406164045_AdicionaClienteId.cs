using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_Vindi.Migrations
{
    public partial class AdicionaClienteId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "User");

            
        }
    }
}
