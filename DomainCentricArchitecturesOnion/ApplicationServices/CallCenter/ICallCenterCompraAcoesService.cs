namespace DomainCentricArchitecturesOnion.ApplicationServices.CallCenter
{
    public interface ICallCenterCompraAcoesService
    {
        NegociacaoDeAcaoParaCallcenter ComprarAcao(string ticket,
            int quantidade,
            decimal valorUnitario,
            string numeroDaConta);
    }
}
