namespace DomainCentricArchitecturesHexagonal.Adapters.WebAPI.HomeBroker.Responses
{
    public class PosicaoDeCarteiraHomeBrokerControllerResponse
    {
        public virtual string Acao { get; set; }

        public virtual int Quantidade { get; set; }

        public virtual decimal PrecoUnitarioDeCompra { get; set; }
    }
}
