using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_Aliante_Intera
{
    internal class Ala : IComposite
    {
        private double _lenght;
        private double _width;

        public double Lenght
        {
            get { return _lenght; }
            set
            {
                if(value >= 0)
                {
                    _lenght = value;
                }
                else
                {
                    throw new ArgumentException("La lunghezza deve esseere > 0");
                }
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if(value * 2F >= Lenght)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException("Il valore della larghezza delle ali deve essere > 0");
                }
            }
        }
        
    }
}
