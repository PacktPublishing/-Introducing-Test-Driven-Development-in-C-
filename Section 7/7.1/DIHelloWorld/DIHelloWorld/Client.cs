namespace DIHelloWorld
{
    public class Client
    {
        private readonly IWritter _writter;

        public Client(IWritter writter)
        {
            _writter = writter;
        }

        public void SayHello()
        {
            _writter.WriteHelloWorld();
        }
    }
}
