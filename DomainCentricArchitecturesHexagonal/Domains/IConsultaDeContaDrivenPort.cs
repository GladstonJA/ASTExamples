namespace DomainCentricArchitecturesHexagonal.Domains
{
    public interface IConsultaDeContaDrivenPort
    {
        Conta ConsultarConta(string numeroDaConta);
    }
}
