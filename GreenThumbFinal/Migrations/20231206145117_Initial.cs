using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenThumbFinal.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    PlantsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.PlantsId);
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    InstructionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlantsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.InstructionId);
                    table.ForeignKey(
                        name: "FK_Instructions_Plants_PlantsId",
                        column: x => x.PlantsId,
                        principalTable: "Plants",
                        principalColumn: "PlantsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "PlantsId", "Name" },
                values: new object[,]
                {
                    { 1, "Marijuana" },
                    { 2, "Papaver somniferum" },
                    { 3, "Erythroxylum coca" },
                    { 4, "Psilocybe spp." },
                    { 5, "Lophophora williamsii" },
                    { 6, "Catha edulis" },
                    { 7, "Mitragyna speciosa" },
                    { 8, "Salvia" },
                    { 9, "Amanita muscaria" },
                    { 10, "Lactuca virosa" },
                    { 11, "Piper methysticum" },
                    { 12, "Areca catechu" }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "InstructionId", "Info", "PlantsId" },
                values: new object[,]
                {
                    { 1, "Consistent Watering, establish consistent watering and use room temperature water.", 1 },
                    { 2, "Consistent Watering, establish consistent watering and use room temperature water.", 3 },
                    { 3, "Consistent Watering, establish consistent watering and use room temperature water.", 4 },
                    { 4, "Consistent Watering, establish consistent watering and use room temperature water.", 6 },
                    { 5, "Consistent Watering, establish consistent watering and use room temperature water.", 7 },
                    { 6, "Consistent Watering, establish consistent watering and use room temperature water.", 8 },
                    { 7, "Consistent Watering, establish consistent watering and use room temperature water.", 9 },
                    { 8, "Consistent Watering, establish consistent watering and use room temperature water.", 11 },
                    { 9, "Consistent Watering, establish consistent watering and use room temperature water.", 12 },
                    { 10, "Light Requirements, this plant require full sun.", 1 },
                    { 11, "Light Requirements, this plant require full sun.", 2 },
                    { 12, "Light Requirements, this plant require full sun.", 3 },
                    { 13, "Light Requirements, this plant require full sun.", 6 },
                    { 14, "Light Requirements, this plant require full sun.", 8 },
                    { 15, "Light Requirements, this plant require full sun.", 9 },
                    { 16, "Light Requirements, this plant require full sun.", 10 },
                    { 17, "Light Requirements, this plant require full sun.", 12 },
                    { 18, "Fertilization, follow a fertilization schedule suitable for your plants.", 2 },
                    { 19, "Fertilization, follow a fertilization schedule suitable for your plants.", 4 },
                    { 20, "Fertilization, follow a fertilization schedule suitable for your plants.", 6 },
                    { 21, "Fertilization, follow a fertilization schedule suitable for your plants.", 8 },
                    { 22, "Fertilization, follow a fertilization schedule suitable for your plants.", 10 },
                    { 23, "Fertilization, follow a fertilization schedule suitable for your plants.", 12 },
                    { 24, "Rotate Plants, rotate indoor plants periodically to ensure all sides receive adequate light.", 4 },
                    { 25, "Rotate Plants, rotate indoor plants periodically to ensure all sides receive adequate light.", 8 },
                    { 26, "Rotate Plants, rotate indoor plants periodically to ensure all sides receive adequate light.", 12 },
                    { 27, "Humidity, use a humidifier or mist the plant occasionally to maintain adequate moisture.", 1 },
                    { 28, "Humidity, use a humidifier or mist the plant occasionally to maintain adequate moisture.", 3 },
                    { 29, "Humidity, use a humidifier or mist the plant occasionally to maintain adequate moisture.", 5 },
                    { 30, "Humidity, use a humidifier or mist the plant occasionally to maintain adequate moisture.", 7 },
                    { 31, "Humidity, use a humidifier or mist the plant occasionally to maintain adequate moisture.", 9 },
                    { 32, "Humidity, use a humidifier or mist the plant occasionally to maintain adequate moisture.", 11 },
                    { 33, "Remove Dead Leaves and Flowers, regularly remove dead or yellowing leaves and spent flowers.", 5 },
                    { 34, "Remove Dead Leaves and Flowers, regularly remove dead or yellowing leaves and spent flowers.", 9 },
                    { 35, "Remove Dead Leaves and Flowers, regularly remove dead or yellowing leaves and spent flowers.", 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_PlantsId",
                table: "Instructions",
                column: "PlantsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "Plants");
        }
    }
}
