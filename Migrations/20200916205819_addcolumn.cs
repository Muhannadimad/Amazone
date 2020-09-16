using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Mercury.Migrations
{
    public partial class addcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
            name: "CreatedAt",
            table: "Users",
            nullable: false,
            // this gives this exception :" Invalid default value for 'CreatedAt' "
            defaultValue: "now()"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}