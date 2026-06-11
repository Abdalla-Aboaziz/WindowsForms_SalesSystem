using SalesMangmentSystem.DAL;
using SalesMangmentSystem.DAL.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMangmentSystem.BLL.Services
{
    public class AuthenticationService
    {
        public static bool SeedData()
        {
            try
            {
                // check if data already exists to avoid duplication
                DataTable rolesData = DataBaseHelper.ExcuteSelect("SELECT COUNT(*) FROM Roles");
                DataTable usersData = DataBaseHelper.ExcuteSelect("SELECT COUNT(*) FROM Users");

                int rolesCount = Convert.ToInt32(rolesData.Rows[0][0]);
                int usersCount = Convert.ToInt32(usersData.Rows[0][0]);

                if (rolesCount > 0 && usersCount > 0) return false; // data already exists, no need to seed

                // Add Roles
                if (rolesCount == 0)
                {
                    DataBaseHelper.ExcuteDML("INSERT INTO Roles (Name) VALUES (N'SuperAdmin'), (N'Admin')");
                }

                // 2. Add Users
                if (usersCount == 0)
                {
                    // Get the new role IDs to accurately link them with users
                    DataTable superAdminRole = DataBaseHelper.ExcuteSelect("SELECT ID FROM Roles WHERE Name = 'SuperAdmin'");
                    DataTable adminRole = DataBaseHelper.ExcuteSelect("SELECT ID FROM Roles WHERE Name = 'Admin'");

                    int superAdminId = Convert.ToInt32(superAdminRole.Rows[0]["ID"]);
                    int adminRoleId = Convert.ToInt32(adminRole.Rows[0]["ID"]);

                    // Add SuperAdmin user
                    string user1Query = $@"INSERT INTO Users (FirstName, LastName, UserName, Email, PhoneNumber, Password, RoleID) 
                                          VALUES (N'Abdalla', N'Aboaziz', 'AbdallaAboaziz', 'abdallaaboaziz@gmail.com', '01277353904', 'Admin@123', {superAdminId})";
                    DataBaseHelper.ExcuteDML(user1Query);

                    // Add Admin user
                    string user2Query = $@"INSERT INTO Users (FirstName, LastName, UserName, Email, PhoneNumber, Password, RoleID) 
                                          VALUES (N'Mohamed', N'amr', 'Mohamedamr', 'Mohamedamr@gmail.com', '01092694545', 'Admin@123', {adminRoleId})";
                    DataBaseHelper.ExcuteDML(user2Query);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Seed Failed: {ex.Message}");
                return false;
            }
        }

       
        public static ApplicationUser Login(string username, string password)
        {
            string query = $"SELECT * FROM Users WHERE UserName = '{username}' AND Password = '{password}'";
            DataTable dt = DataBaseHelper.ExcuteSelect(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new ApplicationUser
                {
                    ID = Convert.ToInt32(row["ID"]),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    UserName = row["UserName"].ToString(),
                    RoleID = Convert.ToInt32(row["RoleID"])
                };
            }
            return null; 
        }
    }


}
