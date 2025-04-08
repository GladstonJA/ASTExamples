namespace DesignPatterns.GoF.Structural.Adapter.Parceiros.BrasilAberto
{
    public class BuscadorDeCEPBrasilAberto
    {
        public virtual Response BuscarCEP(string CEP)
        {
            // Envia requisição HTTP para o Brasil CEP e converte o JSON em objeto 
            return new Response()
            {
                street = "Praça da Sé",
                complement = null,
                district = "Sé",
                city = "São Paulo",
                state = "São Paulo",
                stateShortname = "SP",
                zipcode = "01001000"
            };
        }
    }
}
