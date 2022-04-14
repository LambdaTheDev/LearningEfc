﻿// <auto-generated />
using System;
using LearningEfc.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LearningEfc.Migrations
{
    [DbContext(typeof(TestDatabase))]
    [Migration("20220414083010_Test")]
    partial class Test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("LearningEfc.Models.Bar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FooId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Secret")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Something")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Something2")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FooId");

                    b.ToTable("Bars");
                });

            modelBuilder.Entity("LearningEfc.Models.Foo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Secret")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Something")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Foos");
                });

            modelBuilder.Entity("LearningEfc.Models.Bar", b =>
                {
                    b.HasOne("LearningEfc.Models.Foo", null)
                        .WithMany("Bars")
                        .HasForeignKey("FooId");
                });

            modelBuilder.Entity("LearningEfc.Models.Foo", b =>
                {
                    b.Navigation("Bars");
                });
#pragma warning restore 612, 618
        }
    }
}
