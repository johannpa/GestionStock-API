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
    public class ClientService : IClientService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Client CreateClient(Client newClient)
        {
            
            var client = _unitOfWork.ClientRepository.Add(newClient);
            _unitOfWork.ClientRepository.SaveChanges();
            return client;
        }

        public void DeleteClient(Client client)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _unitOfWork.ClientRepository.All();
        }

        public Client GetClientById(int id)
        {
            return _unitOfWork.ClientRepository.Get(id);
        }

        public Client UpdateClient(Client client)
        {
           var clientUpdated = _unitOfWork.ClientRepository.Update(client);
            _unitOfWork.ClientRepository.SaveChanges();
            return clientUpdated;
        }
    }
}
