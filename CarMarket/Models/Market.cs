using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Models
{
    public class Market
    {
        public int MarketId { get; set; }
        public string User { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }

        public int PhoneId { get; set; }
        public Cars Cars { get; set; }

    }
}
