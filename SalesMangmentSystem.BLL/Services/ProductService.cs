
using SalesMangmentSystem.DAL;
using SalesMangmentSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.BLL.Services
{
    public static class ProductService
    {
        // Get All Products
        // Get Product By Id
        // Add Product
        // Update Product
        // Delete Product

        public static List<Product> GetAllProducts()
        {
            var dataTable = DataBaseHelper.ExcuteSelect("SELECT * FROM Products");
            List<Product> products = new List<Product>();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                products.Add(new Product
                {
                    ID = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    BuyPrice = Convert.ToDouble(row["BuyPrice"]),
                    SalePrice = Convert.ToDouble(row["SalePrice"]),
                    Quantity = Convert.ToDouble(row["Quantity"]),
                    CategoryID = Convert.ToInt32(row["CATEGORY"])
                });
            }
            return products;
        }
        public static List<Product> GetAllProductsbyPattern(string pattern)
        {
            var dataTable = DataBaseHelper.ExcuteSelect($"SELECT * FROM Products where Name Like N'%{pattern}%' or BuyPrice Like N'%{pattern}%' or SalePrice Like N'%{pattern}%' or Quantity Like N'%{pattern}%'");
            List<Product> Products = new List<Product>();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                Products.Add(new Product
                {
                    ID = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    BuyPrice = Convert.ToDouble(row["BuyPrice"]),
                    SalePrice = Convert.ToDouble(row["SalePrice"]),
                    Quantity = Convert.ToDouble(row["Quantity"]),
                    CategoryID = Convert.ToInt32(row["CATEGORY"])

                });
            }
            return Products;
        }

        public static Product GetProductById(int id)
        {
            var dataTable = DataBaseHelper.ExcuteSelect($"SELECT * FROM Products WHERE Id = {id}");
            if (dataTable.Rows.Count > 0)
            {
                var row = dataTable.Rows[0];
                return new Product
                {
                    ID = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    BuyPrice = Convert.ToDouble(row["BuyPrice"]),
                    SalePrice = Convert.ToDouble(row["SalePrice"]),
                    Quantity = Convert.ToDouble(row["Quantity"]),
                    CategoryID = Convert.ToInt32(row["CATEGORY"])
                };
            }
            return null;
        }
        public static bool AddProduct(Product product)
        {
            bool result= DataBaseHelper.ExcuteDML($"INSERT INTO Products (Name, BuyPrice, SalePrice, Quantity, CATEGORY) VALUES (N'{product.Name}', {product.BuyPrice}, {product.SalePrice}, {product.Quantity}, {product.CategoryID})");
            return result;
        }
        public static bool UpdateProduct(Product product)
        {
            bool result = DataBaseHelper.ExcuteDML($"UPDATE Products SET Name = N'{product.Name}', BuyPrice = {product.BuyPrice}, SalePrice = {product.SalePrice}, Quantity = {product.Quantity}, Category = {product.CategoryID} WHERE Id = {product.ID}");
            return result;
        }
        public static bool DeleteProduct(int id)
        {
            bool result = DataBaseHelper.ExcuteDML($"DELETE FROM Products WHERE Id = {id}");
            return result;
        }
        public static bool DeleteAllProduct()
        {
            bool result = DataBaseHelper.ExcuteDML($"DELETE FROM Products");
            return result;
        }

    }
}
