using QLBHTranTheHaiDang.Common.DAL;
using QLBHTranTheHaiDang.Common.Rsp;
using QLBHTranTheHaiDang.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBHTranTheHaiDang.DAL
{
    public class ProductRep : GenericRep<NorthwindContext, Product>
    {
        public SingleRsp CreateProduct(Product product)
        {
            var res = new SingleRsp();
            using (var context = new NorthwindContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var p = context.Products.Add(product);
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;
        }

        public SingleRsp UpdateProduct(Product product)
        {
            var res = new SingleRsp();
            using (var context = new NorthwindContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var p = context.Products.Update(product);
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;
        }        
    }
}
