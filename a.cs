using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la palabra a cifrar:");
        string mensajeOriginal = Console.ReadLine();

        Console.WriteLine("Mensaje original: " + mensajeOriginal);

        Console.WriteLine("Ingrese la distancia para el cifrado: ");
        int distancia = Convert.ToInt32(Console.ReadLine());

        string mensajeCifrado = Cifrar(mensajeOriginal, distancia);
        Console.WriteLine("Mensaje cifrado: " + mensajeCifrado);

        string mensajeDescifrado = Descifrar(mensajeCifrado, distancia);
        Console.WriteLine("Mensaje descifrado: " + mensajeDescifrado);
    }

    static string Cifrar(string mensaje, int distancia)
    {
        string mensajeCifrado = "";
        foreach (char letra in mensaje)
        {
            if (char.IsLetter(letra))
            {
                char letraCifrada = (char)(letra + distancia);
                if ((char.IsLower(letra) && letraCifrada > 'z') || (char.IsUpper(letra) && letraCifrada > 'Z'))
                {
                    letraCifrada = (char)(letra - (26 - distancia));
                }
                mensajeCifrado += letraCifrada;
            }
            else
            {
                mensajeCifrado += letra;
            }
        }
        return mensajeCifrado;
    }

    static string Descifrar(string mensajeCifrado, int distancia)
    {
        return Cifrar(mensajeCifrado, -distancia);
    }
}
