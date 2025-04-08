namespace DomainCentricArchitecturesHexagonal.Adapters.WebAPI.HomeBroker.Responses
{
    public class ConsultaCarteiraHomeBrokerControllerResponse
    {
        public virtual string Conta { get; set; }

        public virtual PosicaoDeCarteiraHomeBrokerControllerResponse[] Posicao { get; set; }
    }
}
