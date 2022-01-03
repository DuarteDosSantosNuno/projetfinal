using Microsoft.EntityFrameworkCore;
using band_apa_api.Entities;

namespace band_apa_api.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<AnimalsIdentity> AnimalsIdentities { get; set; }
        public DbSet<AssoCompte> AssoComptes { get; set; }
        public DbSet<ClientCompte> ClientComptes { get; set; }
        public DbSet<Demand> Demands { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("Animals_Identity_id_seq").StartsAt(1).IncrementsBy(1);
            modelBuilder.HasSequence<int>("Asso_Compte_id_seq").StartsAt(1).IncrementsBy(1);
            modelBuilder.HasSequence<int>("Client_Compte_id_seq").StartsAt(1).IncrementsBy(1);
            modelBuilder.HasSequence<int>("Demand_id_seq").StartsAt(1).IncrementsBy(1);

            modelBuilder.Entity<AnimalsIdentity>().Property(p => p.aiID).HasDefaultValueSql("NEXT VALUE FOR Animals_Identity_id_seq");
            modelBuilder.Entity<AssoCompte>().Property(p => p.userID).HasDefaultValueSql("NEXT VALUE FOR Asso_Compte_id_seq");
            modelBuilder.Entity<ClientCompte>().Property(p => p.clientID).HasDefaultValueSql("NEXT VALUE FOR Client_Compte_id_seq");
            modelBuilder.Entity<Demand>().Property(p => p.demandID).HasDefaultValueSql("NEXT VALUE FOR Demand_id_seq");
        }
    }
}
