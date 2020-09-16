using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Mercury.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // product table
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false).Annotation("MySql:ValueGenerationStrategy",
                        MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "mediumtext", nullable: false),
                    Quantity = table.Column<int>(type: "int(10)", nullable: false),
                    Price = table.Column<int>(type: "int(10)", nullable: false),
                    Image = table.Column<string>(type: "varchar(100)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "now()")
                },
                constraints: table => { table.PrimaryKey("PK_product", x => x.Id); }
            );
            // user table 
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false).Annotation("MySql:ValueGenerationStrategy",
                        MySqlValueGenerationStrategy.IdentityColumn),
                    address = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 50, nullable: false),
                    firstname = table.Column<string>(name: "firstname", maxLength: 30, nullable: false),
                    lastname = table.Column<string>(name: "lastname", maxLength: 30, nullable: false),
                    password = table.Column<string>(maxLength: 20, nullable: false),
                    phone = table.Column<string>(maxLength: 20, nullable: false)
                    // CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "now()"),
                    // UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "now()")
                },
                constraints: table => { table.PrimaryKey("Id", x => x.Id); }
            );
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(10)", nullable: false).Annotation("MySql:ValueGenerationStrategy",
                        MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int(10)", nullable: false),
                    UserId = table.Column<int>(type: "int(10)", nullable: false),
                    Quantity = table.Column<int>(type: "int(10)", nullable: false)
                    // CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "now()"),
                    // UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductID",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserID",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Users");
            migrationBuilder.DropTable(name: "Products");
            migrationBuilder.DropTable(name: "Orders");
        }
    }
}