using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.DAL.Models
{
    public class SaleOrder
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime DateOrder { get; set; }
        public double TotalOrder { get; set; }

    }
}
