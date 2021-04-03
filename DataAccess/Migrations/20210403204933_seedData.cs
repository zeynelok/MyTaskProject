using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Description", "Name" },
                values: new object[] { 1, new DateTime(2021, 4, 3, 23, 49, 31, 266, DateTimeKind.Local).AddTicks(4903), "Kitap Kategorisi Açıklaması", "Kitap" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Description", "Name" },
                values: new object[] { 2, new DateTime(2021, 4, 3, 23, 49, 31, 269, DateTimeKind.Local).AddTicks(6670), "Beyaz Eşya Kategorisi Açıklaması", "Beyaz Eşya" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Description", "Name" },
                values: new object[] { 3, new DateTime(2021, 4, 3, 23, 49, 31, 269, DateTimeKind.Local).AddTicks(6827), "Giyim Kategorisi Açıklaması", "Giyim" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(5714), "Yüzüğün Büyüsü", "Yüzüklerin Efendisi", 15m },
                    { 2, 1, new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8371), "Ejderhanın Hazinesi", "Hobbit", 15m },
                    { 3, 1, new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8434), "Alice'in Maceraları", "Alice Harikalar Diyarında", 15m },
                    { 4, 2, new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8441), "Çift Kapılı", "Buz Dolabı", 10000m },
                    { 5, 2, new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8447), "9 Kg Kapasiteli", "Çamaşır Makinesi", 7000m },
                    { 6, 2, new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8454), "Su Tasarruflu", "Bulaşık Makinesi", 5000m },
                    { 7, 3, new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8458), "Desenli", "Tişört", 20m },
                    { 8, 3, new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8462), "%100 Yün", "Kazak", 100m },
                    { 9, 3, new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8469), "Oduncu Gömleği", "Gömlek", 60m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
