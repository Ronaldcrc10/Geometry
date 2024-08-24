using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Models
{
   
        internal class Triangulo : FiguraGeometrica //La clase Triangulo hereda de la figura geometrica
        {
            //Atributos de mi clase Triangulo 
            public float Lado1 { get; set; }
            public float Lado2 { get; set; }        
            public float Lado3 { get; set; }

            //Metodo constructor
            public Triangulo(float lado1, float lado2, float lado3)
            {
                Lado1 = lado1;
                Lado2 = lado2;
                Lado3 = lado3;
                this.Area = 0;
            }

            public override void CalcularArea() //Sobreescritura de metodo para heredar el metodo Calcular Area
            {
               float semiperimetro =(this.Lado1 + this.Lado2 + this.Lado3) / 2;
            this.Area = (float) Math.Sqrt(semiperimetro * (semiperimetro - this.Lado1)*(semiperimetro-this.Lado2)*(semiperimetro-this.Lado3));

            }
        }
}
