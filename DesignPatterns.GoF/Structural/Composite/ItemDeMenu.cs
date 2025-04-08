using System.Drawing;

namespace DesignPatterns.GoF.Structural.Composite
{
    public class ItemDeMenu : Menu
    {
        public Icon Icone { get; set; }

        public override void Draw()
        {
        }

        public override void Executar()
        {
            throw new NotImplementedException();
        }
    }
}
