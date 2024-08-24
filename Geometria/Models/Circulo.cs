using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Models
{
    internal class Circulo : FiguraGeometrica
    {
        public float Radio { get; set; }

        public Circulo(float radio)
        {
            this.Radio = radio;
            this.Area = 0;
        }
        
        public override void CalcularArea()
        {
            this.Area = (float)(Math.PI * Math.Pow(this.Radio, 2));
        }
    }
}
