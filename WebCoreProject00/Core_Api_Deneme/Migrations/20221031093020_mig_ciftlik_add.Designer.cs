﻿// <auto-generated />
using Core_Api_Deneme.DataAcessL.ApiContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core_Api_Deneme.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221031093020_mig_ciftlik_add")]
    partial class mig_ciftlik_add
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core_Api_Deneme.DataAcessL.Entity.MakuCiftlik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CiftlikID")
                        .HasColumnType("int");

                    b.Property<int>("HayvanID")
                        .HasColumnType("int");

                    b.Property<int>("SagimSuresi")
                        .HasColumnType("int");

                    b.Property<int>("SagımID")
                        .HasColumnType("int");

                    b.Property<int>("SutMiktari")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("MakuCiftliks");
                });
#pragma warning restore 612, 618
        }
    }
}