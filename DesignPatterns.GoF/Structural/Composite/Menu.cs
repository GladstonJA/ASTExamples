﻿namespace DesignPatterns.GoF.Structural.Composite
{
    public abstract class Menu
    {
        public string Texto { get; set; }

        public abstract void Executar();

        public abstract void Draw();

        public virtual void Add(Menu menu) { }

        public virtual void Remove(Menu menu) { }

        public virtual Menu GetChild(int menu)
        {
            return null;
        }
    }
}
