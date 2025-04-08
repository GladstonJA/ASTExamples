namespace DesignPatterns.GoF.Behavioral.Strategy.Depois
{
    public class Game
    {
        public void Play(bool isDemoVerion)
        {
            IMarketingStrategy? marketingStrategy = isDemoVerion
                ? new DemoMarketingStrategy()
                : null;
            _ = new Mario(this, marketingStrategy);
            /// ....
        }
    }
}
