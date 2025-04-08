using DomainCentricArchitecturesClean.UseCases.Domains;

namespace DomainCentricArchitecturesClean.UseCases.Ports
{
    public interface ICompraDeAcaoUseCase
    {
        Negociacao ComprarAcao(string ticket,
            int quantidade,
            decimal valorUnitario,
            string numeroDaConta);
    }
}
