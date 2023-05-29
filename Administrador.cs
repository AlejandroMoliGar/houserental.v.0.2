using Newtonsoft.Json;
using System.IO;

public class Administrador
{
    public string Name { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }

    public void UserAdmin(){

        Console.WriteLine("\registrate como Administrador!");

        Console.Write("Nombre del Administador: ");
        string Name = Console.ReadLine();

        Console.Write("Numero de Telefono: ");
        int PhoneNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Correo Electronico: ");
        string Email = Console.ReadLine();

        Console.WriteLine("¡te has registrado con exito!");

        var Houserental = new
        {
            Name = Name,
            PhoneNumber = PhoneNumber,
            Email = Email,
        };

       // Serializar el objeto a formato JSON
        string jsonData = JsonConvert.SerializeObject(Houserental, Formatting.Indented);

        Console.WriteLine("Datos en formato JSON:");
        Console.WriteLine(jsonData);

        // Llamar al método para guardar el JSON
        GuardarJson(jsonData);
    }

    public static void GuardarJson(string jsonData)
    {
        try
        {
            // Obtener el directorio actual
            string currentDirectory = Directory.GetCurrentDirectory();

            // Crear un nuevo archivo de texto
            string filePath = Path.Combine(currentDirectory, "Administrador.json");

            // Guardar el JSON en el archivo
            File.AppendAllText(filePath, jsonData + Environment.NewLine);

            Console.WriteLine("Los datos se han guardado correctamente en el archivo .json.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar los datos: " + ex.Message);
        }
    }

}
