using System;

public class Coordinador : Persona
{
    private string areaAsignada;
    private int personasACargo;
    public string AreaAsignada{get{return this.areaAsignada;}set{this.areaAsignada=value;}}
    public int PersonasACargo{get{return this.personasACargo;}set{this.personasACargo=value;}}

    public Coordinador(string nombre, string dni, string areaAsignada, int personasACargo)
        : base(nombre, dni)
    {
        this.AreaAsignada = areaAsignada;
        this.PersonasACargo = personasACargo;
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"DNI: {Dni}");
        Console.WriteLine($"Área: {AreaAsignada}");
        Console.WriteLine($"Personas a cargo: {PersonasACargo}");
    }
}