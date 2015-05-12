using Board.Contract;
using System.ServiceModel;

namespace Board.Client
{
    public class ServiceFactory : Board.Client.IServiceFactory
    {
        private readonly string _uri;

        public ServiceFactory(string uri)
        {
            _uri = uri;
        }

        public IBoardService GetService()
        {
            return null;
        } 
    }
}
