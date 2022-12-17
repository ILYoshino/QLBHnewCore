using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLBHTranTheHaiDang.BLL;
using QLBHTranTheHaiDang.Common.Req;
using QLBHTranTheHaiDang.Common.Rsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBHTranTheHaiDang.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private OrderSrv orderSrv;
        public OrderController()
        {
            orderSrv = new OrderSrv();
        }
        [HttpPost("get-by-id")]
        public IActionResult GetCustomerByID([FromBody] SimpleReq simpleReq)
        {
            SingleRsp rsp = orderSrv.Read(simpleReq.Keyword);
            rsp.Data = orderSrv.All.Where(c => c.CustomerId == simpleReq.Keyword);
            return Ok(rsp);
        }
        [HttpPost("get-all-Order")]
        public IActionResult GetAllOrder([FromBody] SimpleReq simpleReq)
        {
            SingleRsp rsp = orderSrv.Read(simpleReq.Id);
            rsp.Data = orderSrv.All;
            return Ok(rsp);
        }
    }
}
