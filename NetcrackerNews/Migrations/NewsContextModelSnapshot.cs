﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetcrackerNews.Models;

namespace NetcrackerNews.Migrations
{
    [DbContext(typeof(NewsContext))]
    partial class NewsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetcrackerNews.Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<DateTime>("TimeStamp");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ArticleId");

                    b.ToTable("Articles");

                    b.HasData(
                        new { ArticleId = 2, Text = @"Каждая новость состоит из заголовка длиной 100 символов и текста (длина не ограничена), оба поля обязательные. 
                        На ленте новостей должен отображаться не полный текст новости, а только первые 200 символов с кнопкой 'читать полностью',
                        которая разворачивает текст целиком.", TimeStamp = new DateTime(2019, 4, 30, 9, 2, 22, 459, DateTimeKind.Local), Title = "Welcome" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
