using System;
using System.Collections.Generic;
using System.Text;

namespace TratandoExcecoes
{
    class ItemVenda
    {
        private string descricao;
        private double preco;
        private int quantidade;

        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
