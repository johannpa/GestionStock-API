using GestionStock.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Infrastructure.Repositories
{
    public class ClientRepository : Repository<Client>
    {
        public ClientRepository(GestionStockContext context):base(context)
        {

        }

        public override Client Update(Client entity)
        {
            var client = base._context.Find<Client>(entity.Id);
            client.Nom = entity.Nom;
            client.Prenom = entity.Prenom;
            client.Adresse = entity.Adresse;

            return base.Update(client);
        }
    }
}
