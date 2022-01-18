using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGameStore.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblStores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Number = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Addition = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Place = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    IsFranchiseStore = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPeople",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPeople", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPeople_tblStores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "tblStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "tblPeople",
                columns: new[] { "Id", "EmailAddress", "FirstName", "Gender", "LastName", "StoreId" },
                values: new object[,]
                {
                    { 1, "samah.abarhich@mygamestore.be", "Samah", 0, "Abarhich", null },
                    { 243, "uwe.van landeghem@mygamestore.be", "Uwe", 0, "Van Landeghem", null },
                    { 242, "nicolas.vanderleenen@mygamestore.be", "Nicolas", 0, "Vanderleenen", null },
                    { 241, "phyllis.van vlierberghe @mygamestore.be", "Phyllis", 0, "Van Vlierberghe ", null },
                    { 240, "merel.van acker@mygamestore.be", "Merel", 0, "Van Acker", null },
                    { 239, "fleur.ronsmans@mygamestore.be", "Fleur", 0, "Ronsmans", null },
                    { 238, "imelda.roef@mygamestore.be", "Imelda", 0, "Roef", null },
                    { 237, "stephanie.peeters@mygamestore.be", "Stéphanie", 0, "Peeters", null },
                    { 236, "cato.mannekens@mygamestore.be", "Cato", 0, "Mannekens", null },
                    { 244, "helin.van miert@mygamestore.be", "Helin", 0, "Van Miert", null },
                    { 235, "jelle.maes@mygamestore.be", "Jelle", 0, "Maes", null },
                    { 233, "marthe.kemps@mygamestore.be", "Marthe", 0, "Kemps", null },
                    { 232, "brend.jacobs@mygamestore.be", "Brend", 0, "Jacobs", null },
                    { 231, "yoran.huysmans@mygamestore.be", "Yoran", 0, "Huysmans", null },
                    { 230, "jolien.fourneau@mygamestore.be", "Jolien", 0, "Fourneau", null },
                    { 229, "jill.eerdekens@mygamestore.be", "Jill", 0, "Eerdekens", null },
                    { 228, "jonas.duymelinckx@mygamestore.be", "Jonas", 0, "Duymelinckx", null },
                    { 227, "karolien.de kort@mygamestore.be", "Karolien", 0, "de Kort", null },
                    { 226, "kaylee.bernaerts@mygamestore.be", "Kaylee", 0, "Bernaerts", null },
                    { 234, "pieter.leten@mygamestore.be", "Pieter", 0, "Leten", null },
                    { 225, "flore.bagramyan@mygamestore.be", "Flore", 0, "Bagramyan", null },
                    { 245, "astrid.verresen@mygamestore.be", "Astrid", 0, "Verresen", null },
                    { 247, "dagny.hauquier@mygamestore.be", "Dagny", 0, "Hauquier", null },
                    { 265, "luka.verreth@mygamestore.be", "Luka", 0, "Verreth", null },
                    { 264, "silke.van doorslaer@mygamestore.be", "Silke", 0, "Van Doorslaer", null },
                    { 263, "anouk.schoors@mygamestore.be", "Anouk", 0, "Schoors", null },
                    { 262, "vicky.gashi@mygamestore.be", "Vicky", 0, "Gashi", null },
                    { 261, "fien.de peuter@mygamestore.be", "Fien", 0, "De Peuter", null },
                    { 260, "frauke.bruynkens@mygamestore.be", "Frauke", 0, "Bruynkens", null },
                    { 259, "jill.maes@mygamestore.be", "Jill", 0, "Maes", null },
                    { 258, "lars.wijnants@mygamestore.be", "Lars", 0, "Wijnants", null },
                    { 246, "axelle.de loose@mygamestore.be", "Axelle", 0, "De Loose", null },
                    { 257, "maya.vranckaert@mygamestore.be", "Maya", 0, "Vranckaert", null },
                    { 255, "natan.deschoenmaker@mygamestore.be", "Natan", 0, "Deschoenmaker", null },
                    { 254, "shauni.verbeeck@mygamestore.be", "Shauni", 0, "Verbeeck", null },
                    { 253, "shania.van den sande @mygamestore.be", "Shania", 0, "Van den Sande ", null },
                    { 252, "steven.nijs@mygamestore.be", "Steven", 0, "Nijs", null },
                    { 251, "kaylee.de laender@mygamestore.be", "Kaylee", 0, "De Laender", null },
                    { 250, "lina.de cree@mygamestore.be", "Lina", 0, "De Crée", null },
                    { 249, "maxinn.lardenoit@mygamestore.be", "Maxinn", 0, "Lardenoit", null },
                    { 248, "julie.kennis@mygamestore.be", "Julie", 0, "Kennis", null },
                    { 256, "marie.vandersmissen@mygamestore.be", "Marie", 0, "Vandersmissen", null }
                });

            migrationBuilder.InsertData(
                table: "tblPeople",
                columns: new[] { "Id", "EmailAddress", "FirstName", "Gender", "LastName", "StoreId" },
                values: new object[,]
                {
                    { 224, "gjeve.slimani@mygamestore.be", "Gjeve", 0, "Slimani", null },
                    { 223, "ikram.racaj@mygamestore.be", "Ikram", 0, "Racaj", null },
                    { 222, "ahmed.el boutahiri@mygamestore.be", "Ahmed", 0, "El Boutahiri", null },
                    { 197, "saloua.mashinda@mygamestore.be", "Saloua", 0, "Mashinda", null },
                    { 196, "kirsten.laaraj@mygamestore.be", "Kirsten", 0, "Laaraj", null },
                    { 195, "rumeysa.de grauwe@mygamestore.be", "Rumeysa", 0, "De Grauwe", null },
                    { 194, "hazal.avci@mygamestore.be", "Hazal", 0, "Avci", null },
                    { 193, "samah.akyuz@mygamestore.be", "Samah", 0, "Akyüz", null },
                    { 192, "yousra.bourima@mygamestore.be", "yousra", 0, "Bourima", null },
                    { 191, "amine.tanrikulu@mygamestore.be", "Amine", 0, "Tanrikulu", null },
                    { 190, "leny.taiebi@mygamestore.be", "Leny", 0, "Taiebi", null },
                    { 198, "prisca.sahin@mygamestore.be", "Prisca", 0, "Sahin", null },
                    { 189, "mariam.shalaj@mygamestore.be", "Mariam", 0, "Shalaj", null },
                    { 187, "anissa.nika@mygamestore.be", "Anissa", 0, "Nika", null },
                    { 186, "nabil.mettle@mygamestore.be", "Nabil", 0, "Mettle", null },
                    { 185, "chaimae.frunza@mygamestore.be", "Chaimae", 0, "Frunza", null },
                    { 184, "tarik.amakran@mygamestore.be", "Tarik", 0, "Amakran", null },
                    { 183, "soumia.abarhich@mygamestore.be", "Soumia", 0, "Abarhich", null },
                    { 182, "anastassiya.akhmetova@mygamestore.be", "Anastassiya", 0, "Akhmetova", null },
                    { 181, "anastasia.abdurazakova@mygamestore.be", "Anastasia", 0, "Abdurazakova", null },
                    { 180, "lhamo.findik@mygamestore.be", "Lhamo", 0, "Findik", null },
                    { 188, "diana.puati@mygamestore.be", "Diana", 0, "Puati", null },
                    { 199, "suara.sahin@mygamestore.be", "Suara", 0, "Sahin", null },
                    { 200, "zilan.zurel@mygamestore.be", "Zilan", 0, "Zurel", null },
                    { 201, "abdel.akyuz@mygamestore.be", "Abdel", 0, "Akyuz", null },
                    { 221, "jordy.benaissaoui@mygamestore.be", "Jordy", 0, "Benaissaoui", null },
                    { 220, "yusuf.baos y quinto@mygamestore.be", "Yusuf", 0, "Baos y Quinto", null },
                    { 219, "mesua.abdirahman@mygamestore.be", "Mesua", 0, "Abdirahman", null },
                    { 218, "siham.osmani@mygamestore.be", "Siham", 0, "Osmani", null },
                    { 217, "hafssa.ben messaoud@mygamestore.be", "Hafssa", 0, "Ben Messaoud", null },
                    { 216, "kubra.badreddine@mygamestore.be", "Kübra", 0, "Badreddine", null },
                    { 215, "farah.bayar@mygamestore.be", "Farah", 0, "Bayar", null },
                    { 214, "arta.laha@mygamestore.be", "Arta", 0, "laha", null },
                    { 213, "ibtissam.yahyaoui@mygamestore.be", "Ibtissam", 0, "Yahyaoui", null },
                    { 212, "marigona.noboa@mygamestore.be", "Marigona", 0, "Noboa", null },
                    { 211, "segourney.ben saïd abdelnour@mygamestore.be", "Segourney", 0, "Ben Saïd Abdelnour", null },
                    { 210, "maryana.zakaryan@mygamestore.be", "Maryana", 0, "Zakaryan", null },
                    { 209, "youssra.rahimi@mygamestore.be", "Youssra", 0, "Rahimi", null },
                    { 208, "mariam.khayi@mygamestore.be", "Mariam", 0, "Khayi", null },
                    { 206, "soukaina.alou@mygamestore.be", "Soukaina", 0, "Alou", null },
                    { 205, "silwa.sellami@mygamestore.be", "Silwa", 0, "Sellami", null },
                    { 204, "rachida.ouajhain@mygamestore.be", "Rachida", 0, "Ouajhain", null }
                });

            migrationBuilder.InsertData(
                table: "tblPeople",
                columns: new[] { "Id", "EmailAddress", "FirstName", "Gender", "LastName", "StoreId" },
                values: new object[,]
                {
                    { 203, "kabongo.nasir@mygamestore.be", "Kabongo", 0, "Nasir", null },
                    { 202, "sara.mbuyamba@mygamestore.be", "Sara", 0, "Mbuyamba", null },
                    { 266, "camille.willemsen@mygamestore.be", "Camille", 0, "Willemsen", null },
                    { 179, "kamila.marinova@mygamestore.be", "Kamila", 0, "Marinova", null },
                    { 267, "lies.cuvelier@mygamestore.be", "Lies", 0, "Cuvelier", null },
                    { 269, "messalina.peeters@mygamestore.be", "Messalina", 0, "Peeters", null },
                    { 336, "margaux.poelemans@mygamestore.be", "Margaux", 0, "Poelemans", null },
                    { 335, "gilles.pire@mygamestore.be", "Gilles", 0, "Pire", null },
                    { 334, "sarah.pieters@mygamestore.be", "Sarah", 0, "Pieters", null },
                    { 333, "britt.piessens@mygamestore.be", "Britt", 0, "Piessens", null },
                    { 332, "gert.peeters@mygamestore.be", "Gert", 0, "Peeters", null },
                    { 331, "margo.peeters@mygamestore.be", "Margo", 0, "Peeters", null },
                    { 330, "sofie.muller@mygamestore.be", "Sofie", 0, "Muller", null },
                    { 329, "robbe.martens@mygamestore.be", "Robbe", 0, "Martens", null },
                    { 337, "laura.ratinckx@mygamestore.be", "Laura", 0, "Ratinckx", null },
                    { 328, "sebastian.siebens@mygamestore.be", "Sebastian", 0, "Siebens", null },
                    { 326, "emmeline.van rompaey@mygamestore.be", "Emmeline", 0, "Van Rompaey", null },
                    { 325, "elena.alliet@mygamestore.be", "Elena", 0, "Alliet", null },
                    { 324, "julie.paulussen@mygamestore.be", "Julie", 0, "Paulussen", null },
                    { 323, "louise.omloop@mygamestore.be", "Louise", 0, "Omloop", null },
                    { 322, "liesbeth.leemans@mygamestore.be", "Liesbeth", 0, "Leemans", null },
                    { 321, "elke.hamers@mygamestore.be", "Elke", 0, "Hamers", null },
                    { 320, "arne.arnaout@mygamestore.be", "Arne", 0, "Arnaout", null },
                    { 319, "thibaut.van reeth@mygamestore.be", "Thibaut", 0, "Van Reeth", null },
                    { 327, "colin.verrykt@mygamestore.be", "Colin", 0, "Verrykt", null },
                    { 318, "amber.van pellecom@mygamestore.be", "Amber", 0, "Van Pellecom", null },
                    { 338, "nora.robberechts@mygamestore.be", "Nora", 0, "Robberechts", null },
                    { 340, "manon.snels@mygamestore.be", "Manon", 0, "Snels", null },
                    { 358, "dirk.bosmans@mygamestore.be", "Dirk", 0, "Bosmans", null },
                    { 357, "mark.dessers@mygamestore.be", "Mark", 0, "Dessers", null },
                    { 356, "renke.wouters@mygamestore.be", "Renke", 0, "Wouters", null },
                    { 355, "jonas.voeten@mygamestore.be", "Jonas", 0, "Voeten", null },
                    { 354, "laura.vermeiren@mygamestore.be", "Laura", 0, "Vermeiren", null },
                    { 353, "oona.vermeersch@mygamestore.be", "Oona", 0, "Vermeersch", null },
                    { 352, "sheila.verhoeven@mygamestore.be", "Sheila", 0, "Verhoeven", null },
                    { 351, "niels.verbelen@mygamestore.be", "Niels", 0, "Verbelen", null },
                    { 339, "chayenne.seeuws@mygamestore.be", "Chayenne", 0, "Seeuws", null },
                    { 350, "evelynn.vandermeersch@mygamestore.be", "Evelynn", 0, "Vandermeersch", null },
                    { 348, "joshua.van opstal@mygamestore.be", "Joshua", 0, "Van Opstal", null },
                    { 347, "rachel.van merode@mygamestore.be", "Rachel", 0, "Van Merode", null },
                    { 346, "diego.van duyse@mygamestore.be", "Diëgo", 0, "Van Duyse", null },
                    { 345, "brent.van dooren@mygamestore.be", "Brent", 0, "Van Dooren", null }
                });

            migrationBuilder.InsertData(
                table: "tblPeople",
                columns: new[] { "Id", "EmailAddress", "FirstName", "Gender", "LastName", "StoreId" },
                values: new object[,]
                {
                    { 344, "femke.van dessel@mygamestore.be", "Femke", 0, "Van Dessel", null },
                    { 343, "sien.van de vondel@mygamestore.be", "Sien", 0, "Van De Vondel", null },
                    { 342, "thomas.tinck@mygamestore.be", "Thomas", 0, "Tinck", null },
                    { 341, "jody.thys@mygamestore.be", "Jody", 0, "Thys", null },
                    { 349, "rubin.van vuuren@mygamestore.be", "Rubin", 0, "Van Vuuren", null },
                    { 317, "annelore.maes@mygamestore.be", "Annelore", 0, "Maes", null },
                    { 316, "feyzanur.leroy@mygamestore.be", "Feyzanur", 0, "Leroy", null },
                    { 315, "thomas.keustermans@mygamestore.be", "Thomas", 0, "Keustermans", null },
                    { 287, "ludovic.smets@mygamestore.be", "Ludovic", 0, "Smets", null },
                    { 286, "colin.lens@mygamestore.be", "Colin", 0, "Lens", null },
                    { 285, "lies.vertonghen@mygamestore.be", "Lies", 0, "Vertonghen", null },
                    { 284, "wout.ven@mygamestore.be", "Wout", 0, "Ven", null },
                    { 283, "ineke.quintelier@mygamestore.be", "Ineke", 0, "Quintelier", null },
                    { 282, "eline.proost@mygamestore.be", "Eline", 0, "Proost", null },
                    { 281, "julie.calle@mygamestore.be", "Julie", 0, "Calle", null },
                    { 280, "jill.wouters@mygamestore.be", "Jill", 0, "Wouters", null },
                    { 288, "lise.stuyven@mygamestore.be", "Lise", 0, "Stuyven", null },
                    { 279, "emma.wellens@mygamestore.be", "Emma", 0, "Wellens", null },
                    { 277, "stiene.sannen@mygamestore.be", "Stiene", 0, "Sannen", null },
                    { 276, "anouk.quayhackx@mygamestore.be", "Anouk", 0, "Quayhackx", null },
                    { 275, "britt.peleman@mygamestore.be", "Britt", 0, "Peleman", null },
                    { 274, "laura.geens@mygamestore.be", "Laura", 0, "Geens", null },
                    { 273, "lien.boeykens@mygamestore.be", "Lien", 0, "Boeykens", null },
                    { 272, "shana.verbaenen@mygamestore.be", "Shana", 0, "Verbaenen", null },
                    { 271, "anne.van den broek @mygamestore.be", "Anne", 0, "Van den Broek ", null },
                    { 270, "charlotte.peeters@mygamestore.be", "Charlotte", 0, "Peeters", null },
                    { 278, "emma.wambacq@mygamestore.be", "Emma", 0, "Wambacq", null },
                    { 289, "pieterjan.maes@mygamestore.be", "Pieterjan", 0, "Maes", null },
                    { 290, "willem.mabille@mygamestore.be", "Willem", 0, "Mabille", null },
                    { 291, "jan.martens@mygamestore.be", "Jan", 0, "Martens", null },
                    { 314, "karel.hendrickx@mygamestore.be", "Karel", 0, "Hendrickx", null },
                    { 313, "dythe.goetstouwers@mygamestore.be", "Dythe", 0, "Goetstouwers", null },
                    { 312, "liesa.gerard@mygamestore.be", "Liesa", 0, "Gerard", null },
                    { 311, "arthur.duarte tome@mygamestore.be", "Arthur", 0, "Duarte Tome", null },
                    { 310, "yannick.de wit@mygamestore.be", "Yannick", 0, "De Wit", null },
                    { 309, "loriane.de tollenaere@mygamestore.be", "Loriane", 0, "De Tollenaere", null },
                    { 308, "celine.de belie@mygamestore.be", "Céline", 0, "De Belie", null },
                    { 307, "marie.daskin@mygamestore.be", "Marie", 0, "Daskin", null },
                    { 306, "sophie.da silva pereira @mygamestore.be", "Sophie", 0, "Da Silva Pereira ", null },
                    { 305, "aline.couck@mygamestore.be", "Aline", 0, "Couck", null },
                    { 304, "arne.bressinck@mygamestore.be", "Arne", 0, "Bressinck", null },
                    { 303, "melissa.bouckaert@mygamestore.be", "Melissa", 0, "Bouckaert", null }
                });

            migrationBuilder.InsertData(
                table: "tblPeople",
                columns: new[] { "Id", "EmailAddress", "FirstName", "Gender", "LastName", "StoreId" },
                values: new object[,]
                {
                    { 302, "jill.bosmans@mygamestore.be", "Jill", 0, "Bosmans", null },
                    { 301, "ignace.anciaux@mygamestore.be", "Ignace", 0, "Anciaux", null },
                    { 300, "michiel.adriaenssens@mygamestore.be", "Michiel", 0, "Adriaenssens", null },
                    { 299, "emilie.vermeyen@mygamestore.be", "Emilie", 0, "Vermeyen", null },
                    { 298, "nick.wouters@mygamestore.be", "Nick", 0, "Wouters", null },
                    { 297, "katrien.van hoecke@mygamestore.be", "Katrien", 0, "Van Hoecke", null },
                    { 296, "anthony.van der stappen@mygamestore.be", "Anthony", 0, "Van der Stappen", null },
                    { 268, "michiel.heyecan@mygamestore.be", "Michiel", 0, "Heyecan", null },
                    { 178, "radima.kachichian@mygamestore.be", "Radima", 0, "Kachichian", null },
                    { 207, "arzu.el yousfi@mygamestore.be", "Arzu", 0, "El Yousfi", null },
                    { 176, "zeynep.summerville@mygamestore.be", "Zeynep", 0, "Summerville", null },
                    { 64, "karolien.bruynkens@mygamestore.be", "Karolien", 0, "Bruynkens", null },
                    { 63, "kaylee.maes@mygamestore.be", "Kaylee", 0, "Maes", null },
                    { 62, "flore.wijnants@mygamestore.be", "Flore", 0, "Wijnants", null },
                    { 61, "axelle.vranckaert@mygamestore.be", "Axelle", 0, "Vranckaert", null },
                    { 177, "malikat.gorochshenko@mygamestore.be", "Malikat", 0, "Gorochshenko", null },
                    { 59, "helin.vanderleenen@mygamestore.be", "Helin", 0, "Vanderleenen", null },
                    { 58, "uwe.van vlierberghe @mygamestore.be", "Uwe", 0, "Van Vlierberghe ", null },
                    { 57, "nicolas.van acker@mygamestore.be", "Nicolas", 0, "Van Acker", null },
                    { 65, "jonas.de peuter@mygamestore.be", "Jonas", 0, "De Peuter", null },
                    { 56, "phyllis.ronsmans@mygamestore.be", "Phyllis", 0, "Ronsmans", null },
                    { 54, "fleur.peeters@mygamestore.be", "Fleur", 0, "Peeters", null },
                    { 53, "imelda.mannekens@mygamestore.be", "Imelda", 0, "Mannekens", null },
                    { 52, "stephanie.maes@mygamestore.be", "Stéphanie", 0, "Maes", null },
                    { 51, "cato.leten@mygamestore.be", "Cato", 0, "Leten", null },
                    { 50, "jelle.kemps@mygamestore.be", "Jelle", 0, "Kemps", null },
                    { 49, "renke.jacobs@mygamestore.be", "Renke", 0, "Jacobs", null },
                    { 48, "jonas.huysmans@mygamestore.be", "Jonas", 0, "Huysmans", null },
                    { 47, "laura.fourneau@mygamestore.be", "Laura", 0, "Fourneau", null },
                    { 55, "merel.roef@mygamestore.be", "Merel", 0, "Roef", null },
                    { 46, "oona.eerdekens@mygamestore.be", "Oona", 0, "Eerdekens", null },
                    { 66, "jill.gashi@mygamestore.be", "Jill", 0, "Gashi", null },
                    { 68, "yoran.van doorslaer@mygamestore.be", "Yoran", 0, "Van Doorslaer", null },
                    { 86, "emma.deschoenmaker@mygamestore.be", "Emma", 0, "Deschoenmaker", null },
                    { 85, "emma.verbeeck@mygamestore.be", "Emma", 0, "Verbeeck", null },
                    { 84, "stiene.van den sande @mygamestore.be", "Stiene", 0, "Van den Sande ", null },
                    { 83, "anouk.nijs@mygamestore.be", "Anouk", 0, "Nijs", null },
                    { 82, "britt.de laender@mygamestore.be", "Britt", 0, "De Laender", null },
                    { 81, "marie.de cree@mygamestore.be", "Marie", 0, "De Crée", null },
                    { 80, "natan.lardenoit@mygamestore.be", "Natan", 0, "Lardenoit", null },
                    { 79, "shauni.kennis@mygamestore.be", "Shauni", 0, "Kennis", null },
                    { 67, "jolien.schoors@mygamestore.be", "Jolien", 0, "Schoors", null }
                });

            migrationBuilder.InsertData(
                table: "tblPeople",
                columns: new[] { "Id", "EmailAddress", "FirstName", "Gender", "LastName", "StoreId" },
                values: new object[,]
                {
                    { 78, "shania.hauquier@mygamestore.be", "Shania", 0, "Hauquier", null },
                    { 76, "kaylee.verresen@mygamestore.be", "Kaylee", 0, "Verresen", null },
                    { 75, "lina.van miert@mygamestore.be", "Lina", 0, "Van Miert", null },
                    { 74, "maxinn.van landeghem@mygamestore.be", "Maxinn", 0, "Van Landeghem", null },
                    { 73, "julie.peeters@mygamestore.be", "Julie", 0, "Peeters", null },
                    { 72, "dagny.heyecan@mygamestore.be", "Dagny", 0, "Heyecan", null },
                    { 71, "pieter.cuvelier@mygamestore.be", "Pieter", 0, "Cuvelier", null },
                    { 70, "marthe.willemsen@mygamestore.be", "Marthe", 0, "Willemsen", null },
                    { 69, "brend.verreth@mygamestore.be", "Brend", 0, "Verreth", null },
                    { 77, "steven.de loose@mygamestore.be", "Steven", 0, "De Loose", null },
                    { 45, "sheila.duymelinckx@mygamestore.be", "Sheila", 0, "Duymelinckx", null },
                    { 44, "niels.de kort@mygamestore.be", "Niels", 0, "de Kort", null },
                    { 43, "evelynn.bernaerts@mygamestore.be", "Evelynn", 0, "Bernaerts", null },
                    { 19, "leny.nasir@mygamestore.be", "Leny", 0, "Nasir", null },
                    { 18, "mariam.mbuyamba@mygamestore.be", "Mariam", 0, "Mbuyamba", null },
                    { 17, "diana.akyuz@mygamestore.be", "Diana", 0, "Akyuz", null },
                    { 16, "anissa.zurel@mygamestore.be", "Anissa", 0, "Zurel", null },
                    { 15, "nabil.sahin@mygamestore.be", "Nabil", 0, "Sahin", null },
                    { 14, "chaimae.sahin@mygamestore.be", "Chaimae", 0, "Sahin", null },
                    { 13, "soumia.laaraj@mygamestore.be", "Soumia", 0, "Laaraj", null },
                    { 12, "silwa.de grauwe@mygamestore.be", "Silwa", 0, "De Grauwe", null },
                    { 20, "amine.ouajhain@mygamestore.be", "Amine", 0, "Ouajhain", null },
                    { 11, "rachida.avci@mygamestore.be", "Rachida", 0, "Avci", null },
                    { 9, "ummugulsum.tanrikulu@mygamestore.be", "Ümmügülsüm", 0, "Tanrikulu", null },
                    { 8, "zilan.taiebi@mygamestore.be", "Zilan", 0, "Taiebi", null },
                    { 7, "suara.shalaj@mygamestore.be", "Suara", 0, "Shalaj", null },
                    { 6, "prisca.puati@mygamestore.be", "Prisca", 0, "Puati", null },
                    { 5, "saloua.nika@mygamestore.be", "Saloua", 0, "Nika", null },
                    { 4, "kirsten.mettle@mygamestore.be", "Kirsten", 0, "Mettle", null },
                    { 3, "rumeysa.frunza@mygamestore.be", "Rumeysa", 0, "Frunza", null },
                    { 2, "hazal.amakran@mygamestore.be", "Hazal", 0, "Amakran", null },
                    { 10, "sara.bourima@mygamestore.be", "Sara", 0, "Bourima", null },
                    { 21, "yousra.sellami@mygamestore.be", "yousra", 0, "Sellami", null },
                    { 22, "kubra.alou@mygamestore.be", "Kübra", 0, "Alou", null },
                    { 23, "hafssa.el yousfi@mygamestore.be", "Hafssa", 0, "El Yousfi", null },
                    { 42, "rubin.bagramyan@mygamestore.be", "Rubin", 0, "Bagramyan", null },
                    { 41, "muhammed.yigit@mygamestore.be", "Muhammed", 0, "Yigit", null },
                    { 40, "farah.slimani@mygamestore.be", "Farah", 0, "Slimani", null },
                    { 39, "arta.racaj@mygamestore.be", "Arta", 0, "Racaj", null },
                    { 38, "makaya.el boutahiri@mygamestore.be", "Makaya", 0, "El Boutahiri", null },
                    { 37, "marigona.benaissaoui@mygamestore.be", "Marigona", 0, "Benaissaoui", null },
                    { 36, "segourney.baos y quinto@mygamestore.be", "Segourney", 0, "Baos y Quinto", null }
                });

            migrationBuilder.InsertData(
                table: "tblPeople",
                columns: new[] { "Id", "EmailAddress", "FirstName", "Gender", "LastName", "StoreId" },
                values: new object[,]
                {
                    { 35, "maryana.abdirahman@mygamestore.be", "Maryana", 0, "Abdirahman", null },
                    { 34, "youssra.osmani@mygamestore.be", "Youssra", 0, "Osmani", null },
                    { 33, "mariam.ben messaoud@mygamestore.be", "Mariam", 0, "Ben Messaoud", null },
                    { 32, "arzu.badreddine@mygamestore.be", "Arzu", 0, "Badreddine", null },
                    { 31, "soukaina.bayar@mygamestore.be", "Soukaina", 0, "Bayar", null },
                    { 30, "gjeve.laha@mygamestore.be", "Gjeve", 0, "laha", null },
                    { 29, "ikram.yahyaoui@mygamestore.be", "Ikram", 0, "Yahyaoui", null },
                    { 28, "ahmed.noboa@mygamestore.be", "Ahmed", 0, "Noboa", null },
                    { 27, "jordy.ben saïd abdelnour@mygamestore.be", "Jordy", 0, "Ben Saïd Abdelnour", null },
                    { 26, "yusuf.zakaryan@mygamestore.be", "Yusuf", 0, "Zakaryan", null },
                    { 25, "mesua.rahimi@mygamestore.be", "Mesua", 0, "Rahimi", null },
                    { 24, "siham.khayi@mygamestore.be", "Siham", 0, "Khayi", null },
                    { 87, "jill.peeters@mygamestore.be", "Jill", 0, "Peeters", null },
                    { 88, "julie.van den broek @mygamestore.be", "Julie", 0, "Van den Broek ", null },
                    { 60, "astrid.vandersmissen@mygamestore.be", "Astrid", 0, "Vandersmissen", null },
                    { 90, "ineke.boeykens@mygamestore.be", "Ineke", 0, "Boeykens", null },
                    { 153, "thomas.poelemans@mygamestore.be", "Thomas", 0, "Poelemans", null },
                    { 152, "jody.pire@mygamestore.be", "Jody", 0, "Pire", null },
                    { 151, "manon.pieters@mygamestore.be", "Manon", 0, "Pieters", null },
                    { 150, "chayenne.piessens@mygamestore.be", "Chayenne", 0, "Piessens", null },
                    { 149, "nora.peeters@mygamestore.be", "Nora", 0, "Peeters", null },
                    { 148, "laura.peeters@mygamestore.be", "Laura", 0, "Peeters", null },
                    { 147, "margaux.muller@mygamestore.be", "Margaux", 0, "Muller", null },
                    { 146, "gilles.martens@mygamestore.be", "Gilles", 0, "Martens", null },
                    { 154, "sien.ratinckx@mygamestore.be", "Sien", 0, "Ratinckx", null },
                    { 145, "sarah.maes@mygamestore.be", "Sarah", 0, "Maes", null },
                    { 143, "dythe.keustermans@mygamestore.be", "Dythe", 0, "Keustermans", null },
                    { 142, "liesa.hendrickx@mygamestore.be", "Liesa", 0, "Hendrickx", null },
                    { 141, "arthur.goetstouwers@mygamestore.be", "Arthur", 0, "Goetstouwers", null },
                    { 140, "yannick.gerard@mygamestore.be", "Yannick", 0, "Gerard", null },
                    { 139, "loriane.duarte tome@mygamestore.be", "Loriane", 0, "Duarte Tome", null },
                    { 138, "celine.de wit@mygamestore.be", "Céline", 0, "De Wit", null },
                    { 137, "marie.de tollenaere@mygamestore.be", "Marie", 0, "De Tollenaere", null },
                    { 136, "sophie.de belie@mygamestore.be", "Sophie", 0, "De Belie", null },
                    { 144, "karel.leroy@mygamestore.be", "Karel", 0, "Leroy", null },
                    { 135, "aline.daskin@mygamestore.be", "Aline", 0, "Daskin", null },
                    { 155, "femke.robberechts@mygamestore.be", "Femke", 0, "Robberechts", null },
                    { 157, "elke.snels@mygamestore.be", "Elke", 0, "Snels", null },
                    { 175, "anabel.tenzin@mygamestore.be", "Anabel", 0, "Tenzin", null },
                    { 174, "nathalie.ozieblewska@mygamestore.be", "Nathalie", 0, "Ozieblewska", null },
                    { 173, "joshua.wouters@mygamestore.be", "Joshua", 0, "Wouters", null },
                    { 172, "rachel.voeten@mygamestore.be", "Rachel", 0, "Voeten", null }
                });

            migrationBuilder.InsertData(
                table: "tblPeople",
                columns: new[] { "Id", "EmailAddress", "FirstName", "Gender", "LastName", "StoreId" },
                values: new object[,]
                {
                    { 171, "diego.vermeiren@mygamestore.be", "Diëgo", 0, "Vermeiren", null },
                    { 170, "brent.vermeersch@mygamestore.be", "Brent", 0, "Vermeersch", null },
                    { 169, "britt.verhoeven@mygamestore.be", "Britt", 0, "Verhoeven", null },
                    { 168, "sophie.verbelen@mygamestore.be", "Sophie", 0, "Verbelen", null },
                    { 156, "arne.seeuws@mygamestore.be", "Arne", 0, "Seeuws", null },
                    { 167, "margo.vandermeersch@mygamestore.be", "Margo", 0, "Vandermeersch", null },
                    { 165, "robbe.van opstal@mygamestore.be", "Robbe", 0, "Van Opstal", null },
                    { 164, "sebastian.van merode@mygamestore.be", "Sebastian", 0, "Van Merode", null },
                    { 163, "colin.van duyse@mygamestore.be", "Colin", 0, "Van Duyse", null },
                    { 89, "eline.verbaenen@mygamestore.be", "Eline", 0, "Verbaenen", null },
                    { 161, "elena.van dessel@mygamestore.be", "Elena", 0, "Van Dessel", null },
                    { 160, "julie.van de vondel@mygamestore.be", "Julie", 0, "Van De Vondel", null },
                    { 159, "louise.tinck@mygamestore.be", "Louise", 0, "Tinck", null },
                    { 158, "liesbeth.thys@mygamestore.be", "Liesbeth", 0, "Thys", null },
                    { 166, "sofie.van vuuren@mygamestore.be", "Sofie", 0, "Van Vuuren", null },
                    { 134, "marie.da silva pereira @mygamestore.be", "Marie", 0, "Da Silva Pereira ", null },
                    { 162, "emmeline.van dooren@mygamestore.be", "Emmeline", 0, "Van Dooren", null },
                    { 132, "jill.bressinck@mygamestore.be", "Jill", 0, "Bressinck", null },
                    { 109, "michiel.van pellecom@mygamestore.be", "Michiel", 0, "Van Pellecom", null },
                    { 108, "lies.martens@mygamestore.be", "Lies", 0, "Martens", null },
                    { 107, "camille.mabille@mygamestore.be", "Camille", 0, "Mabille", null },
                    { 106, "luka.maes@mygamestore.be", "Luka", 0, "Maes", null },
                    { 105, "silke.stuyven@mygamestore.be", "Silke", 0, "Stuyven", null },
                    { 104, "anouk.smets@mygamestore.be", "Anouk", 0, "Smets", null },
                    { 103, "vicky.lens@mygamestore.be", "Vicky", 0, "Lens", null },
                    { 102, "fien.vertonghen@mygamestore.be", "Fien", 0, "Vertonghen", null },
                    { 101, "frauke.ven@mygamestore.be", "Frauke", 0, "Ven", null },
                    { 100, "jill.quintelier@mygamestore.be", "Jill", 0, "Quintelier", null },
                    { 99, "lars.proost@mygamestore.be", "Lars", 0, "Proost", null },
                    { 97, "willem.wouters@mygamestore.be", "Willem", 0, "Wouters", null },
                    { 96, "pieterjan.wellens@mygamestore.be", "Pieterjan", 0, "Wellens", null },
                    { 95, "lise.wambacq@mygamestore.be", "Lise", 0, "Wambacq", null },
                    { 94, "ludovic.sannen@mygamestore.be", "Ludovic", 0, "Sannen", null },
                    { 93, "colin.quayhackx@mygamestore.be", "Colin", 0, "Quayhackx", null },
                    { 92, "lies.peleman@mygamestore.be", "Lies", 0, "Peleman", null },
                    { 91, "wout.geens@mygamestore.be", "Wout", 0, "Geens", null },
                    { 133, "melissa.couck@mygamestore.be", "Melissa", 0, "Couck", null },
                    { 110, "messalina.van reeth@mygamestore.be", "Messalina", 0, "Van Reeth", null },
                    { 111, "charlotte.arnaout@mygamestore.be", "Charlotte", 0, "Arnaout", null },
                    { 98, "maya.calle@mygamestore.be", "Maya", 0, "Calle", null },
                    { 113, "shana.leemans@mygamestore.be", "Shana", 0, "Leemans", null },
                    { 131, "ignace.bouckaert@mygamestore.be", "Ignace", 0, "Bouckaert", null }
                });

            migrationBuilder.InsertData(
                table: "tblPeople",
                columns: new[] { "Id", "EmailAddress", "FirstName", "Gender", "LastName", "StoreId" },
                values: new object[,]
                {
                    { 112, "anne.hamers@mygamestore.be", "Anne", 0, "Hamers", null },
                    { 130, "michiel.bosmans@mygamestore.be", "Michiel", 0, "Bosmans", null },
                    { 129, "emilie.anciaux@mygamestore.be", "Emilie", 0, "Anciaux", null },
                    { 128, "nick.adriaenssens@mygamestore.be", "Nick", 0, "Adriaenssens", null },
                    { 126, "anthony.siebens@mygamestore.be", "Anthony", 0, "Siebens", null },
                    { 125, "thibaut.verrykt@mygamestore.be", "Thibaut", 0, "Verrykt", null },
                    { 124, "amber.van rompaey@mygamestore.be", "Amber", 0, "Van Rompaey", null },
                    { 123, "annelore.wouters@mygamestore.be", "Annelore", 0, "Wouters", null },
                    { 127, "katrien.vermeyen@mygamestore.be", "Katrien", 0, "Vermeyen", null },
                    { 121, "thomas.van der stappen@mygamestore.be", "Thomas", 0, "Van der Stappen", null },
                    { 120, "timothy.roex@mygamestore.be", "Timothy", 0, "Roex", null },
                    { 119, "laura.paulus@mygamestore.be", "Laura", 0, "Paulus", null },
                    { 118, "charlotte.poelmans@mygamestore.be", "Charlotte", 0, "Poelmans", null },
                    { 114, "lien.omloop@mygamestore.be", "Lien", 0, "Omloop", null },
                    { 117, "lieze.gillis@mygamestore.be", "Lieze", 0, "Gillis", null },
                    { 116, "jan.alliet@mygamestore.be", "Jan", 0, "Alliet", null },
                    { 122, "feyzanur.van hoecke@mygamestore.be", "Feyzanur", 0, "Van Hoecke", null },
                    { 115, "laura.paulussen@mygamestore.be", "Laura", 0, "Paulussen", null }
                });

            migrationBuilder.InsertData(
                table: "tblStores",
                columns: new[] { "Id", "Addition", "Place", "IsFranchiseStore", "Name", "Number", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 42, null, "Brugge", false, "MyGameStore Brugge", 176, "Steenstraat", "8000" },
                    { 41, null, "Waregem", false, "MyGameStore Waregem", 172, "Stationsstraat", "8790" },
                    { 40, null, "Brussel", false, "MyGameStore Brussel", 104, "Louizalaan", "1000" },
                    { 39, "A", "Deinze", false, "MyGameStore Deinze", 180, "Winkelstraat", "9800" },
                    { 38, "5", "Ukkel", false, "MyGameStore Ukkel", 170, "Verrewinkelstraat", "1180" },
                    { 35, null, "Leuven", false, "MyGameStore Leuven", 83, "Diestsestraat", "3000" },
                    { 36, null, "Anderlecht", false, "MyGameStore Anderlecht", 29, "Olympische Dreef", "1070" },
                    { 34, null, "Vilvoorde", false, "MyGameStore Vilvoorde", 68, "Leuvensestraat", "1800" },
                    { 32, null, "Wevelgem", false, "MyGameStore Wevelgem", 192, "Menenstraat", "8560" },
                    { 43, null, "Sint-Lambrechts-Woluwe", true, "MyGameStore Sint-Lambrechts-Woluwe", 35, "Konkelstraat", "1200" },
                    { 33, null, "Elsene", true, "MyGameStore Elsene", 135, "Elsensesteenweg", "1050" },
                    { 37, null, "Grimbergen", true, "MyGameStore Grimbergen", 264, "Hogesteenweg", "1850" },
                    { 44, null, "Lommel", false, "MyGameStore Lommel", 157, "Kerkstraat", "3920" },
                    { 53, null, "Dilbeek", false, "MyGameStore Dilbeek", 39, "Verheydenstraat", "1700" },
                    { 46, null, "Lier", false, "MyGameStore Lier", 169, "Antwerpsestraat", "2500" },
                    { 47, null, "Sint-Truiden", false, "MyGameStore Sint-Truiden", 76, "Luikerstraat", "3800" },
                    { 48, "C", "Aarschot", false, "MyGameStore Aarschot", 16, "Martelarenstraat", "3200" },
                    { 49, null, "Oostende", false, "MyGameStore Oostende", 149, "Kapellestraat", "8400" },
                    { 50, null, "Lokeren", false, "MyGameStore Lokeren", 2, "Kerkstraat", "9160" },
                    { 51, null, "Tienen", false, "MyGameStore Tienen", 183, "Leuvensestraat", "3300" },
                    { 52, null, "Vorst", false, "MyGameStore Vorst", 132, "Neerstalse Steenweg", "1190" },
                    { 54, "E", "Bilzen", false, "MyGameStore Bilzen", 97, "Hees", "3740" },
                    { 55, null, "Tongeren", false, "MyGameStore Tongeren", 44, "Maastrichterstraat", "3700" },
                    { 56, null, "Sint-Pieters-Leeuw", false, "MyGameStore Sint-Pieters-Leeuw", 97, "Rink", "1600" }
                });

            migrationBuilder.InsertData(
                table: "tblStores",
                columns: new[] { "Id", "Addition", "Place", "IsFranchiseStore", "Name", "Number", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 57, null, "Beveren", false, "MyGameStore Beveren", 62, "Vrasenestraat", "8791" },
                    { 31, null, "Harelbeke", false, "MyGameStore Harelbeke", 184, "Tramstraat", "8530" },
                    { 58, "1", "Bree", false, "MyGameStore Bree", 68, "Gerdingerstraat", "3960" },
                    { 45, null, "Evergem", false, "MyGameStore Evergem", 41, "Noorwegenstraat", "9940" },
                    { 30, "H", "Genk", false, "MyGameStore Genk", 141, "Molenstraat", "3600" },
                    { 9, null, "Beringen", false, "MyGameStore Beringen", 85, "Koolmijnlaan", "3580" },
                    { 28, null, "Stokkem", false, "MyGameStore Dilsen-Stokkem", 236, "Rijksweg", "3650" },
                    { 59, null, "Menen", false, "MyGameStore Menen", 142, "Rijselstraat", "8930" },
                    { 1, null, "Kortrijk", false, "MyGameStore Kortrijk", 260, "Korte Steenstraat", "8500" },
                    { 2, null, "Ninove", true, "MyGameStore Ninove", 95, "Centrumlaan", "9400" },
                    { 3, null, "Roeselare", false, "MyGameStore Roeselare", 97, "Ooststraat", "8800" },
                    { 4, null, "Zaventem", false, "MyGameStore Zaventem", 173, "Weiveldlaan", "1930" },
                    { 5, null, "Hasselt", false, "MyGameStore Hasselt", 254, "Demerstraat", "3500" },
                    { 6, null, "Gent", true, "MyGameStore Gent", 128, "Veldstraat", "9000" },
                    { 7, null, "Knokke-Heist", false, "MyGameStore Knokke-Heist", 215, "Lippenslaan", "8300" },
                    { 8, null, "Maaseik", false, "MyGameStore Maaseik", 239, "Bosstraat", "3680" },
                    { 10, null, "Geraardsbergen", false, "MyGameStore Geraardsbergen", 149, "Winkelstraat", "9500" },
                    { 11, null, "Asse", false, "MyGameStore Asse", 260, "Stationsstraat", "1730" },
                    { 12, null, "Geel", false, "MyGameStore Geel", 59, "Nieuwstraat", "2440" },
                    { 13, null, "Antwerpen", true, "MyGameStore Antwerpen", 76, "Meir", "2000" },
                    { 14, null, "Mol", false, "MyGameStore Mol", 179, "Statiestraat", "2400" },
                    { 15, null, "Sint-Gillis", false, "MyGameStore Sint-Gillis", 286, "Fonsnylaan", "1060" },
                    { 16, "4", "Ieper", false, "MyGameStore Ieper", 189, "Boterstraat", "8900" },
                    { 17, null, "Aalst", false, "MyGameStore Aalst", 64, "Nieuwstraat", "3800" },
                    { 18, "B", "Mechelen", false, "MyGameStore Mechelen", 106, "Bruul", "2800" },
                    { 19, null, "Jette", false, "MyGameStore Jette", 78, "Léon Theodorstraat", "1090" },
                    { 20, null, "Schaarbeek", true, "MyGameStore Schaarbeek", 18, "Helmetsesteenweg", "1030" },
                    { 21, null, "Dendermonde", false, "MyGameStore Dendermonde", 206, "Oude Vest", "9200" },
                    { 22, null, "Sint-Niklaas", false, "MyGameStore Sint-Niklaas", 299, "Stationsstraat", "9100" },
                    { 23, "A", "Turnhout", false, "MyGameStore Turnhout", 40, "Gasthuisstraat", "2300" },
                    { 24, null, "Brecht", false, "MyGameStore Brecht", 18, "Heiken", "2960" },
                    { 25, null, "Sint-Jans-Molenbeek", false, "MyGameStore Sint-Jans-Molenbeek", 191, "Schoolstraat", "1080" },
                    { 26, null, "Brasschaat", false, "MyGameStore Brasschaat", 26, "Bredabaan", "2930" },
                    { 27, "2", "Halle", true, "MyGameStore Halle", 187, "Basiliekstraat", "1500" },
                    { 29, null, "Schoten", false, "MyGameStore Schoten", 77, "Paalstraat", "2900" },
                    { 60, null, "Berg", false, "MyGameStore Heist-op-den-Berg", 39, "Bergstraat", "1910" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPeople_EmailAddress",
                table: "tblPeople",
                column: "EmailAddress",
                unique: true,
                filter: "[EmailAddress] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblPeople_StoreId",
                table: "tblPeople",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStores_Name",
                table: "tblStores",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPeople");

            migrationBuilder.DropTable(
                name: "tblStores");
        }
    }
}
