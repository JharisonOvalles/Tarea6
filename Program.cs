// ============================================================
//   Tarea en Vivo #6 — Manejo de Fechas y Strings en C#
//   Ejercicios: Calculadora de Edad | Corrector | Correos
// ============================================================

using System;

class Program
{
    static void Main(string[] args)
    {
        // ════════════════════════════════════════════════════
        //  EJERCICIO 1 — Calculadora de Edad Exacta
        // ════════════════════════════════════════════════════
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("══════════════════════════════════════");
        Console.WriteLine("  📅  EJERCICIO 1: Calculadora de Edad");
        Console.WriteLine("══════════════════════════════════════");
        Console.ResetColor();

        Console.Write("  Ingresa tu fecha de nacimiento (yyyy-MM-dd): ");
        string entradaFecha = Console.ReadLine()!.Trim();

        // Convertir el string a DateTime con DateTime.Parse()
        DateTime fechaNacimiento = DateTime.Parse(entradaFecha);

        // Restar la fecha de nacimiento a DateTime.Now
        DateTime hoy        = DateTime.Now;
        TimeSpan diferencia = hoy - fechaNacimiento;

        // TimeSpan.Days da el total de días entre las dos fechas
        int diasDeVida = (int)diferencia.TotalDays;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n  Tienes {diasDeVida} días de vida.");
        Console.ResetColor();


        // ════════════════════════════════════════════════════
        //  EJERCICIO 2 — El Corrector de Nombres
        // ════════════════════════════════════════════════════
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("══════════════════════════════════════");
        Console.WriteLine("  ✍️   EJERCICIO 2: Corrector de Nombres");
        Console.WriteLine("══════════════════════════════════════");
        Console.ResetColor();

        Console.Write("  Ingresa tu nombre completo: ");
        string nombreRaw = Console.ReadLine()!;

        // Trim() quita los espacios al inicio y al final
        // ToUpper() convierte todo el texto a mayúsculas
        string nombreCorregido = nombreRaw.Trim().ToUpper();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n  BIENVENIDO, {nombreCorregido}.");
        Console.ResetColor();


        // ════════════════════════════════════════════════════
        //  EJERCICIO 3 — Analizador de Correos
        // ════════════════════════════════════════════════════
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("══════════════════════════════════════");
        Console.WriteLine("  📧  EJERCICIO 3: Analizador de Correos");
        Console.WriteLine("══════════════════════════════════════");
        Console.ResetColor();

        Console.Write("  Ingresa tu correo electrónico: ");
        string correo = Console.ReadLine()!.Trim();

        // Split('@') divide el string en dos partes usando '@' como separador
        // La parte [0] es el usuario  →  alumno
        // La parte [1] es el dominio  →  itla.edu.do
        string[] partes  = correo.Split('@');
        string   dominio = partes[1];

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n  El dominio es: {dominio}.");
        Console.ResetColor();

        Console.WriteLine();
    }
}
