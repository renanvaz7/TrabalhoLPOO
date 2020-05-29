using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLPOO
{
    class Endereco
    {
        public string Logradouro { get; private set; }
        public int Numero { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }

        public string logradouro
        {
            set
            {
                this.Logradouro = value;
            }
        }

        public int numero
        {
            set
            {
                this.Numero = value;
            }
        }

        public string bairro
        {
            set
            {
                this.Bairro = value;
            }
        }

        public string cep
        {
            set
            {
                this.CEP = value;
            }
        }
    }
}
