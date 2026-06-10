using SalesMangmentSystem.DAL;
using SalesMangmentSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.BLL.Services
{
    /* public double ProductPrice { get; set; }
        public double ProductQuantity { get; set; }
        public double ProductTotalPrice { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SaleOrderID { get; set; }
    */
    public class SaleOrderProductService
    {
        public static List<SaleOrderProduct> GetByOrderId(int orderID)
        {
            var dt = DataBaseHelper.ExcuteSelect($@"
            SELECT 
                sop.ORDERID       AS SaleOrderID,
                sop.PRODUCTID,
                p.NAME            AS ProductName,
                sop.PRODUCTPRICE      AS ProductPrice,
                sop.PRODUCTQUANTITY   AS ProductQuantity,
                sop.PRODUCTTOTALPRICE AS ProductTotalPrice
            FROM SALEORDERPRODUCTS sop
            INNER JOIN PRODUCTS p ON sop.PRODUCTID = p.ID
            WHERE sop.ORDERID = {orderID}
             ");

            var list = new List<SaleOrderProduct>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new SaleOrderProduct
                {
                    SaleOrderID = Convert.ToInt32(row["SaleOrderID"]),
                    ProductID = Convert.ToInt32(row["ProductID"]),
                    ProductName = row["ProductName"].ToString(),
                    ProductPrice = Convert.ToDouble(row["ProductPrice"]),
                    ProductQuantity = Convert.ToDouble(row["ProductQuantity"]),
                    ProductTotalPrice = Convert.ToDouble(row["ProductTotalPrice"])
                });
            }
            return list;
        }
        //    public static bool AddOrderProduct(SaleOrderProduct item)
        //    {
        //        return DataBaseHelper.ExcuteDML($@"
        //                                        INSERT INTO SALEORDERPRODUCTS 
        //                                            (ORDERID, PRODUCTID, PRODUCTPRICE, PRODUCTQUANTITY, PRODUCTTOTALPRICE)
        //                                        VALUES 
        //                                            ({item.SaleOrderID}, {item.ProductID}, {item.ProductPrice}, 
        //                                             {item.ProductQuantity}, {item.ProductTotalPrice})
        //                                         ");
        //    }
        //    public static bool DeleteByOrderId(int orderID)
        //    {
        //        return DataBaseHelper.ExcuteDML($"DELETE FROM SALEORDERPRODUCTS WHERE ORDERID = {orderID}");
        //    }
        //    public static bool UpdateByOrderId(SaleOrderProduct item)
        //    {
        //        return DataBaseHelper.ExcuteDML($@"
        //    UPDATE SALEORDERPRODUCTS SET
        //        PRODUCTID = {item.ProductID},
        //        PRODUCTPRICE = {item.ProductPrice},
        //        PRODUCTQUANTITY = {item.ProductQuantity},
        //        PRODUCTTOTALPRICE = {item.ProductTotalPrice}
        //    WHERE ORDERID = {item.SaleOrderID}
        //");
        //    }


        public static bool AddSaleOrderProducts(List<SaleOrderProduct> saleOrderproducts)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var product in saleOrderproducts)
            {
                stringBuilder.Append($"({product.SaleOrderID}, {product.ProductID}, {product.ProductPrice}, " +
                    $"{product.ProductQuantity}, {product.ProductTotalPrice}),");

            }
            string command=stringBuilder.ToString().TrimEnd(',');
            string cmd=$"INSERT INTO SALEORDERPRODUCTS (ORDERID, PRODUCTID, PRODUCTPRICE, PRODUCTQUANTITY, PRODUCTTOTALPRICE) VALUES {command}";
            bool result = DataBaseHelper.ExcuteDML(cmd);
            return result;
        }

        public static string AddSaleOrderProductsGetCommand(List<SaleOrderProduct> products)
        {
            var values = products.Select(p =>
                $"(@NewOrderID, {p.ProductID}, {p.ProductPrice}, {p.ProductQuantity}, {p.ProductTotalPrice})");

            return "INSERT INTO SALEORDERPRODUCTS (ORDERID, PRODUCTID, PRODUCTPRICE, PRODUCTQUANTITY, PRODUCTTOTALPRICE) VALUES "
                   + string.Join(",", values) + ";";
        }


    }
     
    }





