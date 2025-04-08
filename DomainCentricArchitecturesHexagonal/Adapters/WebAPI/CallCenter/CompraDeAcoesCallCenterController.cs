using DomainCentricArchitecturesHexagonal.Domains;
using DomainCentricArchitecturesHexagonal.Framework;

namespace DomainCentricArchitecturesHexagonal.Adapters.WebAPI.CallCenter
{
    public class CompraDeAcoesCallCenterController : IDrivingAdapter
    {
        private readonly ICompraDeAcaoDrivingPort _compraDeAcaoDrivingPort;

        public CompraDeAcoesCallCenterController(ICompraDeAcaoDrivingPort compraDeAcaoDrivingPort)
        {
            _compraDeAcaoDrivingPort = compraDeAcaoDrivingPort;
        }

        public int ComprarAcao(string ticket,
            int quantidade,
            decimal valorUnitario)
        {
            string numeroDaConta = GetContaEmAtendimento();

            // Executaria as validações necessárias na entrada de dados

            // Aciona a regra de negócio
            Negociacao negociacao = _compraDeAcaoDrivingPort.ComprarAcao(ticket,
                quantidade,
                valorUnitario,
                numeroDaConta);

            return negociacao.Id;
        }

        public string GetContaEmAtendimento()
        {
            // Recuperaria a conta da sessão de atendimento
            return "00001-1";
        }
    }
}
