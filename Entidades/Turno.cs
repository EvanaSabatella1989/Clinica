using System;

public class Turno
{
    private int? idTurno;
    private DateTime fechaTurno;
    private String lugar;
    private Medico medico;
    private Paciente paciente;

    public Turno()
    {
    }

    public Turno(int? idTurno, DateTime fechaTurno, string lugar, Medico medico, Paciente paciente)
    {
        this.IdTurno = idTurno;
        this.FechaTurno = fechaTurno;
        this.Lugar = lugar;
        this.Medico = medico;
        this.Paciente = paciente;
        
    }

    public int? IdTurno { get => idTurno; set => idTurno = value; }
    public DateTime FechaTurno { get => fechaTurno; set => fechaTurno = value; }
    public string Lugar { get => lugar; set => lugar = value; }
    public Medico Medico { get => medico; set => medico = value; }
    public Paciente Paciente { get => paciente; set => paciente = value; }
}