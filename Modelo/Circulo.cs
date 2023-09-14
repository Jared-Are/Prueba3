using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Circulo : FigurasBidimensionales
    {
        private double _Radio;
        public Circulo(double _Radio)
        {       
            this._Radio = _Radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(_Radio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * _Radio;
        }
    }
}
