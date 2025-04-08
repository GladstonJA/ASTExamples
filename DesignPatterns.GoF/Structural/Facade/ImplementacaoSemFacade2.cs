using DesignPatterns.GoF.Structural.Facade.AutorizadorDeCartao;

namespace DesignPatterns.GoF.Structural.Facade
{
    public class ImplementacaoSemFacade2
    {
        public void OperacaoSemPreCaptura()
        {
            var gestaoDeRisco = new GestaoDeRisco();
            var notificador = new Notificador();
            var processador = new Processador();
            var autenticador = new Autenticador();

            autenticador.AutenticarPontoDeVenda();
            gestaoDeRisco.AvaliarRiscoDaTransacao();
            processador.ValidarCHIP();
            processador.ConfirmarAutorizacaoDaTransacao();
            notificador.NotificadorTransacao();
        }
    }
}
