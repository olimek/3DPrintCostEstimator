using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FDMPrintCostEstimator.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filaments_UserData_UserDataId",
                table: "Filaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Printers_UserData_UserDataId",
                table: "Printers");

            migrationBuilder.AlterColumn<int>(
                name: "UserDataId",
                table: "Printers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserDataId",
                table: "Filaments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Filaments_UserData_UserDataId",
                table: "Filaments",
                column: "UserDataId",
                principalTable: "UserData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Printers_UserData_UserDataId",
                table: "Printers",
                column: "UserDataId",
                principalTable: "UserData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filaments_UserData_UserDataId",
                table: "Filaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Printers_UserData_UserDataId",
                table: "Printers");

            migrationBuilder.AlterColumn<int>(
                name: "UserDataId",
                table: "Printers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "UserDataId",
                table: "Filaments",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Filaments_UserData_UserDataId",
                table: "Filaments",
                column: "UserDataId",
                principalTable: "UserData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Printers_UserData_UserDataId",
                table: "Printers",
                column: "UserDataId",
                principalTable: "UserData",
                principalColumn: "Id");
        }
    }
}
