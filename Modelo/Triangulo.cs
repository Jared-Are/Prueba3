using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Triangulo : FigurasBidimensionales
    {
        private double _Base;
        private double _Altura;

        public Triangulo(double _Base, double _Altura)
        {
            this._Altura = _Altura;
            this._Base = _Base;
        }

        public override double CalcularArea()
        {
            return (_Base * _Altura)/2;
        }

        public override double CalcularPerimetro()
        {
            return _Base * 3;
        }
    }
}
