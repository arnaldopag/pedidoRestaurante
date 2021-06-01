using System.Collections.Generic;
namespace atividade_i
{

    public class pedido
    {

        public List<itemPedido> items = new List<itemPedido>();
        public bool addItem(string descricao, double precoUni, int qtd)
        {
            items.Add(new itemPedido { descricao = descricao, precoUni = precoUni, qtd = qtd });
            return true;
        }



    }
}