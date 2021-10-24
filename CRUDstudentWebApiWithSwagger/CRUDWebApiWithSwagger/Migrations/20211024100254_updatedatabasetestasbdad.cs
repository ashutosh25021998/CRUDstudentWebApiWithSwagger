using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDWebApiWithSwagger.Migrations
{
    public partial class updatedatabasetestasbdad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "StudentDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "StudentDetails",
                nullable: false,
                defaultValue: 0);
        }
    }
}
