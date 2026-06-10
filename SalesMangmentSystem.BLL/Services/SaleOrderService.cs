using SalesMangmentSystem.BLL.Dtos;
using SalesMangmentSystem.DAL;
using SalesMangmentSystem.DAL.Models;

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

            return (int)(dt.Rows[0]["LASTORDERID"]);
        }

        public static bool InsertSaleOrderTransaction(SaleOrder saleOrder, List<SaleOrderProduct> saleOrderproducts, List<Product> products, Stock stock, StockDetails stockDetails)
        {
            List<string> commands = new List<string>();
            // Insert Sale Order
            string addSaleOrderCommand = SaleOrderService.AddSaleOrderGetCommand(saleOrder);
            commands.Add(addSaleOrderCommand);
            // Insert Sale Order Products
            string addSaleOrderProductsCommand = SaleOrderProductService.AddSaleOrderProductsGetCommand(saleOrderproducts);
            commands.Add(addSaleOrderProductsCommand);
            // Update Products Quantity Minus
            List<string> updateCommands = ProductService.UpdateProductMinusQuantityGetCommands(products);
            commands.AddRange(updateCommands);
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
            return $@"
            DECLARE @NewOrderID INT;
            INSERT INTO SaleOrders (CustomerID, DateOrder, TotalOrder)
            VALUES ({saleOrder.CustomerID}, '{saleOrder.DateOrder:yyyy-MM-dd HH:mm:ss}', {saleOrder.TotalOrder});
            SET @NewOrderID = SCOPE_IDENTITY();";
        }

        public static List<SaleOrderReadProductDto> GetAllSaleOrderDateRange(DateTime dateTime1, DateTime dateTime2)
        {
            var dataTable = DataBaseHelper.ExcuteSelect($@"
                SELECT
                SO.ID,
                C.Name AS CUSTOMERNAME,
                P.Name AS PRODUCTNAME,
                SOP.PRODUCTPRICE,
                SO.DATEORDER,
                SOP.PRODUCTQUANTITY,
                SOP.PRODUCTTOTALPRICE
                FROM
                SALEORDERS AS SO,
                CUSTOMERS AS C,
                PRODUCTS AS P,
                SALEORDERPRODUCTS AS SOP
                WHERE
                SO.CustomerID = C.ID AND
                P.ID = SOP.ProductID AND
                SOP.ORDERID = SO.ID AND
                SO.DATEORDER BETWEEN '{dateTime1:yyyy-MM-dd HH:mm:ss}' AND '{dateTime2:yyyy-MM-dd HH:mm:ss}'

            ");
            List<SaleOrderReadProductDto> saleOrders = new List<SaleOrderReadProductDto>();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                saleOrders.Add(new SaleOrderReadProductDto
                {
                    SaleOrderID = Convert.ToInt32(row["ID"]),
                    CustomerName = row["CUSTOMERNAME"].ToString(),
                    ProductName = row["PRODUCTNAME"].ToString(),
                    ProductPrice = Convert.ToDouble(row["PRODUCTPRICE"]),
                    ProductQuantity = Convert.ToDouble(row["PRODUCTQUANTITY"]),
                    ProductTotalPrice = Convert.ToDouble(row["PRODUCTTOTALPRICE"])
                });
            }
            return saleOrders;
        }

        public static List<SaleOrderReadProductDto> GetAllSaleOrderWithProducts(string customerName, int orderID)
        {
            string whereClause = "";

            if (orderID > 0)
                whereClause = $"WHERE SO.ID = {orderID}";
            else if (!string.IsNullOrEmpty(customerName))
                whereClause = $"WHERE C.NAME LIKE '%{customerName}%'";

            var dataTable = DataBaseHelper.ExcuteSelect($@"
        SELECT 
            SO.ID,
            C.NAME AS CUSTOMERNAME,
            P.NAME AS PRODUCTNAME,
            SOP.PRODUCTPRICE,
            SOP.PRODUCTQUANTITY,
            SOP.PRODUCTTOTALPRICE
        FROM SALEORDERS SO
        JOIN CUSTOMERS C ON SO.CUSTOMERID = C.ID
        JOIN SALEORDERPRODUCTS SOP ON SOP.ORDERID = SO.ID
        JOIN PRODUCTS P ON P.ID = SOP.PRODUCTID
        {whereClause}
    ");

            List<SaleOrderReadProductDto> SaleOrders = new List<SaleOrderReadProductDto>();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                SaleOrders.Add(new SaleOrderReadProductDto
                {
                    SaleOrderID = Convert.ToInt32(row["ID"]),
                    CustomerName = row["CUSTOMERNAME"].ToString(),
                    ProductName = row["PRODUCTNAME"].ToString(),
                    ProductPrice = Convert.ToDouble(row["PRODUCTPRICE"]),
                    ProductQuantity = Convert.ToDouble(row["PRODUCTQUANTITY"]),
                    ProductTotalPrice = Convert.ToDouble(row["PRODUCTTOTALPRICE"])
                });
            }
            return SaleOrders;
        }
    }
}
