using DomainCentricArchitecturesHexagonal.Domains;

namespace DomainCentricArchitecturesHexagonal.Adapters.Repositories
{
    public class NegociacaoRepository : IRegistroDeNegociacaoDrivenPort
    {
        public virtual void RegistrarNegociacaoDeCompraDeAcao(Negociacao negociacao)
        {
            // Enviaria o pedido de compra para o sistema da B3
            negociacao.Id = 1;
        }
    }
}
