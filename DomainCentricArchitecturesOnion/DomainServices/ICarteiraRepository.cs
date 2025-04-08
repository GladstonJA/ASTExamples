using DomainCentricArchitecturesOnion.DomainModels;

namespace DomainCentricArchitecturesOnion.DomainServices
{
    public interface ICarteiraRepository
    {
        Carteira ConsultarCarteira(Conta conta);
    }
}
