using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoLPOO;

namespace SistemaDeGerenciamentoDeEstoque
{
    class Program
    {      
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.categoria = new Categoria();               

            produto.IdProduto = 100;
            produto.descricao = "Hd ssd";
            produto.precoUnitario = 460.0;
            produto.categoria.descricao = "Equipamentos de Informática";


            Console.WriteLine("Informe o id do produto cadastrado");
            produto.IdProduto = Int32.Parse(Console.ReadLine());

            /*Console.WriteLine("Informe o produto a ser cadastrado");
            produto.descricao = Console.ReadLine();                      

            Console.WriteLine("Informe o preço unitário do produto cadastrado");
            produto.precoUnitario = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código da categoria do produto");
            produto.categoria.descricao = Console.ReadLine();

            Console.WriteLine("Informe o nome do cliente");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Informe o logradouro do cliente");
            cliente.Endereco.logradouro = Console.ReadLine();

            Console.WriteLine("Informe o número do cliente");
            cliente.Endereco.numero = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Bairro do cliente");
            cliente.Endereco.bairro = Console.ReadLine();

            Console.WriteLine("Informe o cep do cliente");
            cliente.Endereco.cep = Console.ReadLine();*/

            Console.Clear();

            Console.WriteLine("Produto: IdProduto: " + produto.IdProduto);
            Console.WriteLine("Descrição         : " + produto.descricao);
            Console.WriteLine("Preço Unitário    : " + produto.precoUnitario);
            Console.WriteLine("Categoria         : " + produto.categoria.Descricao);

            

            Cliente cliente = new Cliente();
            cliente.Endereco = new Endereco();

            cliente.IdCliente = 1;
            cliente.cpf = "110.015.236-98";
            cliente.nome = "Marcos da Silva A.";
            cliente.rg = "12 345 678-9.";
            cliente.Endereco.logradouro = "Rua das pedras";
            cliente.Endereco.numero = 14;
            cliente.Endereco.bairro = "Bairro felicidade";
            cliente.Endereco.cep = "29100-018";

            Console.WriteLine("Informe o id do cliente cadastrado");
            cliente.IdCliente = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nome              : " + cliente.Nome);
            Console.WriteLine("CPF               : " + cliente.CPF);
            Console.WriteLine("RG                : " + cliente.RG);
            Console.WriteLine("ID                : " + cliente.IdCliente);
            Console.WriteLine("Logradouro        : " + cliente.Endereco.Logradouro);
            Console.WriteLine("Número            : " + cliente.Endereco.Numero);
            Console.WriteLine("Bairro            : " + cliente.Endereco.Bairro);
            Console.WriteLine("CEP               : " + cliente.Endereco.CEP);                 

            Console.ReadKey();
        }
    }
}
