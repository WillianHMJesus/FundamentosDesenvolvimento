namespace DesignPattern.Creational.Singleton
{
    public class MongoClient
    {
        private static MongoClient _instance;

        public static MongoClient Instance()
        {
            if(_instance == null)
            {
                _instance = new MongoClient();
            }

            return _instance;
        }
    }
}
