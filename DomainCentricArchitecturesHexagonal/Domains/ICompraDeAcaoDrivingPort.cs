using DomainCentricArchitecturesHexagonal.Framework;

namespace DomainCentricArchitecturesHexagonal.Domains
{
    public interface ICompraDeAcaoDrivingPort : IDrivingPort
    {
        Negociacao ComprarAcao(string ticket,
            int quantidade,
            decimal valorUnitario,
            string numeroDaConta);
    }
}
