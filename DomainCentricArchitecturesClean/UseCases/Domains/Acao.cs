namespace DomainCentricArchitecturesClean.UseCases.Domains
{
    public class Acao
    {
        public virtual TipoDeAcao Tipo { get; set; }

        public virtual string Ticket { get; set; }

        public virtual string Descricao { get; set; }
    }
}
