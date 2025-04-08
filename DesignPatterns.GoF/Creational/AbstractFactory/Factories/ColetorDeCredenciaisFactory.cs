using DesignPatterns.GoF.Creational.AbstractFactory.Products.Biometria;
using DesignPatterns.GoF.Creational.AbstractFactory.Products.Senha;

namespace DesignPatterns.GoF.Creational.AbstractFactory.Factories
{
    public abstract class ColetorDeCredenciaisFactory
    {
        public abstract LeitorBiometrico CreateLeitorBiometrico();

        public abstract PasswordControl CreatePasswordControl();
    }
}
