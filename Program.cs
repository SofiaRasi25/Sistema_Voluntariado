using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Persona> personas = new List<Persona>();

        int opcion;

        do
        {
            Console.WriteLine("===== SISTEMA DE VOLUNTARIADO =====");
            Console.WriteLine("1 - Registrar Voluntario");
            Console.WriteLine("2 - Registrar Coordinador");
            Console.WriteLine("3 - Mostrar Datos por DNI");
            Console.WriteLine("0 - Salir");

            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarVoluntario(personas);
                    break;

                case 2:
                    RegistrarCoordinador(personas);
                    break;

                case 3:
                    BuscarPorDni(personas);
                    break;

                case 0:
                    Console.WriteLine("Fin del programa.");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 0);
    }

    static void RegistrarVoluntario(List<Persona> personas)
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("DNI: ");
        string dni = Console.ReadLine();

        Console.Write("Horas trabajadas: ");
        int horas = int.Parse(Console.ReadLine());

        personas.Add(new Voluntario(nombre, dni, horas));

        Console.WriteLine("Voluntario registrado correctamente.");
    }

    static void RegistrarCoordinador(List<Persona> personas)
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("DNI: ");
        string dni = Console.ReadLine();

        Console.Write("Área asignada: ");
        string area = Console.ReadLine();

        Console.Write("Cantidad de personas a cargo: ");
        int cantidad = int.Parse(Console.ReadLine());

        personas.Add(new Coordinador(nombre, dni, area, cantidad));

        Console.WriteLine("Coordinador registrado correctamente.");
    }

    static void BuscarPorDni(List<Persona> personas)
    {
        Console.Write("Ingrese el DNI: ");
        string dniBuscado = Console.ReadLine();

        bool encontrado = false;

        foreach (Persona persona in personas)
        {
            if (persona.Dni == dniBuscado)
            {
                persona.MostrarDatos();
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se encontró una persona con ese DNI.");
        }
    }
}