namespace DesignPatterns.GoF.Structural.Adapter.Validators.Depois
{
    public class UsuarioValidator
    {
        private BuscaCEPAdapter _buscadorDeCep;

        public bool Validar(Usuario usuario)
        {
            // A partir do contexto da execução se escolheria um dos dois parceiros abaixo
            _buscadorDeCep = new BuscaCEPAdapterForBrasilAberto();
            _buscadorDeCep = new BuscaCEPAdapterForViaCEP();

            Endereco endereco = _buscadorDeCep.BuscarCEP(usuario.CEP);

            return endereco.Logradouro.Equals(usuario.Logradouro)
                && endereco.Cidade.Equals(usuario.Cidade)
                && endereco.Estado.Equals(usuario.Estado);
        }
    }
}
