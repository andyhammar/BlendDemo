using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Web.Syndication;
using XamlDemoCommon.Services;

namespace XamlDemoCommon.ViewModels
{
    public class MainPageVm : VmBase
    {
        public string Title { get; set; }
        public IList<ItemVmi> Items { get; set; }

        public MainPageVm()
        {
            Title = "main page title";
        }

        public async Task InitAsync()
        {
            var feedItems = await new DataService().GetAsync();
            Items = feedItems.Select(CreateItemVmi).ToList();
        }

        private ItemVmi CreateItemVmi(SyndicationItem item)
        {
            return new ItemVmi
            {
                Title = item.Title.Text,
                Description = item.Content.Text,
                ImageUri = item.ItemUri.AbsoluteUri
            };
        }
    }
}
