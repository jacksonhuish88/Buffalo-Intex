using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Buffalo_Intex
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

        //public virtual DbSet<Analysis> Analysis { get; set; }
        //public virtual DbSet<AnalysisTextile> AnalysisTextile { get; set; }
        //public virtual DbSet<Artifactfagelgamousregister> Artifactfagelgamousregister { get; set; }
        //public virtual DbSet<ArtifactfagelgamousregisterBurialmain> ArtifactfagelgamousregisterBurialmain { get; set; }
        //public virtual DbSet<Artifactkomaushimregister> Artifactkomaushimregister { get; set; }
        //public virtual DbSet<ArtifactkomaushimregisterBurialmain> ArtifactkomaushimregisterBurialmain { get; set; }
        //public virtual DbSet<Biological> Biological { get; set; }
        //public virtual DbSet<BiologicalC14> BiologicalC14 { get; set; }
        //public virtual DbSet<Bodyanalysischart> Bodyanalysischart { get; set; }
        //public virtual DbSet<Books> Books { get; set; }
        public DbSet<Burialmain> Burialmain { get; set; }
        public IQueryable<Textile> Textile { get; internal set; }

        //public virtual DbSet<BurialmainBiological> BurialmainBiological { get; set; }
        //public virtual DbSet<BurialmainBodyanalysischart> BurialmainBodyanalysischart { get; set; }
        //public virtual DbSet<BurialmainCranium> BurialmainCranium { get; set; }
        ////public virtual DbSet<BurialmainTextile> BurialmainTextile { get; set; }
        //public virtual DbSet<C14> C14 { get; set; }
        //public virtual DbSet<Color> Color { get; set; }
        //public virtual DbSet<ColorTextile> ColorTextile { get; set; }
        //public virtual DbSet<Cranium> Cranium { get; set; }
        //public virtual DbSet<Decoration> Decoration { get; set; }
        //public virtual DbSet<DecorationTextile> DecorationTextile { get; set; }
        //public virtual DbSet<Dimension> Dimension { get; set; }
        //public virtual DbSet<DimensionTextile> DimensionTextile { get; set; }
        //public virtual DbSet<Newsarticle> Newsarticle { get; set; }
        //public virtual DbSet<Photodata> Photodata { get; set; }
        //public virtual DbSet<PhotodataTextile> PhotodataTextile { get; set; }
        //public virtual DbSet<Photoform> Photoform { get; set; }
        //public virtual DbSet<Structure> Structure { get; set; }
        //public virtual DbSet<StructureTextile> StructureTextile { get; set; }
        //public virtual DbSet<Teammember> Teammember { get; set; }
        //public virtual DbSet<Textile> Textile { get; set; }
        //public virtual DbSet<Textilefunction> Textilefunction { get; set; }
        //public virtual DbSet<TextilefunctionTextile> TextilefunctionTextile { get; set; }
        //public virtual DbSet<Yarnmanipulation> Yarnmanipulation { get; set; }
        //public virtual DbSet<YarnmanipulationTextile> YarnmanipulationTextile { get; set; }
    }
}
