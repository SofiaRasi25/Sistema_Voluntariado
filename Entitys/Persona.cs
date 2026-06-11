using System;

public abstract class Persona
{
    private string nombre;
    private string dni;

    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }

    public string Dni
    {
        get { return this.dni; }
        set { this.dni = value; }
    }

    public Persona(string nombre, string dni)
    {
        this.Nombre = nombre;
        this.Dni = dni;
    }

    public abstract void MostrarDatos();
}