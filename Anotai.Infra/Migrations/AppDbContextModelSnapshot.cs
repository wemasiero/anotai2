﻿// <auto-generated />
using System;
using Anotai.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Anotai.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(6741));

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
                        .HasMaxLength(100)
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

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7069));

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
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7793),
                            Description = "AÇÃO E AVENTURA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7795),
                            Description = "ARTE E FOTOGRAFIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7797),
                            Description = "AUTOAJUDA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7798),
                            Description = "BIOGRAFIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7799),
                            Description = "CONTO",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7800),
                            Description = "CRIMES REAIS",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7802),
                            Description = "DISTOPIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7803),
                            Description = "ENSAIOS",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7804),
                            Description = "FANTASIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7805),
                            Description = "FICÇÃO CIENTÍFICA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7806),
                            Description = "FICÇÃO CONTEMPORÂNEA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7808),
                            Description = "FICÇÃO FEMININA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7809),
                            Description = "FICÇÃO HISTÓRICA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7810),
                            Description = "FICÇÃO POLICIAL",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7812),
                            Description = "GASTRONOMIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7813),
                            Description = "GÊNEROS DE FICÇÃO",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7814),
                            Description = "GÊNEROS DE NÃO FICÇÃO",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7816),
                            Description = "GRAPHIC NOVEL",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7817),
                            Description = "GUIAS & COMO FAZER ",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 20,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7818),
                            Description = "HISTÓRIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 21,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7819),
                            Description = "HORROR",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 22,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7820),
                            Description = "HUMANIDADES E CIÊNCIAS SOCIAIS",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 23,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7822),
                            Description = "HUMOR",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 24,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7823),
                            Description = "INFANTIL",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 25,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7917),
                            Description = "LGBTQ+",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 26,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7919),
                            Description = "MEMÓRIAS E AUTOBIOGRAFIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 27,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7920),
                            Description = "NEW ADULT – NOVO ADULTO ",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 28,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7922),
                            Description = "PATERNIDADE E FAMÍLIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 29,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7923),
                            Description = "REALISMO MÁGICO",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 30,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7924),
                            Description = "RELIGIÃO E ESPIRITUALIDADE",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 31,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7925),
                            Description = "ROMANCE",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 32,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7926),
                            Description = "TECNOLOGIA E CIÊNCIA",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 33,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7946),
                            Description = "THRILLER E SUSPENSE",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 34,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7947),
                            Description = "VIAJEM",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 35,
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7949),
                            Description = "YOUNG ADULT – JOVEM ADULTO",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Anotai.Domain.Entities.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Annotation")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7218));

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("Reference")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Anotai.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7468));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
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
                            CreatedAt = new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7628),
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

            modelBuilder.Entity("Anotai.Domain.Entities.Note", b =>
                {
                    b.HasOne("Anotai.Domain.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });
#pragma warning restore 612, 618
        }
    }
}
