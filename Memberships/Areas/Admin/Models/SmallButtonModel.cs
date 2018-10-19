using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Memberships.Areas.Admin.Models
{
    public class SmallButtonModel
    {
        public string Action { get; set; }
        public string Text { get; set; }
        public string Glyph { get; set; }
        public string ButtonType { get; set; }
        public int? ID { get; set; }
        public int? ItemID { get; set; }
        public int? ProductID { get; set; }
        public int? SubscriptionID { get; set; }
        public string ActionParameters
        {
            get
            {
                var param = new StringBuilder("?");
                if (ID != null && ID > 0)
                    param.Append(String.Format("{0}={1}&", "Id", ID));

                if (ItemID != null && ItemID > 0)
                    param.Append(String.Format("{0}={1}&", "ItemID", ItemID));

                if (ProductID != null & ProductID > 0)
                    param.Append(String.Format("{0}={1}&", "ProductId", ProductID));

                if (SubscriptionID != null && SubscriptionID > 0)
                    param.Append(String.Format("{0}={1}&", "SuscriptionId", SubscriptionID));

                return param.ToString().Substring(0, param.Length - 1);
            }
        }
    }
}