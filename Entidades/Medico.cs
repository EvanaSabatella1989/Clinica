using System;

public class Medico : Persona
{
    private int? idMedico;
    private DateTime horarios;
    private String especialidad;



    public Medico()
    {
    }

    public Medico(string nombre, string apellido, DateTime fechaNac, int dni, DateTime horarios, String especialidad) : base(nombre, apellido, fechaNac, dni)
    {
        Horarios = horarios;
        especialidad = especialidad;
    }

    public int? IdMedico { get => idMedico; set => idMedico = value; }
    public DateTime Horarios { get => horarios; set => horarios = value; }
}