using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TechEvent.Domain.Entities
{
    public partial class TechEventContext : DbContext
    {
        public TechEventContext()
        {
        }

        public TechEventContext(DbContextOptions<TechEventContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Edition> Editions { get; set; }
        public virtual DbSet<Paper> Papers { get; set; }
        public virtual DbSet<PaperStatus> PaperStatuses { get; set; }
        public virtual DbSet<Speaker> Speakers { get; set; }
        public virtual DbSet<Sponsor> Sponsors { get; set; }
        public virtual DbSet<SponsorType> SponsorTypes { get; set; }
        public virtual DbSet<Talk> Talks { get; set; }
        public virtual DbSet<TalkType> TalkTypes { get; set; }
        public virtual DbSet<Workshop> Workshops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:dbsrv-siit.database.windows.net,1433;Initial Catalog=conference;Persist Security Info=False;User ID=net4;Password=conf@si1t!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Sponsor>(entity =>
            {
                entity.HasOne(d => d.SponsorType)
                    .WithMany(p => p.InverseSponsorType)
                    .HasForeignKey(d => d.SponsorTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sponsors_Sponsors");
            });
        }
    }
}
