﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using band_apa_api.Data;

namespace BAND_APA_API.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220113224145_data")]
    partial class data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.HasSequence<int>("Animals_Identity_id_seq");

            modelBuilder.HasSequence<int>("Asso_Compte_id_seq");

            modelBuilder.HasSequence<int>("Client_Compte_id_seq");

            modelBuilder.HasSequence<int>("Demand_id_seq");

            modelBuilder.Entity("band_apa_api.Entities.AnimalsIdentity", b =>
                {
                    b.Property<int>("aiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR Animals_Identity_id_seq");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("comments")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("couleur")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("dateEntree")
                        .HasColumnType("datetime2");

                    b.Property<string>("espece")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("race")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("sexe")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.HasKey("aiID");

                    b.ToTable("AnimalsIdentity");
                });

            modelBuilder.Entity("band_apa_api.Entities.AssoCompte", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR Asso_Compte_id_seq");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("connectIdent")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("connectPwd")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("telephone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("titre")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("userID");

                    b.ToTable("AssoCompte");
                });

            modelBuilder.Entity("band_apa_api.Entities.ClientCompte", b =>
                {
                    b.Property<int>("clientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR Client_Compte_id_seq");

                    b.Property<string>("adresse1")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("adresse2")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("codePostal")
                        .HasColumnType("int");

                    b.Property<string>("connectIdent")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("connectPwd")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("telephone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("titre")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("ville")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("clientID");

                    b.ToTable("ClientCompte");
                });

            modelBuilder.Entity("band_apa_api.Entities.Demand", b =>
                {
                    b.Property<int>("demandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR Demand_id_seq");

                    b.Property<int>("AnimalsIdentityID")
                        .HasColumnType("int");

                    b.Property<int>("AssoCompteID")
                        .HasColumnType("int");

                    b.Property<int>("ClientCompteID")
                        .HasColumnType("int");

                    b.Property<bool>("adoption")
                        .HasColumnType("bit");

                    b.Property<bool>("depot")
                        .HasColumnType("bit");

                    b.Property<string>("statusSocial")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("demandID");

                    b.HasIndex("AnimalsIdentityID");

                    b.HasIndex("AssoCompteID");

                    b.HasIndex("ClientCompteID");

                    b.ToTable("Demand");
                });

            modelBuilder.Entity("band_apa_api.Entities.Demand", b =>
                {
                    b.HasOne("band_apa_api.Entities.AnimalsIdentity", "animalsIdentity")
                        .WithMany()
                        .HasForeignKey("AnimalsIdentityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("band_apa_api.Entities.AssoCompte", "assoCompte")
                        .WithMany()
                        .HasForeignKey("AssoCompteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("band_apa_api.Entities.ClientCompte", "client_compte")
                        .WithMany()
                        .HasForeignKey("ClientCompteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("animalsIdentity");

                    b.Navigation("assoCompte");

                    b.Navigation("client_compte");
                });
#pragma warning restore 612, 618
        }
    }
}
