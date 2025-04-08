using DomainCentricArchitecturesOnion.ApplicationServices.CallCenter;

namespace DomainCentricArchitecturesOnion.InfrastructureServices.CallCenter.WebAPI
{
    public class CompraDeAcoesCallCenterController
    {
        private readonly ICallCenterCompraAcoesService _callCenterCompraAcoesService;

        public CompraDeAcoesCallCenterController(ICallCenterCompraAcoesService callCenterCompraAcoesService)
        {
            _callCenterCompraAcoesService = callCenterCompraAcoesService;
        }

        public CompraDeAcoesCallCenterControllerResponse ComprarAcao(string ticket,
            int quantidade,
            decimal valorUnitario)
        {
            string conta = GetContaEmAtendimento();

            // Executaria as validações necessárias na entrada de dados

            // Aciona a regra de negócio
            NegociacaoDeAcaoParaCallcenter negociacao = _callCenterCompraAcoesService.ComprarAcao(ticket,
                quantidade,
                valorUnitario,
                conta);

            return new CompraDeAcoesCallCenterControllerResponse()
            {
                Acao = negociacao.Acao,
                Quantidade = negociacao.Quantidade,
                ValorUnitario = negociacao.ValorUnitario,
            };
        }

        public string GetContaEmAtendimento()
        {
            // Recuperaria a conta da sessão de atendimento
            return "000001-1";
        }
    }
}
