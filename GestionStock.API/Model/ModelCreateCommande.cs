using System.Collections.Generic;

namespace GestionStock.API.Model
{
    public class ModelCreateCommande
    {
        public IEnumerable<LigneCommandeModel> CommandeLignes { get; set; }
        public ClientModel Client { get; set; }
    }
}