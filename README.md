# 🛒 Sales Management System

A desktop application built with **C# Windows Forms**, implementing a clean **3-Layer Architecture (PL → BLL → DAL)** using raw **ADO.NET** against SQL Server — no ORM, full control over every query and transaction.

---

## Table of Contents

- [Why This Project](#why-this-project)
- [Architecture](#architecture)
- [Technology Stack](#technology-stack)
- [Project Structure](#project-structure)
- [Modules](#modules)
- [Transaction Design — Save Sale Order](#transaction-design--save-sale-order)
- [Database Schema](#database-schema)
- [Authentication & Seeding](#authentication--seeding)
- [Getting Started](#getting-started)
- [Author](#author)

---

## Why This Project

Most desktop projects stop at basic CRUD with scattered SQL everywhere.  
This one doesn't.

- **No ORM** — raw ADO.NET with full query control via `DataBaseHelper`
- **3-Layer Architecture** — strict separation: PL handles only UI, BLL handles business logic, DAL handles data access
- **Atomic transactions** — saving a sale order writes to 5 tables in a single SQL transaction; any failure rolls back everything
- **DTOs for projection** — `CustomerReadBasicDto`, `ProductReadBasicDto`, `SaleOrderReadProductDto`, and `StockReadDto` keep UI bindings clean and avoid over-fetching
- **Pattern-based search** — every module supports live `LIKE`-based search across all relevant columns
- **Role-based login** — `AuthenticationService` seeds `SuperAdmin` and `Admin` roles on first run, with no duplication logic

---

## Architecture

```
SalesMangmentSystem
│
├── DAL  (Data Access Layer)
│   ├── Models/           ← Domain Entities
│   ├── Identity/         ← ApplicationUser, Role
│   └── DataBaseHelper    ← ExcuteSelect / ExcuteDML / ExcuteTransaction
│
├── BLL  (Business Logic Layer)
│   ├── Services/         ← One service class per entity
│   └── Dtos/             ← Read-only projection objects
│
└── PL   (Presentation Layer)
    └── SalesForms/       ← Windows Forms (one Form per module)
```

Dependencies only point **inward**: PL → BLL → DAL.  
The DAL has zero references to UI or business logic.

---

## Technology Stack

| Category | Technology |
|---|---|
| Language | C# (.NET Windows Forms) |
| Database | SQL Server (raw ADO.NET) |
| Data Access | `SqlConnection` / `SqlCommand` / `SqlDataAdapter` |
| Transactions | `SqlTransaction` with `BeginTransaction` / `Commit` / `Rollback` |
| UI Framework | Windows Forms (DataGridView, NumericUpDown, ComboBox, DateTimePicker) |
| Pattern | 3-Layer Architecture + DTO Projection |

---

## Project Structure

```
SalesMangmentSystem.DAL
├── Models
│   ├── Category.cs
│   ├── Customer.cs
│   ├── Product.cs
│   ├── SaleOrder.cs
│   ├── SaleOrderProduct.cs
│   ├── Stock.cs
│   └── StockDetails.cs          ← includes Type enum (Sale / Purchase / Expenses)
├── Identity
│   ├── ApplicationUser.cs
│   └── Role.cs
└── DataBaseHelper.cs             ← ExcuteSelect / ExcuteDML / ExcuteTransaction

SalesMangmentSystem.BLL
├── Services
│   ├── AuthenticationService.cs  ← SeedData() + Login()
│   ├── CategoryService.cs
│   ├── CustomerServices.cs
│   ├── ProductService.cs
│   ├── SaleOrderService.cs       ← InsertSaleOrderTransaction (5-table atomic write)
│   ├── SaleOrderProductService.cs
│   ├── StockService.cs
│   └── StockDetailsService.cs
└── Dtos
    ├── CustomerReadBasicDto.cs
    ├── ProductReadBasicDto.cs
    ├── SaleOrderReadProductDto.cs
    └── StockReadDto.cs

SalesMangmentSystem.PL
└── SalesForms
    ├── FrmAuthentication.cs      ← Login form
    ├── FrmCategory.cs
    ├── FrmCustomer.cs
    ├── FrmProduct.cs
    ├── FrmSaleOrdercs.cs         ← New invoice + Save transaction
    ├── FrmSaleOrderReport.cs     ← Reports by date range / order ID / customer
    └── FrmStockDetails.cs        ← Stock movement reports
```

---

## Modules

### 🏠 Main Form
<img width="954" height="653" alt="Main Form" src="https://github.com/user-attachments/assets/4a6f59f6-7167-4609-b023-208c070e395b" />

---

### 🔐 Authentication
<img width="956" height="657" alt="Authentication Form" src="https://github.com/user-attachments/assets/c15809ff-a915-4a2d-8a49-42e04de5f5bf" />

- Login screen with username + password validation
- `AuthenticationService.SeedData()` runs on startup — inserts `SuperAdmin` and `Admin` roles and two default users if the tables are empty
- Successful login opens `MainForm` and hides the login window

---

### 📦 Categories
<img width="1190" height="1032" alt="Categories Form" src="https://github.com/user-attachments/assets/89aeb3d6-95da-47b2-b032-e1c53f2f7a30" />

- Full CRUD via `FrmCategory`
- Pattern search across `Name`
- Confirmation dialog before Delete / Delete All

---

### 👤 Customers
<img width="1377" height="908" alt="Customers Form" src="https://github.com/user-attachments/assets/5aed740a-f60e-488f-a245-fa393a486a40" />

- Full CRUD via `FrmCustomer`
- Fields: Name, Address, Phone, BirthDate
- Pattern search across Name, Phone, Address, and birth year

---

### 🏷️ Products
<img width="1373" height="909" alt="Products Form" src="https://github.com/user-attachments/assets/50e4f9cd-2ad6-48e9-ab27-fa0604b8e200" />

- Full CRUD via `FrmProduct`
- Fields: Name, BuyPrice, SalePrice, Quantity, Category (ComboBox bound to Categories table)
- Pattern search across Name, BuyPrice, SalePrice, Quantity
- Quantity is adjusted automatically during sale order saves

---

### 🧾 Sale Orders
<img width="1374" height="912" alt="Sale Orders Form" src="https://github.com/user-attachments/assets/a8b1cbf5-c6f4-4f3f-9574-ec9fcec5124d" />

- New invoice form (`FrmSaleOrdercs`) with:
  - Product selection via ComboBox (bound to `ProductReadBasicDto`)
  - Quantity validation against current stock before adding a row
  - Running total calculated per line and accumulated in `nudTotalInvoice`
  - Customer, Stock, and Transaction Type selectors
  - **Save triggers a 5-table atomic SQL transaction** (see section below)

---

### 📊 Sale Order Reports
<img width="1371" height="911" alt="Sale Order Reports Form" src="https://github.com/user-attachments/assets/f38f60ee-46a2-4639-975b-172cf1d659e7" />

- Search by **date range**
- Search by **Order ID** or **Customer Name** (toggle checkbox)
- Shows joined data: Customer Name, Product Name, Price, Quantity, Line Total
- Auto-calculates grand total via LINQ `.Sum()`

---

### 💰 Stock Details
<img width="1371" height="911" alt="Stock Details Form" src="https://github.com/user-attachments/assets/2072a895-2367-4c29-b233-6c105e0bd066" />

- Search by **date range**
- Search by **Order ID**
- Filter by **transaction type** (Sales / Purchases / Expenses)
- Arabic type labels rendered at the service layer (`typeValue switch { 0 => "مبيعات", ... }`)
- Auto-calculates total from DataGridView column

---

## Transaction Design — Save Sale Order

Saving a sale order touches **5 tables at once**:

1. `SaleOrders` — insert the order header
2. `SaleOrderProducts` — insert all line items
3. `Products` — decrement quantity for each sold product
4. `Stock` — add the invoice total to the selected stock's `TotalMoney`
5. `StockDetails` — log the financial movement

Without a transaction, if anything fails halfway through (e.g. inserting the order succeeds but updating the stock fails), the database would end up in an **inconsistent state** — an order exists with no stock record, or products lose quantity without a matching invoice. The transaction guarantees that either **all 5 operations succeed together, or none of them are applied**.

### How It Works

Each service method exposes a `GetCommand()` variant that returns the SQL string instead of executing it. `InsertSaleOrderTransaction` collects all commands into a list and passes them to `DataBaseHelper.ExcuteTransaction`:

```csharp
public static bool InsertSaleOrderTransaction(
    SaleOrder saleOrder,
    List<SaleOrderProduct> saleOrderproducts,
    List<Product> products,
    Stock stock,
    StockDetails stockDetails)
{
    List<string> commands = new List<string>();

    commands.Add(SaleOrderService.AddSaleOrderGetCommand(saleOrder));
    commands.Add(SaleOrderProductService.AddSaleOrderProductsGetCommand(saleOrderproducts));
    commands.AddRange(ProductService.UpdateProductMinusQuantityGetCommands(products));
    commands.Add(StockService.UpdateStockMoneyPlusGetCommand(stock));
    commands.Add(StockDetailsService.AddStockDetailsGetCommand(stockDetails));

    return DataBaseHelper.ExcuteTransaction(commands);
}
```

### `ExcuteTransaction` in `DataBaseHelper`

```csharp
public static bool ExcuteTransaction(List<string> commands)
{
    using (SqlConnection connection = new SqlConnection(ConnectionString))
    {
        connection.Open();
        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            string batch = string.Join(Environment.NewLine, commands);
            using (SqlCommand cmd = new SqlCommand(batch, connection, transaction))
            {
                cmd.ExecuteNonQuery();
            }
            transaction.Commit();  // All succeeded → persist everything
            return true;
        }
        catch (Exception ex)
        {
            transaction.Rollback(); // Any failure → undo everything
            System.Diagnostics.Debug.WriteLine(ex.Message);
            return false;
        }
    }
}
```

If any command in the batch throws an exception, `Rollback()` reverts every change made within that transaction — the database stays clean as if nothing happened.

---

## Database Schema

```
Categorys       → ID, Name
Products        → ID, Name, BuyPrice, SalePrice, Quantity, CATEGORY (FK → Categorys)
Customers       → ID, Name, Address, PHONENUMBER, BIRTHDATE
SaleOrders      → ID, CustomerID (FK → Customers), DateOrder, TotalOrder
SaleOrderProducts → ORDERID (FK → SaleOrders), PRODUCTID (FK → Products),
                    PRODUCTPRICE, PRODUCTQUANTITY, PRODUCTTOTALPRICE
Stock           → ID, Name, TotalMoney
StockDetails    → ID, StockID (FK → Stock), Type (0=Sale/1=Purchase/2=Expenses),
                  Total, Date, OrderID (FK → SaleOrders)
Roles           → ID, Name
Users           → ID, FirstName, LastName, UserName, Email,
                  PhoneNumber, Password, RoleID (FK → Roles)
```

---

## Authentication & Seeding

`AuthenticationService.SeedData()` is called once at startup from `Program.cs`:

```csharp
[STAThread]
static void Main()
{
    ApplicationConfiguration.Initialize();
    AuthenticationService.SeedData(); // Seeds roles and default users if tables are empty
    Application.Run(new FrmAuthentication());
}
```

**Default Seeded Users**

| Username | Password | Role |
|---|---|---|
| AbdallaAboaziz | Admin@123 | SuperAdmin |
| Mohamedamr | Admin@123 | Admin |

---

## Getting Started

### Prerequisites
- .NET 6+ (Windows Forms)
- SQL Server (LocalDB or Express)

### Setup

```bash
# 1. Clone the repository
git clone https://github.com/Abdalla-Aboaziz/SalesMangmentSystem.git

# 2. Create the database
# Run the SQL schema script in SQL Server Management Studio

# 3. Update the connection string in DataBaseHelper.cs
private const string ConnectionString =
    "Data Source=.;Initial Catalog=SSTOREONLINE;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";

# 4. Run the application
# Build and run via Visual Studio — seed data is inserted automatically on first launch
```

---

## Author

**Abdalla Aboaziz**

- GitHub: [github.com/Abdalla-Aboaziz](https://github.com/Abdalla-Aboaziz)
- LinkedIn: [linkedin.com/in/abdalla-aboaziz](https://www.linkedin.com/in/abdalla-aboaziz-13a513331/)
- 📧 abdallaaboaziz@gmail.com
