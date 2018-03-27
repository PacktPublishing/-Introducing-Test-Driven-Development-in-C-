namespace AbstractFactoryDesignPattern
{
    public class NikeFactory : ISneakersFactory
    {
        public IBasketballSneaker GetBasketballSneaker()
        {
            return new NikeAirZoom();
        }

        public ISoccerSneaker GetSoccerSneaker()
        {
            return new NikeMercurialSuperfly();
        }
    }
}
