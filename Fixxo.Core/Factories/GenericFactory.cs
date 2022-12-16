namespace Fixxo.Core.Factories
{
    public static class GenericFactory
    {
        public static T Create<T>() where T : class, new ()
        {
            return new T();
        }
    }
}
