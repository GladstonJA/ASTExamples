namespace DesignPatterns.GoF.Structural.Adapter.Parceiros.ViaCEP
{
    public class CEP
    {
        public virtual string cep { get; set; }

        public virtual string logradouro { get; set; }

        public virtual string? complemento { get; set; }

        public virtual string bairro { get; set; }

        public virtual string localidade { get; set; }

        public virtual string uf { get; set; }
    }
}