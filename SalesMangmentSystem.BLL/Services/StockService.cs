using SalesMangmentSystem.BLL.Dtos;
using SalesMangmentSystem.DAL;
using SalesMangmentSystem.DAL.Models;
using System;
using System.Collections;
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

        public static string UpdateStockMoneyPlusGetCommand(Stock stock)
        {
            string command = $"UPDATE Stock SET TotalMoney = TotalMoney + {stock.TotalMoney} WHERE ID = {stock.ID}";
            return command;
        }

        // DeleteStock
        public static bool DeleteStock(int id)
        {
            bool Result = DataBaseHelper.ExcuteDML($"DELETE FROM Stocks WHERE ID = {id}");
            return Result;
        }
        public static List<Stock> GetAllStocks()
        {
            List<Stock> Stockes = new List<Stock>();
            var data = DataBaseHelper.ExcuteSelect("SELECT * FROM Stock");


            if (data != null && data.Rows.Count > 0)
            {
                foreach (System.Data.DataRow item in data.Rows)
                {
                    Stock stock = new Stock()
                    {
                        ID = Convert.ToInt32(item["ID"]),
                        Name = item["Name"].ToString(),
                        TotalMoney = Convert.ToDouble(item["TotalMoney"])
                    };
                    Stockes.Add(stock);
                }
            }
            return Stockes;
        }

        public static List<StockReadDto> GetAllSaleOrderDateRange(DateTime dateTime1, DateTime dateTime2)
        {
           
            var dataTable = DataBaseHelper.ExcuteSelect($@"
        SELECT 
            ST.ID, 
            ST.Name, 
            SD.Total AS TotalMoney, 
            SD.Type, 
            SD.OrderID, 
            SD.Date 
        FROM Stock AS ST
        INNER JOIN StockDetails AS SD ON ST.ID = SD.StockID
        WHERE SD.Date BETWEEN '{dateTime1:yyyy-MM-dd 00:00:00}' AND '{dateTime2:yyyy-MM-dd 23:59:59}'
    ");

            List<StockReadDto> stockReadDtos = new List<StockReadDto>();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (System.Data.DataRow item in dataTable.Rows)
                {
                    int typeValue = Convert.ToInt32(item["Type"]);

                    string typeNameAr = typeValue switch
                    {
                        0 => "مبيعات",
                        1 => "مشتريات",
                        2 => "مصروفات",
                        _ => "غير معروف"
                    };

                    StockReadDto stockReadDto = new StockReadDto()
                    {
                        ID = Convert.ToInt32(item["ID"]),
                        Name = item["Name"].ToString(),
                        TotalMoney = Convert.ToDouble(item["TotalMoney"]), 
                        SType = typeNameAr,
                        OrderID = item["OrderID"] != DBNull.Value ? Convert.ToInt32(item["OrderID"]) : 0,
                        Date = Convert.ToDateTime(item["Date"])
                    };
                    stockReadDtos.Add(stockReadDto);
                }
            }
            return stockReadDtos;
        }

        public static List<StockReadDto> GetStockDetailsByOrderID(int orderId)
        {
            string query = $@"
        SELECT 
            ST.ID, 
            ST.Name, 
            SD.Total AS TotalMoney, 
            SD.Type, 
            SD.OrderID, 
            SD.Date 
        FROM Stock AS ST
        INNER JOIN StockDetails AS SD ON ST.ID = SD.StockID
        WHERE SD.OrderID = {orderId}
    ";

            var dataTable = DataBaseHelper.ExcuteSelect(query);
            List<StockReadDto> stockReadDtos = new List<StockReadDto>();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (System.Data.DataRow item in dataTable.Rows)
                {
                    int typeValue = Convert.ToInt32(item["Type"]);

                    string typeNameAr = typeValue switch
                    {
                        0 => "مبيعات",
                        1 => "مشتريات",
                        2 => "مصروفات",
                        _ => "غير معروف"
                    };

                    StockReadDto stockReadDto = new StockReadDto()
                    {
                        ID = Convert.ToInt32(item["ID"]),
                        Name = item["Name"].ToString(),
                        TotalMoney = Convert.ToDouble(item["TotalMoney"]),
                        SType = typeNameAr,
                        OrderID = item["OrderID"] != DBNull.Value ? Convert.ToInt32(item["OrderID"]) : 0,
                        Date = Convert.ToDateTime(item["Date"])
                    };
                    stockReadDtos.Add(stockReadDto);
                }
            }
            return stockReadDtos;
        }

        public static List<StockReadDto> GetStockDetailsByType(int transactionType)
        {
            string query = $@"
        SELECT 
            ST.ID, 
            ST.Name, 
            SD.Total AS TotalMoney, 
            SD.Type, 
            SD.OrderID, 
            SD.Date 
        FROM Stock AS ST
        INNER JOIN StockDetails AS SD ON ST.ID = SD.StockID
        WHERE SD.Type = {transactionType}
    ";

            var dataTable = DataBaseHelper.ExcuteSelect(query);
            List<StockReadDto> stockReadDtos = new List<StockReadDto>();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (System.Data.DataRow item in dataTable.Rows)
                {
                    int typeValue = Convert.ToInt32(item["Type"]);

                    string typeNameAr = typeValue switch
                    {
                        0 => "مبيعات",
                        1 => "مشتريات",
                        2 => "مصروفات",
                        _ => "غير معروف"
                    };

                    StockReadDto stockReadDto = new StockReadDto()
                    {
                        ID = Convert.ToInt32(item["ID"]),
                        Name = item["Name"].ToString(),
                        TotalMoney = Convert.ToDouble(item["TotalMoney"]),
                        SType = typeNameAr,
                        OrderID = item["OrderID"] != DBNull.Value ? Convert.ToInt32(item["OrderID"]) : 0,
                        Date = Convert.ToDateTime(item["Date"])
                    };
                    stockReadDtos.Add(stockReadDto);
                }
            }
            return stockReadDtos;
        }
    }
    }
