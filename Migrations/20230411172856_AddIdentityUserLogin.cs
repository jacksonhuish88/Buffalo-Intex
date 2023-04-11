using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Buffalo_Intex.Migrations
{
    public partial class AddIdentityUserLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Analysis",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Analysistype = table.Column<int>(nullable: true),
                    Doneby = table.Column<string>(nullable: true),
                    Analysisid = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analysis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisTextile",
                columns: table => new
                {
                    MainAnalysisid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainTextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisTextile", x => x.MainAnalysisid);
                });

            migrationBuilder.CreateTable(
                name: "Artifactfagelgamousregister",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Registernum = table.Column<string>(nullable: true),
                    Photographed = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Coordinateset = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artifactfagelgamousregister", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArtifactfagelgamousregisterBurialmain",
                columns: table => new
                {
                    MainArtifactfagelgamousregisterid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainBurialmainid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtifactfagelgamousregisterBurialmain", x => x.MainArtifactfagelgamousregisterid);
                });

            migrationBuilder.CreateTable(
                name: "Artifactkomaushimregister",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Provenance = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Qualityphotos = table.Column<string>(nullable: true),
                    Finder = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Rehousedto = table.Column<string>(nullable: true),
                    Photos = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    Entrydate = table.Column<DateTime>(nullable: true),
                    Currentlocation = table.Column<string>(nullable: true),
                    Excavatornum = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artifactkomaushimregister", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArtifactkomaushimregisterBurialmain",
                columns: table => new
                {
                    MainArtifactkomaushimregisterid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainBurialmainid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtifactkomaushimregisterBurialmain", x => x.MainArtifactkomaushimregisterid);
                });

            migrationBuilder.CreateTable(
                name: "Biological",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Racknumber = table.Column<int>(nullable: true),
                    Bagnumber = table.Column<int>(nullable: true),
                    Previouslysampled = table.Column<string>(nullable: true),
                    Initials = table.Column<string>(nullable: true),
                    Clusternumber = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biological", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BiologicalC14",
                columns: table => new
                {
                    MainBiologicalid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainC14id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiologicalC14", x => x.MainBiologicalid);
                });

            migrationBuilder.CreateTable(
                name: "Bodyanalysischart",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Femur = table.Column<string>(nullable: true),
                    Humerusheaddiameter = table.Column<string>(nullable: true),
                    Squamossuture = table.Column<string>(nullable: true),
                    CariesPeriodontalDisease = table.Column<string>(nullable: true),
                    MedicalIpRamus = table.Column<string>(nullable: true),
                    Perservationindex = table.Column<int>(nullable: true),
                    Gonion = table.Column<string>(nullable: true),
                    Humeruslength = table.Column<int>(nullable: true),
                    Femurlength = table.Column<int>(nullable: true),
                    Lambdoidsuture = table.Column<string>(nullable: true),
                    Ventralarc = table.Column<bool>(nullable: true),
                    Tootheruptionageestimation = table.Column<int>(nullable: true),
                    Nuchalcrest = table.Column<string>(nullable: true),
                    Estimatestature = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Osteophytosis = table.Column<string>(nullable: true),
                    Subpubicangle = table.Column<string>(nullable: true),
                    Robust = table.Column<bool>(nullable: true),
                    Femurheaddiameter = table.Column<string>(nullable: true),
                    Sciaticnotch = table.Column<string>(nullable: true),
                    Supraorbitalridges = table.Column<string>(nullable: true),
                    Orbitedge = table.Column<string>(nullable: true),
                    Toothattrition = table.Column<int>(nullable: true),
                    Sphenooccipitalsynchondrosis = table.Column<string>(nullable: true),
                    Parietalblossing = table.Column<bool>(nullable: true),
                    Observations = table.Column<string>(nullable: true),
                    Humerus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodyanalysischart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Burialmain",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Squarenorthsouth = table.Column<string>(nullable: true),
                    Headdirection = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    Northsouth = table.Column<string>(nullable: true),
                    Depth = table.Column<string>(nullable: true),
                    Eastwest = table.Column<string>(nullable: true),
                    Adultsubadult = table.Column<string>(nullable: true),
                    Facebundles = table.Column<string>(nullable: true),
                    Southtohead = table.Column<string>(nullable: true),
                    Preservation = table.Column<string>(nullable: true),
                    Fieldbookpage = table.Column<string>(nullable: true),
                    Squareeastwest = table.Column<string>(nullable: true),
                    Goods = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Wrapping = table.Column<string>(nullable: true),
                    Haircolor = table.Column<string>(nullable: true),
                    Westtohead = table.Column<string>(nullable: true),
                    Samplescollected = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Burialid = table.Column<long>(nullable: true),
                    Length = table.Column<string>(nullable: true),
                    Burialnumber = table.Column<string>(nullable: true),
                    Dataexpertinitials = table.Column<string>(nullable: true),
                    Westtofeet = table.Column<string>(nullable: true),
                    Ageatdeath = table.Column<string>(nullable: true),
                    Southtofeet = table.Column<string>(nullable: true),
                    Excavationrecorder = table.Column<string>(nullable: true),
                    Photos = table.Column<string>(nullable: true),
                    Hair = table.Column<string>(nullable: true),
                    Burialmaterials = table.Column<string>(nullable: true),
                    Dateofexcavation = table.Column<DateTime>(nullable: true),
                    Fieldbookexcavationyear = table.Column<string>(nullable: true),
                    Clusternumber = table.Column<string>(nullable: true),
                    Shaftnumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burialmain", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BurialmainBiological",
                columns: table => new
                {
                    MainBurialmainid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainBiologicalid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurialmainBiological", x => x.MainBurialmainid);
                });

            migrationBuilder.CreateTable(
                name: "BurialmainBodyanalysischart",
                columns: table => new
                {
                    MainBurialmainid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainBodyanalysischartid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurialmainBodyanalysischart", x => x.MainBurialmainid);
                });

            migrationBuilder.CreateTable(
                name: "BurialmainCranium",
                columns: table => new
                {
                    MainBurialmainid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainCraniumid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurialmainCranium", x => x.MainBurialmainid);
                });

            migrationBuilder.CreateTable(
                name: "BurialmainTextile",
                columns: table => new
                {
                    MainBurialmainid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainTextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurialmainTextile", x => x.MainBurialmainid);
                });

            migrationBuilder.CreateTable(
                name: "C14",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: true),
                    Agebp = table.Column<int>(nullable: true),
                    Calibratedspan = table.Column<int>(nullable: true),
                    Tubenumber = table.Column<int>(nullable: true),
                    Calibrateddatemin = table.Column<int>(nullable: true),
                    Calibrateddateavg = table.Column<int>(nullable: true),
                    Foci = table.Column<string>(nullable: true),
                    Rack = table.Column<int>(nullable: true),
                    Calendardate = table.Column<int>(nullable: true),
                    Calibrateddatemax = table.Column<int>(nullable: true),
                    C14lab = table.Column<string>(nullable: true),
                    Questions = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C14", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(nullable: true),
                    Colorid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorTextile",
                columns: table => new
                {
                    MainColorid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainTextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorTextile", x => x.MainColorid);
                });

            migrationBuilder.CreateTable(
                name: "Cranium",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InterobitalBreadth = table.Column<decimal>(nullable: true),
                    MaxNasalBreadth = table.Column<decimal>(nullable: true),
                    BasionNasion = table.Column<decimal>(nullable: true),
                    InterorbitalBreadth = table.Column<decimal>(nullable: true),
                    NasionProsthionUpper = table.Column<decimal>(nullable: true),
                    NasoAlphaSubtense = table.Column<decimal>(nullable: true),
                    BasionBregmaHeight = table.Column<decimal>(nullable: true),
                    Maxcraniumlength = table.Column<decimal>(nullable: true),
                    InterorbitalSubtense = table.Column<decimal>(nullable: true),
                    BasionProsthionLength = table.Column<decimal>(nullable: true),
                    AlphaCore = table.Column<decimal>(nullable: true),
                    MidOrbitalSubtense = table.Column<decimal>(nullable: true),
                    Maxcraniumbreadth = table.Column<decimal>(nullable: true),
                    BizygomaticDiameter = table.Column<decimal>(nullable: true),
                    MidOrbitalBreadth = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cranium", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decoration",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Decorationid = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decoration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DecorationTextile",
                columns: table => new
                {
                    MainDecorationid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainTextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecorationTextile", x => x.MainDecorationid);
                });

            migrationBuilder.CreateTable(
                name: "Dimension",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Dimensiontype = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Dimensionid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DimensionTextile",
                columns: table => new
                {
                    MainDimensionid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainTextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionTextile", x => x.MainDimensionid);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserLogin<string>",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserLogin<string>", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "Newsarticle",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Urltoimage = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsarticle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photodata",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(nullable: true),
                    Filename = table.Column<string>(nullable: true),
                    Photodataid = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photodata", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhotodataTextile",
                columns: table => new
                {
                    MainPhotodataid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainTextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotodataTextile", x => x.MainPhotodataid);
                });

            migrationBuilder.CreateTable(
                name: "Photoform",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Area = table.Column<string>(nullable: true),
                    Squarenorthsouth = table.Column<string>(nullable: true),
                    Tableassociation = table.Column<string>(nullable: true),
                    Filename = table.Column<string>(nullable: true),
                    Photographer = table.Column<string>(nullable: true),
                    Burialnumber = table.Column<string>(nullable: true),
                    Squareeastwest = table.Column<string>(nullable: true),
                    Eastwest = table.Column<string>(nullable: true),
                    Northsouth = table.Column<string>(nullable: true),
                    Photodate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photoform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Structure",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(nullable: true),
                    Structureid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Structure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StructureTextile",
                columns: table => new
                {
                    MainStructureid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainTextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructureTextile", x => x.MainStructureid);
                });

            migrationBuilder.CreateTable(
                name: "Teammember",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Bio = table.Column<string>(nullable: true),
                    Membername = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teammember", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Textile",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Locale = table.Column<string>(nullable: true),
                    Textileid = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Burialnumber = table.Column<string>(nullable: true),
                    Estimatedperiod = table.Column<string>(nullable: true),
                    Sampledate = table.Column<DateTime>(nullable: true),
                    Photographeddate = table.Column<DateTime>(nullable: true),
                    Direction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Textile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Textilefunction",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(nullable: true),
                    Textilefunctionid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Textilefunction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TextilefunctionTextile",
                columns: table => new
                {
                    MainTextilefunctionid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainTextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextilefunctionTextile", x => x.MainTextilefunctionid);
                });

            migrationBuilder.CreateTable(
                name: "Yarnmanipulation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Thickness = table.Column<string>(nullable: true),
                    Angle = table.Column<string>(nullable: true),
                    Manipulation = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Count = table.Column<string>(nullable: true),
                    Component = table.Column<string>(nullable: true),
                    Ply = table.Column<string>(nullable: true),
                    Yarnmanipulationid = table.Column<int>(nullable: true),
                    Direction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yarnmanipulation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YarnmanipulationTextile",
                columns: table => new
                {
                    MainYarnmanipulationid = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainTextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YarnmanipulationTextile", x => x.MainYarnmanipulationid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Analysis");

            migrationBuilder.DropTable(
                name: "AnalysisTextile");

            migrationBuilder.DropTable(
                name: "Artifactfagelgamousregister");

            migrationBuilder.DropTable(
                name: "ArtifactfagelgamousregisterBurialmain");

            migrationBuilder.DropTable(
                name: "Artifactkomaushimregister");

            migrationBuilder.DropTable(
                name: "ArtifactkomaushimregisterBurialmain");

            migrationBuilder.DropTable(
                name: "Biological");

            migrationBuilder.DropTable(
                name: "BiologicalC14");

            migrationBuilder.DropTable(
                name: "Bodyanalysischart");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Burialmain");

            migrationBuilder.DropTable(
                name: "BurialmainBiological");

            migrationBuilder.DropTable(
                name: "BurialmainBodyanalysischart");

            migrationBuilder.DropTable(
                name: "BurialmainCranium");

            migrationBuilder.DropTable(
                name: "BurialmainTextile");

            migrationBuilder.DropTable(
                name: "C14");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "ColorTextile");

            migrationBuilder.DropTable(
                name: "Cranium");

            migrationBuilder.DropTable(
                name: "Decoration");

            migrationBuilder.DropTable(
                name: "DecorationTextile");

            migrationBuilder.DropTable(
                name: "Dimension");

            migrationBuilder.DropTable(
                name: "DimensionTextile");

            migrationBuilder.DropTable(
                name: "IdentityUserLogin<string>");

            migrationBuilder.DropTable(
                name: "Newsarticle");

            migrationBuilder.DropTable(
                name: "Photodata");

            migrationBuilder.DropTable(
                name: "PhotodataTextile");

            migrationBuilder.DropTable(
                name: "Photoform");

            migrationBuilder.DropTable(
                name: "Structure");

            migrationBuilder.DropTable(
                name: "StructureTextile");

            migrationBuilder.DropTable(
                name: "Teammember");

            migrationBuilder.DropTable(
                name: "Textile");

            migrationBuilder.DropTable(
                name: "Textilefunction");

            migrationBuilder.DropTable(
                name: "TextilefunctionTextile");

            migrationBuilder.DropTable(
                name: "Yarnmanipulation");

            migrationBuilder.DropTable(
                name: "YarnmanipulationTextile");
        }
    }
}
