using DomainCentricArchitecturesHexagonal.Framework;

namespace DomainCentricArchitecturesHexagonal.Domains
{
    public interface IConsultaCarteiraDrivingPort : IDrivingPort
    {
        Carteira ConsultarCarteira(string numeroDaConta);
    }
}
