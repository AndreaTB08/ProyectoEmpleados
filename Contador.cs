using System;

namespace ProyectoEmpleados
{
    public class Contador : Empleado
    {
        public int HorasExtras { get; set; }
        public double PagoPorHoraExtra { get; set; }

        public override double CalcularSalarioAnual()
        {
            return (SalarioBase * 12) + (HorasExtras * PagoPorHoraExtra);
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"--- Contador ---");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario Base: {SalarioBase:C}");
            Console.WriteLine($"Horas Extras: {HorasExtras}");
            Console.WriteLine($"Pago por Hora Extra: {PagoPorHoraExtra:C}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
            Console.WriteLine();
        }
    }
}