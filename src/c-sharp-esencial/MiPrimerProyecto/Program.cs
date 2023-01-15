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

        #region Tipos anonimos
        var location = new { Pais = "Austria", Ciudad = "Graz"};
        //location.Pais = "Argentina";

        Console.WriteLine("Pais {0}, Ciudad {1}", location.Pais, location.Ciudad);

        var locationB = new { Pais = "Argentina", Ciudad = "Avellaneda"};
        var cliente = new
        {
            Nombre = "Christian",
            Apellido = "Grimberg",
            Locacion = location
        };
        var clientes = new[]
        {
            new { Nombre = "Clara", Apellido = "Castro", Locacion = locationB },
            new { Nombre = "Raul", Apellido = "Noel", Locacion = location },
            cliente
        };

        foreach (var item in clientes)
        {
            Console.WriteLine("Cliente {0} {1}, Pais {2} - Ciudad {3}", item.Nombre, item.Apellido, item.Locacion.Pais, item.Locacion.Ciudad);
        }
        #endregion

        #region Tuplas
        var proveedor = (Nombre: "Alberto", Apellido: "Perez");
        Console.WriteLine($"Proveedor: {proveedor.Nombre}, {proveedor.Apellido}");

        (string Nombre, string Apellido) proveedorB = (Nombre: "Christian", Apellido: "Grimberg");
        proveedorB.Nombre = "Bruno";
        Console.WriteLine($"Proveedor: {proveedorB.Nombre}, {proveedorB.Apellido}");
        #endregion

        #region Operadores matematicos
        const int miConstante = 10;
        int num;
        Console.Write("Ingrese un numero distinto de cero: ");
        string? valor = Console.ReadLine();

        if(!System.String.IsNullOrWhiteSpace(valor)
        && int.TryParse(valor, out num)
        && num != 0)
        {
            Console.WriteLine($"Valor ingresado: {num}");
            int suma = miConstante + num;
            Console.WriteLine($"Suma = {suma}");
            int resta = miConstante - num;
            Console.WriteLine($"Resta = {resta}");
            int multiplicacion = miConstante * num;
            Console.WriteLine($"Multiplicacion = {multiplicacion}");
            float division = miConstante / num;
            Console.WriteLine($"Division = {division}");
        }
        else
        {
            Console.WriteLine("El valor ingresado no es valido");
        }
        #endregion

        Console.Read();
    }

    static void AddTen(ref int number)
    {
        number += 10;
    }
}
