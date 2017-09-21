using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace efcminimaltestcase.Migrations
{
    public partial class TestField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AmountCharged_Currency",
                table: "BusinessTransactions",
                newName: "ChargeFee_Currency");

            migrationBuilder.RenameColumn(
                name: "AmountCharged_Amount",
                table: "BusinessTransactions",
                newName: "ChargeFee_Amount");

            migrationBuilder.AddColumn<decimal>(
                name: "AmountCharged_Amount",
                table: "BusinessTransactions",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "AmountCharged_Currency",
                table: "BusinessTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountCharged_Amount",
                table: "BusinessTransactions");

            migrationBuilder.DropColumn(
                name: "AmountCharged_Currency",
                table: "BusinessTransactions");

            migrationBuilder.RenameColumn(
                name: "ChargeFee_Currency",
                table: "BusinessTransactions",
                newName: "AmountCharged_Currency");

            migrationBuilder.RenameColumn(
                name: "ChargeFee_Amount",
                table: "BusinessTransactions",
                newName: "AmountCharged_Amount");
        }
    }
}
