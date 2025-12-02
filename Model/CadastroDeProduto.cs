using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoValidacao1.Model
{
    public class CadastroDeProduto
    {
        public int? id {get; set; }
        public string? NomeProduto {get; set; }
        public decimal ValorProduto {get; set; }
        public DateTime? DataProduto {get; set; }
        //public string? LoteProduto {get; set; }
        
       
    }
}
