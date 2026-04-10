using SalesMangmentSystem.DAL;
using SalesMangmentSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.BLL.Services
{
    public static class CategoryService
    {
        // Get All Categorys
        // Get Category By Id
        // Add Category
        // Update Category
        // Delete Category

        public static List<Category> GetAllCategorys()
        {
            var dataTable = DataBaseHelper.ExcuteSelect("SELECT * FROM Categorys");
            List<Category> Categorys = new List<Category>();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                Categorys.Add(new Category
                {
                    ID = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    
                });
            }
            return Categorys;
        }
        public static List<Category> GetAllCategorysbyPattern(string pattern)
        {
            var dataTable = DataBaseHelper.ExcuteSelect($"SELECT * FROM Categorys where Name Like N'%{pattern}%' ");
            List<Category> Categorys = new List<Category>();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                Categorys.Add(new Category
                {
                    ID = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    
                });
            }
            return Categorys;
        }

        public static Category GetCategoryById(int id)
        {
            var dataTable = DataBaseHelper.ExcuteSelect($"SELECT * FROM Categorys WHERE Id = {id}");
            if (dataTable.Rows.Count > 0)
            {
                var row = dataTable.Rows[0];
                return new Category
                {
                    ID = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),

                };
            }
            return null;
        }
        public static bool AddCategory(Category Category)
        {
            bool result = DataBaseHelper.ExcuteDML($"INSERT INTO Categorys (Name ) VALUES (N'{Category.Name}')");
            return result;
        }
        public static bool UpdateCategory(Category Category)
        {
            bool result = DataBaseHelper.ExcuteDML($"UPDATE Categorys SET Name = N'{Category.Name}' WHERE Id = {Category.ID}");
            return result;
        }
        public static bool DeleteCategory(int id)
        {
            bool result = DataBaseHelper.ExcuteDML($"DELETE FROM Categorys WHERE Id = {id}");
            return result;
        }
        public static bool DeleteAllCategory()
        {
            bool result = DataBaseHelper.ExcuteDML($"DELETE FROM Categorys");
            return result;
        }

    }
}
