namespace DomainCentricArchitecturesClean.Entities.Domains
{
    public class Conta
    {
        public virtual string Id { get; set; }

        public virtual Correntista Titular { get; set; }
    }
}
