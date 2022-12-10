using QLBHTranTheHaiDang.Common.BLL;
using QLBHTranTheHaiDang.Common.Rsp;
using QLBHTranTheHaiDang.DAL;
using QLBHTranTheHaiDang.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLBHTranTheHaiDang.BLL
{
    public class CategorySrv: GenericSvc<CategoryRep, Category>
    {
        private CategoryRep categoryRep;
        public CategorySrv()
        {
            categoryRep = new CategoryRep();
        }
        public override SingleRsp Read(int id)
        {
            SingleRsp rsp = new SingleRsp();
            rsp.Data = categoryRep.Read(id);
            return rsp;
        }
    }
}
