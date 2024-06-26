﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TSS.QBuilder.Repository;

#nullable disable

namespace TSS.QBuilder.API.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240527074735_DatabaseCreation")]
    partial class DatabaseCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TSS.QBuilder.Entities.Models.ControlType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ControlName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ControlType");
                });

            modelBuilder.Entity("TSS.QBuilder.Entities.Models.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ControlTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuestionSetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("QuestionSubText")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ControlTypeId");

                    b.HasIndex("QuestionSetId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("TSS.QBuilder.Entities.Models.QuestionSet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("QuestionSet");
                });

            modelBuilder.Entity("TSS.QBuilder.Entities.Models.Question", b =>
                {
                    b.HasOne("TSS.QBuilder.Entities.Models.ControlType", "ControlType")
                        .WithMany()
                        .HasForeignKey("ControlTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TSS.QBuilder.Entities.Models.QuestionSet", "QuestionSet")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ControlType");

                    b.Navigation("QuestionSet");
                });

            modelBuilder.Entity("TSS.QBuilder.Entities.Models.QuestionSet", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
