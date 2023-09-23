using GestionStock.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Domain.Interface
{
    public interface IUnitOfWork
    {
        IRepository<Produit> ProduitRepository { get; }
        IRepository<Commande> CommandeRepository { get; }
        IRepository<LignesCommande> LigneCommandeRepository { get; }
        IRepository<Client> ClientRepository { get; }

        void SaveChanges();
    }
}
