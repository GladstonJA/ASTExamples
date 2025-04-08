using DomainCentricArchitecturesOnion.DomainModels;

namespace DomainCentricArchitecturesOnion.DomainServices
{
    public interface IBroker
    {
        Negociacao ComprarAcao(string ticket,
            int quantidade,
            decimal valorUnitario,
            Conta conta);
    }
}
