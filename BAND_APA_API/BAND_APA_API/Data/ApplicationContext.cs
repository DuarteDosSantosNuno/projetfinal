using Microsoft.EntityFrameworkCore;
using BAND_APA_API.Entities;

namespace BAND_APA_API.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Animals_Identity> Animals_Identitys { get; set; }
        public DbSet<Asso_Compte> Asso_Comptes { get; set; }
        public DbSet<Client_Compte> Client_Comptes { get; set; }
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

            modelBuilder.Entity<Animals_Identity>().Property(p => p.a_i_ID).HasDefaultValueSql("NEXT VALUE FOR Animals_Identity_id_seq");
            modelBuilder.Entity<Asso_Compte>().Property(p => p.user_ID).HasDefaultValueSql("NEXT VALUE FOR Asso_Compte_id_seq");
            modelBuilder.Entity<Client_Compte>().Property(p => p.client_ID).HasDefaultValueSql("NEXT VALUE FOR Client_Compte_id_seq");
            modelBuilder.Entity<Demand>().Property(p => p.demand_ID).HasDefaultValueSql("NEXT VALUE FOR Demand_id_seq");
            modelBuilder.Entity<Demand>().HasKey(bc => new { bc.Animals_IdentityID, bc.Asso_CompteID, bc.Client_CompteID });
        }
    }
}
