﻿using System.Linq;
using Buffalo_Intex;
using Buffalo_Intex.Models;

namespace Buffalo_Intex.Data.Repositories
{
    public interface IMummyRepository
    {
        //IQueryable<Analysis> Analysis { get; }
        //IQueryable<AnalysisTextile> AnalysisTextiles { get; }
        //IQueryable<Artifactfagelgamousregister> Artifactfagelgamousregisters { get; }
        //IQueryable<ArtifactfagelgamousregisterBurialmain> ArtifactfagelgamousregisterBurialmains { get; }
        //IQueryable<Artifactkomaushimregister> Artifactkomaushimregisters { get; }
        //IQueryable<ArtifactkomaushimregisterBurialmain> ArtifactkomaushimregisterBurialmains { get; }
        //IQueryable<Biological> Biologicals { get; }
        //IQueryable<BiologicalC14> BiologicalC14s { get; }
        //IQueryable<Bodyanalysischart> Bodyanalysischarts { get; }
        //IQueryable<Books> Books { get; }
        IQueryable<Burialmain> Burialmain { get; }

        //IQueryable<BurialmainBiological> BurialmainBiologicals { get; }
        //IQueryable<BurialmainBodyanalysischart> BurialmainBodyanalysischarts { get; }
        //IQueryable<BurialmainCranium> BurialmainCrania { get; }
        //IQueryable<C14> C14s { get; }
        //IQueryable<Color> Colors { get; }
        //IQueryable<ColorTextile> ColorsTextiles { get; }
        //IQueryable<Cranium> Crania { get; }
        //IQueryable<Decoration> Decorations { get; }
        //IQueryable<DecorationTextile> DecorationTextiles { get; }
        //IQueryable<Dimension> Dimensions { get; }
        //IQueryable<DimensionTextile> DimensionTextiles { get; }
        //IQueryable<Newsarticle> Newsarticles { get; }
        //IQueryable<Photodata> Photodatas { get; }
        //IQueryable<PhotodataTextile> PhotodatasTextiles { get; }
        //IQueryable<Photoform> Photoforms { get; }
        //IQueryable<Structure> Structures { get; }
        //IQueryable<StructureTextile> StructuresTextiles { get; }
        //IQueryable<Teammember> Teammembers { get; }
        //IQueryable<Textile> Textiles { get; }
        //IQueryable<Textilefunction> TextilesFunctions { get; }
        //IQueryable<TextilefunctionTextile> TextilesFunctionsTextiles { get; }
        //IQueryable<Yarnmanipulation> Yarnmanipulation { get; }
        //IQueryable<YarnmanipulationTextile> YarnmanipulationTextiles { get; }
    }
}
