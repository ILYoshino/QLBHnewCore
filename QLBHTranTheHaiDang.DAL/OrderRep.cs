using QLBHTranTheHaiDang.Common.DAL;
using QLBHTranTheHaiDang.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBHTranTheHaiDang.DAL
{
    public class OrderRep : GenericRep<NorthwindContext, Order>
    {
        public override Order Read(string id)
        {
            var s = All.FirstOrDefault(c => c.CustomerId == id);
            return s;
        }
    }
}
