using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioCore7.Migrations
{
    public partial class mig_about_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SecondDescription",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Abouts",
                newName: "SubDescription");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Abouts",
                newName: "JobTitle");

            migrationBuilder.RenameColumn(
                name: "SecondTitle",
                table: "Abouts",
                newName: "ImageURL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubDescription",
                table: "Abouts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "JobTitle",
                table: "Abouts",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Abouts",
                newName: "SecondTitle");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Degree",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondDescription",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
