using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssAPI.Migrations
{
    /// <inheritdoc />
    public partial class hiiii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_KhachHang_KhachHangIdKhachHang",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NhanVien_NhanVienMaNhanVien",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Role_RoleIdRole",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleIdRole",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_KhachHangIdKhachHang",
                table: "HoaDons");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_NhanVienMaNhanVien",
                table: "HoaDons");

            migrationBuilder.DropColumn(
                name: "RoleIdRole",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "KhachHangIdKhachHang",
                table: "HoaDons");

            migrationBuilder.DropColumn(
                name: "NhanVienMaNhanVien",
                table: "HoaDons");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdRole",
                table: "Users",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdKhachHang",
                table: "HoaDons",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_MaNhanVien",
                table: "HoaDons",
                column: "MaNhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_KhachHang_IdKhachHang",
                table: "HoaDons",
                column: "IdKhachHang",
                principalTable: "KhachHang",
                principalColumn: "IdKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_NhanVien_MaNhanVien",
                table: "HoaDons",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Role_IdRole",
                table: "Users",
                column: "IdRole",
                principalTable: "Role",
                principalColumn: "IdRole",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_KhachHang_IdKhachHang",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NhanVien_MaNhanVien",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Role_IdRole",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_IdRole",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_IdKhachHang",
                table: "HoaDons");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_MaNhanVien",
                table: "HoaDons");

            migrationBuilder.AddColumn<int>(
                name: "RoleIdRole",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KhachHangIdKhachHang",
                table: "HoaDons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NhanVienMaNhanVien",
                table: "HoaDons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleIdRole",
                table: "Users",
                column: "RoleIdRole");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangIdKhachHang",
                table: "HoaDons",
                column: "KhachHangIdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_NhanVienMaNhanVien",
                table: "HoaDons",
                column: "NhanVienMaNhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_KhachHang_KhachHangIdKhachHang",
                table: "HoaDons",
                column: "KhachHangIdKhachHang",
                principalTable: "KhachHang",
                principalColumn: "IdKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_NhanVien_NhanVienMaNhanVien",
                table: "HoaDons",
                column: "NhanVienMaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Role_RoleIdRole",
                table: "Users",
                column: "RoleIdRole",
                principalTable: "Role",
                principalColumn: "IdRole",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
