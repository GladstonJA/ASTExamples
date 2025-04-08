using DesignPatterns.GoF.Creational.FactoryMethod.Factories;

namespace DesignPatterns.GoF.Creational.FactoryMethod
{
    public class DesktopClient : Client
    {
        protected override ColetorDeCredenciais BuildColetorDeCredenciais()
        {
            return new ColetorDeCredenciaisForDesktop();
        }
    }
}
