using DesignPatterns.GoF.Structural.Facade.AutorizadorDeCartao;

namespace DesignPatterns.GoF.Structural.Facade
{
    public class ImplementacaoComFacade
    {
        public void OperacaoComPreCaptura()
        {
            FacadeForAutorizadorDeCartao autorizador = new();
            autorizador.AutorizacaoDeTransacaoEmCartaoDeCredito(true);
        }
    }
}
