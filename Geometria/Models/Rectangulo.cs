using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Models
{
    internal class Rectangulo : FiguraGeometrica //La clase rectangulo hereda de la figura geometrica
    {
        //Atributos de mi clase Rectangulo
        public float Lado1 { get; set; }
        public float Lado2 { get; set; }

        //public float Area { get; set; } propiedad 

        //Metodo constructor
        public Rectangulo(float lado1, float lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Area = 0;
        }

        public override void CalcularArea() //Sobreescritura de metodo para heredar el metodo Calcular Area
        {
            this.Area = this.Lado1 * this.Lado2;
            
        }

        //public void CalcularArea() //Metodo calcular area del triangulo
        //{
        //    this.Area = this.Lado1 * this.Lado2; //this para identificar el atributo de mi clase a excepcion de reconocerla como variable


        //}

    }
}
