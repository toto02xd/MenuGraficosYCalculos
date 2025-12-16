using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ver = 1;
            int ho = 30;
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 30; i < 66; i++)
                {
                    Console.SetCursorPosition(ho, 1);
                    Console.WriteLine("*");
                    Console.SetCursorPosition(ho, 10);
                    Console.WriteLine("*");
                    ho++;

                    Console.SetCursorPosition(30, ver);
                    Console.WriteLine("*");
                    Console.SetCursorPosition(66, ver);
                    Console.WriteLine("*");
                    if (ver < 9)
                    { ver++; }
                }
                ver = 1;
                ho = 30;

                Console.SetCursorPosition(31, 2);
                Console.WriteLine("1. Suma de números");
                Console.SetCursorPosition(31, 3);
                Console.WriteLine("2. Tablas de multiplicar");
                Console.SetCursorPosition(31, 4);
                Console.WriteLine("3. Dibujar un cuadrilátero");
                Console.SetCursorPosition(31, 5);
                Console.WriteLine("4. Dibujar una estrella de David");
                Console.SetCursorPosition(31, 6);
                Console.WriteLine("5. Salir");
                Console.SetCursorPosition(31, 8);
                Console.Write("Seleccione una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.SetCursorPosition(31, 10);
                    Console.Write("ingrese un número de los que se le ");
                    Console.SetCursorPosition(31, 11);
                    Console.Write("solicita");
                    Console.SetCursorPosition(31, 12);
                    Console.Write("Presione una tecla para continuar");
                    Console.SetCursorPosition(31, 13);
                    Console.Write("Mario Alejandro Chaj Sipáque ");
                    Console.SetCursorPosition(31, 14);
                    Console.Write("5to BACO B  ");
                    Console.SetCursorPosition(31, 1);
                    Console.ReadKey();
                    continue;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 30; i < 66; i++)
                    {
                        Console.SetCursorPosition(ho, 1);
                        Console.WriteLine("*");
                        Console.SetCursorPosition(ho, 10);
                        Console.WriteLine("*");
                        ho++;

                        Console.SetCursorPosition(30, ver);
                        Console.WriteLine("*");
                        Console.SetCursorPosition(66, ver);
                        Console.WriteLine("*");
                        if (ver < 9)
                        { ver++; }
                    }
                    ver = 1;
                    ho = 30;
                }
                if (opcion == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    for (int i = 30; i < 75; i++)
                    {

                        Console.SetCursorPosition(ho, 1);
                        Console.WriteLine("*");
                        Console.SetCursorPosition(ho, 10);
                        Console.WriteLine("*");
                        ho++;

                        Console.SetCursorPosition(30, ver);
                        Console.WriteLine("*");
                        Console.SetCursorPosition(75, ver);
                        Console.WriteLine("*");
                        if (ver < 9)
                        { ver++; }
                    }
                    ver = 1;
                    ho = 30;

                    Console.SetCursorPosition(31, 2);
                    Console.Write("Ingrese el primer número: ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(31, 3);
                    Console.Write("Ingrese el segundo número: ");
                    int n2 = int.Parse(Console.ReadLine());
                    int suma = 0;
                    for (int i = n1; i <= n2; i++)
                    { suma += i; }

                    Console.SetCursorPosition(31, 4);
                    Console.WriteLine("La suma de los números entre ");
                    Console.SetCursorPosition(31, 5);
                    Console.WriteLine(n1 + " y " + n2 + " es: " + suma);
                    Console.SetCursorPosition(31, 6);
                    Console.WriteLine("Gracias por usar la opción 1 ");
                    Console.SetCursorPosition(31, 7);
                    Console.WriteLine("Presione una tecla para regresar al menú");
                    Console.SetCursorPosition(31, 8);
                    Console.ReadKey();
                }
                else if (opcion == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(10, 1);
                    Console.WriteLine("Las 10 tablas de multiplicar");
                    for (int tabla = 1; tabla <= 10; tabla++)
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            int columna1 = (tabla - 1) % 5;
                            int fila1 = (tabla - 1) / 5;
                            Console.SetCursorPosition(5 + columna1 * 12, 3 + fila1 * 11 + i - 1);
                            Console.WriteLine(tabla + " x " + i + " = " + (tabla * i));
                        }
                    }

                    Console.SetCursorPosition(2, 25);
                    Console.WriteLine("Gracias por usar la opción 2. Presione una tecla para regresar al menú.");

                    Console.ReadKey();
                }
                else if (opcion == 3)
                {
                    Console.Clear();
                    Console.Write("Ingrese la base (mayor a 10): ");
                    int base1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura (mayor a 10): ");
                    int altura = int.Parse(Console.ReadLine());
                    if (base1 <= 10 || altura <= 10)
                    {
                        Console.WriteLine("Error: base y altura deben ser mayores a 10. Presione una tecla para volver al menú.");

                        Console.ReadKey();
                        continue;
                    }
                    for (int i = 0; i < altura; i++)
                    {
                        for (int j = 0; j < base1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Gracias por usar la opción 3 Presione una tecla para regresar al menú.");

                    Console.ReadKey();
                }
                else if (opcion == 4)
                {
                    Console.Clear();
                    Console.SetCursorPosition(1, 12);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Programa a");
                    Console.SetCursorPosition(1, 13);
                    Console.Write("realizar");
                    Console.SetCursorPosition(50, 12);
                    Console.Write("estrella");
                    Console.SetCursorPosition(50, 13);
                    Console.Write("de david");


                    for (int i = 0; i <= 31; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(14 + i, 9);
                        Console.Write("▒");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(14 + i, 18);
                        Console.Write("▒");
                    }
                    for (int i = 0; i < 15; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.SetCursorPosition(30 + i, 24 - i);
                        Console.Write("▒");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(29 - i, 24 - i);
                        Console.Write("▒");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.SetCursorPosition(44 - i, 17 - i);
                        Console.Write("▒");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(15 + i, 17 - i);
                        Console.Write("▒");
                    }
                    Console.ResetColor();
                    Console.SetCursorPosition(14, 26);
                    Console.WriteLine("Gracias por usar la opción 4 Presione una tecla para regresar al menú");

                    Console.ReadKey();
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("Gracias por usar la opción 5 Saliendo del programa.");
                }
                else
                {
                    Console.SetCursorPosition(31, 9);
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
