class Vendedor
{
    public static void PublishHouseForSale()
    {
        Console.WriteLine("\nPublish a House for Sale!");

        string filePath = @"C:\Users\aleja\houserentalv.0.1\HouseForSale.json";
    
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
            var newHouseForSale = new
            {
                Price = Convert.ToDecimal(Console.ReadLine()),
                Location = Console.ReadLine(),
                SquareMeters = Convert.ToDecimal(Console.ReadLine()),
                NumberOfRooms = Convert.ToInt32(Console.ReadLine()),
                Furnished = Convert.ToBoolean(Console.ReadLine()),
                FreeOfLiens = Convert.ToBoolean(Console.ReadLine()),
                PropertyType = Console.ReadLine(),
                PaymentType = Console.ReadLine(),
                SellerName = Console.ReadLine(),
                PhoneNumber = Convert.ToInt32(Console.ReadLine()),
                Email = Console.ReadLine(),
                Description = Console.ReadLine(),
                Photo = Console.ReadLine()
            };

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

    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al Sistema de Búsqueda de Inmuebles!");

        bool exit = false;

        // Resto del código...
    }
}
