using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLPOO
{
    class Produto
    {
        public int IdProduto { get; set; }
        public string descricao { get; set; }
        public Categoria categoria { get; set; }
        public double precoUnitario { get; set; }
    }
}
