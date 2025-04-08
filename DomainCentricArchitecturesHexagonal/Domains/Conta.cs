namespace DomainCentricArchitecturesHexagonal.Domains
{
    public class Conta
    {
        public virtual string Id { get; set; }

        public virtual string Titular { get; set; }

        public virtual Carteira Carteira { get; set; }
    }
}
