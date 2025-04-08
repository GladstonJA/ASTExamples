namespace DomainCentricArchitecturesOnion.DomainModels
{
    public class Carteira
    {
        public virtual int Id { get; set; }

        public virtual Conta Conta { get; set; }

        public virtual Custodia[] Custodia { get; set; }
    }
}
