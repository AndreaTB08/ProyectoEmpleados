using System;

namespace ProyectoEmpleados
{
    public abstract class Empleado
    {
        // Propiedades comunes
        public string Nombre { get; set; }
        public int ID { get; set; }
        public double SalarioBase { get; set; }

        // Métodos abstractos que las clases hijas deben implementar
        public abstract double CalcularSalarioAnual();
        public abstract void MostrarInformacion();
    }
}