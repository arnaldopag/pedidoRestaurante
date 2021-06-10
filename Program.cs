using System;
using System.Collections.Generic;
namespace atividade_i
{
    class Program
    {
        static void Main(string[] args)
        {
            string descricao;
            double preco;
            int qtd;
            char fim = 's';

            Pedido novoPedido = new Pedido();   
            do{
                Console.WriteLine("==Novo Pedido==");
                Console.Write("Descrição do produto: ");
                descricao = Console.ReadLine();
                Console.Write("Preço do Produto: ");
                preco =Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade: ");
                qtd = Convert.ToInt32(Console.ReadLine());


                ItemPedido novoItemPedido = new ItemPedido(descricao, preco, qtd);
                novoPedido.AddItemPedido(novoItemPedido);

                Console.Write("Deseja Adicionais meis items S ou N: ");
                fim = Convert.ToChar(Console.ReadLine());


            }while (fim == 's');
        

            Console.WriteLine("Valor Total: " + novoPedido.totalizador());

        }
    
    }
}
