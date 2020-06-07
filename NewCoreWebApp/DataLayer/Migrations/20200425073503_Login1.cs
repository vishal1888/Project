using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Login1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLogins_Employees_LoginId",
                table: "EmployeeLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeLogins",
                table: "EmployeeLogins");

            migrationBuilder.RenameColumn(
                name: "LoginId",
                table: "EmployeeLogins",
                newName: "RefLoginId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EmployeeLogins",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeLogins",
                table: "EmployeeLogins",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogins_RefLoginId",
                table: "EmployeeLogins",
                column: "RefLoginId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLogins_Employees_RefLoginId",
                table: "EmployeeLogins",
                column: "RefLoginId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLogins_Employees_RefLoginId",
                table: "EmployeeLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeLogins",
                table: "EmployeeLogins");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeLogins_RefLoginId",
                table: "EmployeeLogins");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EmployeeLogins");

            migrationBuilder.RenameColumn(
                name: "RefLoginId",
                table: "EmployeeLogins",
                newName: "LoginId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeLogins",
                table: "EmployeeLogins",
                column: "LoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLogins_Employees_LoginId",
                table: "EmployeeLogins",
                column: "LoginId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
