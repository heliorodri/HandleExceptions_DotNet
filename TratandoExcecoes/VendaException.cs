using System;
using System.Collections.Generic;
using System.Text;

namespace TratandoExcecoes
{
    class VendaException : Exception
    {
        private int id;

        public int ID { get => id; set => id = value; }

        public VendaException(int cod, string msg) : base($"{msg}. Código de erro: {cod}") { }
    }
}
