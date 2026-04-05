using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Migrations
{
    /// <inheritdoc />
    public partial class ThemCacBang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    NameVN = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    MatKhau = table.Column<string>(type: "text", nullable: false),
                    HoTen = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    HinhAnh = table.Column<string>(type: "text", nullable: false),
                    KichHoat = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenSanPham = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    GiaBan = table.Column<decimal>(type: "numeric", nullable: false),
                    GiaGoc = table.Column<decimal>(type: "numeric", nullable: true),
                    PhanTramGiam = table.Column<int>(type: "integer", nullable: true),
                    DuongDanAnh = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    IsNewProduct = table.Column<bool>(type: "boolean", nullable: false),
                    IsOnSale = table.Column<bool>(type: "boolean", nullable: false),
                    IsFeatureProduct = table.Column<bool>(type: "boolean", nullable: false),
                    DanhMucId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPham_DanhMuc_DanhMucId",
                        column: x => x.DanhMucId,
                        principalTable: "DanhMuc",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DonHangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KhachHangId = table.Column<string>(type: "text", nullable: false),
                    NgayDatHang = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DiaChi = table.Column<string>(type: "text", nullable: false),
                    TongTien = table.Column<double>(type: "double precision", nullable: false),
                    MoTa = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonHangs_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonHangId = table.Column<int>(type: "integer", nullable: false),
                    SanPhamId = table.Column<int>(type: "integer", nullable: false),
                    DonGia = table.Column<double>(type: "double precision", nullable: false),
                    SoLuong = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHangs_DonHangs_DonHangId",
                        column: x => x.DonHangId,
                        principalTable: "DonHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHangs_SanPham_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DanhMuc",
                columns: new[] { "Id", "Name", "NameVN" },
                values: new object[,]
                {
                    { 1, "Fashion T-Shirts", "Áo Thời Trang" },
                    { 2, "Denim Jeans", "Quần Denim" },
                    { 3, "Luxury Accessories", "Phụ Kiện Cao Cấp" },
                    { 4, "Winter Jackets", "Áo Khoác Thu Đông" },
                    { 5, "Sneakers", "Giày Sneaker" }
                });

            migrationBuilder.InsertData(
                table: "SanPham",
                columns: new[] { "Id", "DanhMucId", "DuongDanAnh", "GiaBan", "GiaGoc", "IsFeatureProduct", "IsNewProduct", "IsOnSale", "PhanTramGiam", "TenSanPham" },
                values: new object[,]
                {
                    { 1, 4, "/lib/product-1.png", 82.5666526963779m, null, false, false, false, null, "Sản phẩm Trendy #001" },
                    { 2, 3, "/lib/product-7.png", 97.4344948383209m, null, true, true, false, null, "Sản phẩm Trendy #002" },
                    { 3, 4, "/lib/product-6.png", 103.873985039012m, null, true, false, false, null, "Sản phẩm Trendy #003" },
                    { 4, 1, "/lib/product-4.png", 25.0635060570498m, 182m, false, true, true, 7, "Sản phẩm Trendy #004" },
                    { 5, 4, "/lib/product-4.png", 37.7314857559891m, null, false, false, false, null, "Sản phẩm Trendy #005" },
                    { 6, 2, "/lib/no-image.png", 36.3217230654888m, null, true, false, false, null, "Sản phẩm Trendy #006" },
                    { 7, 3, "/lib/product-1.png", 142.164979958518m, null, false, true, false, null, "Sản phẩm Trendy #007" },
                    { 8, 4, "/lib/product-8.png", 126.459751408296m, 220m, false, false, true, 20, "Sản phẩm Trendy #008" },
                    { 9, 3, "/lib/no-image.png", 44.251229848364m, null, false, false, false, null, "Sản phẩm Trendy #009" },
                    { 10, 2, "/lib/product-3.png", 44.4512711113558m, null, false, true, false, null, "Sản phẩm Trendy #010" },
                    { 11, 2, "/lib/product-6.png", 47.7406541713237m, null, false, false, false, null, "Sản phẩm Trendy #011" },
                    { 12, 4, "/lib/product-8.png", 131.571810163358m, 196m, false, false, true, 5, "Sản phẩm Trendy #012" },
                    { 13, 4, "/lib/product-7.png", 42.2725324538874m, null, false, true, false, null, "Sản phẩm Trendy #013" },
                    { 14, 4, "/lib/product-8.png", 36.772724770835m, null, true, true, false, null, "Sản phẩm Trendy #014" },
                    { 15, 3, "/lib/product-3.png", 12.3003112931272m, null, false, false, false, null, "Sản phẩm Trendy #015" },
                    { 16, 4, "/lib/product-8.png", 100.300916974573m, 179m, false, false, true, 7, "Sản phẩm Trendy #016" },
                    { 17, 4, "/lib/product-7.png", 14.4112652616628m, null, false, false, false, null, "Sản phẩm Trendy #017" },
                    { 18, 5, "/lib/product-6.png", 62.9335274584282m, null, false, false, false, null, "Sản phẩm Trendy #018" },
                    { 19, 3, "/lib/product-1.png", 129.262443874154m, null, false, true, false, null, "Sản phẩm Trendy #019" },
                    { 20, 4, "/lib/product-6.png", 83.2347803191444m, 244m, false, true, true, 26, "Sản phẩm Trendy #020" },
                    { 21, 4, "/lib/product-2.png", 39.3377116813034m, null, false, false, false, null, "Sản phẩm Trendy #021" },
                    { 22, 4, "/lib/product-6.png", 13.9195446143483m, null, false, false, false, null, "Sản phẩm Trendy #022" },
                    { 23, 3, "/lib/product-7.png", 45.4460506795189m, null, false, true, false, null, "Sản phẩm Trendy #023" },
                    { 24, 3, "/lib/product-7.png", 112.309663826744m, 162m, true, true, true, 26, "Sản phẩm Trendy #024" },
                    { 25, 1, "/lib/product-4.png", 104.650879437873m, null, false, false, false, null, "Sản phẩm Trendy #025" },
                    { 26, 3, "/lib/product-3.png", 63.1278887428939m, null, true, false, false, null, "Sản phẩm Trendy #026" },
                    { 27, 4, "/lib/product-1.png", 111.465947394942m, null, true, true, false, null, "Sản phẩm Trendy #027" },
                    { 28, 2, "/lib/product-4.png", 67.2226073323854m, 187m, true, false, true, 20, "Sản phẩm Trendy #028" },
                    { 29, 4, "/lib/product-7.png", 78.7643228195441m, null, false, true, false, null, "Sản phẩm Trendy #029" },
                    { 30, 1, "/lib/product-3.png", 49.9071140298187m, null, false, true, false, null, "Sản phẩm Trendy #030" },
                    { 31, 2, "/lib/product-4.png", 122.229737555249m, null, false, true, false, null, "Sản phẩm Trendy #031" },
                    { 32, 4, "/lib/product-4.png", 11.7718757087234m, 247m, false, false, true, 7, "Sản phẩm Trendy #032" },
                    { 33, 4, "/lib/product-8.png", 49.306020063025m, null, true, true, false, null, "Sản phẩm Trendy #033" },
                    { 34, 3, "/lib/no-image.png", 42.3697534172655m, null, false, false, false, null, "Sản phẩm Trendy #034" },
                    { 35, 3, "/lib/product-3.png", 81.824613135692m, null, false, true, false, null, "Sản phẩm Trendy #035" },
                    { 36, 4, "/lib/product-4.png", 120.834045317878m, 197m, false, false, true, 13, "Sản phẩm Trendy #036" },
                    { 37, 4, "/lib/product-6.png", 136.836247318814m, null, false, false, false, null, "Sản phẩm Trendy #037" },
                    { 38, 3, "/lib/product-5.png", 68.5603658643366m, null, false, true, false, null, "Sản phẩm Trendy #038" },
                    { 39, 3, "/lib/product-7.png", 83.3490706888722m, null, true, true, false, null, "Sản phẩm Trendy #039" },
                    { 40, 1, "/lib/product-3.png", 74.2012177501811m, 203m, false, false, true, 27, "Sản phẩm Trendy #040" },
                    { 41, 3, "/lib/product-6.png", 48.2567255321223m, null, false, true, false, null, "Sản phẩm Trendy #041" },
                    { 42, 3, "/lib/product-1.png", 14.0856277784731m, null, true, true, false, null, "Sản phẩm Trendy #042" },
                    { 43, 5, "/lib/product-4.png", 20.3133003531551m, null, false, true, false, null, "Sản phẩm Trendy #043" },
                    { 44, 5, "/lib/product-8.png", 145.200933218562m, 190m, false, false, true, 8, "Sản phẩm Trendy #044" },
                    { 45, 2, "/lib/product-3.png", 28.6211149918945m, null, false, true, false, null, "Sản phẩm Trendy #045" },
                    { 46, 4, "/lib/no-image.png", 141.515962607933m, null, false, true, false, null, "Sản phẩm Trendy #046" },
                    { 47, 3, "/lib/product-8.png", 27.7184445358433m, null, true, false, false, null, "Sản phẩm Trendy #047" },
                    { 48, 1, "/lib/product-5.png", 99.0858500185822m, 222m, true, false, true, 16, "Sản phẩm Trendy #048" },
                    { 49, 4, "/lib/product-7.png", 63.255881000895m, null, false, true, false, null, "Sản phẩm Trendy #049" },
                    { 50, 5, "/lib/product-5.png", 18.7815769718874m, null, false, false, false, null, "Sản phẩm Trendy #050" },
                    { 51, 2, "/lib/product-3.png", 108.017451254659m, null, false, false, false, null, "Sản phẩm Trendy #051" },
                    { 52, 5, "/lib/product-4.png", 76.3582943227879m, 225m, false, false, true, 20, "Sản phẩm Trendy #052" },
                    { 53, 1, "/lib/no-image.png", 149.793083512128m, null, false, false, false, null, "Sản phẩm Trendy #053" },
                    { 54, 5, "/lib/product-1.png", 13.7900130393868m, null, false, true, false, null, "Sản phẩm Trendy #054" },
                    { 55, 1, "/lib/product-4.png", 37.5843215438464m, null, false, false, false, null, "Sản phẩm Trendy #055" },
                    { 56, 5, "/lib/product-4.png", 68.8523015113791m, 183m, false, true, true, 21, "Sản phẩm Trendy #056" },
                    { 57, 1, "/lib/product-3.png", 10.8457074113403m, null, false, false, false, null, "Sản phẩm Trendy #057" },
                    { 58, 1, "/lib/product-5.png", 127.337317318347m, null, false, true, false, null, "Sản phẩm Trendy #058" },
                    { 59, 3, "/lib/product-7.png", 89.393847711102m, null, false, false, false, null, "Sản phẩm Trendy #059" },
                    { 60, 5, "/lib/product-1.png", 136.98157954448m, 190m, false, true, true, 21, "Sản phẩm Trendy #060" },
                    { 61, 3, "/lib/product-7.png", 26.0838570450823m, null, false, true, false, null, "Sản phẩm Trendy #061" },
                    { 62, 3, "/lib/product-1.png", 86.4091370144902m, null, false, true, false, null, "Sản phẩm Trendy #062" },
                    { 63, 4, "/lib/product-3.png", 75.2736937102274m, null, true, true, false, null, "Sản phẩm Trendy #063" },
                    { 64, 4, "/lib/product-3.png", 146.379690988632m, 178m, false, false, true, 7, "Sản phẩm Trendy #064" },
                    { 65, 3, "/lib/product-2.png", 101.98102490929m, null, true, false, false, null, "Sản phẩm Trendy #065" },
                    { 66, 3, "/lib/product-8.png", 57.1152539072164m, null, false, true, false, null, "Sản phẩm Trendy #066" },
                    { 67, 5, "/lib/no-image.png", 45.6799230406433m, null, false, true, false, null, "Sản phẩm Trendy #067" },
                    { 68, 3, "/lib/product-4.png", 119.068699416271m, 206m, false, false, true, 14, "Sản phẩm Trendy #068" },
                    { 69, 5, "/lib/product-4.png", 32.0282925749329m, null, false, false, false, null, "Sản phẩm Trendy #069" },
                    { 70, 2, "/lib/product-7.png", 32.7613927320397m, null, false, true, false, null, "Sản phẩm Trendy #070" },
                    { 71, 1, "/lib/product-1.png", 104.27865616152m, null, false, false, false, null, "Sản phẩm Trendy #071" },
                    { 72, 3, "/lib/product-4.png", 39.8347924821241m, 227m, false, true, true, 16, "Sản phẩm Trendy #072" },
                    { 73, 2, "/lib/product-6.png", 38.863495943073m, null, false, true, false, null, "Sản phẩm Trendy #073" },
                    { 74, 3, "/lib/product-5.png", 87.0044855726904m, null, false, false, false, null, "Sản phẩm Trendy #074" },
                    { 75, 5, "/lib/product-8.png", 67.7841409946718m, null, false, true, false, null, "Sản phẩm Trendy #075" },
                    { 76, 4, "/lib/product-1.png", 49.389296602639m, 245m, true, true, true, 29, "Sản phẩm Trendy #076" },
                    { 77, 2, "/lib/product-5.png", 132.000035323668m, null, false, false, false, null, "Sản phẩm Trendy #077" },
                    { 78, 5, "/lib/product-1.png", 67.8545553348281m, null, true, false, false, null, "Sản phẩm Trendy #078" },
                    { 79, 2, "/lib/product-4.png", 40.0362193533388m, null, false, false, false, null, "Sản phẩm Trendy #079" },
                    { 80, 5, "/lib/product-6.png", 20.5748195795225m, 214m, false, true, true, 23, "Sản phẩm Trendy #080" },
                    { 81, 3, "/lib/product-6.png", 61.5595483018828m, null, false, false, false, null, "Sản phẩm Trendy #081" },
                    { 82, 2, "/lib/product-2.png", 88.0396794234587m, null, false, false, false, null, "Sản phẩm Trendy #082" },
                    { 83, 4, "/lib/product-8.png", 148.756436001862m, null, false, true, false, null, "Sản phẩm Trendy #083" },
                    { 84, 4, "/lib/product-8.png", 114.240829653219m, 236m, false, true, true, 29, "Sản phẩm Trendy #084" },
                    { 85, 4, "/lib/product-5.png", 100.288360191178m, null, false, true, false, null, "Sản phẩm Trendy #085" },
                    { 86, 4, "/lib/product-5.png", 80.982438567552m, null, false, false, false, null, "Sản phẩm Trendy #086" },
                    { 87, 4, "/lib/product-4.png", 31.7821621605112m, null, false, false, false, null, "Sản phẩm Trendy #087" },
                    { 88, 1, "/lib/product-1.png", 102.253672308407m, 217m, false, true, true, 24, "Sản phẩm Trendy #088" },
                    { 89, 4, "/lib/product-8.png", 120.266886463513m, null, false, true, false, null, "Sản phẩm Trendy #089" },
                    { 90, 2, "/lib/product-2.png", 87.0236673359869m, null, false, false, false, null, "Sản phẩm Trendy #090" },
                    { 91, 4, "/lib/product-7.png", 144.861822716827m, null, true, false, false, null, "Sản phẩm Trendy #091" },
                    { 92, 1, "/lib/product-2.png", 97.1176154995885m, 207m, true, true, true, 13, "Sản phẩm Trendy #092" },
                    { 93, 2, "/lib/product-6.png", 43.7034568640885m, null, true, true, false, null, "Sản phẩm Trendy #093" },
                    { 94, 3, "/lib/product-6.png", 120.430607471816m, null, false, true, false, null, "Sản phẩm Trendy #094" },
                    { 95, 4, "/lib/product-7.png", 27.7025196252868m, null, false, true, false, null, "Sản phẩm Trendy #095" },
                    { 96, 3, "/lib/product-8.png", 31.4675131758989m, 226m, true, false, true, 6, "Sản phẩm Trendy #096" },
                    { 97, 2, "/lib/product-3.png", 35.465348050215m, null, false, true, false, null, "Sản phẩm Trendy #097" },
                    { 98, 3, "/lib/product-2.png", 99.5277594227939m, null, true, false, false, null, "Sản phẩm Trendy #098" },
                    { 99, 3, "/lib/product-6.png", 145.183233491696m, null, false, true, false, null, "Sản phẩm Trendy #099" },
                    { 100, 4, "/lib/product-6.png", 82.386532862385m, 220m, false, false, true, 26, "Sản phẩm Trendy #100" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHangs_DonHangId",
                table: "ChiTietDonHangs",
                column: "DonHangId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHangs_SanPhamId",
                table: "ChiTietDonHangs",
                column: "SanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangs_KhachHangId",
                table: "DonHangs",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_DanhMucId",
                table: "SanPham",
                column: "DanhMucId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDonHangs");

            migrationBuilder.DropTable(
                name: "DonHangs");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "DanhMuc");
        }
    }
}
