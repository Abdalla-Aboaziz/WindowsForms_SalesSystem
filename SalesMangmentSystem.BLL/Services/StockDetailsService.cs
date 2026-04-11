using SalesMangmentSystem.DAL;
using SalesMangmentSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.BLL.Services
{
    public class StockDetailsService
    {

        public static bool AddStockDetails(StockDetails StockDetails)
        {
            bool Result = DataBaseHelper.ExcuteDML($"INSERT INTO StockDetails (STOCKID, TYPE, TOTAL, DATE, ORDERID) VALUES ({StockDetails.StockID}, {(int)StockDetails.Type}, {StockDetails.Total}, '{StockDetails.Date:yyyy-MM-dd HH:mm:ss}', {StockDetails.SaleOrderID})");
            return Result;
        }

        public static string AddStockDetailsGetCommand(StockDetails StockDetails)
        {
            string command = $"INSERT INTO StockDetails (STOCKID, TYPE, TOTAL, DATE, ORDERID) VALUES ({StockDetails.StockID}, {(int)StockDetails.Type}, {StockDetails.Total}, '{StockDetails.Date:yyyy-MM-dd HH:mm:ss}', {StockDetails.SaleOrderID})";
            return command;
        }

        // DeleteStockDetails
        public static bool DeleteStockDetails(int id)
        {
            bool Result = DataBaseHelper.ExcuteDML($"DELETE FROM StockDetails WHERE ID = {id}");
            return Result;
        }
    }
}
