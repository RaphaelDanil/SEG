﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEG.Context;

#nullable disable

namespace SEG.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240824223622_Migracaoinicial")]
    partial class Migracaoinicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("SEG.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_user");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("dtcad_us");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("email");

                    b.Property<int>("IdSapiens")
                        .HasColumnType("INT(11)")
                        .HasColumnName("id_sapiens");

                    b.Property<int>("IdSetor")
                        .HasColumnType("INT(10)")
                        .HasColumnName("id_set");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("login");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("nome");

                    b.Property<string>("PrimeiroNome")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("de_primeironome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("senha");

                    b.Property<string>("SobreNome")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("de_sobrenome");

                    b.Property<bool>("Status")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("status_us");

                    b.HasKey("Id");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
