using DomainCentricArchitecturesOnion.DomainModels;
using DomainCentricArchitecturesOnion.DomainServices;

namespace DomainCentricArchitecturesOnion.ApplicationServices.CallCenter
{
    public class CallCenterCompraAcoesService : ICallCenterCompraAcoesService
    {
        private readonly IContaRepository _contaRepository;
        private readonly IBroker _broker;

        public CallCenterCompraAcoesService(IContaRepository contaRepository,
            IBroker broker)
        {
            _contaRepository = contaRepository;
            _broker = broker;
        }

        public NegociacaoDeAcaoParaCallcenter ComprarAcao(string ticket,
            int quantidade,
            decimal valorUnitario,
            string numeroDaConta)
        {
            Conta conta = _contaRepository.ConsultarConta(numeroDaConta);

            Negociacao negociacao = _broker.ComprarAcao(ticket,
                quantidade,
                valorUnitario,
                conta);

            return new NegociacaoDeAcaoParaCallcenter()
            {
                Conta = negociacao.Conta.Id,
                Acao = negociacao.Acao.Ticket,
                Quantidade = negociacao.Quantidade,
                ValorUnitario = negociacao.ValorUnitario,
            };
        }
    }
}
