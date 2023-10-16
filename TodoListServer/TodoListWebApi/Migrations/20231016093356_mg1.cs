using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoListWebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Work = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "CompletedAt", "CreatedAt", "IsCompleted", "Work" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9306), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9296), false, "Get to work" },
                    { 2, new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9309), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9308), false, "Pick up groceries" },
                    { 3, new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9310), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9310), false, "Go home" },
                    { 4, new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9312), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9312), false, "Fall asleep" },
                    { 5, new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9313), true, "Get up" },
                    { 6, new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9315), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9315), true, "Brush teeth" },
                    { 7, new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9318), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9317), true, "Take a shower" },
                    { 8, new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9319), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9319), true, "Check e-mail" },
                    { 9, new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9321), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9320), true, "Walk dog" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
