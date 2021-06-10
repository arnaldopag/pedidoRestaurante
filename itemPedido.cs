
using System.Collections.Generic;

namespace atividade_i
{
    public class ItemPedido
    {
        
        public string descricao;
        public double precoUni ;
        public int qtd ;
        public ItemPedido(string d, double p, int q){
            descricao = d;
            precoUni = p;  
            qtd = q;
        }
    }
}