public class Manager
{
    public string Name { get; set; }
    public string Contact { get; set; }
}

public class Suppliers
{
    public string SupplierId { get; set; }
    public string Name { get; set; }
    public string Contact { get; set; }
    public IList<string> ProductsSupplied { get; set; }
    public string DeliverySchedule { get; set; }
}

public class Employee
{
    public string EmployeeId { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public string Contact { get; set; }
    public DateTime HireDate { get; set; }
    public double Salary { get; set; }
}

public class Item
{
    public string ProductId { get; set; }
    public int Quantity { get; set; }
}

public class Transaction
{
    public string TransactionId { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public string EmployeeId { get; set; }
    public IList<Item> Items { get; set; }
    public double TotalAmount { get; set; }
    public string PaymentMethod { get; set; }
}

public class Purchase
{
    public string TransactionId { get; set; }
    public DateTime Date { get; set; }
    public double TotalAmount { get; set; }
}

public class Customer
{
    public string CustomerId { get; set; }
    public string Name { get; set; }
    public string Contact { get; set; }
    public int LoyaltyPoints { get; set; }
    public IList<Purchase> PurchaseHistory { get; set; }
}

public class Promotion
{
    public string PromotionId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int DiscountPercentage { get; set; }
    public IList<string> ApplicableProducts { get; set; }
}

public class Report
{
    public SalesReport SalesReports { get; set; }
    public InventoryReport InventoryReports { get; set; }
    public FinancialReport FinancialReports { get; set; }
    public EmployeePerformanceReport EmployeePerformanceReports { get; set; }
}

public class SalesReport
{
    public string DateRange { get; set; }
    public double TotalSales { get; set; }
}

public class InventoryReport
{
    public IList<string> LowStockItems { get; set; }
    public IList<string> OutOfStockItems { get; set; }
}

public class FinancialReport
{
    public double TotalRevenue { get; set; }
    public double TotalExpenses { get; set; }
    public double NetProfit { get; set; }
}

public class EmployeePerformanceReport
{
    public IList<EmployeePerformance> TopPerformers { get; set; }
}

public class EmployeePerformance
{
    public string EmployeeId { get; set; }
    public string Name { get; set; }
    public double TotalSales { get; set; }
}

public class StoreData
{
    public IList<Store> Stores { get; set; }
    public IList<Suppliers> Suppliers { get; set; }
    public IList<Employee> Employees { get; set; }
    public IList<Transaction> Sales { get; set; }
    public IList<Customer> Customers { get; set; }
    public IList<Promotion> Promotions { get; set; }
    public Report Reports { get; set; }
}

public class Store
{
    public string StoreId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Contact { get; set; }
    public string Hours { get; set; }
    public Manager Manager { get; set; }
}