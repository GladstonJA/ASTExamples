using DomainCentricArchitecturesHexagonal.Adapters.WebAPI.HomeBroker.Responses;
using DomainCentricArchitecturesHexagonal.Domains;
using DomainCentricArchitecturesHexagonal.Framework;

namespace DomainCentricArchitecturesHexagonal.Adapters.WebAPI.HomeBroker
{
    public class ConsultaCarteiraHomeBrokerController : IDrivingAdapter
    {
        private readonly IConsultaCarteiraDrivingPort _consultaCarteiraDrivingPort;

        public ConsultaCarteiraHomeBrokerController(IConsultaCarteiraDrivingPort consultaCarteiraDrivingPort)
        {
            _consultaCarteiraDrivingPort = consultaCarteiraDrivingPort;
        }

        public ConsultaCarteiraHomeBrokerControllerResponse ConsultarCarteira(string numeroDaConta)
        {
            Carteira carteira = _consultaCarteiraDrivingPort.ConsultarCarteira(numeroDaConta);

            // Converteria Carteira (domínio) em ConsultaCarteiraHomeBrokerControllerResponse (DTO)
            return new ConsultaCarteiraHomeBrokerControllerResponse();
        }
    }
}
