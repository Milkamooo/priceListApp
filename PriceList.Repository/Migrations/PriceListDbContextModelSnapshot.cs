﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PriceListApp.Repository.Base;

#nullable disable

namespace PriceListApp.Repository.Migrations
{
    [DbContext(typeof(PriceListDbContext))]
    partial class PriceListDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ParameterPriceList", b =>
                {
                    b.Property<int>("ParametersId")
                        .HasColumnType("int");

                    b.Property<int>("PriceListsId")
                        .HasColumnType("int");

                    b.HasKey("ParametersId", "PriceListsId");

                    b.HasIndex("PriceListsId");

                    b.ToTable("ParameterPriceList");
                });

            modelBuilder.Entity("PriceListApp.Common.Contracts.Parameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("PriceListApp.Common.Contracts.PriceList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PriceLists");
                });

            modelBuilder.Entity("PriceListApp.Common.Contracts.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PriceListApp.Common.Contracts.ProductParameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ParameterId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParameterId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductParameters");
                });

            modelBuilder.Entity("PriceListProduct", b =>
                {
                    b.Property<int>("PriceListsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("PriceListsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("PriceListProduct");
                });

            modelBuilder.Entity("ParameterPriceList", b =>
                {
                    b.HasOne("PriceListApp.Common.Contracts.Parameter", null)
                        .WithMany()
                        .HasForeignKey("ParametersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PriceListApp.Common.Contracts.PriceList", null)
                        .WithMany()
                        .HasForeignKey("PriceListsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PriceListApp.Common.Contracts.ProductParameter", b =>
                {
                    b.HasOne("PriceListApp.Common.Contracts.Parameter", "Parameter")
                        .WithMany()
                        .HasForeignKey("ParameterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PriceListApp.Common.Contracts.Product", "Product")
                        .WithMany("ProductParameters")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parameter");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PriceListProduct", b =>
                {
                    b.HasOne("PriceListApp.Common.Contracts.PriceList", null)
                        .WithMany()
                        .HasForeignKey("PriceListsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PriceListApp.Common.Contracts.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PriceListApp.Common.Contracts.Product", b =>
                {
                    b.Navigation("ProductParameters");
                });
#pragma warning restore 612, 618
        }
    }
}
