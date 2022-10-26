using System;

/*
 Validar si el usuario existe, en caso contrario registrarse

Saludo de bienvenida a usuarios existentes :)

El programa debe repetirse hasta que hayan registrado 10 personas
 */
public class RotiseriaLosPollosHermanos
{
    static void Main(string[] args)
    {
        string[] usuarios = new string[10] { "", "", "", "", "", "", "", "", "", "" };
        int posicionIndice = 0;
        bool estaRegistrado;

        Console.WriteLine("Rotiseria Los pollos hermanos, bienvenidx!!!");

        while (posicionIndice < 10)
        {
            Console.WriteLine("\nEstas en el sistema? Responda True/False por favor");
            estaRegistrado = bool.Parse(Console.ReadLine());

            if (estaRegistrado == true)
            {
                Console.WriteLine("\n Joya!, ingrese su nombre por favor");
                string nombreIngresado = Console.ReadLine();

                Console.WriteLine($"\nEl usuario ingresado es {nombreIngresado}");

                int indiceBuscado = Array.IndexOf(usuarios, nombreIngresado);

                if (indiceBuscado == -1)
                {
                    Console.WriteLine("\nEl usuario no fue encontrado! ¿Queres probar de nuevo?");
                }
                else
                {
                    Console.WriteLine($"\nHola! ¿puedo tomar tu pedido {usuarios[indiceBuscado]}?");
                }
            }
            else if (estaRegistrado == false)
            {
                Console.WriteLine("\nPor favor ingrese su nombre para registrarse \n");

                usuarios[posicionIndice] = Console.ReadLine();

                Console.WriteLine("\nEl usuario fue registrado!" +
                    $"Desde este momento tu usuario es {usuarios[posicionIndice]}");
                posicionIndice++;
            }
        }

        Console.WriteLine("\n El restaurante esta lleno! La lista de reserva es: \n");

        foreach (string cliente in usuarios)
        {
            Console.WriteLine($"Usuario numero {posicionIndice + 1} y el nombre del usuario es: {usuarios[posicionIndice]}");
            posicionIndice++;
        }
        Console.WriteLine("Gracias por elegirnos!!!");
        Environment.Exit(0);

    }
}