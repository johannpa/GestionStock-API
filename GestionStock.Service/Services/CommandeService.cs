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
        private readonly IUnitOfWork _unitOfWork;

        public CommandeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Commande CreateCommande(Commande commande)
        {
            throw new NotImplementedException();
        }

        public void CreateCommandeAvecClient(Client client, Commande commande, List<LignesCommande> listLigneCommande)
        {
            // Create the client
            var clientCreated = _unitOfWork.ClientRepository.Add(client);
            commande.Client = clientCreated;

            // Create command
            var CommandeCreated = _unitOfWork.CommandeRepository.Add(commande);

            // Creat lignes of command
            foreach(var ligne in listLigneCommande)
            {
                ligne.Commande = CommandeCreated;
                _unitOfWork.LigneCommandeRepository.Add(ligne);
            }
            _unitOfWork.SaveChanges();
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
