using DesignPatterns.GoF.Structural.Adapter.Parceiros.BrasilAberto;

namespace DesignPatterns.GoF.Structural.Adapter
{
    public class BuscaCEPAdapterForBrasilAberto : BuscaCEPAdapter
    {
        private readonly BuscadorDeCEPBrasilAberto _buscador = new BuscadorDeCEPBrasilAberto();

        public override Endereco BuscarCEP(string CEP)
        {
            Response response = _buscador.BuscarCEP(CEP);
            return new Endereco()
            {
                Logradouro = response.street,
                Complemento = response.complement,
                Bairro = response.district,
                Cidade = response.city,
                Estado = response.state,
                CEP = CEP
            };
        }
    }
}
