using EstoqueProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o nome do produto: ");
            string nomeProd = Console.ReadLine();

            Console.WriteLine("Valor do produto: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade do produto no estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            Produto prod = new Produto(nomeProd, valor, qtd);
            Console.WriteLine(prod);

            Console.WriteLine("1-Adicione mais produtos");
            Console.WriteLine("2-Remova os produtos");
            Console.WriteLine("3-Fechar aplicação");
            string selecionarOpc = Console.ReadLine();



            while (selecionarOpc == "1" || selecionarOpc == "2")
            {
                if (selecionarOpc == "1")
                {
                    Console.WriteLine("Adicione mais produtos ao estoque");
                    int adicionarProd = int.Parse(Console.ReadLine());
                    prod.AdicionarQuantidade(adicionarProd);

                    Console.WriteLine("estoque atual após a inclusão de mais produtos, " + prod);

                    Console.WriteLine("1-Adicione mais produtos");
                    Console.WriteLine("2-Remova os produtos");
                    Console.WriteLine("3-Fechar aplicação");
                    selecionarOpc = Console.ReadLine();

                }
                else if (selecionarOpc == "2")
                {
                    Console.WriteLine("Quantidades de produtos removidos");
                    int removerProd = int.Parse(Console.ReadLine());
                    prod.RemoverProduto(removerProd);

                    Console.WriteLine("Após remoção dos produtos, " + prod);

                    Console.WriteLine("1-Adicione mais produtos");
                    Console.WriteLine("2-Remova os produtos");
                    Console.WriteLine("3-Fechar aplicação");
                    selecionarOpc = Console.ReadLine();
                }
               
            }
             
            
                Console.WriteLine("aplicação encerrada");
            

        }
    }
}
