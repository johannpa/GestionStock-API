using GestionStock.Domain.Interface;
using GestionStock.Domain.Model;
using GestionStock.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Service.Services
{
    public class LignesCommandeService : ILignesCommandeService
    {
        private readonly IRepository<LignesCommande> _repository;

        public LignesCommandeService(IRepository<LignesCommande> repository)
        {
            _repository = repository;
        }
        public LignesCommande CreateLignesCommande(LignesCommande lignesCommande)
        {
            throw new NotImplementedException();
        }

        public void DeleteLignesCommande(LignesCommande lignesCommande)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LignesCommande> GetAllLignesCommandes()
        {
            throw new NotImplementedException();
        }

        public LignesCommande GetLignesCommandeById(int id)
        {
            throw new NotImplementedException();
        }

        public LignesCommande UpdateLignesCommande(LignesCommande ligneCommande)
        {
            throw new NotImplementedException();
        }
    }
}
