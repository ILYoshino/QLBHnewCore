using QLBHTranTheHaiDang.Common.BLL;
using QLBHTranTheHaiDang.Common.Req;
using QLBHTranTheHaiDang.Common.Rsp;
using QLBHTranTheHaiDang.DAL;
using QLBHTranTheHaiDang.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLBHTranTheHaiDang.BLL
{
    public class OrderSrv : GenericSvc<OrderRep, Order>
    {
        private OrderRep orderRep;
        public OrderSrv()
        {
            orderRep = new OrderRep();
        }
        public override SingleRsp Read(string id)
        {
            SingleRsp rsp = new SingleRsp();
            rsp.Data = orderRep.Read(id);
            return rsp;
        }
    }
}
