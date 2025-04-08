using DomainCentricArchitecturesClean.UseCases.Domains;
using DomainCentricArchitecturesClean.UseCases.Domains.Ports;
using DomainCentricArchitecturesClean.UseCases.Ports;

namespace DomainCentricArchitecturesClean.UseCases
{
    public class CompraDeAcaoUseCase : ICompraDeAcaoUseCase
    {
        private readonly IAcaoRepository _acaoRepository;
        private readonly IContaInvestimentoRepository _contaInvestimentoRepository;
        private readonly INegociacaoRepository _negociacaoRepository;

        public CompraDeAcaoUseCase(IAcaoRepository acaoRepository,
            IContaInvestimentoRepository contaInvestimentoRepository,
            INegociacaoRepository negociacaoRepository)
        {
            _acaoRepository = acaoRepository;
            _contaInvestimentoRepository = contaInvestimentoRepository;
            _negociacaoRepository = negociacaoRepository;
        }

        public virtual Negociacao ComprarAcao(string ticket,
            int quantidade,
            decimal valorUnitario,
            string numeroDaConta)
        {
            // Recupera a ação
            Acao acao = _acaoRepository.ConsultarAcaoByTicket(ticket);

            // Recupera a conta
            ContaInvestimento conta = _contaInvestimentoRepository.ConsultarConta(numeroDaConta);

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
