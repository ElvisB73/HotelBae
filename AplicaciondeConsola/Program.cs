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

            Console.WriteLine("\n--- Tests finalizados ---");
            Console.ReadKey();
        }
    }
}