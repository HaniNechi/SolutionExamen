using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class testmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    CinemaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Localisation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SalleFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.CinemaId);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duree = table.Column<double>(type: "float", nullable: false),
                    DateRealisation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    TypeFilm = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.FilmId);
                });

            migrationBuilder.CreateTable(
                name: "Salles",
                columns: table => new
                {
                    IdSalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    NbPlaces = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salles", x => x.IdSalle);
                    table.ForeignKey(
                        name: "FK_Salles_Cinema_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinema",
                        principalColumn: "CinemaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projection",
                columns: table => new
                {
                    DateProjection = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeProjection = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FilmFk = table.Column<int>(type: "int", nullable: false),
                    SalleFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projection", x => x.DateProjection);
                    table.ForeignKey(
                        name: "FK_Projection_Film_FilmFk",
                        column: x => x.FilmFk,
                        principalTable: "Film",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projection_Salles_SalleFk",
                        column: x => x.SalleFk,
                        principalTable: "Salles",
                        principalColumn: "IdSalle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projection_FilmFk",
                table: "Projection",
                column: "FilmFk");

            migrationBuilder.CreateIndex(
                name: "IX_Projection_SalleFk",
                table: "Projection",
                column: "SalleFk");

            migrationBuilder.CreateIndex(
                name: "IX_Salles_CinemaId",
                table: "Salles",
                column: "CinemaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projection");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Salles");

            migrationBuilder.DropTable(
                name: "Cinema");
        }
    }
}
