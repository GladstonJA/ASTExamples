namespace DomainCentricArchitecturesClean.UseCases.Domains.Ports
{
    public interface ICarteiraRepository
    {
        Carteira ConsultarCarteira(ContaInvestimento conta);
    }
}
