﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MigrationsPractice.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MigrationsPractice.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210128202427_CreatedPetTable")]
    partial class CreatedPetTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("MigrationsPractice.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PossibleAdoptionVisits")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
