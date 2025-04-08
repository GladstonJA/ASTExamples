namespace DesignPatterns.GoF.Behavioral.Strategy.Antes
{
    public class Game
    {
        public bool IsDemoVersion { get; private set; }

        public void Play(bool isDemoVerion)
        {
            IsDemoVersion = isDemoVerion;
            _ = new Mario(this);
            /// ....
        }
    }
}
