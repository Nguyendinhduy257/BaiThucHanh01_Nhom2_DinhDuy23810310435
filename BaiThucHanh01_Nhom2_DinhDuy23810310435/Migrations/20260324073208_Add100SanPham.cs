using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Migrations
{
    /// <inheritdoc />
    public partial class Add100SanPham : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SanPham",
                columns: new[] { "Id", "DuongDanAnh", "GiaBan", "GiaGoc", "IsFeatureProduct", "IsNewProduct", "IsOnSale", "PhanTramGiam", "TenSanPham" },
                values: new object[,]
                {
                    { 1, "/lib/product-2.png", 51.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 1" },
                    { 2, "/lib/product-3.png", 52.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 2" },
                    { 3, "/lib/product-4.png", 53.0m, 73.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 3" },
                    { 4, "/lib/product-1.png", 54.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 4" },
                    { 5, "/lib/product-2.png", 55.0m, null, true, false, false, null, "Sản phẩm thời trang mẫu 5" },
                    { 6, "/lib/product-3.png", 56.0m, 76.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 6" },
                    { 7, "/lib/product-4.png", 57.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 7" },
                    { 8, "/lib/product-1.png", 58.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 8" },
                    { 9, "/lib/product-2.png", 59.0m, 79.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 9" },
                    { 10, "/lib/product-3.png", 60.0m, null, true, true, false, null, "Sản phẩm thời trang mẫu 10" },
                    { 11, "/lib/product-4.png", 61.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 11" },
                    { 12, "/lib/product-1.png", 62.0m, 82.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 12" },
                    { 13, "/lib/product-2.png", 63.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 13" },
                    { 14, "/lib/product-3.png", 64.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 14" },
                    { 15, "/lib/product-4.png", 65.0m, 85.0m, true, false, true, 15, "Sản phẩm thời trang mẫu 15" },
                    { 16, "/lib/product-1.png", 66.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 16" },
                    { 17, "/lib/product-2.png", 67.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 17" },
                    { 18, "/lib/product-3.png", 68.0m, 88.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 18" },
                    { 19, "/lib/product-4.png", 69.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 19" },
                    { 20, "/lib/product-1.png", 50.0m, null, true, true, false, null, "Sản phẩm thời trang mẫu 20" },
                    { 21, "/lib/product-2.png", 51.0m, 71.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 21" },
                    { 22, "/lib/product-3.png", 52.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 22" },
                    { 23, "/lib/product-4.png", 53.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 23" },
                    { 24, "/lib/product-1.png", 54.0m, 74.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 24" },
                    { 25, "/lib/product-2.png", 55.0m, null, true, false, false, null, "Sản phẩm thời trang mẫu 25" },
                    { 26, "/lib/product-3.png", 56.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 26" },
                    { 27, "/lib/product-4.png", 57.0m, 77.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 27" },
                    { 28, "/lib/product-1.png", 58.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 28" },
                    { 29, "/lib/product-2.png", 59.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 29" },
                    { 30, "/lib/product-3.png", 60.0m, 80.0m, true, true, true, 15, "Sản phẩm thời trang mẫu 30" },
                    { 31, "/lib/product-4.png", 61.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 31" },
                    { 32, "/lib/product-1.png", 62.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 32" },
                    { 33, "/lib/product-2.png", 63.0m, 83.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 33" },
                    { 34, "/lib/product-3.png", 64.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 34" },
                    { 35, "/lib/product-4.png", 65.0m, null, true, false, false, null, "Sản phẩm thời trang mẫu 35" },
                    { 36, "/lib/product-1.png", 66.0m, 86.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 36" },
                    { 37, "/lib/product-2.png", 67.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 37" },
                    { 38, "/lib/product-3.png", 68.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 38" },
                    { 39, "/lib/product-4.png", 69.0m, 89.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 39" },
                    { 40, "/lib/product-1.png", 50.0m, null, true, true, false, null, "Sản phẩm thời trang mẫu 40" },
                    { 41, "/lib/product-2.png", 51.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 41" },
                    { 42, "/lib/product-3.png", 52.0m, 72.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 42" },
                    { 43, "/lib/product-4.png", 53.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 43" },
                    { 44, "/lib/product-1.png", 54.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 44" },
                    { 45, "/lib/product-2.png", 55.0m, 75.0m, true, false, true, 15, "Sản phẩm thời trang mẫu 45" },
                    { 46, "/lib/product-3.png", 56.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 46" },
                    { 47, "/lib/product-4.png", 57.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 47" },
                    { 48, "/lib/product-1.png", 58.0m, 78.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 48" },
                    { 49, "/lib/product-2.png", 59.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 49" },
                    { 50, "/lib/product-3.png", 60.0m, null, true, true, false, null, "Sản phẩm thời trang mẫu 50" },
                    { 51, "/lib/product-4.png", 61.0m, 81.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 51" },
                    { 52, "/lib/product-1.png", 62.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 52" },
                    { 53, "/lib/product-2.png", 63.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 53" },
                    { 54, "/lib/product-3.png", 64.0m, 84.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 54" },
                    { 55, "/lib/product-4.png", 65.0m, null, true, false, false, null, "Sản phẩm thời trang mẫu 55" },
                    { 56, "/lib/product-1.png", 66.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 56" },
                    { 57, "/lib/product-2.png", 67.0m, 87.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 57" },
                    { 58, "/lib/product-3.png", 68.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 58" },
                    { 59, "/lib/product-4.png", 69.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 59" },
                    { 60, "/lib/product-1.png", 50.0m, 70.0m, true, true, true, 15, "Sản phẩm thời trang mẫu 60" },
                    { 61, "/lib/product-2.png", 51.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 61" },
                    { 62, "/lib/product-3.png", 52.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 62" },
                    { 63, "/lib/product-4.png", 53.0m, 73.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 63" },
                    { 64, "/lib/product-1.png", 54.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 64" },
                    { 65, "/lib/product-2.png", 55.0m, null, true, false, false, null, "Sản phẩm thời trang mẫu 65" },
                    { 66, "/lib/product-3.png", 56.0m, 76.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 66" },
                    { 67, "/lib/product-4.png", 57.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 67" },
                    { 68, "/lib/product-1.png", 58.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 68" },
                    { 69, "/lib/product-2.png", 59.0m, 79.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 69" },
                    { 70, "/lib/product-3.png", 60.0m, null, true, true, false, null, "Sản phẩm thời trang mẫu 70" },
                    { 71, "/lib/product-4.png", 61.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 71" },
                    { 72, "/lib/product-1.png", 62.0m, 82.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 72" },
                    { 73, "/lib/product-2.png", 63.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 73" },
                    { 74, "/lib/product-3.png", 64.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 74" },
                    { 75, "/lib/product-4.png", 65.0m, 85.0m, true, false, true, 15, "Sản phẩm thời trang mẫu 75" },
                    { 76, "/lib/product-1.png", 66.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 76" },
                    { 77, "/lib/product-2.png", 67.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 77" },
                    { 78, "/lib/product-3.png", 68.0m, 88.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 78" },
                    { 79, "/lib/product-4.png", 69.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 79" },
                    { 80, "/lib/product-1.png", 50.0m, null, true, true, false, null, "Sản phẩm thời trang mẫu 80" },
                    { 81, "/lib/product-2.png", 51.0m, 71.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 81" },
                    { 82, "/lib/product-3.png", 52.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 82" },
                    { 83, "/lib/product-4.png", 53.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 83" },
                    { 84, "/lib/product-1.png", 54.0m, 74.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 84" },
                    { 85, "/lib/product-2.png", 55.0m, null, true, false, false, null, "Sản phẩm thời trang mẫu 85" },
                    { 86, "/lib/product-3.png", 56.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 86" },
                    { 87, "/lib/product-4.png", 57.0m, 77.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 87" },
                    { 88, "/lib/product-1.png", 58.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 88" },
                    { 89, "/lib/product-2.png", 59.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 89" },
                    { 90, "/lib/product-3.png", 60.0m, 80.0m, true, true, true, 15, "Sản phẩm thời trang mẫu 90" },
                    { 91, "/lib/product-4.png", 61.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 91" },
                    { 92, "/lib/product-1.png", 62.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 92" },
                    { 93, "/lib/product-2.png", 63.0m, 83.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 93" },
                    { 94, "/lib/product-3.png", 64.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 94" },
                    { 95, "/lib/product-4.png", 65.0m, null, true, false, false, null, "Sản phẩm thời trang mẫu 95" },
                    { 96, "/lib/product-1.png", 66.0m, 86.0m, false, true, true, 15, "Sản phẩm thời trang mẫu 96" },
                    { 97, "/lib/product-2.png", 67.0m, null, false, false, false, null, "Sản phẩm thời trang mẫu 97" },
                    { 98, "/lib/product-3.png", 68.0m, null, false, true, false, null, "Sản phẩm thời trang mẫu 98" },
                    { 99, "/lib/product-4.png", 69.0m, 89.0m, false, false, true, 15, "Sản phẩm thời trang mẫu 99" },
                    { 100, "/lib/product-1.png", 50.0m, null, true, true, false, null, "Sản phẩm thời trang mẫu 100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
