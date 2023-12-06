using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenThumbFinal.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantsId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantsId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantsId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantsId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantsId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantsId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantsId",
                keyValue: 12);
        }
    }
}
