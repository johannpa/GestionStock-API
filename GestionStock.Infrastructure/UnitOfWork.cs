using GestionStock.Domain.Interface;
using GestionStock.Domain.Model;
using GestionStock.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Infrastructure
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly GestionStockContext _context;
        private IRepository<Produit> _produitRepository;
        private IRepository<Commande> _commandeRepository;
        private IRepository<LignesCommande> _ligneCommandeRepository;
        private IRepository<Client> _clientRepository;
        public UnitOfWork(GestionStockContext context)
        {
            _context = context;
        }

        public IRepository<Produit> ProduitRepository
        {
            get
            {
                if(_produitRepository == null)
                {
                    _produitRepository = new ProduitRepository(_context);
                }
                return _produitRepository;
            }
        }

        public IRepository<Client> ClientRepository
        {
            get
            {
                if (_clientRepository == null)
                {
                    _clientRepository = new ClientRepository(_context);
                }
                return _clientRepository;
            }
        }

        public IRepository<Commande> CommandeRepository
        {
            get
            {
                if(_commandeRepository == null)
                {
                    _commandeRepository = new CommandeRepository(_context);
                }
                return _commandeRepository;
            }
        }
        public IRepository<LignesCommande> LigneCommandeRepository
        {
            get
            {
                if(_ligneCommandeRepository == null)
                {
                    _ligneCommandeRepository = new LignesCommandeRepository(_context);
                }
                return _ligneCommandeRepository;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        
    }
}
