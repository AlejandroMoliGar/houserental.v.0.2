using Newtonsoft.Json;
using System;
using System.IO;

public class Arendatario
{
    public decimal Price { get; set; }
    public string Location { get; set; }
    public int NumberOfRooms { get; set; }
    public decimal Deposit { get; set; }
    public int MinimumContractDuration { get; set; }
    public bool ExclusiveContract { get; set; }
    public decimal SquareMeters { get; set; }
    public string IncludedServices { get; set; }
    public bool Furnished { get; set; }
    public bool PetsAllowed { get; set; }
    public string LandlordName { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }

    public void BuscarInmuebleRenta()
    {
        Console.WriteLine("\n¡Buscar un Inmueble en Renta!");

        string filePath = @"C:\Users\aleja\houserentalv.0.1\Houserental.json";

        try
        {
            // Leer el archivo JSON
            string jsonData = File.ReadAllText(filePath);

            // Deserializar el JSON en una lista de objetos Arendador
            var houseRentalList = JsonConvert.DeserializeObject<List<Arendador>>(jsonData);

            // Acceder a los objetos y sus propiedades
            foreach (var houseRental in houseRentalList)
            {
                Console.WriteLine("Datos obtenidos del archivo:");
                Console.WriteLine($"Precio: {houseRental.Price}");
                Console.WriteLine($"Ubicación: {houseRental.Location}");
                Console.WriteLine($"Número de habitaciones: {houseRental.NumberOfRooms}");
                Console.WriteLine($"Depósito: {houseRental.Deposit}");
                Console.WriteLine($"Duración mínima del contrato: {houseRental.MinimumContractDuration}");
                Console.WriteLine($"Contrato exclusivo: {houseRental.ExclusiveContract}");
                Console.WriteLine($"Metros cuadrados: {houseRental.SquareMeters}");
                Console.WriteLine($"Servicios incluidos: {houseRental.IncludedServices}");
                Console.WriteLine($"Amueblada: {houseRental.Furnished}");
                Console.WriteLine($"Aceptación de mascotas: {houseRental.PetsAllowed}");
                Console.WriteLine($"Nombre del arrendador: {houseRental.LandlordName}");
                Console.WriteLine($"Teléfono: {houseRental.PhoneNumber}");
                Console.WriteLine($"Correo electrónico: {houseRental.Email}");
                Console.WriteLine($"Descripción: {houseRental.Description}");
                Console.WriteLine($"Fotografía: {houseRental.Photo}");
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo JSON: " + ex.Message);
        }
    }
}
