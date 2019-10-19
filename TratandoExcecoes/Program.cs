using System;

namespace TratandoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Venda venda = new Venda
            {
                ID = 1,
                Data = DateTime.Today
            };

            ItemVenda i1 = new ItemVenda
            {
                Descricao = "FIFA 20",
                Preco = 299.99,
                Quantidade = 1
            };

            ItemVenda i2 = new ItemVenda
            {
                Descricao = "Formula 1 2020 Deluxe Edition",
                Preco = 340.00,
                Quantidade = 1
            };

            ItemVenda i3 = new ItemVenda
            {
                Descricao = "Nascar 20",
                Preco = 270.99,
                Quantidade = 1
            };

            ItemVenda itemExcept = null;

            try
            {
                venda.AdicionarItem(i1);
                venda.AdicionarItem(i2);
                venda.AdicionarItem(i3);
                Console.WriteLine($"O total da venda é: {venda.CalcularTotal()}");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (VendaException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Processamento Concluído!");
            }

            Console.ReadKey();
        }
    }
}
