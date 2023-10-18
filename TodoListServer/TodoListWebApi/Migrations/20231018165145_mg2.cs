using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListWebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Todos",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CompletedAt",
                table: "Todos",
                newName: "CompletedDate");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Todos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompletedDate", "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5863), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5851), false });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompletedDate", "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5865), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5865), false });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompletedDate", "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5867), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5867), false });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CompletedDate", "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5869), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5869), false });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompletedDate", "CreatedDate", "IsCompleted", "IsDeleted", "Work" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5871), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5871), false, false, "Get Up" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompletedDate", "CreatedDate", "IsCompleted", "IsDeleted" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5873), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5873), false, false });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CompletedDate", "CreatedDate", "IsCompleted", "IsDeleted" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5875), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5874), false, false });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CompletedDate", "CreatedDate", "IsCompleted", "IsDeleted" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5876), false, false });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CompletedDate", "CreatedDate", "IsCompleted", "IsDeleted" },
                values: new object[] { new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5879), new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5878), false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Todos");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Todos",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "CompletedDate",
                table: "Todos",
                newName: "CompletedAt");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompletedAt", "CreatedAt" },
                values: new object[] { new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9306), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompletedAt", "CreatedAt" },
                values: new object[] { new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9309), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompletedAt", "CreatedAt" },
                values: new object[] { new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9310), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CompletedAt", "CreatedAt" },
                values: new object[] { new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9312), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompletedAt", "CreatedAt", "IsCompleted", "Work" },
                values: new object[] { new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9313), true, "Get up" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompletedAt", "CreatedAt", "IsCompleted" },
                values: new object[] { new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9315), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9315), true });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CompletedAt", "CreatedAt", "IsCompleted" },
                values: new object[] { new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9318), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9317), true });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CompletedAt", "CreatedAt", "IsCompleted" },
                values: new object[] { new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9319), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9319), true });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CompletedAt", "CreatedAt", "IsCompleted" },
                values: new object[] { new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9321), new DateTime(2023, 10, 16, 12, 33, 56, 425, DateTimeKind.Local).AddTicks(9320), true });
        }
    }
}
