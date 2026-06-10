using SalesMangmentSystem.BLL.Dtos;
using SalesMangmentSystem.DAL;
using SalesMangmentSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.BLL.Services
{
    public class CustomerServices
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

        public static List<CustomerReadBasicDto> GetAllBasicCustomer()
        {
            var dataTable = DataBaseHelper.ExcuteSelect("SELECT ID, Name FROM Customers");
            List<CustomerReadBasicDto> customers = new List<CustomerReadBasicDto>();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                customers.Add(new CustomerReadBasicDto
                {
                    ID = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                });
            }
            return customers;

        }



        public static List<Customer> GetAllCustomersbyPattern(string pattern)
        {
            var dataTable = DataBaseHelper.ExcuteSelect($@"
        SELECT * FROM Customers 
        WHERE Name LIKE N'%{pattern}%' 
        OR PHONENUMBER LIKE N'%{pattern}%' 
        OR Address LIKE N'%{pattern}%' 
        OR YEAR(BIRTHDATE) LIKE N'%{pattern}%'
    ");

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

        public static Customer GetCustomerById(int id)
        {
            var dataTable = DataBaseHelper.ExcuteSelect($"SELECT * FROM Customers WHERE Id = {id}");
            if (dataTable.Rows.Count > 0)
            {
                var row = dataTable.Rows[0];
                return new Customer
                {
                    ID = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),

                };
            }
            return null;
        }
        public static bool AddCustomer(Customer customer)
        {
            bool result = DataBaseHelper.ExcuteDML($@"
        INSERT INTO Customers (Name, Address, PHONENUMBER, BIRTHDATE) 
        VALUES (N'{customer.Name}', N'{customer.Address}', N'{customer.Phone}', '{customer.BirthData:yyyy-MM-dd}')
    ");
            return result;
        }

        public static bool UpdateCustomer(Customer customer)
        {
            bool result = DataBaseHelper.ExcuteDML($@"
        UPDATE Customers 
        SET Name = N'{customer.Name}', 
            Address = N'{customer.Address}', 
            PHONENUMBER = N'{customer.Phone}', 
            BIRTHDATE = '{customer.BirthData:yyyy-MM-dd}' 
        WHERE Id = {customer.ID}
    ");
            return result;
        }
        public static bool DeleteCustomer(int id)
        {
            bool result = DataBaseHelper.ExcuteDML($"DELETE FROM Customers WHERE Id = {id}");
            return result;
        }
        public static bool DeleteAllCustomer()
        {
            bool result = DataBaseHelper.ExcuteDML($"DELETE FROM Customers");
            return result;
        }
            
        }
    }

