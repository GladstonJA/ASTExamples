﻿using DesignPatterns.GoF.Structural.Facade.AutorizadorDeCartao;

namespace DesignPatterns.GoF.Structural.Facade
{
    public class FacadeForAutorizadorDeCartao
    {
        public void AutorizacaoDeTransacaoEmCartaoDeCredito(bool executarPreCaptura)
        {
            var gestaoDeRisco = new GestaoDeRisco();
            var notificador = new Notificador();
            var processador = new Processador();
            var autenticador = new Autenticador();

            autenticador.AutenticarPontoDeVenda();
            gestaoDeRisco.AvaliarRiscoDaTransacao();
            processador.ValidarCHIP();

            if (executarPreCaptura)
                processador.RegistrarPreCaptura();

            processador.ConfirmarAutorizacaoDaTransacao();
            notificador.NotificadorTransacao();
        }
    }
}
