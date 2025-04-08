using DomainCentricArchitecturesHexagonal.Framework;

namespace DomainCentricArchitecturesHexagonal.Domains
{
    public interface IRegistroDeNegociacaoDrivenPort : IDrivenPort
    {
        void RegistrarNegociacaoDeCompraDeAcao(Negociacao negociacao);
    }
}
