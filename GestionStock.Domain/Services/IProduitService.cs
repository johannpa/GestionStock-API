using GestionStock.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Domain.Services
{
    public interface IProduitService
    {
        IEnumerable<Produit> GetAllProduits();
        Produit GetProduitById(int id);
        Produit CreateProduit(Produit newProduit);
        Produit UpdateProduit(Produit produit);
        void DeleteProduit(Produit produit);
    }
}
