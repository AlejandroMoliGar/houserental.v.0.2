using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

public class Buyer
{
    public decimal Price { get; set; }
    public string Location { get; set; }
    public string PropertyType { get; set; }
    public decimal SquareMeters { get; set; }
    public string PaymentType { get; set; }
    public string Description { get; set; }
    public bool FreeOfLiens { get; set; }
    public string PropertyRegistration { get; set; }

    public void SearchProperty()
    {
        Console.WriteLine("\nSearch for a Property!");

        string filePath = @"C:\Users\aleja\houserentalv.0.1\PropertiesForSale.json";

        try
        {
            // Read the JSON file if it exists
            if (File.Exists(filePath))
            {
                // Read the file content
                string jsonData = File.ReadAllText(filePath);

                // Deserialize the JSON into a list of Buyer objects
                var propertiesForSaleList = JsonConvert.DeserializeObject<List<Buyer>>(jsonData);

                // Display the properties for sale that match the buyer's criteria
                Console.WriteLine("Matching Properties for Sale:");

                foreach (var property in propertiesForSaleList)
                {
                    if (property.Location.Equals(Location, StringComparison.OrdinalIgnoreCase)
                        && property.PropertyType.Equals(PropertyType, StringComparison.OrdinalIgnoreCase)
                        && property.SquareMeters >= SquareMeters
                        && property.PaymentType.Equals(PaymentType, StringComparison.OrdinalIgnoreCase)
                        && property.FreeOfLiens == FreeOfLiens)
                    {
                        Console.WriteLine($"Price: {property.Price}");
                        Console.WriteLine($"Location: {property.Location}");
                        Console.WriteLine($"Property Type: {property.PropertyType}");
                        Console.WriteLine($"Square Meters: {property.SquareMeters}");
                        Console.WriteLine($"Payment Type: {property.PaymentType}");
                        Console.WriteLine($"Description: {property.Description}");
                        Console.WriteLine($"Free of Liens: {property.FreeOfLiens}");
                        Console.WriteLine($"Property Registration: {property.PropertyRegistration}");
                        Console.WriteLine("---------------------------------------");
                    }
                }
            }
            else
            {
                Console.WriteLine("No properties for sale found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error searching for properties: " + ex.Message);
        }
    }
}

