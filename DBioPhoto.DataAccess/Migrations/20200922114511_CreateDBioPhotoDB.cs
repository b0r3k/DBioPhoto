using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBioPhoto.DataAccess.Migrations
{
    public partial class CreateDBioPhotoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(nullable: true),
                    LatFirstName = table.Column<string>(nullable: true),
                    LatSecondName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fungi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(nullable: true),
                    LatFirstName = table.Column<string>(nullable: true),
                    LatSecondName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fungi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Micros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(nullable: true),
                    LatFirstName = table.Column<string>(nullable: true),
                    LatSecondName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Micros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    FileName = table.Column<string>(nullable: false),
                    FilePath = table.Column<string>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlossomColour = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(nullable: true),
                    LatFirstName = table.Column<string>(nullable: true),
                    LatSecondName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnimalOnPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalId = table.Column<int>(nullable: false),
                    PhotoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalOnPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalOnPhotos_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalOnPhotos_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FungusOnPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FungusId = table.Column<int>(nullable: false),
                    PhotoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FungusOnPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FungusOnPhotos_Fungi_FungusId",
                        column: x => x.FungusId,
                        principalTable: "Fungi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FungusOnPhotos_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MicroOnPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MicroId = table.Column<int>(nullable: false),
                    PhotoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MicroOnPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MicroOnPhotos_Micros_MicroId",
                        column: x => x.MicroId,
                        principalTable: "Micros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MicroOnPhotos_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonOnPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    PhotoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonOnPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonOnPhotos_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonOnPhotos_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlantOnPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantId = table.Column<int>(nullable: false),
                    PhotoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantOnPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlantOnPhotos_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlantOnPhotos_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalOnPhotos_AnimalId",
                table: "AnimalOnPhotos",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalOnPhotos_PhotoId",
                table: "AnimalOnPhotos",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_FungusOnPhotos_FungusId",
                table: "FungusOnPhotos",
                column: "FungusId");

            migrationBuilder.CreateIndex(
                name: "IX_FungusOnPhotos_PhotoId",
                table: "FungusOnPhotos",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_MicroOnPhotos_MicroId",
                table: "MicroOnPhotos",
                column: "MicroId");

            migrationBuilder.CreateIndex(
                name: "IX_MicroOnPhotos_PhotoId",
                table: "MicroOnPhotos",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonOnPhotos_PersonId",
                table: "PersonOnPhotos",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonOnPhotos_PhotoId",
                table: "PersonOnPhotos",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantOnPhotos_PhotoId",
                table: "PlantOnPhotos",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantOnPhotos_PlantId",
                table: "PlantOnPhotos",
                column: "PlantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalOnPhotos");

            migrationBuilder.DropTable(
                name: "FungusOnPhotos");

            migrationBuilder.DropTable(
                name: "MicroOnPhotos");

            migrationBuilder.DropTable(
                name: "PersonOnPhotos");

            migrationBuilder.DropTable(
                name: "PlantOnPhotos");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Fungi");

            migrationBuilder.DropTable(
                name: "Micros");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Plants");
        }
    }
}
