namespace DesignPatterns.GoF.Behavioral.State.Depois
{
    //HINT: Fonte original: https://www.ashishvishwakarma.com/GoF-Design-Patterns-by-Example/State-Pattern/
    public class Mario
    {
        public int LifeCount { get; private set; }

        public int CoinCount { get; private set; }

        public IState _state;

        private readonly SmallMario _smallMario;
        private readonly SuperMario superMario;
        private readonly FireMario fireMario;
        private readonly CapeMario capeMario;

        public Mario()
        {
            LifeCount = 1;
            CoinCount = 0;

            _smallMario = new SmallMario(this);
            superMario = new SuperMario(this);
            fireMario = new FireMario(this);
            capeMario = new CapeMario(this);

            _state = _smallMario;
        }

        public IState GetState(string stateId)
        {
            switch (stateId)
            {
                case "superMario":
                    return superMario;
                case "fireMario":
                    return fireMario;
                case "capeMario":
                    return capeMario;
                default:
                    return _smallMario;
            }
        }

        public void GotMushroom()
        {
            _state.GotMushroom();
        }

        public void GotFireFlower()
        {
            _state.GotFireFlower();
        }

        public void GotFeather()
        {
            _state.GotFeather();
        }

        public void MetMonster()
        {
            _state.MetMonster();
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

        public void GotLife()
        {
            LifeCount += 1;
        }

        public void LostLife()
        {
            LifeCount -= 1;
            if (LifeCount <= 0)
                GameOver();
        }

        public void GameOver()
        {
            LifeCount = 0;
            CoinCount = 0;
        }
    }
}
