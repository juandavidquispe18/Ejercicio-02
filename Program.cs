using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definir precios de estadía y desayuno
            decimal costo_3estrellas = 100.00m;
            decimal costo_5estrellas = 300.00m;
            decimal costo_desayuno = 7.00m;

            //Ingresar datos
            Console.WriteLine("Seleccione un número para escoger la categoría del hotel");
            Console.WriteLine("Seleccione 3 para Tres estrellas");
            Console.WriteLine("Seleccione 5 para Cinco estrellas");
            int categoria_hotel = int.Parse(Console.ReadLine());

            while (categoria_hotel != 3 && categoria_hotel != 5) 
            {
                Console.WriteLine("Error: Categoría de hotel inválida.");
                Console.WriteLine("Ingrese una categoría válida.");
                categoria_hotel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("===========================================");
            Console.WriteLine("Ingrese la cantidad de días que se va a hospedar:");
            int dias_estadía = int.Parse(Console.ReadLine());

            //Realizar cálculos de estadia
            decimal costo_base = (categoria_hotel == 3) ? costo_3estrellas : costo_5estrellas;
            decimal costo_total = 0;

            if (dias_estadía >= 1 && dias_estadía <= 5)
            {
                costo_total = costo_base * dias_estadía;
            }
            else if (dias_estadía >= 6 && dias_estadía <= 10)
            {
                costo_total = costo_base * dias_estadía * 0.85m;
            }
            else if (dias_estadía >= 11) 
            {
                costo_total = costo_base * dias_estadía * 0.7m;
            }
            //Costos adicionales
            decimal costo_totaldesayuno = costo_desayuno * dias_estadía;
            decimal costo_totalfinal = costo_total + costo_totaldesayuno;
            string costo_TotalFn = costo_totalfinal.ToString("N2");

            //Mostrar resultado
            Console.WriteLine("===========================================");
            Console.WriteLine($"El costo total de estadía en un hotel {(categoria_hotel == 3 ? "Tres Estrellas" : "Cinco Estrellas")} durante {dias_estadía} días es: S/. {costo_TotalFn}");
            Console.ReadKey();   
        }         
    }
}
