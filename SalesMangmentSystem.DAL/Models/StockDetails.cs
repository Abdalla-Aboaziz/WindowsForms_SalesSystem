using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.DAL.Models
{
    public enum Type
    {
        Sale,
        Purchase,
        Expenses
    }
    public class StockDetails
    {
        public int ID { get; set; }
        public int StockID { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public Type Type { get; set; }
        public int SaleOrderID { get; set; }

    }
}
