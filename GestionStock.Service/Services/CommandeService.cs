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
    public class CommandeService : ICommandeService
    {
        private readonly IRepository<Commande> _repository;

        public CommandeService(IRepository<Commande> repository)
        {
            _repository = repository;
        }
        public Commande CreateCommande(Commande commande)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommande(Commande commande)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Commande> GetAllCommandes()
        {
            throw new NotImplementedException();
        }

        public Commande GetCommandeById(int id)
        {
            throw new NotImplementedException();
        }

        public Commande UpdateCommande(ICommandeService commande)
        {
            throw new NotImplementedException();
        }
    }
}
