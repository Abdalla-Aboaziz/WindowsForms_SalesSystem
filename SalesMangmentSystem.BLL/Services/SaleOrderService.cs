using SalesMangmentSystem.DAL;
using SalesMangmentSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.BLL.Services
{
    /* public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime DateOrder { get; set; }
        public double TotalOrder { get; set; }
    */
    public class SaleOrderService
    {
        // Add Sale Order
        // Delete Sale Order

        public static bool AddSaleOrder(SaleOrder saleOrder)
        {
            bool result = DataBaseHelper.ExcuteDML($"INSERT INTO SaleOrders (CustomerID, DateOrder, TotalOrder) VALUES ({saleOrder.CustomerID}, '{saleOrder.DateOrder}', {saleOrder.TotalOrder})");
            return result;
        }
        public static bool DeleteSaleOrder(int id)
        {
            bool result = DataBaseHelper.ExcuteDML($"DELETE FROM SaleOrders WHERE Id = {id}");
            return result;
         }

        public static List<SaleOrder> GetAllSaleOrders()
        {
            var dataTable = DataBaseHelper.ExcuteSelect("SELECT * FROM SaleOrders");
            List<SaleOrder> saleOrders = new List<SaleOrder>();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                saleOrders.Add(new SaleOrder
                {
                    ID = Convert.ToInt32(row["Id"]),
                    CustomerID = Convert.ToInt32(row["CustomerID"]),
                    DateOrder = Convert.ToDateTime(row["DateOrder"]),
                    TotalOrder = Convert.ToDouble(row["TotalOrder"])
                });
            }
            return saleOrders;
        }
        // Save Sale Order
        public static bool SaveSaleOrder(SaleOrder saleOrder)
        {
            bool result = DataBaseHelper.ExcuteDML($"UPDATE SaleOrders SET CustomerID = {saleOrder.CustomerID}, DateOrder = '{saleOrder.DateOrder:yyyy-MM-dd HH:mm:ss}', TotalOrder = {saleOrder.TotalOrder} WHERE Id = {saleOrder.ID}");
            return result;
        }

        public static int GetLastInsertedID()
        {
            var dt = DataBaseHelper.ExcuteSelect("SELECT ISNULL(MAX(ID),0) AS LASTORDERID FROM SALEORDERS");
      
            return Convert.ToInt32(dt.Rows[0]["LASTORDERID"]);
        }

        public static bool InsertSaleOrderTransaction(SaleOrder saleOrder, List<SaleOrderProduct> saleOrderproducts, List<Product> products, Stock stock, StockDetails stockDetails)
        {
            List<string> commands = new List<string>();
            // Insert Sale Order
            string addSaleOrderCommand= SaleOrderService.AddSaleOrderGetCommand(saleOrder);
            commands.Add(addSaleOrderCommand);
            // Insert Sale Order Products
            string addSaleOrderProductsCommand = SaleOrderProductService.AddSaleOrderProductsGetCommand(saleOrderproducts);
            commands.Add(addSaleOrderProductsCommand);
            // Update Products Quantity Minus
            string updateProductMinusQuantityCommand = ProductService.UpdateProductMinusQuantityGetCommand(products);
            commands.Add(updateProductMinusQuantityCommand);
            // Update Stock Plus Money
            string updateStockPlusMoneyCommand = StockService.UpdateStockMoneyPlusGetCommand(stock);
            commands.Add(updateStockPlusMoneyCommand);
            // Insert Stock Details
            string insertStockDetailsCommand = StockDetailsService.AddStockDetailsGetCommand(stockDetails);
            commands.Add(insertStockDetailsCommand);

            bool result = DataBaseHelper.ExcuteTransaction(commands);
            return result;
        }

        private static string AddSaleOrderGetCommand(SaleOrder saleOrder)
        {
            string command = $"INSERT INTO SaleOrders (CustomerID, DateOrder, TotalOrder) VALUES ({saleOrder.CustomerID}, '{saleOrder.DateOrder:yyyy-MM-dd HH:mm:ss}', {saleOrder.TotalOrder})";
            return command;
        }
    }
}
