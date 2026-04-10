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
            var dt = DataBaseHelper.ExcuteSelect("SELECT TOP 1 ID FROM SALEORDERS ORDER BY ID DESC");
            return Convert.ToInt32(dt.Rows[0]["ID"]);
        }

    }
}
