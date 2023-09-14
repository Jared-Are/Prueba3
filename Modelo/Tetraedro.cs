using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Tetraedro : FigurasTridimensionales
    {
        private double _Lado;

        public Tetraedro(double _Lado)
        {
            this._Lado = _Lado;
        }


        public override double CalcularArea()
        { 
            return Math.Sqrt(3) * Math.Pow(_Lado, 2);
        }

        public override double CalcularVolumen()
        {
           return (Math.Pow(_Lado, 3) * Math.Sqrt(2)) / 12;
        }
    }
}
