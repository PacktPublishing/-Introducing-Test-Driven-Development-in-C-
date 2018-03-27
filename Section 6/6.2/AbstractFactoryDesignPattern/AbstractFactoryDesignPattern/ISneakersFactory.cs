namespace AbstractFactoryDesignPattern
{
    public interface ISneakersFactory
    {
        IBasketballSneaker GetBasketballSneaker();
        ISoccerSneaker GetSoccerSneaker();
    }
}
