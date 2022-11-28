using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Repositories.Entities
{
    internal class InvitedAdvertisment
    {
        public int InvitedAdvertismentId { get; set; }
        public PageType PageType { get; set; }
        public int PageTypeId{ get; set; }

        // public image Image { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }
        // public date InvitionDate { get; set; }

        // public date DestinationDate { get; set; }

        public FontSize FontSize { get; set; }
        public int FontSizeId { get; set; }

        public string Title1 { get; set; }
        public string Title2 { get; set; }
        //public xml ContentReportage { get; set; }

        public AdvertismentSize AdvertismentSize { get; set; }
        public int AdvertismentSizeId { get; set; }
    }
}
