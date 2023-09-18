using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Domain.Model
{
    public class Produit
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int Quantite { get; set; }
        public decimal Prix { get; set; }
    }
}
