namespace DesignPatterns.GoF.Behavioral.State.Depois
{
    //HINT: Fonte original: https://www.ashishvishwakarma.com/GoF-Design-Patterns-by-Example/State-Pattern/
    public class SmallMario : IState
    {
        private readonly Mario _mario;

        public SmallMario(Mario mario)
        {
            this._mario = mario;
        }

        public void GotMushroom()
        {
            _mario._state = _mario.GetState("superMario");
            _mario.GotCoins(100);
        }

        public void GotFireFlower()
        {
            _mario._state = _mario.GetState("fireMario");
            _mario.GotCoins(200);
        }

        public void GotFeather()
        {
            _mario._state = _mario.GetState("capeMario");
            _mario.GotCoins(300);
        }

        public void MetMonster()
        {
            _mario._state = _mario.GetState("smallMario");
            _mario.LostLife();
        }
    }
}
