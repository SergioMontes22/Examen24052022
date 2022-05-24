//namespace EDexamenT6a8
/// <summary>
/// <para> Se han encapsulados los campos ya que no deben estar públicos por eso los combertir en propiedades.
///  Se ha realizado un Renombre de los nombres de los campos a nombres mas significativos.
///  También se ha realizado una Reordenacion de los parámetros ya que el constructor debe ir despues de la declaración de los campos y propiedades.
///  Además se ha realizado la Eliminación de los parámetros this ya que no eran necesarios.
///  <remarks> Estas son las Refactorizaciones del código</remarks></para>
///  
/// </summary>
class Cafetera
{
    /// <remarks>
    /// Se han utilizado lineas en blanco para leer mejor el código y se han cambiado las declaraciones de las variables ya que los nombres eran poco descriptivos y utilzando el estilo caMel
    /// Los métodos han sido reescritos al metodo PasCal y utilizando verbos
    /// </remarks>
    public string Marca { get; set; }
    public string Referencia { get; set; }
    public double Agua { get; set; }
    public double TotalDeCapsulas { get; set; }


    public Cafetera(string marca, string referencia, double agua, double totalDeCapsulas)
    {
        Marca = marca; //marca de la máquina cafetera
        Referencia = referencia; //referencia del modelo
        TotalDeCapsulas = totalDeCapsulas; //Total de cápsulas en la máquina. 
        Agua = agua; //Cantidad de agua en el recipiente. 
    }
    /// <summary>
    /// Método que calcula el consumo de agua dependiendo del numero de cafe que se desea hacer
    /// </summary>
    /// <param name="numeroDeCafe">Valor de tipo double que nos da a conocer el numero de cafés a hacer</param>
    /// <returns>Un string que nos muestra la cantidad de agua</returns>
    public string ObtenerConsumoAgua(double numeroDeCafe) //numero de cafés a hacer
    {
        double constante = 0.1;
        Agua = Agua - numeroDeCafe * constante; // Constante de consumo de agua 0.1l por cada unidad de café. 
        if (Agua < 0.1)
        {
            Agua = 0;
            return "Falta agua en el depósito, por favor, revisar los niveles.";
        }
        else
        {
            return "Quedan" + Agua + " centilitros";
        }
    }

    /// <summary>
    /// Método que calcula el consumo de cápsulas de café dependiendo del numero de café que se desea hacer
    /// </summary>
    /// <param name="numeroDeCafe">Valor de tipo double que nos da a conocer el numero de cafés a hacer</param>
    /// <returns>Un string que nos muestra la cantidad de cápsulas</returns>
    public string ObtenerConsumoCapsulas(double numeroDeCafe) //Hacer un café 
    {
        TotalDeCapsulas = TotalDeCapsulas - numeroDeCafe;
        if (TotalDeCapsulas < 0)
        {
            TotalDeCapsulas = 0;
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
        else
        {
            return "Quedan" + TotalDeCapsulas + "unidades";
        }
    }

    /// <summary>
    /// Este método nos permite reponer el número de capsulas que tiene la clase
    /// </summary>
    /// <param name="cantidadCapsulas">Valor de tipo double que nos da a conocer el numero de cápsulas para reponer</param>
    /// <returns>Un double con el total de cápsulas</returns>
    public double ReponerCapsulas(double cantidadCapsulas)
    {
        TotalDeCapsulas = TotalDeCapsulas + cantidadCapsulas;
        return TotalDeCapsulas;
    }

    /// <summary>
    /// Método que nos permite llenar el deposito de agua
    /// </summary>
    /// <param name="litros">Valor de tipo double que nos da a conocer la cantidad de litros que deseamos rellenar</param>
    /// <returns>Un double con la cantidad de agua</returns>
    public double LlenarDeposito(double litros)
    {
        Agua = Agua + litros;
        return Agua;
    }

    /// <summary>
    /// Método que nos permite cambiar las especificaciones de la cafetera
    /// </summary>
    /// <param name="referencia">Es un string que nos permite indicar la nueva referencia de modelo de la cafetera</param>
    /// <param name="marca">Es un string que nos permite indicar la nueva marca de la cafetera</param>
    public void CambiarEspecificacion(string referencia, string marca)
    {
        Marca = marca;
        Referencia = referencia;
    }
}


class CafeteraEjemplo
{
    static void Main()
    {
     ///<example>Este es un ejemplo de instacia y muestra de los datos y métodos de la clase Cafetera</example>
        Cafetera ejemploDeMiCafetera = new Cafetera("EspressoBarista", "Procoffee", 0.6, 7);

        Console.WriteLine(ejemploDeMiCafetera.Agua);
        Console.WriteLine(ejemploDeMiCafetera.ObtenerConsumoCapsulas(5));
        Console.WriteLine(ejemploDeMiCafetera.TotalDeCapsulas);
        Console.WriteLine(ejemploDeMiCafetera.ObtenerConsumoAgua(5));
        Console.WriteLine(ejemploDeMiCafetera.Agua);
        ejemploDeMiCafetera.LlenarDeposito(0.5);
        Console.WriteLine(ejemploDeMiCafetera.Agua);
        ejemploDeMiCafetera.ReponerCapsulas(3);
        Console.WriteLine(ejemploDeMiCafetera.TotalDeCapsulas);
    }
}