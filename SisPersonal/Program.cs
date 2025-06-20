// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Empleado[] empleados = new Empleado[3];

        // Cargamos 3 empleados (puedes cambiar los datos)
        empleados[0] = new Empleado
        {
            Nombre = "Valeria",
            Apellido = "Ríos",
            FechaNacimiento = new DateTime(1970, 12, 20),
            EstadoCivil = 'C',
            FechaIngreso = new DateTime(2000, 2, 20),
            SueldoBasico = 700000,
            Cargo = Cargos.Especialista
        };

        empleados[1] = new Empleado
        {
            Nombre = "Luis",
            Apellido = "Martínez",
            FechaNacimiento = new DateTime(1990, 7, 5),
            EstadoCivil = 'S',
            FechaIngreso = new DateTime(2015, 6, 10),
            SueldoBasico = 500000,
            Cargo = Cargos.Administrativo
        };

        empleados[2] = new Empleado
        {
            Nombre = "Ana",
            Apellido = "Gómez",
            FechaNacimiento = new DateTime(1985, 4, 10),
            EstadoCivil = 'C',
            FechaIngreso = new DateTime(2010, 3, 1),
            SueldoBasico = 650000,
            Cargo = Cargos.Ingeniero
        };

        double montoTotal = 0;
        Empleado proximoAJubilarse = empleados[0];

        foreach (var emp in empleados)
        {
            double salario = emp.CalcularSalario();
            montoTotal += salario;

            if (emp.AniosParaJubilarse() < proximoAJubilarse.AniosParaJubilarse())
            {
                proximoAJubilarse = emp;
            }
        }

        Console.WriteLine("\n--- Empleado más próximo a jubilarse ---");
        Console.WriteLine($"Nombre: {proximoAJubilarse.Nombre} {proximoAJubilarse.Apellido}");
        Console.WriteLine($"Edad: {proximoAJubilarse.Edad()} años");
        Console.WriteLine($"Antigüedad: {proximoAJubilarse.Antiguedad()} años");
        Console.WriteLine($"Años para jubilarse: {proximoAJubilarse.AniosParaJubilarse()}");
        Console.WriteLine($"Salario: {proximoAJubilarse.CalcularSalario():C}");

        Console.WriteLine($"\nMonto total en salarios: {montoTotal:C}");
    }
}
