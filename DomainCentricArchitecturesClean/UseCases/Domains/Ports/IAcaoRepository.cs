namespace DomainCentricArchitecturesClean.UseCases.Domains.Ports
{
    public interface IAcaoRepository
    {
        Acao ConsultarAcaoByTicket(string ticket);

        Acao ConsultarAcaoById(int id);
    }
}
