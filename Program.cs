/*
 * 2. 2.	El colegio SUAREZ requiere un programa que permita hallar la calificación promedio de sus estudiantes así:
 • Por teclado se debe solicitar la cantidad de usuarios a valorar. (ejemplo si digita 5 deberá repetir
  los pasos siguientes 5 veces)
 • Se requiere captura por teclado de nombre y calificación (siendo la edad un número entero de 1 a 10).
 • Se debe calcular e imprimir en consola el valor de la calificación promedio, máxima y mínima de los estudiantes.

Nombre: Maicol David Siachoque Cubides
Grupo: 104
Programa: Ingenieria de sistemas
Codigo funte: Autoria propia  */

namespace PromMaxMinEje2;  
class Program 
{
    static void Main(string[] args) 
    {
        Estudiante estudiante = new Estudiante();
        string entrada;
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine("Bienvenido");
        Console.WriteLine("Este programa sirve para calcular promedio,puntaje maximo y minimo");
        Console.WriteLine("---------------------------------------------------------------------");

        Console.Write("Ingrese la cantidad de estudiantes a evaluar: ");
        entrada = Console.ReadLine();
        if (!int.TryParse(entrada, out int cantidad))
        {
            Console.WriteLine("Solo se permiten numeros");
            return;
        }
        estudiante.Nombre = new string[cantidad];
        estudiante.Calificacion = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingrese el nombre del estudiante {0} ", i + 1 + ":");
            entrada = Console.ReadLine();
            if (entrada is null)
            {
                Console.WriteLine("Solo se permite texto");
                i--;
                continue;
            }
            estudiante.Nombre[i] = entrada;
            Console.Write("Ingrese la calificacion del estudiante {0}: ", i + 1);
            entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out int calif))
            {
                Console.WriteLine("Solo se permiten numeros");
                i--;
                continue;
            }
            if (calif <1 || calif >10)
            {
                Console.WriteLine("Solo se permiten numeros de 1 a 10");
                i--;
                continue;
            }
            estudiante.Calificacion[i] = calif;
        }
        Console.WriteLine("El promedio de calificaciones es: {0}", estudiante.Calificacion.Average());

        Console.WriteLine("El maximo de calificaciones es: {0}", estudiante.Calificacion.Max());

        Console.WriteLine("El Minimo de calificaciones es: {0}", estudiante.Calificacion.Min());
    }

}

    
