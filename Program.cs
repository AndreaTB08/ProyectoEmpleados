using System;

namespace ProyectoEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos de cada clase
            Gerente gerente = new Gerente()
            {
                ID = 1,
                Nombre = "Carlos Pérez",
                SalarioBase = 5000,
                BonoAnual = 20000
            };

            Desarrollador dev = new Desarrollador()
            {
                ID = 2,
                Nombre = "Andrea Gómez",
                SalarioBase = 4000,
                LenguajePrincipal = "C#"
            };

            Contador contador = new Contador()
            {
                ID = 3,
                Nombre = "Luis Martínez",
                SalarioBase = 3500,
                HorasExtras = 120,
                PagoPorHoraExtra = 50
            };

            // Mostrar resultados en consola
            gerente.MostrarInformacion();
            dev.MostrarInformacion();
            contador.MostrarInformacion();

            Console.ReadKey(); // Para que la consola no se cierre de inmediato
        }
    }
}