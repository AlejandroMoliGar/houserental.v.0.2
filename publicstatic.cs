using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Program
{
    public static void Main()
    {
        List<Arrendador> arrendadores = new List<Arrendador>();
        List<Arrendatario> arrendatarios = new List<Arrendatario>();
        List<Vendedor> vendedores = new List<Vendedor>();
        List<Comprador> compradores = new List<Comprador>();

        // Agregar datos de arrendadores, arrendatarios, vendedores y compradores a las listas

        // Serializar las listas a JSON
        string arrendadoresJson = JsonConvert.SerializeObject(arrendadores, Formatting.Indented);
        string arrendatariosJson = JsonConvert.SerializeObject(arrendatarios, Formatting.Indented);
        string vendedoresJson = JsonConvert.SerializeObject(vendedores, Formatting.Indented);
        string compradoresJson = JsonConvert.SerializeObject(compradores, Formatting.Indented);

        // Guardar los datos en archivos JSON
        File.WriteAllText("arrendadores.json", arrendadoresJson);
        File.WriteAllText("arrendatarios.json", arrendatariosJson);
        File.WriteAllText("vendedores.json", vendedoresJson);
        File.WriteAllText("compradores.json", compradoresJson);

        Console.WriteLine("Datos guardados en archivos JSON.");
    }
}
