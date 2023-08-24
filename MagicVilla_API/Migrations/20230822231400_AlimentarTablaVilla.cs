using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa", new DateTime(2023, 8, 22, 17, 14, 0, 53, DateTimeKind.Local).AddTicks(2244), new DateTime(2023, 8, 22, 17, 14, 0, 53, DateTimeKind.Local).AddTicks(2224), "", 50, "Economica", 5, 200.0 },
                    { 2, "", "Vista a la piscina", new DateTime(2023, 8, 22, 17, 14, 0, 53, DateTimeKind.Local).AddTicks(2247), new DateTime(2023, 8, 22, 17, 14, 0, 53, DateTimeKind.Local).AddTicks(2246), "", 60, "Premium", 3, 250.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
