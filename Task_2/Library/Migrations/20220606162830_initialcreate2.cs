using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class initialcreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__states__catalogs_CatalogDTOId",
                table: "_states");

            migrationBuilder.DropIndex(
                name: "IX__states_CatalogDTOId",
                table: "_states");

            migrationBuilder.DropColumn(
                name: "CatalogDTOId",
                table: "_states");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "_returns",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StateId",
                table: "_returns",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "_rents",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StateId",
                table: "_rents",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX__returns_StateId",
                table: "_returns",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX__returns_UserId",
                table: "_returns",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX__rents_StateId",
                table: "_rents",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX__rents_UserId",
                table: "_rents",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK__rents__states_StateId",
                table: "_rents",
                column: "StateId",
                principalTable: "_states",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__rents__users_UserId",
                table: "_rents",
                column: "UserId",
                principalTable: "_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__returns__states_StateId",
                table: "_returns",
                column: "StateId",
                principalTable: "_states",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__returns__users_UserId",
                table: "_returns",
                column: "UserId",
                principalTable: "_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__states__catalogs_Id",
                table: "_states",
                column: "Id",
                principalTable: "_catalogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__rents__states_StateId",
                table: "_rents");

            migrationBuilder.DropForeignKey(
                name: "FK__rents__users_UserId",
                table: "_rents");

            migrationBuilder.DropForeignKey(
                name: "FK__returns__states_StateId",
                table: "_returns");

            migrationBuilder.DropForeignKey(
                name: "FK__returns__users_UserId",
                table: "_returns");

            migrationBuilder.DropForeignKey(
                name: "FK__states__catalogs_Id",
                table: "_states");

            migrationBuilder.DropIndex(
                name: "IX__returns_StateId",
                table: "_returns");

            migrationBuilder.DropIndex(
                name: "IX__returns_UserId",
                table: "_returns");

            migrationBuilder.DropIndex(
                name: "IX__rents_StateId",
                table: "_rents");

            migrationBuilder.DropIndex(
                name: "IX__rents_UserId",
                table: "_rents");

            migrationBuilder.AddColumn<string>(
                name: "CatalogDTOId",
                table: "_states",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "_returns",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "StateId",
                table: "_returns",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "_rents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "StateId",
                table: "_rents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX__states_CatalogDTOId",
                table: "_states",
                column: "CatalogDTOId");

            migrationBuilder.AddForeignKey(
                name: "FK__states__catalogs_CatalogDTOId",
                table: "_states",
                column: "CatalogDTOId",
                principalTable: "_catalogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
