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
    public class ProductSrv : GenericSvc<ProductRep, Product>
    {
        ProductRep productRep;
        public ProductSrv()
        {
            productRep = new ProductRep();
        }
        public SingleRsp CreateProduct(ProductReq productReq)
        {
            var res = new SingleRsp();
            Product product = new Product();
            product.ProductId = productReq.ProductId;
            product.ProductName = productReq.ProductName;
            product.SupplierId = productReq.SupplierId;
            product.CategoryId = productReq.CategoryId;
            product.QuantityPerUnit = productReq.QuantityPerUnit;
            product.UnitPrice = productReq.UnitPrice;
            product.UnitsInStock = productReq.UnitsInStock;
            product.ReorderLevel = productReq.ReorderLevel;
            product.Discontinued = productReq.Discontinued;
            res = productRep.CreateProduct(product);
            return res;
        }
        public SingleRsp UpdateProduct(ProductReq productReq)
        {
            var res = new SingleRsp();
            Product product = new Product();
            product.ProductId = productReq.ProductId;
            product.ProductName = productReq.ProductName;
            product.SupplierId = productReq.SupplierId;
            product.CategoryId = productReq.CategoryId;
            product.QuantityPerUnit = productReq.QuantityPerUnit;
            product.UnitPrice = productReq.UnitPrice;
            product.UnitsInStock = productReq.UnitsInStock;
            product.ReorderLevel = productReq.ReorderLevel;
            product.Discontinued = productReq.Discontinued;
            res = productRep.UpdateProduct(product);
            return res;
        }      
    }
}
