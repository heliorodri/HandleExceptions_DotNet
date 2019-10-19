using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TratandoExcecoes
{
    class Venda
    {
        private int id;
        private DateTime data;
        private List<ItemVenda> itens = new List<ItemVenda>();

        public int ID { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public List<ItemVenda> Itens { get => itens; } 

        public void AdicionarItem(ItemVenda item)
        {
            if(item == null)
                throw new VendaException(999, "Item nulo");

            this.itens.Add(item);
        }

        public double CalcularTotal()
        {
            return this.Itens.Sum(i => i.Preco * i.Quantidade);
        }
    }
}
