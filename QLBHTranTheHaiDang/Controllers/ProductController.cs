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
    public class ProductController : ControllerBase
    {
        ProductSrv productSrv;
        public ProductController() 
        {
            productSrv = new ProductSrv();
        }
        [HttpPost("create-product")]
        public IActionResult CreateProduct([FromBody] ProductReq productReq)
        {
            var res = new SingleRsp();
            res = productSrv.CreateProduct(productReq);
            return Ok(res);
        }
        [HttpPost("update-product")]
        public IActionResult UpdateProduct([FromBody] ProductReq productReq)
        {
            var res = new SingleRsp();
            res = productSrv.UpdateProduct(productReq);
            return Ok(res);
        }
    }
}
