using DesignPatterns.GoF.Creational.AbstractFactory.Products.Biometria;
using DesignPatterns.GoF.Creational.AbstractFactory.Products.Senha;

namespace DesignPatterns.GoF.Creational.AbstractFactory.Factories
{
    public class ColetorDeCredenciaisFactoryForMobile : ColetorDeCredenciaisFactory
    {
        public override LeitorBiometrico CreateLeitorBiometrico()
        {
            return new FingerPrintReader();
        }

        public override PasswordControl CreatePasswordControl()
        {
            return new PasswordTextBox();
        }
    }
}
