namespace DesignPatterns.GoF.Structural.Adapter
{
    public class Endereco
    {
        public virtual string CEP { get; set; }

        public virtual string Logradouro { get; set; }

        public virtual string? Complemento { get; set; }

        public virtual string Bairro { get; set; }

        public virtual string Cidade { get; set; }

        public virtual string Estado { get; set; }
    }
}
