using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Web.Syndication;

namespace BlendDemoCommon.Services
{
    public class DataService
    {
        public async Task<IList<SyndicationItem>> GetAsync()
        {
            var client = new SyndicationClient();
            var feed = await client.RetrieveFeedAsync(new Uri("http://www.zdnet.com/topic-windows/rss.xml"));
            return feed.Items;
        }
    }
}
