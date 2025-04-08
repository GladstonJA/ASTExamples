namespace DesignPatterns.GoF.Behavioral.State.Depois
{
    //HINT: Fonte original: https://www.ashishvishwakarma.com/GoF-Design-Patterns-by-Example/State-Pattern/
    public class CapeMario : IState
    {
        private readonly Mario _mario;

        public CapeMario(Mario mario)
        {
            this._mario = mario;
        }

        public void GotMushroom()
        {
            _mario.GotCoins(100);
        }

        public void GotFireFlower()
        {
            _mario._state = _mario.GetState("fireMario");
            _mario.GotCoins(200);
        }

        public void GotFeather()
        {
            _mario.GotCoins(300);
        }

        public void MetMonster()
        {
            _mario._state = _mario.GetState("smallMario");
        }
    }
}
