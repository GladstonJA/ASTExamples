namespace DomainCentricArchitecturesClean.UseCases.Domains
{
    public class Negociacao
    {
        public virtual int Id { get; set; }

        public virtual ContaInvestimento Conta { get; set; }

        public virtual Acao Acao { get; set; }

        public virtual int Quantidade { get; set; }

        public virtual decimal ValorUnitario { get; set; }

        public virtual TipoDeNegociacao Tipo { get; set; }
    }
}
