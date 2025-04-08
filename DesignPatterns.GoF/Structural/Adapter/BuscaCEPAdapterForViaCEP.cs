using DesignPatterns.GoF.Structural.Adapter.Parceiros.ViaCEP;

namespace DesignPatterns.GoF.Structural.Adapter
{
    public class BuscaCEPAdapterForViaCEP : BuscaCEPAdapter
    {
        private readonly BuscadorDeCEPViaCEP _buscador = new();

        public override Endereco BuscarCEP(string CEP)
        {
            CEP response = _buscador.BuscarCEP(new BuscaCEPRequest()
            {
                CEP = CEP
            });
            return new Endereco()
            {
                Logradouro = response.logradouro,
                Complemento = response.complemento,
                Bairro = response.bairro,
                Cidade = response.localidade,
                Estado = response.uf,
                CEP = CEP
            };
        }
    }
}
