namespace CleanArchitecture.Application.Common.Interfaces.Public
{
    public interface IRedisManager
    {
        Task Create<T>(string key, T data, TimeSpan? exTime = null, TimeSpan? unUseExTime = null);
        Task<T> Get<T>(string key);
        Task DeleteKeysForRequest(string endOfClass);
    }
    public class Redis : IRedisManager
    {
        public Task Create<T>(string key, T data, TimeSpan? exTime = null, TimeSpan? unUseExTime = null)
        {
            return null;
        }

        public Task DeleteKeysForRequest(string endOfClass)
        {
            return null;
        }

        public Task<T> Get<T>(string key)
        {
            return null;
        }
    }
}