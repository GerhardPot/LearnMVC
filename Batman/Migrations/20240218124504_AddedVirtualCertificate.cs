using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Batman.Migrations
{
    /// <inheritdoc />
    public partial class AddedVirtualCertificate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CertID",
                table: "Person",
                newName: "CertificateID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Certificate_CertificateID",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_CertificateID",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "CertificateID",
                table: "Person",
                newName: "CertID");
        }
    }
}
