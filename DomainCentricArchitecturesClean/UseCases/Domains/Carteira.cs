namespace DomainCentricArchitecturesClean.UseCases.Domains
{
    public class Carteira
    {
        public virtual int Id { get; set; }

        public virtual ContaInvestimento Conta { get; set; }

        public virtual Custodia[] Custodia { get; set; }
    }
}
