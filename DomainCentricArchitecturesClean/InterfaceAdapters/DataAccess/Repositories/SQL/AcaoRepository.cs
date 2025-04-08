using DomainCentricArchitecturesClean.UseCases.Domains;
using DomainCentricArchitecturesClean.UseCases.Domains.Ports;

namespace DomainCentricArchitecturesClean.InterfaceAdapters.DataAccess.Repositories.SQL
{
    public class AcaoRepository : IAcaoRepository
    {
        private static readonly List<Acao> _listaDeAcoesNegociadas = [
            new Acao() { Descricao = "", Ticket = "EMBR3", Tipo = TipoDeAcao.Preferencial },
            new Acao() { Descricao = "", Ticket = "JBBS3", Tipo = TipoDeAcao.Preferencial },
            new Acao() { Descricao = "", Ticket = "PETR4", Tipo = TipoDeAcao.Preferencial },
            new Acao() { Descricao = "", Ticket = "BPAC11", Tipo = TipoDeAcao.Unit },
            new Acao() { Descricao = "", Ticket = "JSLG3", Tipo = TipoDeAcao.Preferencial },
            new Acao() { Descricao = "", Ticket = "XPBR34", Tipo = TipoDeAcao.BDR }
        ];

        public Acao ConsultarAcaoById(int id)
        {
            return _listaDeAcoesNegociadas[id];
        }

        public Acao ConsultarAcaoByTicket(string ticket)
        {
            return _listaDeAcoesNegociadas
                .First(a => a.Ticket.Equals(ticket));
        }
    }
}
