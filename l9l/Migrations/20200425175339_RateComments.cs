using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace l9l.Migrations
{
    public partial class RateComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Rates");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Rates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberRaters",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TotalRate",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    CommentBody = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Rates");

            migrationBuilder.DropColumn(
                name: "NumberRaters",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TotalRate",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Rates",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
