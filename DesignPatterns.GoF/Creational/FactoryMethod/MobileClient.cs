﻿using DesignPatterns.GoF.Creational.FactoryMethod.Factories;

namespace DesignPatterns.GoF.Creational.FactoryMethod
{
    public class MobileClient : Client
    {
        protected override ColetorDeCredenciais BuildColetorDeCredenciais()
        {
            return new ColetorDeCredenciaisForMobile();
        }
    }
}
