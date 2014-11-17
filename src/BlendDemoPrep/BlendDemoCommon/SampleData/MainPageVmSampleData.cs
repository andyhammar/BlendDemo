using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Web.Syndication;
using BlendDemoCommon.Services;
using BlendDemoCommon.ViewModels;

namespace BlendDemoCommon.SampleData
{
    public class MainPageVmSampleData : MainPageVm
    {
        private static int _itemCount;

        public MainPageVmSampleData()
        {
            Title = "sampledata main page title";
            Items = new ItemVmi[]
            {
                CreateItemVmi("news item 1", "short text"),
                CreateItemVmi("news item 2", "Bacon ipsum dolor amet salami sirloin picanha strip steak shank turkey. Meatloaf ground round bacon, pancetta sausage prosciutto biltong pig ham hock leberkas turkey. Beef ribs chicken short ribs jowl leberkas sirloin frankfurter salami venison hamburger jerky. Swine bacon ribeye jerky, strip steak salami turkey ham hock sirloin. Chuck pig strip steak, pork loin cow ham hock bacon meatball frankfurter ground round. Spare ribs pork loin beef beef ribs venison. Bresaola landjaeger hamburger rump alcatra pork chop pork loin pig tri-tip drumstick brisket pastrami venison."),
                CreateItemVmi("news item with very veeeeeeeeeeery long title ", "short text"),
                CreateItemVmi("news item 4", "short text"),
                CreateItemVmi("news item 5", "short text"),
            };
        }

        private ItemVmi CreateItemVmi(string title, string description)
        {
            _itemCount++;
            var imageUri = _itemCount % 2 == 0 ?
                "https://fbcdn-profile-a.akamaihd.net/hprofile-ak-xap1/v/t1.0-1/p160x160/1380687_522238147867581_92872882_n.png?oh=604b2b67f73f586ba2a889c45a997380&oe=55173A47&__gda__=1423782905_bf9f5160c989cac21e9d699b24d2810d" :
                "http://filmfork-cdn.s3.amazonaws.com/content/TopGun1.jpg";

            return new ItemVmi
            {
                Title = title,
                Description = description,
                ImageUri = imageUri,
                Date = DateTime.Now.ToString("t")
            };
        }
    }
}
