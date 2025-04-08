using DomainCentricArchitecturesOnion.DomainModels;

namespace DomainCentricArchitecturesOnion.DomainServices
{
    public interface IAcaoRepository
    {
        Acao ConsultarAcaoByTicket(string ticket);

        Acao ConsultarAcaoById(int id);
    }
}
