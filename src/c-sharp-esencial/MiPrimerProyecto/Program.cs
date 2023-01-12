using System;
namespace MiPrimerProyecto;

class Program
{
    /// <summary>
    /// Metodo principal
    /// </summary>
    /// <param name="args">Descripcion del parametro args</param>
    static void Main(string[] args)
    {
        #region Imprimir
        Console.WriteLine("Probando mi primer proyecto");
        #endregion

        string? nombre;

        Console.WriteLine("Ingrese su nombre:");
        nombre = Console.ReadLine();
        Console.WriteLine("Tu nombre es: {0}", nombre);

        Console.ReadKey();
    }
}
