using System;

public class Empleado
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public char EstadoCivil { get; set; } // 'C' = Casado, 'S' = Soltero
    public DateTime FechaIngreso { get; set; }
    public double SueldoBasico { get; set; }
    public Cargos Cargo { get; set; }

    public int Antiguedad()
    {
        return DateTime.Now.Year - FechaIngreso.Year;
    }

    public int Edad()
    {
        return DateTime.Now.Year - FechaNacimiento.Year;
    }

    public int AniosParaJubilarse()
    {
        return 65 - Edad();
    }

    public double CalcularAdicional()
    {
        int antiguedad = Antiguedad();
        double porcentaje = antiguedad <= 20 ? 0.01 * antiguedad : 0.25;
        double adicional = SueldoBasico * porcentaje;

        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional *= 1.5; // Aumenta un 50%
        }

        if (EstadoCivil == 'C') // Casado
        {
            adicional += 150000;
        }

        return adicional;
    }

    public double CalcularSalario()
    {
        return SueldoBasico + CalcularAdicional();
    }
}