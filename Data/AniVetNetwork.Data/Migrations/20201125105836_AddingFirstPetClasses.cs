using Microsoft.EntityFrameworkCore.Migrations;

namespace AniVetNetwork.Data.Migrations
{
    public partial class AddingFirstPetClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AnimalClass = table.Column<int>(nullable: false),
                    Breed = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(nullable: false),
                    Diagnose = table.Column<string>(nullable: true),
                    Recipe = table.Column<string>(nullable: true),
                    Treatment = table.Column<string>(nullable: true),
                    TreatmentStatus = table.Column<int>(nullable: false),
                    VeterinaryComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetProfiles_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetProfiles_PetId",
                table: "PetProfiles",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_UserId",
                table: "Pets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetProfiles");

            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
