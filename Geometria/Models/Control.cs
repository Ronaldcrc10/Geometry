using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Models
{
    internal class Control
    {
        public static void Iniciador() //Metodo iniciador 
        {
            //Creando un objeto

            Rectangulo rectangulo = new Rectangulo(5, 8); // Pasando argumentos a mi objeto
            rectangulo.CalcularArea(); //llamando al metodo calcular area del rectangulo
            Console.WriteLine("Lado 1 " + rectangulo.Lado1);
            Console.WriteLine($"Lado 2 : {rectangulo.Lado2}");
            Console.WriteLine($"Area : {rectangulo.Area}");

            //FiguraGeometrica Figura = new FiguraGeometrica(); //Objeto de figura geometrica            
            //Figura.CalcularArea();

            Triangulo triangulo = new Triangulo(4, 5, 2);

            triangulo.CalcularArea();
            Console.WriteLine("Lado 1 " + triangulo.Lado1);
            Console.WriteLine($"Lado 2 : {triangulo.Lado2}");
            Console.WriteLine($"Lado 3 : {triangulo.Lado3}");
            Console.WriteLine($"Area : {triangulo.Area}");

            Circulo circulo = new Circulo(7);

            circulo.CalcularArea();
            Console.WriteLine("Radio :  " + circulo.Radio);            
            Console.WriteLine($"Area :  {circulo.Area}");
        }

    }
}
