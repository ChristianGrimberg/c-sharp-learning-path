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
        string? nombre = "Christian";

        Console.WriteLine("Ingrese su nombre:");
        //nombre = Console.ReadLine();
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

        Coordenadas coordA = new Coordenadas();
        coordA.x = 1;
        coordA.y = 50;

        Coordenadas coordB = coordA;
        Console.WriteLine("coordB.x {0}", coordB.x);
        Console.WriteLine("coordB.y {0}", coordB.y);

        coordA.x = 100;
        Console.WriteLine("coordB.x {0}", coordB.x);
        Console.WriteLine("coordB.y {0}", coordB.y);

        int miNum = 10;
        AddTen(ref miNum);
        Console.WriteLine("miNum {0}", miNum);
        #endregion

        #region Constantes e identificadores
        const int HORAS_DIA = 24;
        //HORAS_DIA = 80;
        #endregion

        #region Valores nulos
        bool? miSegundaBandera = null;
        int? miNumero = null;
        #endregion

        #region Enumeradores
        Console.WriteLine("Mes actual {0}", eMeses.Enero.ToString());
        #endregion

        Console.Read();
    }

    static void AddTen(ref int number)
    {
        number += 10;
    }
}
