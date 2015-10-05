using System.ServiceModel;
using System.ServiceModel.Syndication;

namespace JServiceLayer
{
    [ServiceContract]
    public interface IRssFeed
    {
        SyndicationFeed GetRssFeedItems(string feedUrl);
    }
}
