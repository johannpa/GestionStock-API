using GestionStock.Domain.Interface;
using GestionStock.Domain.Model;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace GestionStock.Service.Services
{
    public class CommandeServiceTest
    {
        [Fact]
        public void CreateCommandeAvecClient_RetournCreatCommande()
        {
            // Arrange
            var commandeRepository = new Mock<IRepository<Commande>>();
            var clientRepository = new Mock<IRepository<Client>>();
            var produitRepository = new Mock<IRepository<Produit>>();
            var lignesCommandeRepository = new Mock<IRepository<LignesCommande>>();

            var unitOfWork = new Mock<IUnitOfWork>();

            // Setup
            unitOfWork.Setup(x => x.ClientRepository).Returns(() => clientRepository.Object);
            unitOfWork.Setup(x => x.ProduitRepository).Returns(() => produitRepository.Object);
            unitOfWork.Setup(x => x.CommandeRepository).Returns(() => commandeRepository.Object);
            unitOfWork.Setup(x => x.LigneCommandeRepository).Returns(() => lignesCommandeRepository.Object);

            var commandeService = new CommandeService(unitOfWork.Object);

            //Model validation
            var client = new Client
            {
                Nom = "Philipe",
                Prenom = "Jack",
                Adresse = "Adresse"
            };
            var commande = new Commande
            {
                //Client = client,
                DteCommande = DateTime.Now,
                Total = 154
            };

            var ligneCommandes = new List<LignesCommande>();

            var ligneCommande = new LignesCommande
            {
                IdProduit = 1,
                Quantite = 1
            };
            ligneCommandes.Add(ligneCommande);
            commandeService.CreateCommandeAvecClient(client, commande, ligneCommandes);

            // Assert

            commandeRepository.Verify(c => c.Add(It.IsAny<Commande>()), Times.AtLeastOnce);
            clientRepository.Verify(c => c.Add(It.IsAny<Client>()), Times.AtLeastOnce);
            lignesCommandeRepository.Verify(c => c.Add(It.IsAny<LignesCommande>()), Times.AtLeastOnce);
        }
    }
}
