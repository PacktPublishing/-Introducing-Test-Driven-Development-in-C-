namespace AbstractFactoryDesignPattern
{
    public class AdidasFactory : ISneakersFactory
    {
        public IBasketballSneaker GetBasketballSneaker()
        {
            return new AdidasDropTop();
        }

        public ISoccerSneaker GetSoccerSneaker()
        {
            return new AdidasACEPurecontrol();
        }
    }
}
