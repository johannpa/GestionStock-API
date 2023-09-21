using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionStock.Infrastructure.Migrations
{
    public partial class UpdateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LignesCommande_Produits_ProduitId",
                table: "LignesCommande");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produits",
                table: "Produits");

            migrationBuilder.RenameTable(
                name: "Produits",
                newName: "produit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produit",
                table: "produit",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LignesCommande_produit_ProduitId",
                table: "LignesCommande",
                column: "ProduitId",
                principalTable: "produit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LignesCommande_produit_ProduitId",
                table: "LignesCommande");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produit",
                table: "produit");

            migrationBuilder.RenameTable(
                name: "produit",
                newName: "Produits");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produits",
                table: "Produits",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LignesCommande_Produits_ProduitId",
                table: "LignesCommande",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
