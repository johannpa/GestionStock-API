using GestionStock.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Infrastructure
{
    public class GestionStockContext: DbContext
    {
        public DbSet<Client> Clients { get; }
        public DbSet<Commande> Commandes { get; }
        public DbSet<Produit> Produits { get; }
        public DbSet<LignesCommande> LignesCommandes { get; }

        public GestionStockContext(DbContextOptions<GestionStockContext> context): base(context)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder build)
        {

        }
    }
}
