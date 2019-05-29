using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Api.Data.Migrations
{
    public partial class ProductMovement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductMovements",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovementType = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMovements_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductMovements_ProductId",
                table: "ProductMovements",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductMovements");
        }
    }
}
