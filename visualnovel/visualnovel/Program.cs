using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualnovel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int vida = 100;
            int posionesT = 0;
            Console.WriteLine("te adentras a una masmorra ven algunos sacos de de cosas utiles  cuando decides llevar 1 2 o 3  ");
            string posiones = Console.ReadLine();
            Console.WriteLine("llevas " + posiones);

            if (posiones == "1") { Console.WriteLine("llevas poco elementos curativos se agregara un bonus grande  de defensa  "); vida = 200; posionesT = 1; }
            if (posiones == "2") { Console.WriteLine("llevas algunos elementos curativos se agregara un bonus medio de defensa  "); vida = 150; posionesT = 2; }
            if (posiones == "3") { Console.WriteLine("llevas muchos elementos curativos se agregara un bonus de defensa "); vida = 120; posionesT = 3; }
            Console.WriteLine("te adentras a la masmorra y te encuentras con 1 duende    ");
            Console.WriteLine("que deseas  hacer luchar escapar o usar tu escudo    ");

            switch (Console.ReadLine())
            {
                case "luchar":
                    Console.WriteLine("te enfrentas al duende y lo derrotas pero pierdes 20 de vida");
                    vida -= 20;
                    break;
                case "escapar":
                    Console.WriteLine("no puedes escapar  del duende pero pierdes 10 de vida");
                    vida -= 10;
                    break;
                case "escudo":
                    Console.WriteLine("usas tu escudo y bloqueas el ataque del duende pero pierdes 5 de vida y lo logras tirar al abismo ");
                    vida -= 5;
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;
            }

            Console.WriteLine("vida." + vida + "encuentras un ave gigante que deseas hacer hablar o pelear?   ");
            string ave = Console.ReadLine();

            if (ave == "hablar")
            {
                Console.WriteLine("a pesar de hablar con el ave no parece entenderte pero te deja salir de la masmorra ");
            }
            else
            {
                Console.WriteLine(" usas tu arma y atacas al ave sin embargo su grito genera que varias rocas caigan ");
            }

            if (vida < 150) { Console.WriteLine("te aplaste las piedras y no te puedes mover mueres"); } else { Console.WriteLine("te caen las piedras pero logras salir a duras penas"); }
          

            

        }
    }
}
