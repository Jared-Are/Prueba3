using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Esfera : FigurasTridimensionales
    {
        private double _Radio;
        public Esfera(double _Radio)
        {
            this._Radio = _Radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(_Radio, 2) * 4;
        }

        public override double CalcularVolumen()
        {
            return (Math.PI * Math.Pow(_Radio, 3) * 4) / 3;
        }
    }
}
