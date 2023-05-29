using Newtonsoft.Json;
using System;
using System.IO;

public class comprador
{
    public decimal Price { get; set; }
    public string Location { get; set; }
    public decimal squaremeters { get; set; }
    public decimal Norooms { get; set; }
    public string furnished { get; set; }
    public string freefieldgavamen { get; set; }
    public string propertytype { get; set; }
    public string paymenttype { get; set; }
    public string Sellername { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }

    public void BuscarInmuebleVenta()
    {
        Console.WriteLine("\n¡Buscar un Inmueble en Venta!");

        string filePath = @"C:\Users\luism\houserentalv.0.1\h.json";

        try
        {
            // Leer el archivo JSON
            string jsonData = File.ReadAllText(filePath);

            // Deserializar el JSON en una lista de objetos Vendedor
            var houseRentalList = JsonConvert.DeserializeObject<List<Vendedor>>(jsonData);

            // Acceder a los objetos y sus propiedades
            foreach (var h in houseRentalList)
            {
                Console.WriteLine("Datos obtenidos del archivo:");
                Console.WriteLine($"Precio: {h.Price}");
                Console.WriteLine($"Ubicación: {h.Location}");
                Console.WriteLine($"Metros cuadrados: {h.squaremeter}");
                Console.WriteLine($"Número de habitaciones: {h.Norooms}");
                Console.WriteLine($"Amueblado: {h.furnished}");
                Console.WriteLine($"Campo libre gavamen: {h.freefieldgavamen}");
                Console.WriteLine($"Tipo de inmuenble: {h.propertytype}");
                Console.WriteLine($"Tipo de pago: {h.paymenttype}");
                Console.WriteLine($"Nombre venderor: {h.Sellername}");
                Console.WriteLine($"Teléfono: {h.PhoneNumber}");
                Console.WriteLine($"Correo electrónico: {h.Email}");
                Console.WriteLine($"Descripción: {h.Description}");
                Console.WriteLine($"Fotografía: {h.Photo}");
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo JSON: " + ex.Message);
        }
    }
}
