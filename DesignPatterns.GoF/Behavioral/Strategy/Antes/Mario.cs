using DesignPatterns.GoF.Behavioral.State;

namespace DesignPatterns.GoF.Behavioral.Strategy.Antes
{
    //HINT: Fonte original: https://www.ashishvishwakarma.com/GoF-Design-Patterns-by-Example/State-Pattern/
    public class Mario
    {
        private MarioState State = MarioState.SmallMario;

        public Game Game { get; private set; }

        public int LifeCount { get; private set; }

        public int CoinCount { get; private set; }

        public Mario(Game game)
        {
            Game = game;
            LifeCount = 1;
            CoinCount = 0;
        }

        private void ShowPropagandaDeDemonstracao()
        {
            if (Game.IsDemoVersion)
            {
                // Exibe popup de propaganda
            }
        }

        public void GameOver()
        {
            ShowPropagandaDeDemonstracao();
            LifeCount = 0;
            CoinCount = 0;
        }

        private void LostLife()
        {
            LifeCount -= 1;
            if (LifeCount <= 0)
                GameOver();
            else if (LifeCount <= 5)
                ShowPropagandaDeDemonstracao();
        }

        public void MetMonster()
        {
            if (State == MarioState.SmallMario)
                LostLife();
            else
            {
                State = MarioState.SmallMario;
                ShowPropagandaDeDemonstracao();
            }
        }

        public void GotCoins(int numberOfCoins)
        {
            CoinCount += numberOfCoins;
            if (CoinCount >= 5000)
            {
                GotLife();
                CoinCount -= 5000;
            }
        }

        public void GotMushroom()
        {
            if (State == MarioState.SmallMario)
                State = MarioState.SuperMario;

            GotCoins(100);
        }

        public void GotFireFlower()
        {
            State = MarioState.FireMario;
            GotCoins(200);
        }

        public void GotFeather()
        {
            State = MarioState.CapeMario;
            GotCoins(300);
        }

        private void GotLife()
        {
            LifeCount += 1;
        }
    }
}
