using System;

    public void PublicarCasaRenta()
    {
        Console.WriteLine("\n¡Publicar una Casa para Renta!");

        Console.Write("Precio: ");
        Precio = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ubicación: ");
        Ubicacion = Console.ReadLine();

        Console.Write("Número de habitaciones: ");
        NumeroHabitaciones = Convert.ToInt32(Console.ReadLine());

        Console.Write("Depósito: ");
        Deposito = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Duración mínima del contrato (en meses): ");
        ContratoMinimo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Contrato exclusivo (s/n): ");
        ContratoExclusivo = Console.ReadLine().ToLower() == "s";

        Console.Write("Metros cuadrados: ");
        MetrosCuadrados = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Servicios incluidos: ");
        ServiciosIncluidos = Console.ReadLine();

        Console.Write("Amueblada (s/n): ");
        Amueblada = Console.ReadLine().ToLower() == "s";

        Console.Write("Aceptación de mascotas (s/n): ");
        AceptacionMascotas = Console.ReadLine().ToLower() == "s";

        Console.Write("Nombre del arrendador: ");
        NombreArendador = Console.ReadLine();

        Console.Write("Teléfono: ");
        Telefono = Console.ReadLine();

        Console.Write("Correo electrónico: ");
        CorreoElectronico = Console.ReadLine();

        Console.Write("Descripción: ");
        Descripcion = Console.ReadLine();

        Console.Write("Fotografía: ");
        Fotografia = Console.ReadLine();

        Console.WriteLine("¡Casa publicada exitosamente para renta!");
    }
}

public class Arendador : NewBaseType
{
        public decimal Precio { get; set; }
        public string Ubicacion { get; set; }
        public int NumeroHabitaciones { get; set; }
        public decimal Deposito { get; set; }
        public int ContratoMinimo { get; set; }
        public bool ContratoExclusivo { get; set; }
        public decimal MetrosCuadrados { get; set; }
        public string ServiciosIncluidos { get; set; }
        public bool Amueblada { get; set; }
        public bool AceptacionMascotas { get; set; }
        public string NombreArendador { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Descripcion { get; set; }
        public string Fotografia { get; set; }
}


