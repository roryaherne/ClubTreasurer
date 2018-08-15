using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Data.Migrations
{
    public partial class AppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_AppUser_LastModifiedById",
                table: "BankAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_BankTransactionCategorys_AppUser_LastModifiedById",
                table: "BankTransactionCategorys");

            migrationBuilder.DropForeignKey(
                name: "FK_BankTransactions_AppUser_LastModifiedById",
                table: "BankTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_AppUser_LastModifiedById",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPositions_AppUser_LastModifiedById",
                table: "PlayerPositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser");

            migrationBuilder.RenameTable(
                name: "AppUser",
                newName: "AppUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_AppUsers_LastModifiedById",
                table: "BankAccounts",
                column: "LastModifiedById",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BankTransactionCategorys_AppUsers_LastModifiedById",
                table: "BankTransactionCategorys",
                column: "LastModifiedById",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BankTransactions_AppUsers_LastModifiedById",
                table: "BankTransactions",
                column: "LastModifiedById",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_AppUsers_LastModifiedById",
                table: "Persons",
                column: "LastModifiedById",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPositions_AppUsers_LastModifiedById",
                table: "PlayerPositions",
                column: "LastModifiedById",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_AppUsers_LastModifiedById",
                table: "BankAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_BankTransactionCategorys_AppUsers_LastModifiedById",
                table: "BankTransactionCategorys");

            migrationBuilder.DropForeignKey(
                name: "FK_BankTransactions_AppUsers_LastModifiedById",
                table: "BankTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_AppUsers_LastModifiedById",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPositions_AppUsers_LastModifiedById",
                table: "PlayerPositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.RenameTable(
                name: "AppUsers",
                newName: "AppUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_AppUser_LastModifiedById",
                table: "BankAccounts",
                column: "LastModifiedById",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BankTransactionCategorys_AppUser_LastModifiedById",
                table: "BankTransactionCategorys",
                column: "LastModifiedById",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BankTransactions_AppUser_LastModifiedById",
                table: "BankTransactions",
                column: "LastModifiedById",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_AppUser_LastModifiedById",
                table: "Persons",
                column: "LastModifiedById",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPositions_AppUser_LastModifiedById",
                table: "PlayerPositions",
                column: "LastModifiedById",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
