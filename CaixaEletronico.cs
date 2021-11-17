using System;

namespace StatePattern
{
    public class CaixaEletronico : ICaixaEletronicoState
    {
        public ICaixaEletronicoState CaixaEletronicoState { get; set; }

        public CaixaEletronico()
        {
            CaixaEletronicoState = new CartaoNaoInseridoState();
        }

        public void InserirCartao()
        {
            CaixaEletronicoState.InserirCartao();

            if (CaixaEletronicoState is CartaoNaoInseridoState)
            {
                CaixaEletronicoState = new CartaoInseridoState();
                Console.WriteLine($"\nO estado interno do caixa eletrônico foi alterado para: {CaixaEletronicoState.GetType().Name}");
            }
        }

        public void EjetarCartao()
        {
            CaixaEletronicoState.EjetarCartao();

            if (CaixaEletronicoState is CartaoInseridoState)
            {
                CaixaEletronicoState = new CartaoNaoInseridoState();
                Console.WriteLine($"\nO estado interno do caixa eletrônico foi alterado para: {CaixaEletronicoState.GetType().Name}");
            }
        }

        public void InformarSenha() => CaixaEletronicoState.InformarSenha();

        public void SacarDinheiro() => CaixaEletronicoState.SacarDinheiro();
    }
}
