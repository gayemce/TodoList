using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListWebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4048), new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4051), new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4055), new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4057), new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4059), new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4061), new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4062), new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4064), new DateTime(2023, 10, 19, 10, 40, 35, 298, DateTimeKind.Local).AddTicks(4064) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5863), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5865), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5867), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5869), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5871), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5873), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5875), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5879), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5878) });
        }
    }
}
