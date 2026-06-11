using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.BLL.Dtos
{
    public  class StockReadDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SType { get; set; }
            public double TotalMoney { get; set; }
        public DateTime Date { get; set; }
        public int OrderID { get; set; }

    }
}
