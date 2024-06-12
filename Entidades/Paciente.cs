using System;

public class Paciente : Persona
{
    private int? idPaciente;
    private List<Turno> turnos;


   
    public Paciente()
    {
    }


    public Paciente(string nombre, string apellido, DateTime fechaNac, int dni, List<Turno> turnos) : base(nombre, apellido, fechaNac, dni)
    {
        Turnos = turnos;
    }

    public List<Turno> Turnos { get => turnos; set => turnos = value; }
}
