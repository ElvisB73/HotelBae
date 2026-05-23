using System;
using Hotel.Negocio_.Modelo;
using Hotel.Negocio_.Servicios;


namespace HotelZormat.testes
{
    class Program
    {
        static void Main(string[] args)
        {
            var servicio = new Reservaservice();

            // Aquí llamaremos los métodos de cada reto para probarlos
            Console.WriteLine("--- RETO 01: ValidarTipoHabitacion ---");
            Console.WriteLine("Suite     → " + servicio.ValidarTipoHabitacion("Suite"));
            Console.WriteLine("Sencilla  → " + servicio.ValidarTipoHabitacion("Sencilla"));
            Console.WriteLine("Penthouse → " + servicio.ValidarTipoHabitacion("Penthouse"));
            Console.WriteLine("(vacío)   → " + servicio.ValidarTipoHabitacion(""));
            Console.WriteLine("(null)    → " + servicio.ValidarTipoHabitacion(null));
        }
    }
}