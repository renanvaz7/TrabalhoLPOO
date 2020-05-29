using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLPOO
{
    class Categoria
    {
        public int IdCategoria { get; private set; }
        public string Descricao { get; private set; }

        public int idcategoria
        {
            set
            {
                this.IdCategoria = value;
            }
        }

        public string descricao
        {
            set
            {
                this.Descricao = value;
            }
        }
    }
}
