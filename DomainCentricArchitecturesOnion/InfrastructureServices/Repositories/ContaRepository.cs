using DomainCentricArchitecturesOnion.DomainModels;
using DomainCentricArchitecturesOnion.DomainServices;

namespace DomainCentricArchitecturesOnion.InfrastructureServices.Repositories
{
    public class ContaRepository : IContaRepository
    {
        private readonly ICarteiraRepository _carteiraRepository;

        public ContaRepository(ICarteiraRepository carteiraRepository)
        {
            _carteiraRepository = carteiraRepository;
        }

        public Conta ConsultarConta(string numeroDaConta)
        {
            Conta conta = new Conta()
            {
                Id = "000001-0",
                Titular = "Correntista Teste"
            };
            conta.Carteira = _carteiraRepository.ConsultarCarteira(conta);
            return conta;
        }
    }
}
