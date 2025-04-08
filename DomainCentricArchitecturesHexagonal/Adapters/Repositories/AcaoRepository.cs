using DomainCentricArchitecturesHexagonal.Domains;

namespace DomainCentricArchitecturesHexagonal.Adapters.Repositories
{
    public class AcaoRepository : IConsultaDeAcoesDrivenPort
    {
        private static readonly List<Acao> _listaDeAcoesNegociadas = [
            new Acao() { Descricao = "", Ticket = "EMBR3", Tipo = TipoDeAcao.Preferencial },
            new Acao() { Descricao = "", Ticket = "JBBS3", Tipo = TipoDeAcao.Preferencial },
            new Acao() { Descricao = "", Ticket = "PETR4", Tipo = TipoDeAcao.Preferencial },
            new Acao() { Descricao = "", Ticket = "BPAC11", Tipo = TipoDeAcao.Unit },
            new Acao() { Descricao = "", Ticket = "JSLG3", Tipo = TipoDeAcao.Preferencial },
            new Acao() { Descricao = "", Ticket = "XPBR34", Tipo = TipoDeAcao.BDR }
        ];

        public virtual Acao ConsultarAcaoById(int id)
        {
            // Acessaria o banco de dados ou outra fonte de persistência
            return _listaDeAcoesNegociadas[id];
        }

        public virtual Acao ConsultarAcaoByTicket(string ticket)
        {
            // Acessaria o banco de dados ou outra fonte de persistência
            return _listaDeAcoesNegociadas
                .First(a => a.Ticket.Equals(ticket));
        }
    }
}
