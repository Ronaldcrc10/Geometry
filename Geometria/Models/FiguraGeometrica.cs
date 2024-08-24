using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Models
{
    internal abstract class FiguraGeometrica //Clase abstracta al menos tiene un metodo abstracto propiedades y metodos abstracto 
    { //NO se pueden crear objetos desde la clase abstracta
        public float Area { get; set; } //Property 

        public FiguraGeometrica()  //Metodo Constructor
        {
            this.Area = 0;
                
        }

        public abstract void CalcularArea(); //Metodo abstracto metodo que existe pero no tiene cuerpo
    }
}
