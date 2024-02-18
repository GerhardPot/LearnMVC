using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Batman.Migrations
{
    /// <inheritdoc />
    public partial class RemovedCertID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertID",
                table: "Certificate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CertID",
                table: "Certificate",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
