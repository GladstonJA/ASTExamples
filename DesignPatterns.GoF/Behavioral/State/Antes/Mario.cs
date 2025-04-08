namespace DesignPatterns.GoF.Behavioral.State.Antes
{
    //HINT: Fonte original: https://www.ashishvishwakarma.com/GoF-Design-Patterns-by-Example/State-Pattern/
    public class Mario
    {
        private MarioState State = MarioState.SmallMario;

        public int LifeCount { get; private set; }

        public int CoinCount { get; private set; }

        public Mario()
        {
            LifeCount = 1;
            CoinCount = 0;
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

        public void GotCoins(int numberOfCoins)
        {
            CoinCount += numberOfCoins;
            if (CoinCount >= 5000)
            {
                GotLife();
                CoinCount -= 5000;
            }
        }

        private void GotLife()
        {
            LifeCount += 1;
        }

        private void LostLife()
        {
            LifeCount -= 1;
            if (LifeCount <= 0)
                GameOver();
        }

        public void MetMonster()
        {
            if (State == MarioState.SmallMario)
                LostLife();
            else
                State = MarioState.SmallMario;
        }

        public void GameOver()
        {
            LifeCount = 0;
            CoinCount = 0;
        }
    }
}
