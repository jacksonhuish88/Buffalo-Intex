using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace Buffalo_Intex.Models
{
    public class MummyDbContext : IdentityDbContext<IdentityUser>
    {
        public MummyDbContext(DbContextOptions<MummyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(l => new { l.LoginProvider, l.ProviderKey });
        }


        public DbSet<Analysis> Analysis { get; set; }
        public DbSet<AnalysisTextile> AnalysisTextile { get; set; }
        public DbSet<Artifactfagelgamousregister> Artifactfagelgamousregister { get; set; }
        public DbSet<ArtifactfagelgamousregisterBurialmain> ArtifactfagelgamousregisterBurialmain { get; set; }
        public DbSet<Artifactkomaushimregister> Artifactkomaushimregister { get; set; }
        public DbSet<ArtifactkomaushimregisterBurialmain> ArtifactkomaushimregisterBurialmain { get; set; }
        public DbSet<Biological> Biological { get; set; }
        public DbSet<BiologicalC14> BiologicalC14 { get; set; }
        public DbSet<Bodyanalysischart> Bodyanalysischart { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Burialmain> Burialmain { get; set; }
        public DbSet<BurialmainBiological> BurialmainBiological { get; set; }
        public DbSet<BurialmainBodyanalysischart> BurialmainBodyanalysischart { get; set; }
        public DbSet<BurialmainCranium> BurialmainCranium { get; set; }
        public DbSet<BurialmainTextile> BurialmainTextile { get; set; }
        public DbSet<C14> C14 { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<ColorTextile> ColorTextile { get; set; }
        public DbSet<Cranium> Cranium { get; set; }
        public DbSet<Decoration> Decoration { get; set; }
        public DbSet<DecorationTextile> DecorationTextile { get; set; }
        public DbSet<Dimension> Dimension { get; set; }
        public DbSet<DimensionTextile> DimensionTextile { get; set; }
        public DbSet<Newsarticle> Newsarticle { get; set; }
        public DbSet<Photodata> Photodata { get; set; }
        public DbSet<PhotodataTextile> PhotodataTextile { get; set; }
        public DbSet<Photoform> Photoform { get; set; }
        public DbSet<Structure> Structure { get; set; }
        public DbSet<StructureTextile> StructureTextile { get; set; }
        public DbSet<Teammember> Teammember { get; set; }
        public DbSet<Textile> Textile { get; set; }
        public DbSet<Textilefunction> Textilefunction { get; set; }
        public DbSet<TextilefunctionTextile> TextilefunctionTextile { get; set; }
        public DbSet<Yarnmanipulation> Yarnmanipulation { get; set; }
        public DbSet<YarnmanipulationTextile> YarnmanipulationTextile { get; set; }

    }

}
