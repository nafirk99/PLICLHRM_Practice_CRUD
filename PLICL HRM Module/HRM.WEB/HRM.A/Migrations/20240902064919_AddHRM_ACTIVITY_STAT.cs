using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.A.Migrations
{
    /// <inheritdoc />
    public partial class AddHRM_ACTIVITY_STAT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HRM_ACTIVITY_STATs",
                columns: table => new
                {
                    ActivityCd = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActivityNm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortNm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IUsr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UUsr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UDt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HRM_ACTIVITY_STATs", x => x.ActivityCd);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HRM_ACTIVITY_STATs");
        }
    }
}
