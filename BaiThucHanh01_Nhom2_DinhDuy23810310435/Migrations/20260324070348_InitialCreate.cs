using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    DuongDanAnh = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    IsNewProduct = table.Column<bool>(type: "boolean", nullable: false),
                    IsOnSale = table.Column<bool>(type: "boolean", nullable: false),
                    IsFeatureProduct = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPham");
        }
    }
}
