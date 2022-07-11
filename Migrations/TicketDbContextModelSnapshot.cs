﻿// <auto-generated />
using System;
using ASPNet_Core_6_TicketTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPNet_Core_6_TicketTracker.Migrations
{
    [DbContext(typeof(TicketDbContext))]
    partial class TicketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASPNet_Core_6_TicketTracker.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TicketDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("TicketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TicketStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TicketId");

                    b.ToTable("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}