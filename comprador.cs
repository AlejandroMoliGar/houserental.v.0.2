using Newtonsoft.Json;
using System;
using System.IO;

public class Comprador
{
    public decimal Price { get; set; }
    public string Location { get; set; }
    public decimal SquareMeters { get; set; }
    public int NumberOfRooms { get; set; }
    public bool Furnished { get; set; }
    public bool FreeOfLien { get; set; }
    public string TypeProperty { get; set; }
    public string PaymentType { get; set; }
    public string VendorName { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }

    public void BuscarInmuebleVenta()
    {
        Console.WriteLine("\nBuscar un Inmueble en Venta!");

        string filePath = @"..\\.\\HouseForSale.json";

        try
        {
            // Leer el archivo JSON
            string jsonData = File.ReadAllText(filePath);

            // Deserializar el JSON en un objeto Comprador
            var property = JsonConvert.DeserializeObject<Comprador>(jsonData);

            // Acceder a las propiedades del objeto
            Console.WriteLine("Datos obtenidos del archivo:");
            Console.WriteLine($"Precio: {property.Price}");
            Console.WriteLine($"Ubicación: {property.Location}");
            Console.WriteLine($"Metros cuadrados: {property.SquareMeters}");
            Console.WriteLine($"Número de habitaciones: {property.NumberOfRooms}");
            Console.WriteLine($"Amueblado: {property.Furnished}");
            Console.WriteLine($"Libre de gravamen: {property.FreeOfLien}");
            Console.WriteLine($"Tipo de propiedad: {property.TypeProperty}");
            Console.WriteLine($"Tipo de pago: {property.PaymentType}");
            Console.WriteLine($"Nombre del vendedor: {property.VendorName}");
            Console.WriteLine($"Teléfono: {property.PhoneNumber}");
            Console.WriteLine($"Correo electrónico: {property.Email}");
            Console.WriteLine($"Descripción: {property.Description}");
            Console.WriteLine($"Foto: {property.Photo}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo JSON: " + ex.Message);
        }
    }
}