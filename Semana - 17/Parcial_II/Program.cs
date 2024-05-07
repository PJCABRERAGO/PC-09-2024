using System;

class Cabrera_González_Pablo_José_1278724_Parcial_II
{
    static void Main()
    {
        string[] Nombre = new string[10];
        decimal [] Nota = new decimal[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Por favor, ingrese el nombre del alumno {i + 1}: ");
            Nombre[i] = Console.ReadLine();

            while (true)
            {
                Console.Write($"Por favor, ingrese la nota del alumno {i + 1} (0 - 100): ");
                if (decimal.TryParse(Console.ReadLine(), out Nota[i]) && Nota[i] >= 0 && Nota[i] <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("El dato que ingreso es inválido (debe ser un número entre 0 y 100). Intente de nuevo."); 
                }
            }
        }

        while (true)
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1) El menú muestra nombre y nota de alumnos que aprobaron el curso.");
            Console.WriteLine("2) El menú muestra nombre y nota de alumnos que no aprobaron el curso.");
            Console.WriteLine("3) El menú muestra el promedio de las notas del grupo.");
            Console.WriteLine("4) Salir del programa.");
            Console.Write("Elija una opción: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal opcion))
            {
                switch (opcion)
                {
                    case 1:
                        MostrarAlumnosAprobados(Nombre, Nota);
                        break;
                    case 2:
                        MostrarAlumnosNoAprobados(Nombre, Nota);
                        break;
                    case 3:
                        MostrarelPromedio(Nota); Console.WriteLine(" puntos");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("La opción ingresada no es válida. Intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("La opción ingresada no es válida. Intente de nuevo.");
            }
        }
    }

    static void MostrarAlumnosAprobados(string[] Nombre, decimal[] Nota)
    {
        Console.WriteLine("\nLos alumnos que aprobaron el curso exitosamente son:");
        for (int i = 0; i < Nombre.Length; i++)
        {
            if (Nota[i] >= 65)
            {
                Console.WriteLine($"Nombre: {Nombre[i]}, Nota: {Nota[i]}");
            }
        }
    }

    static void MostrarAlumnosNoAprobados(string[] Nombre, decimal[] Nota)
    {
        Console.WriteLine("\nLos alumnos que lastimosamente no aprobaron el curso son:");
        for (int i = 0; i < Nombre.Length; i++)
        {
            if (Nota[i] < 65)
            {
                Console.WriteLine($"Nombre: {Nombre[i]}, Nota: {Nota[i]}");
            }
        }
    }

    static void MostrarelPromedio(decimal[] Nota)
    {
        decimal suma = 0;
        for (int i = 0; i < Nota.Length; i++)
        {
            suma += Nota[i];
        }
        double promedio = (double)suma / Nota.Length;
        Console.WriteLine($"\nEl promedio de las notas de este grupo es: {promedio} puntos");
    }
}