//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AP4_BAR
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class riledhouEntities : DbContext
    {
        public riledhouEntities()
            : base("name=riledhouEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AEMPORTER> AEMPORTER { get; set; }
        public virtual DbSet<ALLERGENE> ALLERGENE { get; set; }
        public virtual DbSet<BARMAN> BARMAN { get; set; }
        public virtual DbSet<BARS> BARS { get; set; }
        public virtual DbSet<BOISSON> BOISSON { get; set; }
        public virtual DbSet<CLIENTS> CLIENTS { get; set; }
        public virtual DbSet<COMMANDE> COMMANDE { get; set; }
        public virtual DbSet<COMPOSER> COMPOSER { get; set; }
        public virtual DbSet<NOURRITURE> NOURRITURE { get; set; }
        public virtual DbSet<PRODUIT> PRODUIT { get; set; }
        public virtual DbSet<STOCKER> STOCKER { get; set; }
        public virtual DbSet<SURPLACE> SURPLACE { get; set; }
        public virtual DbSet<TYPEBAR> TYPEBAR { get; set; }
    }
}
