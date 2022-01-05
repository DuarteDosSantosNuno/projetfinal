using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BAND_APA_API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "Animals_Identity_id_seq");

            migrationBuilder.CreateSequence<int>(
                name: "Asso_Compte_id_seq");

            migrationBuilder.CreateSequence<int>(
                name: "Client_Compte_id_seq");

            migrationBuilder.CreateSequence<int>(
                name: "Demand_id_seq");

            migrationBuilder.CreateTable(
                name: "AnimalsIdentity",
                columns: table => new
                {
                    aiID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR Animals_Identity_id_seq"),
                    dateEntree = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    espece = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    race = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    sexe = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    couleur = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    photo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalsIdentity", x => x.aiID);
                });

            migrationBuilder.CreateTable(
                name: "AssoCompte",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR Asso_Compte_id_seq"),
                    role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    titre = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    nom = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    eMail = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    connectIdent = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    connectPwd = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssoCompte", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "ClientCompte",
                columns: table => new
                {
                    clientID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR Client_Compte_id_seq"),
                    titre = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    nom = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    eMail = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    adresse1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    adresse2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    codePostal = table.Column<int>(type: "int", nullable: false),
                    ville = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    connectIdent = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    connectPwd = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCompte", x => x.clientID);
                });

            migrationBuilder.CreateTable(
                name: "Demand",
                columns: table => new
                {
                    demandID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR Demand_id_seq"),
                    adoption = table.Column<bool>(type: "bit", nullable: false),
                    depot = table.Column<bool>(type: "bit", nullable: false),
                    statusSocial = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    AnimalsIdentityID = table.Column<int>(type: "int", nullable: false),
                    AssoCompteID = table.Column<int>(type: "int", nullable: false),
                    ClientCompteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demand", x => x.demandID);
                    table.ForeignKey(
                        name: "FK_Demand_AnimalsIdentity_AnimalsIdentityID",
                        column: x => x.AnimalsIdentityID,
                        principalTable: "AnimalsIdentity",
                        principalColumn: "aiID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demand_AssoCompte_AssoCompteID",
                        column: x => x.AssoCompteID,
                        principalTable: "AssoCompte",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demand_ClientCompte_ClientCompteID",
                        column: x => x.ClientCompteID,
                        principalTable: "ClientCompte",
                        principalColumn: "clientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demand_AnimalsIdentityID",
                table: "Demand",
                column: "AnimalsIdentityID");

            migrationBuilder.CreateIndex(
                name: "IX_Demand_AssoCompteID",
                table: "Demand",
                column: "AssoCompteID");

            migrationBuilder.CreateIndex(
                name: "IX_Demand_ClientCompteID",
                table: "Demand",
                column: "ClientCompteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demand");

            migrationBuilder.DropTable(
                name: "AnimalsIdentity");

            migrationBuilder.DropTable(
                name: "AssoCompte");

            migrationBuilder.DropTable(
                name: "ClientCompte");

            migrationBuilder.DropSequence(
                name: "Animals_Identity_id_seq");

            migrationBuilder.DropSequence(
                name: "Asso_Compte_id_seq");

            migrationBuilder.DropSequence(
                name: "Client_Compte_id_seq");

            migrationBuilder.DropSequence(
                name: "Demand_id_seq");
        }
    }
}
