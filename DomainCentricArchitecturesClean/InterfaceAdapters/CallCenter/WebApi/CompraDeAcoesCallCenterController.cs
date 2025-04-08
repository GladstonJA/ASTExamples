using DomainCentricArchitecturesClean.UseCases.Domains;
using DomainCentricArchitecturesClean.UseCases.Ports;

namespace DomainCentricArchitecturesClean.InterfaceAdapters.CallCenter.WebApi
{
    public class CompraDeAcoesCallCenterController
    {
        private readonly ICompraDeAcaoUseCase _compraDeAcaoUseCase;

        public CompraDeAcoesCallCenterController(ICompraDeAcaoUseCase compraDeAcaoUseCase)
        {
            _compraDeAcaoUseCase = compraDeAcaoUseCase;
        }

        public CompraDeAcoesCallCenterControllerResponse ComprarAcao(string ticket,
            int quantidade,
            decimal valorUnitario)
        {
            string numeroDaConta = GetContaEmAtendimento();

            // Executaria as validações necessárias na entrada de dados

            // Aciona a regra de negócio
            Negociacao negociacao = _compraDeAcaoUseCase.ComprarAcao(ticket,
                quantidade,
                valorUnitario,
                numeroDaConta);

            return new CompraDeAcoesCallCenterControllerResponse()
            {
                Acao = negociacao.Acao.Ticket,
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
