using DomainCentricArchitecturesHexagonal.Framework;

namespace DomainCentricArchitecturesHexagonal.Domains
{
    public interface IRecuperaCarteiraDrivenPort : IDrivenPort
    {
        Carteira ConsultarCarteira(Conta conta);
    }
}
