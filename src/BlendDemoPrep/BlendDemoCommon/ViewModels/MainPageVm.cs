using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Web.Syndication;
using BlendDemoCommon.Services;

namespace BlendDemoCommon.ViewModels
{
    public class MainPageVm : VmBase
    {
        private static int _itemCount = 0;
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
            _itemCount++;
            var title = item.Title.Text;
            var description = item.Summary.Text;

            if (_itemCount == 2)
            {
                title = "shrt ttl";
                description = description.Substring(0, 5);
            }
            return new ItemVmi
            {
                Title = title,
                Description = description,
                Date = item.PublishedDate.ToString("HH:mm"),
                ImageUri = "https://fbcdn-profile-a.akamaihd.net/hprofile-ak-xap1/v/t1.0-1/p160x160/1380687_522238147867581_92872882_n.png?oh=604b2b67f73f586ba2a889c45a997380&oe=55173A47&__gda__=1423782905_bf9f5160c989cac21e9d699b24d2810d"
            };
        }
    }
}
