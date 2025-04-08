using DomainCentricArchitecturesClean.UseCases.Domains;
using DomainCentricArchitecturesClean.UseCases.Domains.Ports;

namespace DomainCentricArchitecturesClean.InterfaceAdapters.DataAccess.Repositories.SQL
{
    public class ContaInvestimentoRepository : IContaInvestimentoRepository
    {
        private readonly ICarteiraRepository _carteiraRepository;

        public ContaInvestimentoRepository(ICarteiraRepository carteiraRepository)
        {
            _carteiraRepository = carteiraRepository;
        }

        public ContaInvestimento ConsultarConta(string numeroDaConta)
        {
            ContaInvestimento conta = new ContaInvestimento()
            {
                Id = "000001-0",
                Titular = new()
                {
                    Nome = "Correntista Teste"
                }
            };
            conta.Carteira = _carteiraRepository.ConsultarCarteira(conta);
            return conta;
        }
    }
}
