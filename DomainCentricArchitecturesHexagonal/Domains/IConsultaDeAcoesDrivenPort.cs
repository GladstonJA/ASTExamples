namespace DomainCentricArchitecturesHexagonal.Domains
{
    public interface IConsultaDeAcoesDrivenPort
    {
        Acao ConsultarAcaoById(int id);

        Acao ConsultarAcaoByTicket(string ticket);
    }
}
