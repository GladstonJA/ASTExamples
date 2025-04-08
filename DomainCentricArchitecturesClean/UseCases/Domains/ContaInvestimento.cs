using DomainCentricArchitecturesClean.Entities.Domains;

namespace DomainCentricArchitecturesClean.UseCases.Domains
{
    public class ContaInvestimento : Conta
    {
        public virtual Carteira Carteira { get; set; }
    }
}
