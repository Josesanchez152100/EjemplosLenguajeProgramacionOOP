using System;

namespace ejemploDos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hotel WC");
            Console.WriteLine("Cantidad de Huespedes");
            int huespedes = int.Parse(Console.ReadLine());
            Console.WriteLine("Dias de estadia");
            int cant_dias = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre habitaciones");
            string nom_hab = Console.ReadLine();

            var hotelUno = new GestionHotel(){
            habitaciones = nom_hab,
            huesped = huespedes,
            dias = cant_dias

        };
        
        hotelUno.cuentaCobro();
        }


    }
}
