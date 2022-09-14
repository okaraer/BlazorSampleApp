using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Data.Migrations
{
    public partial class initdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Firmalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirmaAdi = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    IsYetkiliFirma = table.Column<bool>(type: "INTEGER", nullable: false),
                    VizeBitisTarihi = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SertifikaBitisTarihi = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Adres = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    Telefon = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Eposta = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    PerformansPuani = table.Column<double>(type: "REAL", nullable: false),
                    GazAcimYuzdesi = table.Column<double>(type: "REAL", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsFirmaYetkilisi = table.Column<bool>(type: "INTEGER", nullable: false),
                    Adi = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Soyadi = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Unvani = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    TelefonNumarisi = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Eposta = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false),
                    fk_firma = table.Column<int>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletionTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personel_Firmalar_fk_firma",
                        column: x => x.fk_firma,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 1, "Batman Mevlana Sokak 9 Suite 014 Bingöl", new DateTime(2022, 10, 5, 11, 6, 33, 775, DateTimeKind.Unspecified).AddTicks(3735), new DateTime(2022, 10, 23, 23, 23, 36, 833, DateTimeKind.Unspecified).AddTicks(8855), "Alpyoruk.Aykac29@hotmail.com", "Pekkan, Velioğlu and Bakırcıoğlu", 86.739482024942063, false, true, 41.204860214013308, new DateTime(2023, 1, 2, 0, 29, 51, 944, DateTimeKind.Unspecified).AddTicks(2868), "+90-501-609-76-75", new DateTime(2023, 5, 3, 21, 2, 52, 66, DateTimeKind.Unspecified).AddTicks(7469) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 2, "Kastamonu Dağınık Evler Sokak 55c Apt. 136 Kırıkkale", new DateTime(2022, 8, 26, 16, 36, 25, 61, DateTimeKind.Unspecified).AddTicks(6020), new DateTime(2023, 5, 14, 8, 8, 29, 839, DateTimeKind.Unspecified).AddTicks(8458), "Agalak_Aybar57@gmail.com", "Küçükler, Çamdalı and Alyanak", 92.539399119641516, false, false, 14.720111802385638, new DateTime(2023, 5, 22, 13, 30, 6, 814, DateTimeKind.Unspecified).AddTicks(7105), "+90-292-620-1-045", new DateTime(2023, 6, 24, 20, 43, 21, 48, DateTimeKind.Unspecified).AddTicks(1864) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 3, "Tunceli Mevlana Sokak 88a Suite 602 Bayburt", new DateTime(2022, 12, 22, 14, 35, 46, 530, DateTimeKind.Unspecified).AddTicks(7843), new DateTime(2022, 9, 24, 1, 37, 4, 211, DateTimeKind.Unspecified).AddTicks(200), "Balaka61@gmail.com", "Kaplangı LLC", 88.824969697560249, false, false, 35.859331469281727, new DateTime(2023, 1, 29, 11, 48, 55, 93, DateTimeKind.Unspecified).AddTicks(7857), "+90-482-679-3-793", new DateTime(2022, 11, 17, 7, 1, 9, 415, DateTimeKind.Unspecified).AddTicks(6865) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 4, "Bursa Nalbant Sokak 42c Apt. 645 Amasya", new DateTime(2023, 3, 31, 22, 11, 58, 654, DateTimeKind.Unspecified).AddTicks(5653), new DateTime(2023, 3, 17, 8, 4, 49, 728, DateTimeKind.Unspecified).AddTicks(8243), "Altankan_Yetkiner57@hotmail.com", "Türkdoğan - Aşıkoğlu", 66.668829122155572, false, true, 26.027822707978189, new DateTime(2023, 2, 28, 23, 38, 42, 79, DateTimeKind.Unspecified).AddTicks(1232), "+90-801-936-53-29", new DateTime(2023, 4, 9, 12, 15, 35, 416, DateTimeKind.Unspecified).AddTicks(6390) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 5, "Afyonkarahisar 30 Ağustos Caddesi 40a Apt. 348 Kilis", new DateTime(2023, 4, 17, 9, 10, 31, 856, DateTimeKind.Unspecified).AddTicks(8263), new DateTime(2022, 8, 19, 7, 56, 3, 884, DateTimeKind.Unspecified).AddTicks(3757), "Bars_Tasci44@hotmail.com", "Nebioğlu and Sons", 82.072833929428185, false, false, 99.130213703613947, new DateTime(2023, 7, 29, 11, 15, 22, 197, DateTimeKind.Unspecified).AddTicks(6156), "+90-499-292-73-89", new DateTime(2023, 2, 15, 15, 52, 0, 798, DateTimeKind.Unspecified).AddTicks(1768) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 6, "Bitlis Harman Altı Sokak 26a Suite 145 Şırnak", new DateTime(2023, 7, 24, 0, 3, 11, 994, DateTimeKind.Unspecified).AddTicks(5977), new DateTime(2023, 7, 10, 4, 49, 56, 817, DateTimeKind.Unspecified).AddTicks(6814), "Kayacik_Mayhos@gmail.com", "Numanoğlu Group", 94.860622963348121, false, false, 84.945534844164186, new DateTime(2022, 9, 16, 15, 57, 55, 36, DateTimeKind.Unspecified).AddTicks(5190), "+90-631-903-51-31", new DateTime(2022, 11, 11, 9, 48, 55, 426, DateTimeKind.Unspecified).AddTicks(8838) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 7, "Diyarbakir Sevgi Sokak 890 Apt. 740 Hatay", new DateTime(2022, 11, 26, 10, 44, 27, 423, DateTimeKind.Unspecified).AddTicks(8652), new DateTime(2022, 12, 15, 0, 24, 26, 607, DateTimeKind.Unspecified).AddTicks(6788), "Balakatay_Sarioglu0@hotmail.com", "Kuzucu, Dağdaş and Mayhoş", 34.313074996659253, false, false, 64.743473230617965, new DateTime(2023, 3, 22, 7, 45, 48, 145, DateTimeKind.Unspecified).AddTicks(2378), "+90-525-616-40-53", new DateTime(2023, 3, 25, 3, 16, 24, 27, DateTimeKind.Unspecified).AddTicks(5355) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 8, "Sivas Lütfi Karadirek Caddesi 656 Apt. 897 Hakkari", new DateTime(2022, 10, 2, 7, 26, 50, 745, DateTimeKind.Unspecified).AddTicks(4042), new DateTime(2023, 3, 15, 23, 26, 35, 158, DateTimeKind.Unspecified).AddTicks(7175), "Buzac.Solmaz97@hotmail.com", "Paksüt, Okumuş and Ertürk", 83.535862637684005, false, true, 27.181639353607657, new DateTime(2022, 12, 25, 7, 12, 27, 217, DateTimeKind.Unspecified).AddTicks(8470), "+90-993-375-1-441", new DateTime(2023, 2, 5, 15, 55, 52, 26, DateTimeKind.Unspecified).AddTicks(6997) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 9, "Diyarbakir Barış Sokak 5 Suite 074 Bartın", new DateTime(2022, 10, 11, 19, 49, 19, 827, DateTimeKind.Unspecified).AddTicks(5739), new DateTime(2023, 4, 25, 13, 41, 36, 53, DateTimeKind.Unspecified).AddTicks(6463), "Bek80@yahoo.com", "Yıldızoğlu, Tütüncü and Bademci", 29.565550312711441, false, true, 64.470080547300284, new DateTime(2022, 8, 9, 18, 21, 6, 532, DateTimeKind.Unspecified).AddTicks(1910), "+90-858-946-2-363", new DateTime(2022, 10, 12, 10, 22, 43, 310, DateTimeKind.Unspecified).AddTicks(3716) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 10, "Malatya Gül Sokak 822 Suite 015 Amasya", new DateTime(2023, 7, 26, 20, 55, 10, 829, DateTimeKind.Unspecified).AddTicks(7282), new DateTime(2022, 11, 13, 15, 53, 7, 720, DateTimeKind.Unspecified).AddTicks(4580), "Berk84@yahoo.com", "Orbay - Barbarosoğlu", 40.212258400834266, false, true, 40.12741273071854, new DateTime(2023, 3, 13, 20, 13, 38, 529, DateTimeKind.Unspecified).AddTicks(397), "+90-305-927-97-03", new DateTime(2023, 6, 22, 3, 28, 4, 787, DateTimeKind.Unspecified).AddTicks(8553) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 11, "Mersin Atatürk Bulvarı 3 Suite 797 Van", new DateTime(2022, 10, 17, 17, 53, 2, 897, DateTimeKind.Unspecified).AddTicks(6), new DateTime(2022, 12, 20, 20, 6, 13, 86, DateTimeKind.Unspecified).AddTicks(8986), "Amul_Bakircioglu1@yahoo.com", "Erginsoy Inc", 10.481984160332548, false, true, 87.786418589946678, new DateTime(2022, 12, 21, 11, 44, 16, 741, DateTimeKind.Unspecified).AddTicks(456), "+90-263-829-3-255", new DateTime(2022, 10, 12, 1, 13, 42, 317, DateTimeKind.Unspecified).AddTicks(4238) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 12, "Kirsehir Saygılı Sokak 4 Suite 397 Karaman", new DateTime(2022, 10, 10, 16, 3, 40, 256, DateTimeKind.Unspecified).AddTicks(7474), new DateTime(2022, 10, 15, 6, 23, 42, 986, DateTimeKind.Unspecified).AddTicks(5908), "Aldogan_Kunter19@yahoo.com", "Yetkiner and Sons", 43.894119506730533, false, false, 48.803176152962855, new DateTime(2022, 8, 31, 20, 5, 7, 859, DateTimeKind.Unspecified).AddTicks(8507), "+90-075-225-3-228", new DateTime(2022, 9, 8, 18, 55, 28, 808, DateTimeKind.Unspecified).AddTicks(7090) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 13, "Düzce Okul Sokak 509 Apt. 675 Bartın", new DateTime(2023, 7, 4, 2, 45, 59, 720, DateTimeKind.Unspecified).AddTicks(2035), new DateTime(2022, 11, 9, 0, 3, 26, 887, DateTimeKind.Unspecified).AddTicks(1053), "Buge.Ozdogan@yahoo.com", "Alyanak, Baturalp and Keçeci", 0.52526453079787538, false, false, 45.840125437485888, new DateTime(2023, 3, 18, 19, 16, 48, 839, DateTimeKind.Unspecified).AddTicks(8281), "+90-499-019-3-672", new DateTime(2023, 2, 22, 10, 1, 36, 391, DateTimeKind.Unspecified).AddTicks(6044) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 14, "Manisa Bandak Sokak 84 Suite 976 Tunceli", new DateTime(2023, 4, 13, 12, 14, 41, 790, DateTimeKind.Unspecified).AddTicks(4805), new DateTime(2023, 6, 6, 14, 45, 0, 476, DateTimeKind.Unspecified).AddTicks(4037), "Bagaisbara1@yahoo.com", "Korol - Kaya ", 79.903452601333953, false, true, 88.276321081201431, new DateTime(2022, 12, 31, 5, 50, 36, 978, DateTimeKind.Unspecified).AddTicks(9882), "+90-278-483-11-88", new DateTime(2022, 10, 26, 18, 37, 31, 55, DateTimeKind.Unspecified).AddTicks(1616) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 15, "Kirsehir Atatürk Bulvarı 5 Suite 709 Balıkesir", new DateTime(2023, 3, 17, 21, 11, 15, 196, DateTimeKind.Unspecified).AddTicks(2173), new DateTime(2022, 11, 30, 6, 24, 36, 825, DateTimeKind.Unspecified).AddTicks(7838), "Evin67@hotmail.com", "Yalçın LLC", 67.21155058876171, false, true, 41.302155193448883, new DateTime(2023, 4, 16, 23, 45, 24, 85, DateTimeKind.Unspecified).AddTicks(7417), "+90-789-203-17-11", new DateTime(2023, 1, 23, 3, 58, 3, 912, DateTimeKind.Unspecified).AddTicks(6199) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 16, "Kirsehir Atatürk Bulvarı 77a Apt. 132 K.maraş", new DateTime(2023, 6, 15, 0, 30, 29, 585, DateTimeKind.Unspecified).AddTicks(4779), new DateTime(2022, 9, 13, 22, 10, 39, 398, DateTimeKind.Unspecified).AddTicks(4796), "Bozkurt.Kucukler42@gmail.com", "Topçuoğlu, Barbarosoğlu and Erbulak", 38.927725666139601, false, true, 86.579135392141012, new DateTime(2023, 5, 10, 11, 43, 49, 859, DateTimeKind.Unspecified).AddTicks(1232), "+90-764-814-06-58", new DateTime(2023, 3, 15, 16, 49, 29, 338, DateTimeKind.Unspecified).AddTicks(1567) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 17, "Kirklareli Barış Sokak 09a Suite 835 Kırıkkale", new DateTime(2023, 5, 29, 15, 35, 4, 139, DateTimeKind.Unspecified).AddTicks(5435), new DateTime(2023, 4, 27, 8, 4, 0, 366, DateTimeKind.Unspecified).AddTicks(2557), "Bekectegin_Tahincioglu@hotmail.com", "Özbey, Tunaboylu and Aydan", 20.154708316398683, false, false, 54.997925861578608, new DateTime(2023, 5, 12, 19, 41, 24, 937, DateTimeKind.Unspecified).AddTicks(6963), "+90-644-448-6-657", new DateTime(2022, 11, 7, 1, 0, 39, 356, DateTimeKind.Unspecified).AddTicks(5243) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 18, "Kastamonu Tevfik Fikret Caddesi 01c Suite 576 Rize", new DateTime(2023, 4, 3, 21, 17, 25, 819, DateTimeKind.Unspecified).AddTicks(3927), new DateTime(2023, 6, 29, 19, 40, 17, 831, DateTimeKind.Unspecified).AddTicks(5112), "Gokboru12@yahoo.com", "Aclan LLC", 75.273444342784643, false, true, 33.283920433671689, new DateTime(2022, 11, 19, 15, 23, 12, 248, DateTimeKind.Unspecified).AddTicks(8880), "+90-937-799-5-382", new DateTime(2022, 9, 24, 6, 55, 15, 910, DateTimeKind.Unspecified).AddTicks(7547) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 19, "Kocaeli Okul Sokak 12b Apt. 793 Elazığ", new DateTime(2023, 6, 28, 2, 51, 53, 614, DateTimeKind.Unspecified).AddTicks(8626), new DateTime(2022, 9, 21, 21, 5, 22, 434, DateTimeKind.Unspecified).AddTicks(8839), "Aydarkagan_Nebioglu@gmail.com", "Poyrazoğlu LLC", 46.626595617188194, false, false, 81.472674513742973, new DateTime(2022, 10, 10, 1, 8, 2, 613, DateTimeKind.Unspecified).AddTicks(5405), "+90-204-183-45-90", new DateTime(2022, 10, 23, 1, 12, 37, 377, DateTimeKind.Unspecified).AddTicks(7551) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 20, "Artvin Sarıkaya Caddesi 27b Apt. 874 Sinop", new DateTime(2022, 12, 13, 2, 19, 2, 786, DateTimeKind.Unspecified).AddTicks(6148), new DateTime(2022, 9, 13, 11, 14, 26, 39, DateTimeKind.Unspecified).AddTicks(5910), "Baybure.Mertoglu@gmail.com", "Akşit Inc", 86.34163873423104, false, true, 99.078201484328702, new DateTime(2023, 6, 19, 22, 37, 49, 281, DateTimeKind.Unspecified).AddTicks(6390), "+90-865-442-87-22", new DateTime(2023, 4, 17, 3, 49, 45, 574, DateTimeKind.Unspecified).AddTicks(5911) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 21, "Trabzon Kocatepe Caddesi 19a Suite 298 Giresun", new DateTime(2023, 2, 2, 19, 28, 27, 554, DateTimeKind.Unspecified).AddTicks(2585), new DateTime(2023, 4, 24, 9, 40, 23, 142, DateTimeKind.Unspecified).AddTicks(1426), "Begdemir20@yahoo.com", "Kuday Group", 32.028833051890473, false, false, 56.874824302760771, new DateTime(2023, 1, 12, 22, 45, 49, 337, DateTimeKind.Unspecified).AddTicks(1751), "+90-040-491-05-46", new DateTime(2023, 6, 1, 9, 54, 51, 124, DateTimeKind.Unspecified).AddTicks(4689) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 22, "Tokat Atatürk Bulvarı 966 Apt. 281 İstanbul", new DateTime(2023, 4, 18, 9, 38, 23, 262, DateTimeKind.Unspecified).AddTicks(5244), new DateTime(2022, 12, 29, 15, 47, 48, 560, DateTimeKind.Unspecified).AddTicks(7373), "Bitaybiki_Tunaboylu45@gmail.com", "Pekkan, Koçoğlu and Balaban", 2.0888241088935278, false, true, 39.711952405735595, new DateTime(2022, 10, 29, 15, 26, 38, 216, DateTimeKind.Unspecified).AddTicks(4969), "+90-978-693-4-056", new DateTime(2023, 3, 26, 7, 27, 24, 849, DateTimeKind.Unspecified).AddTicks(5305) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 23, "Burdur Sarıkaya Caddesi 55 Apt. 625 Hatay", new DateTime(2022, 10, 20, 7, 54, 30, 679, DateTimeKind.Unspecified).AddTicks(2559), new DateTime(2023, 1, 16, 23, 18, 10, 3, DateTimeKind.Unspecified).AddTicks(7238), "Algu_Bakircioglu@hotmail.com", "Okumuş - Bolatlı", 24.454241458008287, false, true, 13.608382192760505, new DateTime(2023, 7, 22, 22, 52, 34, 450, DateTimeKind.Unspecified).AddTicks(169), "+90-587-319-4-184", new DateTime(2023, 1, 11, 17, 46, 9, 800, DateTimeKind.Unspecified).AddTicks(4500) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 24, "Afyonkarahisar İbn-i Sina Sokak 431 Apt. 782 Bolu", new DateTime(2023, 4, 3, 13, 34, 26, 266, DateTimeKind.Unspecified).AddTicks(5577), new DateTime(2023, 4, 13, 11, 15, 45, 377, DateTimeKind.Unspecified).AddTicks(4909), "Burkay_Korol12@yahoo.com", "Kuzucu Group", 95.433434833775678, false, false, 4.654939620147891, new DateTime(2022, 10, 19, 2, 30, 46, 333, DateTimeKind.Unspecified).AddTicks(5596), "+90-181-168-6-310", new DateTime(2023, 6, 3, 19, 58, 44, 661, DateTimeKind.Unspecified).AddTicks(2789) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 25, "Edirne Okul Sokak 47 Apt. 234 Bitlis", new DateTime(2022, 10, 22, 20, 58, 5, 300, DateTimeKind.Unspecified).AddTicks(4177), new DateTime(2022, 12, 13, 7, 35, 22, 141, DateTimeKind.Unspecified).AddTicks(1437), "Isik_Turkdogan@gmail.com", "Akar  - Yorulmaz", 51.796244383844972, false, true, 92.20162348565043, new DateTime(2022, 8, 21, 11, 8, 39, 466, DateTimeKind.Unspecified).AddTicks(5287), "+90-829-832-73-33", new DateTime(2022, 10, 30, 15, 57, 27, 767, DateTimeKind.Unspecified).AddTicks(4696) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 26, "Adiyaman Sevgi Sokak 87c Suite 682 Hatay", new DateTime(2023, 5, 8, 1, 16, 54, 481, DateTimeKind.Unspecified).AddTicks(2091), new DateTime(2023, 7, 11, 14, 25, 25, 717, DateTimeKind.Unspecified).AddTicks(3667), "Ermen_Kaya@yahoo.com", "Akşit - Kuday", 35.705246858541614, false, true, 96.416615729786002, new DateTime(2023, 1, 29, 5, 44, 37, 842, DateTimeKind.Unspecified).AddTicks(9317), "+90-724-546-35-32", new DateTime(2023, 4, 16, 2, 3, 53, 745, DateTimeKind.Unspecified).AddTicks(7430) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 27, "Kastamonu Ali Çetinkaya Caddesi 15 Apt. 749 Bingöl", new DateTime(2023, 5, 17, 12, 40, 21, 33, DateTimeKind.Unspecified).AddTicks(8837), new DateTime(2023, 2, 8, 10, 22, 20, 587, DateTimeKind.Unspecified).AddTicks(2814), "Kayacik87@yahoo.com", "Tahincioğlu LLC", 62.770370411794005, false, true, 80.309639763428535, new DateTime(2022, 10, 8, 5, 31, 0, 46, DateTimeKind.Unspecified).AddTicks(3484), "+90-973-118-00-95", new DateTime(2022, 10, 17, 10, 1, 21, 20, DateTimeKind.Unspecified).AddTicks(5338) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 28, "Agri Kerimoğlu Sokak 0 Apt. 269 Tunceli", new DateTime(2023, 2, 25, 13, 29, 23, 875, DateTimeKind.Unspecified).AddTicks(8881), new DateTime(2023, 1, 26, 18, 50, 46, 499, DateTimeKind.Unspecified).AddTicks(4921), "Bulgak.Limoncuoglu@hotmail.com", "Beşerler - Sandalcı", 7.3244175631844382, false, true, 58.947635671442292, new DateTime(2022, 11, 5, 17, 23, 28, 656, DateTimeKind.Unspecified).AddTicks(56), "+90-380-735-9-510", new DateTime(2023, 2, 14, 6, 6, 11, 732, DateTimeKind.Unspecified).AddTicks(3026) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 29, "Kirsehir Gül Sokak 99 Suite 983 Şırnak", new DateTime(2022, 12, 18, 12, 31, 33, 575, DateTimeKind.Unspecified).AddTicks(7448), new DateTime(2023, 4, 26, 18, 14, 0, 852, DateTimeKind.Unspecified).AddTicks(2836), "Bilgetegin.Okur@gmail.com", "Akyüz - Akyüz", 80.916891799415296, false, false, 3.8276877319918579, new DateTime(2023, 1, 11, 12, 23, 9, 296, DateTimeKind.Unspecified).AddTicks(6513), "+90-436-936-6-751", new DateTime(2022, 12, 8, 1, 1, 59, 986, DateTimeKind.Unspecified).AddTicks(3768) });

            migrationBuilder.InsertData(
                table: "Firmalar",
                columns: new[] { "Id", "Adres", "CreationTime", "DeletionTime", "Eposta", "FirmaAdi", "GazAcimYuzdesi", "IsDeleted", "IsYetkiliFirma", "PerformansPuani", "SertifikaBitisTarihi", "Telefon", "VizeBitisTarihi" },
                values: new object[] { 30, "Bilecik Lütfi Karadirek Caddesi 68 Suite 786 Artvin", new DateTime(2023, 7, 7, 4, 41, 37, 773, DateTimeKind.Unspecified).AddTicks(6919), new DateTime(2022, 12, 29, 23, 36, 59, 46, DateTimeKind.Unspecified).AddTicks(2734), "Cocukboru92@yahoo.com", "Koyuncu LLC", 80.428821974541265, false, false, 27.483250311666353, new DateTime(2022, 11, 6, 16, 47, 54, 513, DateTimeKind.Unspecified).AddTicks(5259), "+90-126-793-46-07", new DateTime(2023, 7, 10, 20, 55, 2, 607, DateTimeKind.Unspecified).AddTicks(4714) });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 1, "Özlen", new DateTime(2022, 9, 11, 12, 36, 45, 937, DateTimeKind.Unspecified).AddTicks(1046), new DateTime(2023, 4, 28, 23, 31, 9, 628, DateTimeKind.Unspecified).AddTicks(7988), "Alayuntlu.Ozbey67@gmail.com", false, true, "Önür", "+90-228-630-8-347", "Tekniker", 24 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 2, "Fahriye", new DateTime(2023, 4, 7, 11, 58, 0, 953, DateTimeKind.Unspecified).AddTicks(7995), new DateTime(2023, 1, 26, 22, 44, 39, 245, DateTimeKind.Unspecified).AddTicks(9071), "Burulday.Kilicci2@yahoo.com", false, false, "Köybaşı", "+90-910-130-98-16", "Mühendis", 29 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 3, "Özcan", new DateTime(2022, 9, 22, 8, 47, 8, 843, DateTimeKind.Unspecified).AddTicks(9720), new DateTime(2023, 2, 8, 19, 2, 48, 103, DateTimeKind.Unspecified).AddTicks(8358), "Bitaybiki49@yahoo.com", false, false, "Topaloğlu", "+90-516-623-12-64", "Mühendis", 10 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 4, "Ferruh", new DateTime(2022, 8, 13, 13, 57, 39, 501, DateTimeKind.Unspecified).AddTicks(8017), new DateTime(2022, 12, 16, 22, 53, 56, 957, DateTimeKind.Unspecified).AddTicks(6914), "Baykoca79@gmail.com", false, true, "Pekkan", "+90-349-372-35-86", "Teknisyen", 26 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 5, "Şemsi", new DateTime(2022, 12, 27, 8, 4, 42, 275, DateTimeKind.Unspecified).AddTicks(6234), new DateTime(2022, 8, 14, 13, 46, 4, 39, DateTimeKind.Unspecified).AddTicks(5310), "Gulemen_Mayhos15@hotmail.com", false, true, "Özkara", "+90-905-537-6-406", "Tekniker", 16 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 6, "Bedran", new DateTime(2023, 7, 29, 6, 0, 46, 499, DateTimeKind.Unspecified).AddTicks(878), new DateTime(2022, 10, 26, 4, 32, 31, 613, DateTimeKind.Unspecified).AddTicks(7191), "Eyiz_Yilmazer97@hotmail.com", false, true, "Koçoğlu", "+90-483-231-6-369", "Makina Mühendisi", 29 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 7, "Selami", new DateTime(2023, 6, 16, 18, 31, 0, 363, DateTimeKind.Unspecified).AddTicks(6978), new DateTime(2022, 11, 3, 9, 11, 18, 326, DateTimeKind.Unspecified).AddTicks(4884), "Baydur.Polat@hotmail.com", false, true, "Akbulut", "+90-460-227-37-84", "Makina Mühendisi", 28 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 8, "Fikri", new DateTime(2023, 7, 14, 14, 32, 19, 47, DateTimeKind.Unspecified).AddTicks(3356), new DateTime(2022, 10, 26, 16, 44, 42, 287, DateTimeKind.Unspecified).AddTicks(1046), "Akbay_Kaya@hotmail.com", false, true, "Türkdoğan", "+90-015-172-1-028", "Teknisyen", 13 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 9, "Dicle", new DateTime(2022, 12, 24, 14, 9, 52, 937, DateTimeKind.Unspecified).AddTicks(8057), new DateTime(2023, 6, 23, 14, 16, 53, 838, DateTimeKind.Unspecified).AddTicks(8962), "Baraktore61@gmail.com", false, false, "Akgül", "+90-460-524-9-697", "Teknisyen", 25 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 10, "Cavid", new DateTime(2023, 1, 11, 22, 34, 29, 138, DateTimeKind.Unspecified).AddTicks(9665), new DateTime(2022, 11, 2, 8, 39, 13, 52, DateTimeKind.Unspecified).AddTicks(2185), "Arikagan9@yahoo.com", false, true, "Tahincioğlu", "+90-482-853-5-617", "Tesisatçı", 21 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 11, "Afra", new DateTime(2023, 2, 6, 17, 58, 58, 566, DateTimeKind.Unspecified).AddTicks(6985), new DateTime(2022, 10, 2, 10, 53, 45, 340, DateTimeKind.Unspecified).AddTicks(5496), "Esin.Akyurek91@yahoo.com", false, false, "Sezek", "+90-509-254-2-101", "Teknisyen", 1 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 12, "Ilgın", new DateTime(2022, 8, 22, 11, 36, 39, 419, DateTimeKind.Unspecified).AddTicks(6947), new DateTime(2023, 3, 21, 22, 15, 47, 80, DateTimeKind.Unspecified).AddTicks(4038), "Guzey_Solmaz40@gmail.com", false, false, "Mertoğlu", "+90-683-532-64-76", "Makina Mühendisi", 18 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 13, "Utku", new DateTime(2023, 4, 7, 1, 34, 21, 158, DateTimeKind.Unspecified).AddTicks(3508), new DateTime(2023, 7, 3, 2, 43, 7, 792, DateTimeKind.Unspecified).AddTicks(8306), "Alpturan.Akyuz@yahoo.com", false, false, "Tütüncü", "+90-009-233-94-84", "Tekniker", 27 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 14, "Açela", new DateTime(2022, 10, 5, 7, 44, 13, 945, DateTimeKind.Unspecified).AddTicks(5841), new DateTime(2023, 2, 21, 3, 9, 45, 435, DateTimeKind.Unspecified).AddTicks(8402), "Ila1@gmail.com", false, false, "Poyrazoğlu", "+90-233-142-0-269", "Mühendis", 15 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 15, "Melek", new DateTime(2023, 1, 29, 6, 59, 42, 205, DateTimeKind.Unspecified).AddTicks(3150), new DateTime(2023, 5, 23, 1, 33, 22, 525, DateTimeKind.Unspecified).AddTicks(7639), "Bilgetacam.Daglaroglu@yahoo.com", false, true, "Bolatlı", "+90-862-327-75-31", "Tesisatçı", 3 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 16, "Salim", new DateTime(2022, 11, 5, 18, 14, 1, 591, DateTimeKind.Unspecified).AddTicks(4740), new DateTime(2022, 11, 18, 22, 16, 17, 301, DateTimeKind.Unspecified).AddTicks(3530), "Iyik57@hotmail.com", false, true, "Gönültaş", "+90-485-740-2-494", "Tekniker", 27 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 17, "Serin", new DateTime(2023, 4, 12, 7, 38, 28, 366, DateTimeKind.Unspecified).AddTicks(4449), new DateTime(2023, 6, 27, 23, 8, 37, 92, DateTimeKind.Unspecified).AddTicks(1930), "Adaldi3@gmail.com", false, false, "Özkara", "+90-384-881-2-608", "Teknisyen", 30 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 18, "Zihnî", new DateTime(2022, 9, 10, 9, 25, 5, 686, DateTimeKind.Unspecified).AddTicks(7830), new DateTime(2022, 10, 19, 5, 12, 39, 20, DateTimeKind.Unspecified).AddTicks(1323), "Basar3@yahoo.com", false, false, "Hamzaoğlu", "+90-081-542-96-43", "Teknisyen", 3 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 19, "Afra", new DateTime(2023, 6, 29, 22, 32, 31, 115, DateTimeKind.Unspecified).AddTicks(7853), new DateTime(2023, 5, 3, 18, 51, 53, 629, DateTimeKind.Unspecified).AddTicks(9959), "Ayas.Bolatli@hotmail.com", false, false, "Kuzucu", "+90-495-777-41-26", "Teknisyen", 22 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 20, "Özden", new DateTime(2023, 2, 20, 7, 4, 17, 857, DateTimeKind.Unspecified).AddTicks(2412), new DateTime(2022, 9, 25, 7, 18, 10, 425, DateTimeKind.Unspecified).AddTicks(8958), "Ayas77@gmail.com", false, true, "Biçer", "+90-942-859-4-156", "Teknisyen", 3 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 21, "Salim", new DateTime(2023, 5, 30, 20, 51, 7, 388, DateTimeKind.Unspecified).AddTicks(8213), new DateTime(2023, 4, 18, 4, 8, 30, 985, DateTimeKind.Unspecified).AddTicks(8609), "Bukebuyrac57@yahoo.com", false, false, "Küçükler", "+90-983-348-45-96", "Tekniker", 4 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 22, "Mükerrem", new DateTime(2023, 5, 1, 2, 22, 54, 532, DateTimeKind.Unspecified).AddTicks(8251), new DateTime(2022, 9, 30, 20, 20, 50, 365, DateTimeKind.Unspecified).AddTicks(1126), "Damla_Kucukler76@hotmail.com", false, false, "Dalkıran", "+90-503-208-9-863", "Makina Mühendisi", 2 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 23, "Cansın", new DateTime(2022, 9, 9, 23, 20, 49, 277, DateTimeKind.Unspecified).AddTicks(6571), new DateTime(2023, 4, 9, 11, 48, 40, 723, DateTimeKind.Unspecified).AddTicks(9999), "Aki.Dizdar26@hotmail.com", false, false, "Düşenkalkar", "+90-669-747-4-223", "Makina Mühendisi", 10 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 24, "Tarkan", new DateTime(2023, 6, 4, 6, 47, 24, 684, DateTimeKind.Unspecified).AddTicks(6612), new DateTime(2023, 2, 18, 20, 3, 31, 579, DateTimeKind.Unspecified).AddTicks(8310), "Buyancuk.Ozkok73@yahoo.com", false, true, "Özkara", "+90-274-010-8-258", "Makina Mühendisi", 5 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 25, "Haseki", new DateTime(2023, 1, 9, 12, 2, 31, 889, DateTimeKind.Unspecified).AddTicks(8211), new DateTime(2023, 2, 15, 17, 45, 26, 659, DateTimeKind.Unspecified).AddTicks(3419), "Baypure2@hotmail.com", false, true, "Kaplangı", "+90-509-623-60-34", "Mühendis", 19 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 26, "Ayren", new DateTime(2022, 8, 15, 16, 8, 19, 152, DateTimeKind.Unspecified).AddTicks(7490), new DateTime(2023, 6, 10, 22, 18, 41, 509, DateTimeKind.Unspecified).AddTicks(3197), "Badabul_Korol@yahoo.com", false, false, "Çetiner", "+90-590-970-0-649", "Mühendis", 14 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 27, "Lemide", new DateTime(2022, 8, 5, 20, 59, 16, 742, DateTimeKind.Unspecified).AddTicks(1075), new DateTime(2023, 4, 7, 17, 46, 58, 371, DateTimeKind.Unspecified).AddTicks(2379), "Badruk_Karaer@hotmail.com", false, true, "Orbay", "+90-430-037-8-472", "Tesisatçı", 26 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 28, "Kiraz", new DateTime(2022, 11, 2, 0, 47, 53, 190, DateTimeKind.Unspecified).AddTicks(772), new DateTime(2022, 12, 5, 16, 34, 7, 476, DateTimeKind.Unspecified).AddTicks(7024), "Calapkulu_Kulaksizoglu39@hotmail.com", false, false, "Alnıaçık", "+90-801-889-0-303", "Mühendis", 15 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 29, "Aktekin", new DateTime(2023, 5, 18, 3, 44, 8, 699, DateTimeKind.Unspecified).AddTicks(3785), new DateTime(2022, 12, 15, 13, 20, 37, 277, DateTimeKind.Unspecified).AddTicks(5251), "Bilgin6@gmail.com", false, false, "Ekşioğlu", "+90-837-476-30-21", "Mühendis", 27 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 30, "Yelda", new DateTime(2023, 1, 20, 0, 26, 40, 337, DateTimeKind.Unspecified).AddTicks(7073), new DateTime(2023, 5, 22, 16, 31, 46, 81, DateTimeKind.Unspecified).AddTicks(4124), "Ancuk_Arslanoglu34@hotmail.com", false, true, "Erbay", "+90-529-765-10-79", "Mühendis", 1 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 31, "Fatoş", new DateTime(2023, 6, 25, 3, 8, 50, 926, DateTimeKind.Unspecified).AddTicks(4632), new DateTime(2023, 4, 28, 7, 58, 46, 474, DateTimeKind.Unspecified).AddTicks(7086), "Kimizin.Mertoglu@hotmail.com", false, false, "Kunter", "+90-886-948-8-457", "Tesisatçı", 22 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 32, "Ümmiye", new DateTime(2022, 12, 23, 16, 1, 25, 56, DateTimeKind.Unspecified).AddTicks(2572), new DateTime(2022, 9, 5, 4, 46, 30, 973, DateTimeKind.Unspecified).AddTicks(216), "Bayrac.Akay76@yahoo.com", false, false, "Hamzaoğlu", "+90-084-673-0-284", "Mühendis", 15 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 33, "Zübeyde", new DateTime(2023, 2, 7, 4, 31, 12, 774, DateTimeKind.Unspecified).AddTicks(3392), new DateTime(2023, 1, 19, 2, 19, 45, 998, DateTimeKind.Unspecified).AddTicks(1632), "Benlidemir.Aclan@hotmail.com", false, true, "Orbay", "+90-918-057-20-66", "Teknisyen", 14 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 34, "Mehmet", new DateTime(2022, 8, 6, 9, 4, 2, 923, DateTimeKind.Unspecified).AddTicks(6523), new DateTime(2023, 4, 11, 9, 59, 38, 424, DateTimeKind.Unspecified).AddTicks(8079), "Inc_Yildirim@hotmail.com", false, false, "Polat", "+90-228-235-9-514", "Makina Mühendisi", 3 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 35, "Raci", new DateTime(2023, 3, 8, 0, 3, 22, 897, DateTimeKind.Unspecified).AddTicks(2822), new DateTime(2022, 10, 12, 14, 23, 4, 904, DateTimeKind.Unspecified).AddTicks(485), "Asanboga34@gmail.com", false, true, "Uca", "+90-906-156-6-027", "Makina Mühendisi", 6 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 36, "Hızır", new DateTime(2023, 6, 13, 18, 53, 58, 717, DateTimeKind.Unspecified).AddTicks(5056), new DateTime(2022, 12, 29, 2, 57, 59, 370, DateTimeKind.Unspecified).AddTicks(5533), "Bagaalp_Karabulut@yahoo.com", false, false, "Avan", "+90-194-732-1-278", "Makina Mühendisi", 11 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 37, "Kısmet", new DateTime(2023, 4, 28, 17, 50, 56, 63, DateTimeKind.Unspecified).AddTicks(1720), new DateTime(2023, 2, 1, 10, 43, 49, 767, DateTimeKind.Unspecified).AddTicks(9545), "Iyik.Kutlay@gmail.com", false, true, "Tekand", "+90-041-516-0-156", "Tekniker", 4 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 38, "Ilgın", new DateTime(2022, 8, 9, 1, 34, 39, 8, DateTimeKind.Unspecified).AddTicks(4567), new DateTime(2022, 12, 29, 16, 16, 20, 674, DateTimeKind.Unspecified).AddTicks(7156), "Baykara_Sozeri20@hotmail.com", false, false, "Beşerler", "+90-939-789-2-359", "Teknisyen", 25 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 39, "Julide", new DateTime(2022, 12, 26, 4, 46, 55, 56, DateTimeKind.Unspecified).AddTicks(549), new DateTime(2022, 11, 24, 2, 27, 24, 409, DateTimeKind.Unspecified).AddTicks(2611), "Begine.Ozansoy@hotmail.com", false, true, "Adıvar", "+90-489-342-46-21", "Tesisatçı", 13 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 40, "Derya", new DateTime(2023, 2, 1, 6, 24, 24, 972, DateTimeKind.Unspecified).AddTicks(4594), new DateTime(2023, 2, 16, 17, 23, 5, 433, DateTimeKind.Unspecified).AddTicks(6294), "Akin.Uca52@gmail.com", false, true, "Bakırcıoğlu", "+90-667-250-7-740", "Tekniker", 25 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 41, "Hammâd", new DateTime(2023, 1, 18, 13, 57, 46, 412, DateTimeKind.Unspecified).AddTicks(833), new DateTime(2022, 11, 19, 17, 48, 26, 21, DateTimeKind.Unspecified).AddTicks(4714), "Kimizalmila.Turkyilmaz@hotmail.com", false, true, "Kulaksızoğlu", "+90-486-683-12-34", "Mühendis", 26 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 42, "Ceren", new DateTime(2022, 10, 26, 15, 37, 4, 536, DateTimeKind.Unspecified).AddTicks(9792), new DateTime(2022, 10, 11, 11, 40, 49, 563, DateTimeKind.Unspecified).AddTicks(4387), "Bitaybiki48@hotmail.com", false, true, "Oraloğlu", "+90-947-001-2-482", "Teknisyen", 7 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 43, "Tanyeli", new DateTime(2022, 9, 16, 8, 50, 53, 456, DateTimeKind.Unspecified).AddTicks(6913), new DateTime(2023, 7, 16, 22, 14, 9, 633, DateTimeKind.Unspecified).AddTicks(7012), "Balaka84@hotmail.com", false, true, "Kunter", "+90-332-496-74-03", "Tekniker", 20 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 44, "Ali", new DateTime(2023, 3, 7, 10, 5, 26, 541, DateTimeKind.Unspecified).AddTicks(2183), new DateTime(2022, 8, 15, 16, 1, 17, 100, DateTimeKind.Unspecified).AddTicks(3103), "Bolun.Basoglu42@gmail.com", false, false, "Keseroğlu", "+90-129-442-6-433", "Mühendis", 26 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 45, "Dağhan", new DateTime(2023, 1, 21, 23, 51, 43, 499, DateTimeKind.Unspecified).AddTicks(3830), new DateTime(2022, 9, 16, 19, 16, 46, 31, DateTimeKind.Unspecified).AddTicks(6960), "Ayyildiz.Sozeri@gmail.com", false, false, "Özdoğan", "+90-703-677-89-51", "Teknisyen", 26 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 46, "Dilruba", new DateTime(2022, 9, 10, 18, 15, 36, 141, DateTimeKind.Unspecified).AddTicks(2986), new DateTime(2022, 12, 16, 0, 2, 14, 580, DateTimeKind.Unspecified).AddTicks(7976), "Bulus95@hotmail.com", false, false, "Adıvar", "+90-169-239-9-661", "Teknisyen", 27 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 47, "Keşşaf", new DateTime(2022, 12, 3, 11, 24, 4, 133, DateTimeKind.Unspecified).AddTicks(3311), new DateTime(2023, 1, 1, 18, 53, 36, 869, DateTimeKind.Unspecified).AddTicks(4303), "Balaban.Dogan87@yahoo.com", false, true, "Tekand", "+90-590-931-3-989", "Makina Mühendisi", 9 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 48, "Ziyâd", new DateTime(2023, 4, 7, 14, 17, 22, 121, DateTimeKind.Unspecified).AddTicks(1600), new DateTime(2023, 3, 11, 8, 35, 36, 853, DateTimeKind.Unspecified).AddTicks(8701), "Adalmis32@hotmail.com", false, true, "Çatalbaş", "+90-057-357-5-661", "Mühendis", 5 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 49, "Sevda", new DateTime(2023, 3, 13, 15, 31, 28, 198, DateTimeKind.Unspecified).AddTicks(6270), new DateTime(2022, 12, 1, 16, 7, 11, 843, DateTimeKind.Unspecified).AddTicks(5984), "Bilgekagan.Toraman63@hotmail.com", false, false, "Atan", "+90-975-878-47-78", "Tekniker", 19 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 50, "Sevil", new DateTime(2022, 9, 10, 12, 59, 10, 86, DateTimeKind.Unspecified).AddTicks(9420), new DateTime(2022, 9, 11, 4, 25, 23, 344, DateTimeKind.Unspecified).AddTicks(2819), "Bilgekulucur.Tasci70@yahoo.com", false, true, "Tokatlıoğlu", "+90-192-140-1-130", "Tekniker", 26 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 51, "Serin", new DateTime(2023, 4, 8, 22, 13, 44, 911, DateTimeKind.Unspecified).AddTicks(3593), new DateTime(2022, 10, 18, 14, 43, 4, 870, DateTimeKind.Unspecified).AddTicks(8909), "Beglen.Erturk@gmail.com", false, false, "Adal", "+90-409-600-0-811", "Tekniker", 24 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 52, "Rüçhan", new DateTime(2022, 11, 4, 10, 20, 35, 482, DateTimeKind.Unspecified).AddTicks(7212), new DateTime(2023, 5, 24, 4, 45, 4, 324, DateTimeKind.Unspecified).AddTicks(1272), "Balaban_Egeli89@gmail.com", false, false, "Akbulut", "+90-594-939-3-744", "Tekniker", 1 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 53, "Gonca", new DateTime(2023, 5, 29, 13, 50, 37, 810, DateTimeKind.Unspecified).AddTicks(2615), new DateTime(2023, 4, 14, 4, 27, 23, 554, DateTimeKind.Unspecified).AddTicks(1676), "Arpat64@yahoo.com", false, false, "Erbay", "+90-210-956-4-664", "Tesisatçı", 2 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 54, "Zeynep", new DateTime(2023, 1, 12, 23, 25, 22, 664, DateTimeKind.Unspecified).AddTicks(3512), new DateTime(2022, 8, 20, 5, 4, 51, 354, DateTimeKind.Unspecified).AddTicks(561), "Alpurungu.Suleymanoglu90@yahoo.com", false, true, "Özkök ", "+90-480-252-53-16", "Mühendis", 8 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 55, "Yalgın", new DateTime(2023, 7, 14, 6, 29, 13, 641, DateTimeKind.Unspecified).AddTicks(343), new DateTime(2023, 2, 13, 22, 8, 49, 798, DateTimeKind.Unspecified).AddTicks(4376), "Bogu51@hotmail.com", false, true, "Özbey", "+90-189-081-27-69", "Tekniker", 19 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 56, "Fedai", new DateTime(2023, 5, 9, 20, 14, 48, 783, DateTimeKind.Unspecified).AddTicks(6576), new DateTime(2023, 4, 6, 2, 51, 53, 124, DateTimeKind.Unspecified).AddTicks(1287), "Begil.Tunceri61@hotmail.com", false, false, "Özdenak", "+90-208-472-79-30", "Teknisyen", 21 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 57, "Tevhid", new DateTime(2023, 3, 4, 17, 11, 55, 212, DateTimeKind.Unspecified).AddTicks(6741), new DateTime(2023, 3, 16, 0, 36, 2, 842, DateTimeKind.Unspecified).AddTicks(9948), "Alka_Erez@yahoo.com", false, true, "Alnıaçık", "+90-341-215-65-47", "Makina Mühendisi", 20 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 58, "Doğanay", new DateTime(2023, 1, 21, 21, 34, 30, 775, DateTimeKind.Unspecified).AddTicks(4500), new DateTime(2023, 5, 16, 6, 2, 48, 157, DateTimeKind.Unspecified).AddTicks(7372), "Alptunga90@gmail.com", false, false, "Çetiner", "+90-393-396-86-32", "Tesisatçı", 11 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 59, "Kıymet", new DateTime(2023, 3, 13, 5, 52, 8, 232, DateTimeKind.Unspecified).AddTicks(5597), new DateTime(2023, 6, 9, 7, 10, 42, 846, DateTimeKind.Unspecified).AddTicks(8983), "Bumin_Berberoglu@gmail.com", false, false, "Gürmen", "+90-854-004-2-724", "Tekniker", 20 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 60, "Görkem", new DateTime(2022, 8, 23, 14, 8, 50, 571, DateTimeKind.Unspecified).AddTicks(377), new DateTime(2022, 8, 16, 0, 52, 19, 895, DateTimeKind.Unspecified).AddTicks(2257), "Bugduzemen3@yahoo.com", false, false, "Öztuna", "+90-831-047-54-20", "Tesisatçı", 28 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 61, "Merve", new DateTime(2023, 4, 15, 4, 16, 21, 955, DateTimeKind.Unspecified).AddTicks(9268), new DateTime(2022, 9, 22, 9, 34, 56, 499, DateTimeKind.Unspecified).AddTicks(6734), "Bozkurt.Abaci@hotmail.com", false, true, "Kıraç ", "+90-853-292-26-48", "Makina Mühendisi", 19 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 62, "Yüksel", new DateTime(2023, 7, 16, 14, 24, 33, 379, DateTimeKind.Unspecified).AddTicks(7827), new DateTime(2023, 4, 25, 13, 58, 46, 822, DateTimeKind.Unspecified).AddTicks(6503), "Aydin52@hotmail.com", false, false, "Beşok", "+90-015-492-96-47", "Makina Mühendisi", 25 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 63, "Cüneyt", new DateTime(2022, 11, 11, 2, 16, 29, 38, DateTimeKind.Unspecified).AddTicks(1103), new DateTime(2022, 8, 9, 4, 48, 49, 146, DateTimeKind.Unspecified).AddTicks(7575), "Bilgekulucur.Aydan@gmail.com", false, true, "Sadıklar", "+90-076-855-5-465", "Teknisyen", 7 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 64, "Filiz", new DateTime(2023, 6, 12, 2, 29, 56, 378, DateTimeKind.Unspecified).AddTicks(6544), new DateTime(2022, 8, 31, 21, 31, 44, 35, DateTimeKind.Unspecified).AddTicks(3793), "Berke.Eronat@hotmail.com", false, false, "Süleymanoğlu", "+90-680-668-70-93", "Teknisyen", 13 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 65, "Batur", new DateTime(2023, 3, 12, 13, 51, 4, 997, DateTimeKind.Unspecified).AddTicks(5676), new DateTime(2022, 12, 16, 16, 47, 37, 275, DateTimeKind.Unspecified).AddTicks(7152), "Alimga10@yahoo.com", false, true, "Erbulak", "+90-987-408-90-01", "Makina Mühendisi", 16 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 66, "Sâkıp", new DateTime(2023, 2, 25, 9, 52, 34, 284, DateTimeKind.Unspecified).AddTicks(7446), new DateTime(2022, 8, 5, 4, 54, 32, 131, DateTimeKind.Unspecified).AddTicks(7658), "Bogde_Atan26@hotmail.com", false, false, "Özkök ", "+90-922-662-8-136", "Tekniker", 3 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 67, "Resûl", new DateTime(2023, 5, 6, 5, 51, 28, 905, DateTimeKind.Unspecified).AddTicks(5495), new DateTime(2023, 6, 12, 14, 47, 2, 549, DateTimeKind.Unspecified).AddTicks(1817), "Abay_Tekand@yahoo.com", false, false, "Berberoğlu", "+90-666-534-9-922", "Makina Mühendisi", 28 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 68, "Çiler", new DateTime(2023, 2, 23, 22, 2, 23, 708, DateTimeKind.Unspecified).AddTicks(7011), new DateTime(2023, 3, 20, 23, 44, 20, 109, DateTimeKind.Unspecified).AddTicks(1208), "Burslan95@yahoo.com", false, true, "Ilıcalı", "+90-982-204-4-666", "Tekniker", 4 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 69, "Dilay", new DateTime(2023, 5, 28, 1, 30, 25, 45, DateTimeKind.Unspecified).AddTicks(1760), new DateTime(2023, 6, 13, 14, 32, 38, 660, DateTimeKind.Unspecified).AddTicks(1148), "Burgucan_Tokatlioglu@hotmail.com", false, true, "Tanrıkulu", "+90-037-217-6-628", "Teknisyen", 30 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 70, "Alişir", new DateTime(2023, 4, 5, 21, 12, 20, 151, DateTimeKind.Unspecified).AddTicks(191), new DateTime(2023, 6, 8, 16, 35, 2, 600, DateTimeKind.Unspecified).AddTicks(111), "Agakagan20@yahoo.com", false, false, "Kahveci", "+90-880-103-1-622", "Tekniker", 21 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 71, "Güneş", new DateTime(2023, 3, 10, 21, 2, 55, 601, DateTimeKind.Unspecified).AddTicks(7901), new DateTime(2022, 11, 22, 12, 34, 24, 250, DateTimeKind.Unspecified).AddTicks(600), "Artiinal_Turkdogan43@yahoo.com", false, true, "Yetkiner", "+90-644-166-48-10", "Tekniker", 8 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 72, "Neşet", new DateTime(2023, 6, 29, 5, 38, 17, 580, DateTimeKind.Unspecified).AddTicks(5352), new DateTime(2023, 2, 21, 23, 47, 5, 4, DateTimeKind.Unspecified).AddTicks(7684), "Babur.Sepetci@yahoo.com", false, true, "Limoncuoğlu", "+90-784-082-4-972", "Makina Mühendisi", 17 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 73, "Tahir", new DateTime(2022, 8, 15, 8, 29, 9, 12, DateTimeKind.Unspecified).AddTicks(1123), new DateTime(2022, 12, 11, 17, 56, 40, 969, DateTimeKind.Unspecified).AddTicks(5700), "Bure60@yahoo.com", false, false, "Tunaboylu", "+90-022-821-8-565", "Mühendis", 18 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 74, "Gizem", new DateTime(2023, 5, 20, 18, 0, 9, 198, DateTimeKind.Unspecified).AddTicks(1338), new DateTime(2023, 3, 20, 9, 58, 45, 369, DateTimeKind.Unspecified).AddTicks(1736), "Gun_Erturk47@hotmail.com", false, false, "Tuğluk", "+90-587-772-98-68", "Teknisyen", 15 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 75, "Nihan", new DateTime(2023, 6, 22, 17, 4, 52, 430, DateTimeKind.Unspecified).AddTicks(5350), new DateTime(2023, 1, 17, 18, 35, 20, 881, DateTimeKind.Unspecified).AddTicks(9539), "Bolsun53@yahoo.com", false, true, "Durmaz", "+90-738-914-23-19", "Teknisyen", 26 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 76, "Ferruh", new DateTime(2023, 2, 10, 6, 16, 34, 437, DateTimeKind.Unspecified).AddTicks(3693), new DateTime(2022, 12, 20, 14, 48, 8, 838, DateTimeKind.Unspecified).AddTicks(1009), "Begi76@hotmail.com", false, false, "Önür", "+90-036-464-3-316", "Teknisyen", 27 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 77, "Gökçe", new DateTime(2022, 10, 4, 7, 49, 38, 324, DateTimeKind.Unspecified).AddTicks(7351), new DateTime(2022, 10, 3, 12, 46, 42, 32, DateTimeKind.Unspecified).AddTicks(4576), "Dizik.Eronat@gmail.com", false, true, "Tunçeri", "+90-476-962-60-23", "Tesisatçı", 30 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 78, "Hazar", new DateTime(2023, 5, 2, 13, 23, 55, 28, DateTimeKind.Unspecified).AddTicks(1474), new DateTime(2023, 6, 15, 8, 57, 56, 868, DateTimeKind.Unspecified).AddTicks(90), "Balaban.Adan@gmail.com", false, false, "Sandalcı", "+90-221-408-51-66", "Teknisyen", 1 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 79, "İzzet", new DateTime(2023, 7, 7, 13, 19, 40, 637, DateTimeKind.Unspecified).AddTicks(5900), new DateTime(2023, 4, 24, 16, 10, 43, 411, DateTimeKind.Unspecified).AddTicks(5472), "Balkik50@yahoo.com", false, true, "Yetkiner", "+90-623-025-6-197", "Makina Mühendisi", 20 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 80, "Şefik", new DateTime(2022, 9, 7, 12, 23, 10, 759, DateTimeKind.Unspecified).AddTicks(7131), new DateTime(2023, 2, 22, 19, 45, 55, 135, DateTimeKind.Unspecified).AddTicks(9005), "Ant_Demirbas41@hotmail.com", false, false, "Önür", "+90-469-319-68-51", "Mühendis", 4 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 81, "Barış", new DateTime(2023, 2, 16, 18, 6, 25, 555, DateTimeKind.Unspecified).AddTicks(3548), new DateTime(2023, 1, 6, 10, 41, 5, 424, DateTimeKind.Unspecified).AddTicks(9378), "Guvercin56@gmail.com", false, false, "Çapanoğlu", "+90-878-452-6-964", "Tesisatçı", 9 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 82, "Kısmet", new DateTime(2023, 3, 16, 4, 3, 54, 282, DateTimeKind.Unspecified).AddTicks(8769), new DateTime(2022, 11, 10, 3, 19, 57, 382, DateTimeKind.Unspecified).AddTicks(3978), "Kaynak8@yahoo.com", false, false, "Akyürek", "+90-841-812-07-54", "Makina Mühendisi", 27 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 83, "Rıfkı", new DateTime(2022, 11, 26, 4, 21, 51, 729, DateTimeKind.Unspecified).AddTicks(3004), new DateTime(2023, 4, 18, 9, 38, 31, 491, DateTimeKind.Unspecified).AddTicks(8741), "Arslan_Evliyaoglu17@gmail.com", false, true, "Öztuna", "+90-521-712-0-053", "Makina Mühendisi", 6 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 84, "Gökalp", new DateTime(2023, 2, 13, 23, 5, 28, 563, DateTimeKind.Unspecified).AddTicks(815), new DateTime(2022, 8, 17, 5, 45, 52, 220, DateTimeKind.Unspecified).AddTicks(2716), "Imrem25@hotmail.com", false, true, "Akbulut", "+90-888-062-38-82", "Makina Mühendisi", 23 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 85, "Barkın", new DateTime(2022, 10, 3, 14, 52, 24, 94, DateTimeKind.Unspecified).AddTicks(9462), new DateTime(2023, 3, 12, 6, 44, 21, 138, DateTimeKind.Unspecified).AddTicks(105), "Baccayman75@yahoo.com", false, true, "Akyürek", "+90-855-049-00-80", "Makina Mühendisi", 21 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 86, "Zülal", new DateTime(2022, 12, 19, 7, 31, 41, 225, DateTimeKind.Unspecified).AddTicks(159), new DateTime(2023, 4, 9, 14, 4, 59, 46, DateTimeKind.Unspecified).AddTicks(9334), "Burluk9@yahoo.com", false, true, "Aykaç", "+90-290-141-01-36", "Tesisatçı", 6 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 87, "Caner", new DateTime(2023, 5, 10, 18, 15, 59, 145, DateTimeKind.Unspecified).AddTicks(9286), new DateTime(2022, 11, 17, 6, 59, 39, 858, DateTimeKind.Unspecified).AddTicks(845), "Alpyoruk_Balaban@yahoo.com", false, false, "Akan", "+90-682-721-83-28", "Tesisatçı", 19 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 88, "Şükrü", new DateTime(2023, 6, 4, 11, 6, 57, 827, DateTimeKind.Unspecified).AddTicks(8890), new DateTime(2022, 8, 27, 3, 4, 56, 488, DateTimeKind.Unspecified).AddTicks(5546), "Gokboru84@gmail.com", false, true, "Gümüşpala", "+90-265-560-1-613", "Teknisyen", 24 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 89, "Fuzuli", new DateTime(2023, 2, 27, 16, 45, 16, 821, DateTimeKind.Unspecified).AddTicks(1079), new DateTime(2023, 2, 25, 18, 29, 40, 125, DateTimeKind.Unspecified).AddTicks(7073), "Bora_Kocyigit13@yahoo.com", false, true, "Atan", "+90-204-044-0-756", "Teknisyen", 18 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 90, "Özkan", new DateTime(2023, 7, 21, 12, 14, 35, 468, DateTimeKind.Unspecified).AddTicks(608), new DateTime(2022, 10, 7, 16, 38, 57, 942, DateTimeKind.Unspecified).AddTicks(1961), "Kazanc91@yahoo.com", false, false, "Alpuğan", "+90-699-786-1-785", "Mühendis", 13 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 91, "Şahinalp", new DateTime(2023, 6, 30, 8, 16, 28, 156, DateTimeKind.Unspecified).AddTicks(1696), new DateTime(2023, 7, 23, 0, 5, 53, 628, DateTimeKind.Unspecified).AddTicks(9983), "Alpsalci.Erez18@yahoo.com", false, true, "Çevik", "+90-058-387-8-241", "Teknisyen", 13 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 92, "Aykan", new DateTime(2023, 3, 16, 16, 26, 54, 915, DateTimeKind.Unspecified).AddTicks(8458), new DateTime(2023, 3, 20, 9, 5, 29, 942, DateTimeKind.Unspecified).AddTicks(3435), "Bargan79@hotmail.com", false, true, "Tokatlıoğlu", "+90-845-104-1-721", "Tesisatçı", 14 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 93, "Sertap", new DateTime(2023, 6, 12, 5, 7, 18, 706, DateTimeKind.Unspecified).AddTicks(3354), new DateTime(2022, 12, 13, 15, 45, 31, 883, DateTimeKind.Unspecified).AddTicks(7646), "Baga.Topcuoglu53@yahoo.com", false, true, "Kumcuoğlu", "+90-901-010-1-260", "Teknisyen", 21 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 94, "Selahattin", new DateTime(2023, 6, 18, 0, 16, 54, 401, DateTimeKind.Unspecified).AddTicks(197), new DateTime(2023, 3, 31, 7, 53, 56, 191, DateTimeKind.Unspecified).AddTicks(9215), "Ilbilge82@hotmail.com", false, true, "Ayaydın", "+90-544-994-9-822", "Tekniker", 23 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 95, "Turan", new DateTime(2023, 3, 3, 5, 27, 51, 766, DateTimeKind.Unspecified).AddTicks(1401), new DateTime(2023, 3, 4, 2, 26, 23, 252, DateTimeKind.Unspecified).AddTicks(4090), "Beklemis_Orbay@hotmail.com", false, true, "Dağlaroğlu", "+90-831-915-80-38", "Tekniker", 28 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 96, "Hale", new DateTime(2023, 1, 24, 2, 18, 11, 457, DateTimeKind.Unspecified).AddTicks(3949), new DateTime(2023, 1, 29, 4, 19, 19, 996, DateTimeKind.Unspecified).AddTicks(2369), "Berkis49@hotmail.com", false, false, "Biçer", "+90-818-004-3-811", "Tekniker", 1 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 97, "Bekir", new DateTime(2023, 3, 9, 17, 35, 19, 321, DateTimeKind.Unspecified).AddTicks(2946), new DateTime(2023, 2, 5, 20, 6, 45, 336, DateTimeKind.Unspecified).AddTicks(1843), "Alpaykagan_Ozbey@yahoo.com", false, false, "Erkekli", "+90-906-284-42-80", "Teknisyen", 24 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 98, "Adnân", new DateTime(2023, 3, 14, 12, 37, 41, 619, DateTimeKind.Unspecified).AddTicks(3155), new DateTime(2023, 1, 14, 4, 6, 21, 462, DateTimeKind.Unspecified).AddTicks(1711), "Iyiktag.Nalbantoglu70@gmail.com", false, true, "Balcı", "+90-968-076-65-93", "Teknisyen", 15 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 99, "Melek", new DateTime(2022, 10, 1, 0, 34, 34, 207, DateTimeKind.Unspecified).AddTicks(8434), new DateTime(2022, 10, 30, 12, 49, 50, 629, DateTimeKind.Unspecified).AddTicks(8902), "Ebin.Babacan53@hotmail.com", false, false, "Eronat", "+90-902-493-47-00", "Tekniker", 1 });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Adi", "CreationTime", "DeletionTime", "Eposta", "IsDeleted", "IsFirmaYetkilisi", "Soyadi", "TelefonNumarisi", "Unvani", "fk_firma" },
                values: new object[] { 100, "Zihnî", new DateTime(2022, 9, 18, 15, 36, 1, 354, DateTimeKind.Unspecified).AddTicks(4588), new DateTime(2022, 9, 18, 21, 5, 35, 97, DateTimeKind.Unspecified).AddTicks(9741), "Baraktore.Kurutluoglu@yahoo.com", false, false, "Ertepınar", "+90-950-816-9-924", "Makina Mühendisi", 18 });

            migrationBuilder.CreateIndex(
                name: "IX_Personel_fk_firma",
                table: "Personel",
                column: "fk_firma");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "Firmalar");
        }
    }
}
