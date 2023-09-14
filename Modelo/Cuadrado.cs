using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cuadrado : FigurasBidimensionales
    {
        private double _Lado;

        public Cuadrado(double _Lado)
        {
            this._Lado = _Lado;
        }

        public override double CalcularArea()
        {
            return Math.Pow(_Lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 4 * _Lado;
        }
    }
}
