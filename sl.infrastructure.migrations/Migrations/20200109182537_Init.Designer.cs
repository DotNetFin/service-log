﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using NpgsqlTypes;
using sl.infrastructure.Repositories.Context;

namespace sl.infrastructure.migrations.Migrations
{
    [DbContext(typeof(LogDbContext))]
    [Migration("20200109182537_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", ",,")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("sl.infrastructure.Repositories.Context.LogEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<string[]>("Labels")
                        .HasColumnName("labels")
                        .HasColumnType("text[]");

                    b.Property<string>("Level")
                        .HasColumnName("level")
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .HasColumnName("message")
                        .HasColumnType("text");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnName("registered_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<NpgsqlTsVector>("SearchVector")
                        .HasColumnName("s_vector")
                        .HasColumnType("tsvector");

                    b.Property<string>("StackTrace")
                        .HasColumnName("stack_trace")
                        .HasColumnType("text");

                    b.Property<string>("SystemId")
                        .HasColumnName("system_id")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_log_id");

                    b.HasIndex("SearchVector")
                        .HasAnnotation("Npgsql:IndexMethod", "GIN");

                    b.ToTable("log");
                });
#pragma warning restore 612, 618
        }
    }
}
