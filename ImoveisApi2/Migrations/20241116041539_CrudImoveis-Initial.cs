 using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ImoveisApi2.Migrations
{
    /// <inheritdoc />
    public partial class CrudImoveisInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Email_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proprietario",
                columns: table => new
                {
                    Id_Proprietario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Proprietario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF_Proprietario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone_Proprietario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietario", x => x.Id_Proprietario);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Vendedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CRECI_Vendedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone_Vendedor = table.Column<int>(type: "int", nullable: false),
                    Email_Vendedor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proprietario = table.Column<int>(type: "int", nullable: false),
                    Endereco_Imovel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaTotal_Imovel = table.Column<decimal>(type: "decimal(10,3)", precision: 10, scale: 3, nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imovel_Proprietario_Proprietario",
                        column: x => x.Proprietario,
                        principalTable: "Proprietario",
                        principalColumn: "Id_Proprietario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "CPF", "DataNascimento", "Email_Cliente", "Endereco", "Nome" },
                values: new object[,]
                {
                    { 1, "123.456.789.10", new DateOnly(2002, 10, 10), "cliente@gmail.com", "Av.12a, Araras-SP", "Guilherme" },
                    { 2, "407.237.896-81", new DateOnly(2006, 5, 10), "Isis75@live.com", "850 Melissa Rodovia, Praia Grande, Paraguai", "Isabelly Albuquerque" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imovel_Proprietario",
                table: "Imovel",
                column: "Proprietario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Imovel");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropTable(
                name: "Proprietario");
        }
    }
}
