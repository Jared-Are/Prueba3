using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cubo : FigurasTridimensionales
    {
        private double _Lado ;

        public Cubo(double _Lado)
        {
            this._Lado = _Lado;
        }

        public override double CalcularArea()
        {
            return 6 * Math.Pow(_Lado, 2);
        }

        public override double CalcularVolumen()
        {
            return Math.Pow(_Lado, 3);
        }
    }
}
