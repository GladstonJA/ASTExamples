namespace DomainCentricArchitecturesHexagonal.Domains
{
    public class Broker : ICompraDeAcaoDrivingPort,
        IConsultaCarteiraDrivingPort
    {
        private readonly IConsultaDeContaDrivenPort _consultaDeContaDrivenPort;
        private readonly IConsultaDeAcoesDrivenPort _consultaDeAcoesPort;
        private readonly IRecuperaCarteiraDrivenPort _recuperaCarteiraDrivenPort;
        private readonly IRegistroDeNegociacaoDrivenPort _acaoRegistroDeNegociacaoPort;

        public Broker(IConsultaDeContaDrivenPort consultaDeContaDrivenPort,
            IConsultaDeAcoesDrivenPort consultaDeAcoesPort,
            IRecuperaCarteiraDrivenPort recuperaCarteiraDrivenPort,
            IRegistroDeNegociacaoDrivenPort acaoRegistroDeNegociacaoPort)
        {
            _consultaDeContaDrivenPort = consultaDeContaDrivenPort;
            _consultaDeAcoesPort = consultaDeAcoesPort;
            _recuperaCarteiraDrivenPort = recuperaCarteiraDrivenPort;
            _acaoRegistroDeNegociacaoPort = acaoRegistroDeNegociacaoPort;
        }

        public virtual Negociacao ComprarAcao(string ticket,
            int quantidade,
            decimal valorUnitario,
            string numeroDaConta)
        {
            // Recupera a conta
            Conta conta = _consultaDeContaDrivenPort.ConsultarConta(numeroDaConta);

            // Recupera a ação
            Acao acao = _consultaDeAcoesPort.ConsultarAcaoByTicket(ticket);

            // Executaria as validações necessárias

            Negociacao ordemDeCompra = new()
            {
                Conta = conta,
                Acao = acao,
                Quantidade = quantidade,
                Tipo = TipoDeNegociacao.Compra,
                ValorUnitario = valorUnitario
            };

            // Registra a negociação de acordo com as regras de negocio
            _acaoRegistroDeNegociacaoPort.RegistrarNegociacaoDeCompraDeAcao(ordemDeCompra);

            return ordemDeCompra;
        }

        public virtual Carteira ConsultarCarteira(string numeroDaConta)
        {
            Conta conta = _consultaDeContaDrivenPort.ConsultarConta(numeroDaConta);

            return _recuperaCarteiraDrivenPort.ConsultarCarteira(conta);
        }
    }
}
