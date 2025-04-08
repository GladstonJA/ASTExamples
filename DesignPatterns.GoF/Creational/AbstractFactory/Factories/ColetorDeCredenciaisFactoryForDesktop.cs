using DesignPatterns.GoF.Creational.AbstractFactory.Products.Biometria;
using DesignPatterns.GoF.Creational.AbstractFactory.Products.Senha;

namespace DesignPatterns.GoF.Creational.AbstractFactory.Factories
{
    public class ColetorDeCredenciaisFactoryForDesktop : ColetorDeCredenciaisFactory
    {
        public override LeitorBiometrico CreateLeitorBiometrico()
        {
            return new ReconhecimentoFacialPorWebCam();
        }

        public override PasswordControl CreatePasswordControl()
        {
            return new TecladoVirtual();
        }
    }
}
