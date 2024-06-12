using System;

public class Persona
{
    private int? idPersona;
    private string? nombre;
    private string? apellido;
    private DateTime fechaNac;
    private int? dni;
   // private bool aptoFisico;

    public Persona()
    {
    }

    public Persona(string nombre, string apellido, DateTime fechaNac, int dni)
    {
        this.idPersona = idPersona;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.FechaNac = fechaNac;
        this.Dni = dni;
        //this.AptoFisico = aptoFisico;
    }
    public int? IdPersona { get => idPersona; set => idPersona = value; }
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public int? Dni { get => dni; set => dni = value; }
    //public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }

}