using DesignPatterns.GoF.Creational.FactoryMethod.Factories;

namespace DesignPatterns.GoF.Creational.FactoryMethod
{
    public abstract class Client
    {
        private readonly ColetorDeCredenciais _coletorDeCredenciais;

        protected abstract ColetorDeCredenciais BuildColetorDeCredenciais();

        public Client()
        {
            _coletorDeCredenciais = BuildColetorDeCredenciais();
        }
    }
}
