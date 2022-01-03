using band_apa_api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace band_apa_api.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();


            if (!context.AnimalsIdentities.Any())
            {
                var a_i1 = new AnimalsIdentity
                {   dateEntree = DateTime.Parse("24-08-2018"),
                    nom = "Nom1",
                    espece = "Chat", 
                    race = "Maine Coon", 
                    sexe = "", 
                    couleur = "Gris Blanc", 
                    age = 7, 
                    comments = "le chat Maine Coon est le chat le plus imposant qui soit. Il peut atteindre tranquillement, sans être obèse, 10 kg et, malgré son aspect impressionnant, " +
                    "il donne une rassurante impression de grande confiance. Autonome parce qu’en mesure de prendre soin de lui - même dans n’importe quelle circonstance, " +
                    "c’est donc un grand chasseur, en réalité un bon mélange de douceur et de sauvagerie ; c’est un chat de travail, justement à cause de cet instinct prédateur " +
                    "bien développé.", 
                    photo = "photo1"
                };
                var a_i2 = new AnimalsIdentity
                {
                    dateEntree = DateTime.Parse("18-09-2010"),
                    nom = "Nom2",
                    espece = "Chat",
                    race = "Persan",
                    sexe = "Femelle",
                    couleur = "Bleu Gris",
                    age = 13,
                    comments = "Outre son poil long, la tête du Persan représente aussi une caractéristique typique de la race. Le crâne est rond et large, les oreilles présentent " +
                    "également une forme ronde, idéalement avec des touffes de poils sur les extrémités.Le museau des chats Persans doit être très court,.Le fameux « stop » ne doit " +
                    "être placé ni au-dessus des paupières supérieures ni en-dessous des paupières inférieures.Ce détail confère au Persan son apparence typique.",
                    photo = "Photo2"
                };
                var a_i3 = new AnimalsIdentity
                {
                    dateEntree = DateTime.Parse("17-09-2020"),
                    nom = "Nom3",
                    espece = "Chien",
                    race = "Rottweiler",
                    sexe = "Male",
                    couleur = "Bleu et Feu",
                    age = 4,
                    comments = "Le rottweiler est un chien solide, au corps bien musclé. C’est un chien ni pesant ni léger mais bien proportionné. Il évoque la force, la souplesse et " +
                    "l’endurance. La robe est formée par le poil de couverture et le sous - poil.Le poil de couverture est de longueur moyenne, dur au toucher, lisse et bien serré " +
                    "contre le corps.Le sous - poil ne doit pas dépasser le poil de couverture. Les poils sont un peu plus longs aux membres postérieurs.",
                    photo = "Photo3"
                };
                var a_i4 = new AnimalsIdentity
                {
                    dateEntree = DateTime.Parse("06-12-2015"),
                    nom = "Nom4",
                    espece = "Chat",
                    race = "Bleu Russe",
                    sexe = "Male",
                    couleur = "Bleu",
                    age = 9,
                    comments = "Originaire de Russie comme l’indique son nom, le Bleu Russe a conquis, en quelques années, l’Europe de l’Ouest et du Nord avec son magnifique aspect, " +
                    "fait de lignes élégantes et d’un pelage aussi agréable à voir qu’à toucher. Côté caractère, il est connu pour son calme, son attachement envers son maître et son " +
                    "goût pour le jeu, sans toutefois être un chat excessivement actif.Il est aussi discret et n’est pas un grand miauleur.Il garde ses distances avec des individus étrangers.",
                    photo = "Photo4"
                };
                var a_i5 = new AnimalsIdentity
                {
                    dateEntree = DateTime.Parse("08-11-2015"),
                    nom = "Nom5",
                    espece = "Chien",
                    race = "Berger Australien",
                    sexe = "Femelle",
                    couleur = "Bleu \"Merle\" avec Marques feu",
                    age = 11,
                    comments = "Le Berger Australien est un chien affectueux qui ne manque pas de caractère. Chien bâti pour l’activité et le travail, le Berger Australien est doté de " +
                    "toutes les aptitudes physiques et mentales pour remplir diverses missions.De taille moyenne, agile et intelligent, il s’intègre parfaitement à la vie de famille et " +
                    "s’adapte à une variété de cadres de vie, à condition de ne pas le laisser s’ennuyer. Depuis quelques années, cette race connaît un grand succès dans le coeur des Français.",
                    photo = "Photo4"
                };

                var a_c1 = new AssoCompte
                {
                    role = "Administrateur",
                    titre = "Mr",
                    nom = "Frin",
                    prenom = "Antoine",
                    birthDate = DateTime.Parse("30-08-1988"),
                    eMail = "antoinefrindev@gmail.com",
                    telephone = "0600000001",
                    connectIdent = "af",
                    connectPwd = "af123"
                };
                var a_c2 = new AssoCompte
                {
                    role = "Conseillé",
                    titre = "Mr",
                    nom = "Walle",
                    prenom = "Didier",
                    birthDate = DateTime.Parse("19-12-1963"),
                    eMail = "dwalle19@gmail.com",
                    telephone = "0600000002",
                    connectIdent = "dw",
                    connectPwd = "dw123"
                };
                var a_c3 = new AssoCompte
                {
                    role = "Administrateur",
                    titre = "Mr",
                    nom = "Renault",
                    prenom = "Baptiste",
                    birthDate = DateTime.Parse("25-06-1995"),
                    eMail = "bat.renault@orange.fr",
                    telephone = "0600000003",
                    connectIdent = "br",
                    connectPwd = "br123"
                };
                var a_c4 = new AssoCompte
                {
                    role = "Conseillé",
                    titre = "Mr",
                    nom = "Duarte",
                    prenom = "Nuno",
                    birthDate = DateTime.Parse("30-08-1988"),
                    eMail = "nuno230400@gmail.com",
                    telephone = "0600000004",
                    connectIdent = "nd",
                    connectPwd = "nd123"
                };

                var c_c1 = new ClientCompte
                {
                    titre = "Mme",
                    nom = "Nom1",
                    prenom = "Prenom1",
                    birthDate = DateTime.Parse("01-01-1961"),
                    eMail = "nom1.prenom1@gmail.com",
                    adresse1 = "Adresse1No1",
                    adresse2 = "Adresse2No1",
                    codePostal = 59001,
                    ville = "Ville1",
                    telephone = "0600000001",
                    connectIdent = "n1p1",
                    connectPwd = "n1p1123"
                };
                var c_c2 = new ClientCompte
                {
                    titre = "Mr",
                    nom = "Nom2",
                    prenom = "Prenom2",
                    birthDate = DateTime.Parse("02-02-1962"),
                    eMail = "nom2.prenom2@gmail.com",
                    adresse1 = "Adresse1No2",
                    adresse2 = "Adresse2No2",
                    codePostal = 59002,
                    ville = "Ville2",
                    telephone = "0600000002",
                    connectIdent = "n2p2",
                    connectPwd = "n2p2123"
                };
                var c_c3 = new ClientCompte
                {
                    titre = "Mme",
                    nom = "Nom3",
                    prenom = "Prenom3",
                    birthDate = DateTime.Parse("03-03-1963"),
                    eMail = "nom3.prenom3@gmail.com",
                    adresse1 = "Adresse1No3",
                    adresse2 = "Adresse2No3",
                    codePostal = 59003,
                    ville = "Ville3",
                    telephone = "0600000003",
                    connectIdent = "n3p3",
                    connectPwd = "n3p3123"
                };
                var c_c4 = new ClientCompte
                {
                    titre = "Mme",
                    nom = "Nom4",
                    prenom = "Prenom4",
                    birthDate = DateTime.Parse("04-04-1964"),
                    eMail = "nom4.prenom4@gmail.com",
                    adresse1 = "Adresse1No4",
                    adresse2 = "Adresse2No4",
                    codePostal = 59004,
                    ville = "Ville4",
                    telephone = "0600000004",
                    connectIdent = "n4p4",
                    connectPwd = "n4p4123"
                };
                var c_c5 = new ClientCompte
                {
                    titre = "Mr",
                    nom = "Nom5",
                    prenom = "Prenom5",
                    birthDate = DateTime.Parse("05-05-1965"),
                    eMail = "nom5.prenom5@gmail.com",
                    adresse1 = "Adresse1No5",
                    adresse2 = "Adresse2No5",
                    codePostal = 59005,
                    ville = "Ville5",
                    telephone = "0600000005",
                    connectIdent = "n5p5",
                    connectPwd = "n5p5123"
                };

                List<Demand> demands = new List<Demand> {
                     new Demand{ adoption = true, depot = false, statusSocial = "OK", animalsIdentity = a_i3, assoCompte = a_c2, client_compte = c_c4},
                     new Demand{ adoption = true, depot = false, statusSocial = "OK", animalsIdentity = a_i5, assoCompte = a_c4, client_compte = c_c3},
                     new Demand{ adoption = false, depot = true, statusSocial = "EA", animalsIdentity = a_i1, assoCompte = a_c4, client_compte = c_c1}
                 };
                context.AssoComptes.Add(a_c1);
                context.AssoComptes.Add(a_c2);
                context.AssoComptes.Add(a_c3);
                context.AssoComptes.Add(a_c4);
                context.AnimalsIdentities.Add(a_i1);
                context.AnimalsIdentities.Add(a_i2);
                context.AnimalsIdentities.Add(a_i3);
                context.AnimalsIdentities.Add(a_i4);
                context.AnimalsIdentities.Add(a_i5);
                context.ClientComptes.Add(c_c1);
                context.ClientComptes.Add(c_c2);
                context.ClientComptes.Add(c_c3);
                context.ClientComptes.Add(c_c4);
                context.ClientComptes.Add(c_c5);
                context.Demands.AddRange(demands);
                context.SaveChanges();

            }

        }
    }
}
