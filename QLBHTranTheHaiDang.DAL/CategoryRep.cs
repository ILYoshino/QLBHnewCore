using System;
using System.Collections.Generic;
using System.Text;
using QLBHTranTheHaiDang.DAL.Models;
using QLBHTranTheHaiDang.Common.DAL;
using System.Linq;

namespace QLBHTranTheHaiDang.DAL
{
    public class CategoryRep: GenericRep<NorthwindContext, Category>
    {
        public override Category Read(int id)
        {
            var s = All.FirstOrDefault(c => c.CategoryId == id);
            return s;
        }
    }
}
