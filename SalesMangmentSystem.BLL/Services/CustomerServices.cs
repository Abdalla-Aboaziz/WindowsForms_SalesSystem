using SalesMangmentSystem.DAL;
using SalesMangmentSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.BLL.Services
{
    public  class CustomerServices
    {
        // Get All Customer
        // Get Customer By Id
        // Add Customer
        // Update Customer
        // Delete Customer
        /*   public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public DateTime BirthData { get; set; }*/

         public static List<Customer> GetAllCustomers()
        {
            var dataTable = DataBaseHelper.ExcuteSelect("SELECT * FROM Customers");
            List<Customer> customers = new List<Customer>();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                customers.Add(new Customer
                {
                    ID = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    Address = row["Address"].ToString(),
                    Phone = row["PHONENUMBER"].ToString(),
                    BirthData = Convert.ToDateTime(row["BIRTHDATE"])
                });
            }
            return customers;
        }


    }
}
