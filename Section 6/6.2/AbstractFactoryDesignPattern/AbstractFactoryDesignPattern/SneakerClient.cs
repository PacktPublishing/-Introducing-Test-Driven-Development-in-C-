namespace AbstractFactoryDesignPattern
{
    public class SneakerClient
    {
        private IBasketballSneaker _basketballSneaker;
        private ISoccerSneaker _soccerSneaker;

        public SneakerClient(ISneakersFactory factory)
        {
            _basketballSneaker = factory.GetBasketballSneaker();
            _soccerSneaker = factory.GetSoccerSneaker();
        }

        public int GetBascketballSneakersPrice()
        {
            return _basketballSneaker.GetPrice();
        }

        public int GetSoccerSneakersPrice()
        {
            return _soccerSneaker.GetPrice();
        }
    }
}
