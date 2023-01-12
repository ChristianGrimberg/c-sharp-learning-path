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

        #region Variables
        string? nombre;

        Console.WriteLine("Ingrese su nombre:");
        nombre = Console.ReadLine();
        Console.WriteLine("Tu nombre es: {0}", nombre);
        #endregion

        #region Tipos de datos
#pragma warning disable CS0219
        int positivo = 500;
        int negativo = -800;
        float miFloat = 530.60f;
        double miDoble = 250.50;
        decimal miDecimal = 835.20m;
        byte diasSemana = 7;
        bool miBandera = true;
        string miCadena = "Probando string";
        char miChar = miCadena[0];
#pragma warning restore CS8600
        #endregion

        #region Variables por valor o referencia
        bool val = false;
        bool nuevoVal = val;
        val = true;

        Console.WriteLine("val {0}", val);
        Console.WriteLine("nuevoVal {0}", nuevoVal);
        #endregion

        Console.ReadKey();
    }
}
