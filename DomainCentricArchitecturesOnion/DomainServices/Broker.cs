using DomainCentricArchitecturesOnion.DomainModels;

namespace DomainCentricArchitecturesOnion.DomainServices
{
    public class Broker : IBroker
    {
        private readonly IAcaoRepository _acaoRepository;
        private readonly INegociacaoRepository _negociacaoRepository;

        public Broker(IAcaoRepository acaoRepository,
            INegociacaoRepository negociacaoRepository)
        {
            _acaoRepository = acaoRepository;
            _negociacaoRepository = negociacaoRepository;
        }

        public virtual Negociacao ComprarAcao(string ticket,
            int quantidade,
            decimal valorUnitario,
            Conta conta)
        {
            // Recupera a ação
            Acao acao = _acaoRepository.ConsultarAcaoByTicket(ticket);

            // Executaria as validações necessárias

            Negociacao ordemDeCompra = new()
            {
                Conta = conta,
                Acao = acao,
                Quantidade = quantidade,
                Tipo = TipoDeNegociacao.Compra,
                ValorUnitario = valorUnitario
            };

            // Registra a negociação de acordo com as regras de negocio
            _negociacaoRepository.RegistrarNegociacaoDeCompraDeAcao(ordemDeCompra);

            return ordemDeCompra;
        }
    }
}
