using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLBHTranTheHaiDang.BLL;
using QLBHTranTheHaiDang.Common.Req;
using QLBHTranTheHaiDang.Common.Rsp;

namespace QLBHTranTheHaiDang.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private CategorySrv categorySrv;
        public CategoryController()
        {
            categorySrv = new CategorySrv();
        }
        [HttpPost("get-by-id")]
        public IActionResult GetCateByID([FromBody]SimpleReq simpleReq)
        {
            SingleRsp rsp = categorySrv.Read(simpleReq.Id);
            return Ok(rsp);
        }
        [HttpPost("get-all-cate")]
        public IActionResult GetAllCate([FromBody] SimpleReq simpleReq)
        {
            SingleRsp rsp = categorySrv.Read(simpleReq.Id);
            rsp.Data = categorySrv.All;
            return Ok(rsp);
        }
    }
}
