using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLPOO
{
    class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }

        public string RG { get; private set; }
        public Endereco Endereco { get; set; }

        public string cpf
        {
            set
            {
                this.CPF = value;
            }
        }

        public string rg
        {
            set
            {
                this.RG = value;
            }
        }

        public string nome
        {
            set
            {
                this.Nome = value;
            }
        }
    }
}
