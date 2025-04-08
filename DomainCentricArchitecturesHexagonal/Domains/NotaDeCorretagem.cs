namespace DomainCentricArchitecturesHexagonal.Domains
{
    public class NotaDeCorretagem
    {
        public virtual string Id { get; set; }

        public virtual Conta Conta { get; set; }

        public virtual DateTime DataDeNegociacao { get; set; }

        public virtual DateTime DataDeLiquidacao { get; set; }

        public virtual Negociacao[] Negociacoes { get; set; }
    }
}
