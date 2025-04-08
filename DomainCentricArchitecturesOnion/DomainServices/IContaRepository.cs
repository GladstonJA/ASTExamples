using DomainCentricArchitecturesOnion.DomainModels;

namespace DomainCentricArchitecturesOnion.DomainServices
{
    public interface IContaRepository
    {
        Conta ConsultarConta(string numeroDaConta);
    }
}
