using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Batman.Migrations
{
    /// <inheritdoc />
    public partial class RemovedFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Certificate_CertificateID",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_CertificateID",
                table: "Person");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Person_CertificateID",
                table: "Person",
                column: "CertificateID");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Certificate_CertificateID",
                table: "Person",
                column: "CertificateID",
                principalTable: "Certificate",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
