using System;
using System.ServiceModel.Syndication;
using System.Xml;

namespace JServiceLayer
{
    public class RssFeed : IRssFeed
    {
        public SyndicationFeed GetRssFeedItems(string feedUrl)
        {
            XmlReader reader = XmlReader.Create(feedUrl);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            return feed;
        }
    }
}
