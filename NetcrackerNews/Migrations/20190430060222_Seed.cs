using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetcrackerNews.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Title", "Text", "TimeStamp" },
                values: new object[] { 1, "Welcome", @"Каждая новость состоит из заголовка длиной 100 символов и текста (длина не ограничена), оба поля обязательные. 
                        На ленте новостей должен отображаться не полный текст новости, а только первые 200 символов с кнопкой 'читать полностью',
                        которая разворачивает текст целиком.", new DateTime(2019, 4, 30, 9, 2, 22, 459, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2);
        }
    }
}
