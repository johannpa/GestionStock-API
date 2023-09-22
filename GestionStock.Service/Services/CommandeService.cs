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
        private readonly IRepository<Commande> _repositoryCommande;
        private readonly IRepository<Client> _repositoryClient;
        private readonly IRepository<LignesCommande> _repositoryLigneCommande;

        public CommandeService(IRepository<Commande> repository, 
            IRepository<Client> repositoryClient, 
            IRepository<LignesCommande> repositoryLigneCommande)
        {
            _repositoryCommande = repository;
            _repositoryClient = repositoryClient;
            _repositoryLigneCommande = repositoryLigneCommande;
        }
        public Commande CreateCommande(Commande commande)
        {
            throw new NotImplementedException();
        }

        public void CreateCommandeAvecClient(Client client, Commande commande, List<LignesCommande> listLigneCommande)
        {
            // Create the client
            var clientCreated = _repositoryClient.Add(client);
            _repositoryClient.SaveChanges();

            // Create command
            commande.Client = clientCreated;
            var CommandeCreated = _repositoryCommande.Add(commande);
            _repositoryCommande.SaveChanges();

            // Creat lignes of command
            foreach(var ligne in listLigneCommande)
            {
                ligne.Commande = CommandeCreated;
                _repositoryLigneCommande.Add(ligne);
                _repositoryLigneCommande.SaveChanges();
            }
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
