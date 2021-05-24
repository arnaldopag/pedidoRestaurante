using System;

namespace atividade_i
{
    class Program
    {
        static list<itemPedido> pedido;
        static void Main(string[] args)
        {
            
        }
        public class itemPedido(){

            string descicao;
            double valorUnitario;
            int quantidade;


        }
        public class pedido(){

            pedido = new list<itemPedido>();
            pedido.Add(new itemPedido());
            pedido.Add(new itemPedido());
            pedido.Add(new itemPedido());
            pedido.Add(new itemPedido());
            pedido.Add(new itemPedido());

            foreach (itemPedido p in pedido)
            {
                console.writeLine(p.descicao + "" + p.quantidade);
            }
        }
    }
}
