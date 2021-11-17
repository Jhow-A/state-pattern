using System;

namespace StatePattern
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            CaixaEletronico caixaEletronico = new CaixaEletronico();

            Console.WriteLine("Estado atual do Caixa Eletrônico: " + caixaEletronico.CaixaEletronicoState.GetType().Name);

            NewLine();
            caixaEletronico.InformarSenha();
            caixaEletronico.SacarDinheiro();
            caixaEletronico.EjetarCartao();
            caixaEletronico.InserirCartao();
            NewLine();

            Console.WriteLine("Estado atual do Caixa Eletrônico: " + caixaEletronico.CaixaEletronicoState.GetType().Name);

            NewLine();
            caixaEletronico.InformarSenha();
            caixaEletronico.SacarDinheiro();
            caixaEletronico.InserirCartao();
            caixaEletronico.EjetarCartao();
            NewLine();

            Console.WriteLine("Estado atual do Caixa Eletrônico: " + caixaEletronico.CaixaEletronicoState.GetType().Name);
        }

        static void NewLine() => Console.Write(Environment.NewLine);
    }
}
