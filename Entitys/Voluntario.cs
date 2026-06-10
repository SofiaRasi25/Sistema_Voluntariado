using System;
using System.Dynamic;

public class Voluntario : Persona
{
    private int horasTrabajadas;
    public int HorasTrabajadas{get{return this.horasTrabajadas;}set{this.horasTrabajadas=value;}}

    public Voluntario(string nombre, string dni, int horasTrabajadas)
        : base(nombre, dni)
    {
        this.HorasTrabajadas = horasTrabajadas;
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"DNI: {Dni}");
        Console.WriteLine($"Horas trabajadas: {HorasTrabajadas}");
    }
}