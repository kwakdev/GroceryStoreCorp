using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

class DataHelper
{
   public static StoreData CreateSampleData()
    {
        // Create instances of stores
        Store store1 = new Store
        {
            StoreId = "1",
            Name = "Sample Store 1",
            Address = "123 Main St",
            Contact = "123-456-7890",
            Hours = "9AM - 5PM",
            Manager = new Manager { Name = "John Doe", Contact = "john.doe@example.com" }
        };

        Store store2 = new Store
        {
            StoreId = "2",
            Name = "Sample Store 2",
            Address = "456 Elm St",
            Contact = "987-654-3210",
            Hours = "10AM - 6PM",
            Manager = new Manager { Name = "Jane Smith", Contact = "jane.smith@example.com" }
        };

        // Create instances of suppliers
        Suppliers supplier1 = new Suppliers
        {
            SupplierId = "1",
            Name = "Sample Supplier 1",
            Contact = "supplier1@example.com",
            ProductsSupplied = new List<string> { "Product A", "Product B" },
            DeliverySchedule = "Weekly"
        };

        Suppliers supplier2 = new Suppliers
        {
            SupplierId = "2",
            Name = "Sample Supplier 2",
            Contact = "supplier2@example.com",
            ProductsSupplied = new List<string> { "Product C", "Product D" },
            DeliverySchedule = "Bi-weekly"
        };

        // Create instances of employees
        Employee employee1 = new Employee
        {
            EmployeeId = "emp1",
            Name = "Alice Johnson",
            Position = "Cashier",
            Contact = "alice@example.com",
            HireDate = new DateTime(2023, 1, 15),
            Salary = 2500
        };

        Employee employee2 = new Employee
        {
            EmployeeId = "emp2",
            Name = "Bob Williams",
            Position = "Store Manager",
            Contact = "bob@example.com",
            HireDate = new DateTime(2022, 5, 10),
            Salary = 4000
        };

        // Create instance of a transaction
        Transaction transaction = new Transaction
        {
            TransactionId = "trans1",
            Date = DateTime.Now.Date,
            Time = DateTime.Now.ToString("HH:mm:ss"),
            EmployeeId = "emp1",
            Items = new List<Item> { new Item { ProductId = "prod1", Quantity = 2 }, new Item { ProductId = "prod2", Quantity = 1 } },
            TotalAmount = 150.50,
            PaymentMethod = "Credit Card"
        };

        // Create instance of a customer
        Customer customer = new Customer
        {
            CustomerId = "cust1",
            Name = "Emily Davis",
            Contact = "emily@example.com",
            LoyaltyPoints = 100,
            PurchaseHistory = new List<Purchase> { new Purchase { TransactionId = "trans1", Date = DateTime.Now.Date, TotalAmount = 150.50 } }
        };

        // Create instance of a promotion
        Promotion promotion = new Promotion
        {
            PromotionId = "promo1",
            Name = "Summer Sale",
            Description = "Get 20% off on selected items",
            DiscountPercentage = 20,
            ApplicableProducts = new List<string> { "Product A", "Product B" }
        };

        // Create instance of reports
        Report report = new Report
        {
            SalesReports = new SalesReport { DateRange = "2024-01-01 to 2024-05-31", TotalSales = 5000 },
            InventoryReports = new InventoryReport { LowStockItems = new List<string> { "Product C" }, OutOfStockItems = new List<string> { "Product D" } },
            FinancialReports = new FinancialReport { TotalRevenue = 10000, TotalExpenses = 6000, NetProfit = 4000 },
            EmployeePerformanceReports = new EmployeePerformanceReport { TopPerformers = new List<EmployeePerformance> { new EmployeePerformance { EmployeeId = "emp1", Name = "Alice Johnson", TotalSales = 3000 }, new EmployeePerformance { EmployeeId = "emp2", Name = "Bob Williams", TotalSales = 2000 } } }
        };

        // Create instance of store data and populate with sample data
        StoreData storeData = new StoreData
        {
            Stores = new List<Store> { store1, store2 },
            Suppliers = new List<Suppliers> { supplier1, supplier2 },
            Employees = new List<Employee> { employee1, employee2 },
            Sales = new List<Transaction> { transaction },
            Customers = new List<Customer> { customer },
            Promotions = new List<Promotion> { promotion },
            Reports = report
        };

        return storeData;
    }


   public static void SerializeToJson(StoreData storeData, string filePath)
    {
        // Serialize StoreData object to JSON and write it to a file
        string jsonData = JsonConvert.SerializeObject(storeData, Formatting.Indented);
        File.WriteAllText(filePath, jsonData);
    }

    public static StoreData DeserializeFromJson(string filePath)
    {
        // Deserialize JSON from the file
        string jsonData = File.ReadAllText(filePath);
        StoreData storeData = JsonConvert.DeserializeObject<StoreData>(jsonData);
        return storeData;
    }

    public static void PrintStoreData(StoreData storeData)
    {
        // Print the deserialized store data
        // Example: Printing store names
        Console.WriteLine("Store Names:");
        foreach (var store in storeData.Stores)
        {
            Console.WriteLine(store.Name);
        }
        // Print other data as needed
    }
}
