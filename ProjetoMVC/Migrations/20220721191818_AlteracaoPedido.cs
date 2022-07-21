using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoMVC.Migrations
{
    public partial class AlteracaoPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Fornecedores_FornecedorId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Produtos_Produtoid",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "Produtoid",
                table: "Pedidos",
                newName: "ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_Produtoid",
                table: "Pedidos",
                newName: "IX_Pedidos_ProdutoId");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Fornecedores_FornecedorId",
                table: "Pedidos",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Produtos_ProdutoId",
                table: "Pedidos",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Fornecedores_FornecedorId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Produtos_ProdutoId",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "Pedidos",
                newName: "Produtoid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_ProdutoId",
                table: "Pedidos",
                newName: "IX_Pedidos_Produtoid");

            migrationBuilder.AlterColumn<int>(
                name: "Produtoid",
                table: "Pedidos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Pedidos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Fornecedores_FornecedorId",
                table: "Pedidos",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Produtos_Produtoid",
                table: "Pedidos",
                column: "Produtoid",
                principalTable: "Produtos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
