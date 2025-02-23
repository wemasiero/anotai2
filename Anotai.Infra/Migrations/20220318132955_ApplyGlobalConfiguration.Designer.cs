﻿// <auto-generated />
using System;
using Anotai.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Anotai.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220318132955_ApplyGlobalConfiguration")]
    partial class ApplyGlobalConfiguration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Anotai.Domain.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4166));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4672),
                            Description = "AÇÃO E AVENTURA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4678)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4681),
                            Description = "ARTE E FOTOGRAFIA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4681)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4683),
                            Description = "AUTOAJUDA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4684)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4685),
                            Description = "BIOGRAFIA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4686)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4687),
                            Description = "CONTO",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4688)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4689),
                            Description = "CRIMES REAIS",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4690)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4691),
                            Description = "DISTOPIA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4692)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4694),
                            Description = "ENSAIOS",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4694)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4696),
                            Description = "FANTASIA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4697)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4698),
                            Description = "FICÇÃO CIENTÍFICA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4699)
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4700),
                            Description = "FICÇÃO CONTEMPORÂNEA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4701)
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4702),
                            Description = "FICÇÃO FEMININA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4703)
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4704),
                            Description = "FICÇÃO HISTÓRICA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4705)
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4706),
                            Description = "FICÇÃO POLICIAL",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4707)
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4708),
                            Description = "GASTRONOMIA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4709)
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4710),
                            Description = "GÊNEROS DE FICÇÃO",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4711)
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4713),
                            Description = "GÊNEROS DE NÃO FICÇÃO",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4713)
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4715),
                            Description = "GRAPHIC NOVEL",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4715)
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4717),
                            Description = "GUIAS & COMO FAZER ",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4717)
                        },
                        new
                        {
                            Id = 20,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4719),
                            Description = "HISTÓRIA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4720)
                        },
                        new
                        {
                            Id = 21,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4721),
                            Description = "HORROR",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4723)
                        },
                        new
                        {
                            Id = 22,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4724),
                            Description = "HUMANIDADES E CIÊNCIAS SOCIAIS",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4725)
                        },
                        new
                        {
                            Id = 23,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4726),
                            Description = "HUMOR",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4727)
                        },
                        new
                        {
                            Id = 24,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4728),
                            Description = "INFANTIL",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4729)
                        },
                        new
                        {
                            Id = 25,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4730),
                            Description = "INFANTIL",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4731)
                        },
                        new
                        {
                            Id = 26,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4732),
                            Description = "LGBTQ+",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4733)
                        },
                        new
                        {
                            Id = 27,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4734),
                            Description = "MEMÓRIAS E AUTOBIOGRAFIA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4735)
                        },
                        new
                        {
                            Id = 28,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4736),
                            Description = "NEW ADULT – NOVO ADULTO ",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4737)
                        },
                        new
                        {
                            Id = 29,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4738),
                            Description = "PATERNIDADE E FAMÍLIA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4739)
                        },
                        new
                        {
                            Id = 30,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4740),
                            Description = "REALISMO MÁGICO",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4741)
                        },
                        new
                        {
                            Id = 31,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4742),
                            Description = "RELIGIÃO E ESPIRITUALIDADE",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4743)
                        },
                        new
                        {
                            Id = 32,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4744),
                            Description = "ROMANCE",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4745)
                        },
                        new
                        {
                            Id = 33,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4746),
                            Description = "TECNOLOGIA E CIÊNCIA",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4747)
                        },
                        new
                        {
                            Id = 34,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4748),
                            Description = "THRILLER E SUSPENSE",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4749)
                        },
                        new
                        {
                            Id = 35,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4750),
                            Description = "VIAJEM",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4751)
                        },
                        new
                        {
                            Id = 36,
                            CreatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4753),
                            Description = "YOUNG ADULT – JOVEM ADULTO",
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4753)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
