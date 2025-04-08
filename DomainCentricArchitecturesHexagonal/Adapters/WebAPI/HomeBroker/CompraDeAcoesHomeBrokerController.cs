using DomainCentricArchitecturesHexagonal.Domains;
using DomainCentricArchitecturesHexagonal.Framework;

namespace DomainCentricArchitecturesHexagonal.Adapters.WebAPI.HomeBroker
{
    public class CompraDeAcoesHomeBrokerController : IDrivingAdapter
    {
        private readonly ICompraDeAcaoDrivingPort _compraDeAcaoDrivingPort;

        public CompraDeAcoesHomeBrokerController(ICompraDeAcaoDrivingPort compraDeAcaoDrivingPort)
        {
            _compraDeAcaoDrivingPort = compraDeAcaoDrivingPort;
        }

        public int ComprarAcao(string ticket,
            int quantidade,
            decimal valorUnitario,
            string numeroDaConta)
        {
            // Executaria as validações necessárias na entrada de dados

            // Aciona a regra de negócio
            Negociacao negociacao = _compraDeAcaoDrivingPort.ComprarAcao(ticket,
                quantidade,
                valorUnitario,
                numeroDaConta);

            return negociacao.Id;
        }
    }
}
