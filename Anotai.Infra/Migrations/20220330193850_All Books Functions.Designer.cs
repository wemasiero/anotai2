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
    [Migration("20220330193850_All Books Functions")]
    partial class AllBooksFunctions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Anotai.Domain.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6143));

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("GenderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("Publisher")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("UserId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Anotai.Domain.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6497));

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
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7005),
                            Description = "AÇÃO E AVENTURA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7007),
                            Description = "ARTE E FOTOGRAFIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7010),
                            Description = "AUTOAJUDA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7011),
                            Description = "BIOGRAFIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7012),
                            Description = "CONTO",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7014),
                            Description = "CRIMES REAIS",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7016),
                            Description = "DISTOPIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7017),
                            Description = "ENSAIOS",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7018),
                            Description = "FANTASIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7020),
                            Description = "FICÇÃO CIENTÍFICA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7021),
                            Description = "FICÇÃO CONTEMPORÂNEA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7023),
                            Description = "FICÇÃO FEMININA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7024),
                            Description = "FICÇÃO HISTÓRICA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7026),
                            Description = "FICÇÃO POLICIAL",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7027),
                            Description = "GASTRONOMIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7028),
                            Description = "GÊNEROS DE FICÇÃO",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7030),
                            Description = "GÊNEROS DE NÃO FICÇÃO",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7031),
                            Description = "GRAPHIC NOVEL",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7032),
                            Description = "GUIAS & COMO FAZER ",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 20,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7034),
                            Description = "HISTÓRIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 21,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7036),
                            Description = "HORROR",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 22,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7037),
                            Description = "HUMANIDADES E CIÊNCIAS SOCIAIS",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 23,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7038),
                            Description = "HUMOR",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 24,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7040),
                            Description = "INFANTIL",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 25,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7041),
                            Description = "LGBTQ+",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 26,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7042),
                            Description = "MEMÓRIAS E AUTOBIOGRAFIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 27,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7044),
                            Description = "NEW ADULT – NOVO ADULTO ",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 28,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7045),
                            Description = "PATERNIDADE E FAMÍLIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 29,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7046),
                            Description = "REALISMO MÁGICO",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 30,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7048),
                            Description = "RELIGIÃO E ESPIRITUALIDADE",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 31,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7049),
                            Description = "ROMANCE",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 32,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7051),
                            Description = "TECNOLOGIA E CIÊNCIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 33,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7052),
                            Description = "THRILLER E SUSPENSE",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 34,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7053),
                            Description = "VIAJEM",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 35,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7055),
                            Description = "YOUNG ADULT – JOVEM ADULTO",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Anotai.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6669));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6861),
                            Email = "wemasiero@gmail.com",
                            IsDeleted = false,
                            Name = "master",
                            Password = "Wand$050483"
                        });
                });

            modelBuilder.Entity("Anotai.Domain.Entities.Book", b =>
                {
                    b.HasOne("Anotai.Domain.Entities.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Anotai.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
