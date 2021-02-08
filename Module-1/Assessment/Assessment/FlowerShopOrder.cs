using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
     public class FlowerShopOrder
    {
        public string BouquetType { get; set; }

        public double NumberOfRoses { get; set; }

        public double SubTotal { get => SubTotal; set => SubTotal = (19.99 + (2.99 * NumberOfRoses)); }

        public FlowerShopOrder(string BouquetType, int NumberOfRoses)
        {
            this.BouquetType = BouquetType;
            this.NumberOfRoses = NumberOfRoses;
            this.SubTotal = SubTotal;

        }

        public decimal total (bool sameDayDelivery, string zipCode)
        {
            decimal total = 0;
            if (Convert.ToInt32(zipCode) >= 20000 && (Convert.ToInt32(zipCode) <= 29999))
            {
                 return total = (decimal)(SubTotal + 3.99);



            }

            else if(Convert.ToInt32(zipCode) >= 30000 && (Convert.ToInt32(zipCode) <= 39999))
            {
                return total = (decimal)(SubTotal + 6.99);
            }

            else if (Convert.ToInt32(zipCode) >= 10000 && (Convert.ToInt32(zipCode) <= 19999))
            {
                return total = ((decimal)SubTotal);
            }

            return total = (decimal)(SubTotal + 19.99);
        }


    }
}
