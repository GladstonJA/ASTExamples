using DomainCentricArchitecturesOnion.DomainModels;
using DomainCentricArchitecturesOnion.DomainServices;

namespace DomainCentricArchitecturesOnion.InfrastructureServices.Repositories
{
    public class NegociacaoRepository : INegociacaoRepository
    {
        public void RegistrarNegociacaoDeCompraDeAcao(Negociacao negociacao)
        {
            // Enviaria o pedido de compra para o sistema da B3
            negociacao.Id = 1;
        }
    }
}
