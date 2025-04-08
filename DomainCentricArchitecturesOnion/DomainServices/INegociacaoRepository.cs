using DomainCentricArchitecturesOnion.DomainModels;

namespace DomainCentricArchitecturesOnion.DomainServices
{
    public interface INegociacaoRepository
    {
        void RegistrarNegociacaoDeCompraDeAcao(Negociacao negociacao);
    }
}
