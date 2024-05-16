using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using static System.Formats.Asn1.AsnWriter;


class Program
{
    static void Main()
    {
        StoreData storeData = DataHelper.CreateSampleData();

        // Serialize StoreData object to JSON and write it to a file
        string jsonFilePath = "C:\\Users\\evank\\source\\repos\\GroceryStoreEvanKwak\\GroceryStoreEvanKwak\\GroceryData.json";
        try
        {
            DataHelper.SerializeToJson(storeData, jsonFilePath);
            Console.WriteLine("Data written to JSON file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing to JSON file: {ex.Message}");
            return;
        }

        // Deserialize JSON from the file and print the data
        try
        {
            StoreData deserializedStoreData = DataHelper.DeserializeFromJson(jsonFilePath);

            DataHelper.PrintStoreData(deserializedStoreData);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading from JSON file: {ex.Message}");
        }


        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("-      Welcome To Evans Grocery Corperation      -");
        Console.WriteLine("-               You are on the main page         -");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("-              Please Select A Department        -");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("-      To View All The Stores And Their Data using the store number enter 1");
        Console.WriteLine("-      To View All The Suppliers And Their Data enter 2");
        Console.WriteLine("-      To View All The Reports enter 3");
        int choice = Convert.ToInt32(Console.ReadLine());


        if (choice == 1)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("-      Welcome To Evans Grocery Corperation      -");
            Console.WriteLine("-               You are on the Store Page        -");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("-              List of stores in Evans Corperation        -");
            Console.WriteLine("-              A-add a store  E-edit a store D-delete a store       -");
            Console.WriteLine("--------------------------------------------------");
            foreach (var storeName in storeData.Stores)
            {
                Console.WriteLine($"Store ID: {storeName.StoreId} " + $"Store Name: {storeName.Name}");

            }
            Console.WriteLine("StoreID: ");
            int Storechoice = Convert.ToInt32(Console.ReadLine());
        }

        // Create an instance of StoreData and fill it with sample data

    }


}
