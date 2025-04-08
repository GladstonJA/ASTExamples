namespace DomainCentricArchitecturesClean.UseCases.Domains
{
    public class NotaDeCorretagem
    {
        public virtual string Id { get; set; }

        public virtual ContaInvestimento Conta { get; set; }

        public virtual DateTime DataDeNegociacao { get; set; }

        public virtual DateTime DataDeLiquidacao { get; set; }

        public virtual Negociacao[] Negociacoes { get; set; }
    }
}
