using DesignPatterns.GoF.Structural.Adapter.Parceiros.BrasilAberto;

namespace DesignPatterns.GoF.Structural.Adapter.Validators.Antes
{
    public class UsuarioValidator
    {
        private readonly BuscadorDeCEPBrasilAberto _buscadorDeCep = new();

        public bool Validar(Usuario usuario)
        {
            Response cep = _buscadorDeCep.BuscarCEP(usuario.CEP);

            return cep.street.Equals(usuario.Logradouro)
                && cep.city.Equals(usuario.Cidade)
                && cep.state.Equals(usuario.Estado);
        }
    }
}
