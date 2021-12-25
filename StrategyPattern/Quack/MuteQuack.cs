namespace StrategyPattern.Quack
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            throw new NotImplementedException();
        }
    }
}