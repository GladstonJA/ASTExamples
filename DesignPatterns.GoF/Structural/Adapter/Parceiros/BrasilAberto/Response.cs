namespace DesignPatterns.GoF.Structural.Adapter.Parceiros.BrasilAberto
{
    public class Response
    {
        public virtual string street { get; set; }

        public virtual string? complement { get; set; }

        public virtual string district { get; set; }

        public virtual string city { get; set; }

        public virtual string state { get; set; }

        public virtual string stateShortname { get; set; }

        public virtual string zipcode { get; set; }
    }
}
