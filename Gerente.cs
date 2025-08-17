using System;

namespace ProyectoEmpleados
{
    public class Gerente : Empleado
    {
        public double BonoAnual { get; set; }

        public override double CalcularSalarioAnual()
        {
            return (SalarioBase * 12) + BonoAnual;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"--- Gerente ---");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario Base: {SalarioBase:C}");
            Console.WriteLine($"Bono Anual: {BonoAnual:C}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
            Console.WriteLine();
        }
    }
}