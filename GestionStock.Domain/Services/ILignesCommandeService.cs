using GestionStock.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Domain.Services
{
    public interface ILignesCommandeService
    {
        IEnumerable<LignesCommande> GetAllLignesCommandes();
        LignesCommande GetLignesCommandeById(int id);
        LignesCommande CreateLignesCommande(LignesCommande lignesCommande);
        LignesCommande UpdateLignesCommande(LignesCommande ligneCommande);
        void DeleteLignesCommande(LignesCommande lignesCommande);
    }
}
