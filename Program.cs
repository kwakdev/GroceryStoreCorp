using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;


class Program
{
    static void Main()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("-      Welcome To Evans Grocery Corperation      -");
        Console.WriteLine("-               You are on the main page         -");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("-              Please Select A Department        -");
        Console.WriteLine("--------------------------------------------------");

        // Create an instance of StoreData and fill it with sample data
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
    }

   
}
