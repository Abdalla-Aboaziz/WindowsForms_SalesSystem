using SalesMangmentSystem.DAL;
using SalesMangmentSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.BLL.Services
{
    public class StockService
    {
        /*   public int ID { get; set; }
        public string Name { get; set; }
        public double TotalMoney { get; set; }*/
        // UpdateStock
        public static bool UpdateStock(Stock Stock)
        {
            bool Result = DataBaseHelper.ExcuteDML($"UPDATE Stocks SET Name = N'{Stock.Name}', TotalMoney = {Stock.TotalMoney} WHERE ID = {Stock.ID}");
            return Result;
        }

        // UpdateStock
        public static bool UpdateStockMoneyMinus(Stock Stock)
        {
            bool Result = DataBaseHelper.ExcuteDML($"UPDATE Stocks SET TotalMoney = TotalMoney - {Stock.TotalMoney} WHERE ID = {Stock.ID}");
            return Result;
        }

        // UpdateStock
        public static bool UpdateStockMoneyPlus(Stock Stock)
        {
            bool Result = DataBaseHelper.ExcuteDML($"UPDATE Stocks SET TotalMoney = TotalMoney + {Stock.TotalMoney} WHERE ID = {Stock.ID}");
            return Result;
        }

        public static string UpdateStockMoneyPlusGetCommand(Stock Stock)
        {
            string command = $"UPDATE Stocks SET TotalMoney = TotalMoney + {Stock.TotalMoney} WHERE ID = {Stock.ID}";
            return command;
        }

        // DeleteStock
        public static bool DeleteStock(int id)
        {
            bool Result = DataBaseHelper.ExcuteDML($"DELETE FROM Stocks WHERE ID = {id}");
            return Result;
        }
    }
    }
