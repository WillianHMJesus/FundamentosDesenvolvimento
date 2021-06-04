namespace DesignPattern.Creational.Singleton
{
    public class Client
    {
        public void Execute()
        {
            var mongoClient = MongoClient.Instance();
        }
    }
}
