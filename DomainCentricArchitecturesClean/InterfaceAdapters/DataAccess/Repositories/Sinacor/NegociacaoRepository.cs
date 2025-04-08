using DomainCentricArchitecturesClean.UseCases.Domains;
using DomainCentricArchitecturesClean.UseCases.Domains.Ports;

namespace DomainCentricArchitecturesClean.InterfaceAdapters.DataAccess.Repositories.Sinacor
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
