namespace DesignPatterns.GoF.Structural.Adapter.Parceiros.ViaCEP
{
    public class BuscadorDeCEPViaCEP
    {
        public CEP BuscarCEP(BuscaCEPRequest request)
        {
            // Envia requisição HTTP para o Brasil CEP e converte o JSON em objeto 
            return new CEP()
            {
                cep = "01001 - 000",
                logradouro = "Praça da Sé",
                complemento = "lado ímpar",
                bairro = "Sé",
                localidade = "São Paulo",
                uf = "SP"
            };
        }
    }
}
