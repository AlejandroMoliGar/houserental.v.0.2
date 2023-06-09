using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

    
        Console.WriteLine("\nPublish a House for Sale!");
        string filePath = @"C:\Users\aleja\houserentalv.0.1\HouseForSale.json";
        {
        try
        {
            List<Seller> houseForSaleList;

            // Read the JSON file if it exists
            if (File.Exists(filePath))
            {
                // Read the file content
                string jsonData = File.ReadAllText(filePath);

                // Deserialize the JSON into a list of Seller objects
                houseForSaleList = JsonConvert.DeserializeObject<List<Seller>>(jsonData);
            }
            else
            {
                // If the file doesn't exist, create a new empty list
                houseForSaleList = new List<Seller>();
            }

            // Create a new Seller object with user-provided data
            Seller newHouseForSale = new Seller();

            Console.Write("Price: ");
            newHouseForSale.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Location: ");
            newHouseForSale.Location = Console.ReadLine();

            Console.Write("Square Meters: ");
            newHouseForSale.SquareMeters = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Number of Rooms: ");
            newHouseForSale.NumberOfRooms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Furnished (true/false): ");
            newHouseForSale.Furnished = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Free of Liens (true/false): ");
            newHouseForSale.FreeOfLiens = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Property Type: ");
            newHouseForSale.PropertyType = Console.ReadLine();

            Console.Write("Payment Type: ");
            newHouseForSale.PaymentType = Console.ReadLine();

            Console.Write("Seller Name: ");
            newHouseForSale.SellerName = Console.ReadLine();

            Console.Write("Phone Number: ");
            newHouseForSale.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Email: ");
            newHouseForSale.Email = Console.ReadLine();

            Console.Write("Description: ");
            newHouseForSale.Description = Console.ReadLine();

            Console.Write("Photo: ");
            newHouseForSale.Photo = Console.ReadLine();

            // Add the new object to the list
            houseForSaleList.Add(newHouseForSale);

            // Serialize the list of objects to JSON format
            string json = JsonConvert.SerializeObject(houseForSaleList, Formatting.Indented);

            // Save the JSON to the file
            File.WriteAllText(filePath, json);

            Console.WriteLine("The house for sale has been successfully published.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error publishing the house for sale: " + ex.Message);
        }
    }
