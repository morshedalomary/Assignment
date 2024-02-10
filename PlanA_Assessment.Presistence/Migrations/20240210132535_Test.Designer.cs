﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlanA_Assessment.Presistence;

namespace PlanA_Assessment.Presistence.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20240210132535_Test")]
    partial class Test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.1.21102.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlanA_Assessment.Domain.Category", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            ID = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Name = "Technology"
                        });
                });

            modelBuilder.Entity("PlanA_Assessment.Domain.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dietary_flags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Number_of_Views")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                            CategoryId = new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                            Description = "Desctiption Test",
                            Number_of_Views = 0,
                            Price = 0.0,
                            Title = "Test "
                        });
                });

            modelBuilder.Entity("PlanA_Assessment.Domain.Product", b =>
                {
                    b.HasOne("PlanA_Assessment.Domain.Category", "Category")
                        .WithMany("products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PlanA_Assessment.Domain.Category", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}
