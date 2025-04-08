namespace DomainCentricArchitecturesClean.UseCases.Domains.Ports
{
    public interface IContaInvestimentoRepository
    {
        ContaInvestimento ConsultarConta(string numeroDaConta);
    }
}
