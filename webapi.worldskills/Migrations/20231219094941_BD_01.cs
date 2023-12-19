using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.worldskills.Migrations
{
    /// <inheritdoc />
    public partial class BD_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competidor",
                columns: table => new
                {
                    IdCompetidor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competidor", x => x.IdCompetidor);
                });

            migrationBuilder.CreateTable(
                name: "Medalha",
                columns: table => new
                {
                    IdTipoMedalha = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoMedalha = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medalha", x => x.IdTipoMedalha);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    IdPais = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.IdPais);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    IdSession = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.IdSession);
                });

            migrationBuilder.CreateTable(
                name: "TiposUsuario",
                columns: table => new
                {
                    IdTipoUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuario", x => x.IdTipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Ranking",
                columns: table => new
                {
                    IdRanking = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pontos = table.Column<int>(type: "INT", nullable: false),
                    IdMedalha = table.Column<int>(type: "int", nullable: false),
                    IdPais = table.Column<int>(type: "int", nullable: false),
                    IdSession = table.Column<int>(type: "int", nullable: false),
                    IdCompetidor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranking", x => x.IdRanking);
                    table.ForeignKey(
                        name: "FK_Ranking_Competidor_IdCompetidor",
                        column: x => x.IdCompetidor,
                        principalTable: "Competidor",
                        principalColumn: "IdCompetidor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ranking_Medalha_IdMedalha",
                        column: x => x.IdMedalha,
                        principalTable: "Medalha",
                        principalColumn: "IdTipoMedalha",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ranking_Pais_IdPais",
                        column: x => x.IdPais,
                        principalTable: "Pais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ranking_Session_IdSession",
                        column: x => x.IdSession,
                        principalTable: "Session",
                        principalColumn: "IdSession",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuário",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    IdTipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuário", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuário_TiposUsuario_IdTipoUsuario",
                        column: x => x.IdTipoUsuario,
                        principalTable: "TiposUsuario",
                        principalColumn: "IdTipoUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ranking_IdCompetidor",
                table: "Ranking",
                column: "IdCompetidor");

            migrationBuilder.CreateIndex(
                name: "IX_Ranking_IdMedalha",
                table: "Ranking",
                column: "IdMedalha");

            migrationBuilder.CreateIndex(
                name: "IX_Ranking_IdPais",
                table: "Ranking",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_Ranking_IdSession",
                table: "Ranking",
                column: "IdSession");

            migrationBuilder.CreateIndex(
                name: "IX_Usuário_IdTipoUsuario",
                table: "Usuário",
                column: "IdTipoUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ranking");

            migrationBuilder.DropTable(
                name: "Usuário");

            migrationBuilder.DropTable(
                name: "Competidor");

            migrationBuilder.DropTable(
                name: "Medalha");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "TiposUsuario");
        }
    }
}
