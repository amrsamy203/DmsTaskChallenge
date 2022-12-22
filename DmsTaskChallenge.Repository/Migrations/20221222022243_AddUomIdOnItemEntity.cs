using Microsoft.EntityFrameworkCore.Migrations;

namespace DmsTaskChallenge.Repository.Migrations
{
    public partial class AddUomIdOnItemEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Uoms_UomId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "UomId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Uoms_UomId",
                table: "Items",
                column: "UomId",
                principalTable: "Uoms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Uoms_UomId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "UomId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Uoms_UomId",
                table: "Items",
                column: "UomId",
                principalTable: "Uoms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
