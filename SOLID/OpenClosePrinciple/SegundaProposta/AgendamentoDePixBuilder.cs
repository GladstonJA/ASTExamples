using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.OpenClosePrinciple.SegundaProposta
{
    public abstract class AgendamentoDePixBuilder
    {
        public abstract AgendamentoDePix Build(SolicitacaoDeAgendamentoDePix solicitacao);
    }

    public class AgendamentoDePixPorChavePixBuilder : AgendamentoDePixBuilder
    {
        public override AgendamentoDePix Build(SolicitacaoDeAgendamentoDePix solicitacao)
        {
            return null;
        }
    }

    public class AgendamentoDePixPorQrCodeEstaticoBuilder : AgendamentoDePixBuilder
    {
        public override AgendamentoDePix Build(SolicitacaoDeAgendamentoDePix solicitacao)
        {
            return null;
        }
    }

    public class AgendamentoDePixPorQrCodeDinamicoBuilder : AgendamentoDePixBuilder
    {
        public override AgendamentoDePix Build(SolicitacaoDeAgendamentoDePix solicitacao)
        {
            return null;
        }
    }

    public class AgendamentoDePixPorDadosManuais : AgendamentoDePixBuilder
    {
        public override AgendamentoDePix Build(SolicitacaoDeAgendamentoDePix solicitacao)
        {
            return null;
        }
    }

    public class UIAgendamentoAgendamentoDePix
    {
        public AgendamentoDePixBuilder Builder { get; set; }

        public void agendarPix(SolicitacaoDeAgendamentoDePix solicitacao)
        {
            var agendamento = Builder.Build(solicitacao);
        }
    }
}
