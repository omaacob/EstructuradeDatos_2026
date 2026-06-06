
namespace CalculadoraFisica;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        bool continuar = true;

        while (continuar)
        {
            MostrarMenu();

            string opcion = Console.ReadLine() ?? "0";

            continuar = ProcesarOpcion(opcion);
        }
    }

    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine(
        "////////////////////////}");
        Console.WriteLine(
        "v      CALCULADORA DE CINEMÁTICA      v");
        Console.WriteLine(
        "///////////////////////}");
        Console.WriteLine(
        "v 1. Calcular Velocidad              v");
        Console.WriteLine(
        "v 2. Calcular Distancia              v");
        Console.WriteLine(
        "v 3. Calcular Tiempo                 v");
        Console.WriteLine(
        "v 0. Salir                           v");
        Console.WriteLine(
        "//////////////////////}");
        Console.Write("\nElige una opción: ");
    }

    static bool ProcesarOpcion(string opcion)
    {
        Console.WriteLine();

        switch (opcion.Trim())
        {
            case "1":

                double d1 = EntradaUsuario.PedirDouble(
                    "Distancia (m): ");

                double t1 = EntradaUsuario.PedirDouble(
                    "Tiempo (s): ");

                double v = Calculos.CalcularVelocidad(d1, t1);

                Console.WriteLine(
                    $"\nVelocidad = {v:F2} m/s");
                break;

            case "2":

                double v2 = EntradaUsuario.PedirDouble(
                    "Velocidad (m/s): ");

                double t2 = EntradaUsuario.PedirDouble(
                    "Tiempo (s): ");

                double d = Calculos.CalcularDistancia(v2, t2);

                Console.WriteLine(
                    $"\nDistancia = {d:F2} m");
                break;

            case "3":

                double d3 = EntradaUsuario.PedirDouble(
                    "Distancia (m): ");

                double v3 = EntradaUsuario.PedirDouble(
                    "Velocidad (m/s): ");

                double tiempo = Calculos.CalcularTiempo(d3, v3);

                Console.WriteLine(
                    $"\nTiempo = {tiempo:F2} s");
                break;

            case "0":

                Console.WriteLine("Gracias por utilizar la calculadora.");
                return false;

            default:

                Console.WriteLine("Opción no válida.");
                break;
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();

        return true;
    }
}