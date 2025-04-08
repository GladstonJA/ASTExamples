using DesignPatterns.GoF.Creational.AbstractFactory.Factories;
using DesignPatterns.GoF.Creational.AbstractFactory.Products.Biometria;
using DesignPatterns.GoF.Creational.AbstractFactory.Products.Senha;

namespace DesignPatterns.GoF.Creational.AbstractFactory
{
    public class Client
    {
        public PasswordControl PasswordControl { get; private set; }

        public LeitorBiometrico LeitorBiometrico { get; private set; }

        public Client(string plataforma)
        {
            var coletorDeCredenciaisFactory = default(ColetorDeCredenciaisFactory);

            if (plataforma.Equals("DESKTOP"))
                coletorDeCredenciaisFactory = new ColetorDeCredenciaisFactoryForDesktop();
            else
                coletorDeCredenciaisFactory = new ColetorDeCredenciaisFactoryForMobile();

            PasswordControl = coletorDeCredenciaisFactory.CreatePasswordControl();
            LeitorBiometrico = coletorDeCredenciaisFactory.CreateLeitorBiometrico();
        }
    }
}
