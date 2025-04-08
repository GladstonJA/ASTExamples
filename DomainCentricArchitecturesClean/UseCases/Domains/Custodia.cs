namespace DomainCentricArchitecturesClean.UseCases.Domains
{
    public class Custodia
    {
        public virtual int Id { get; set; }

        public virtual Acao Acao { get; set; }

        public virtual int Quantidade { get; set; }

        public virtual decimal PrecoUnitarioDeCompra { get; set; }
    }
}
