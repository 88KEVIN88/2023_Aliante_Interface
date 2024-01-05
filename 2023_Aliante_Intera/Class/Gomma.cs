using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_Aliante_Intera
{
    public class Gomma : IComposite
    {
        private double _length;
        private double _width;
        private double _r;

        public double Length
        {
            get { return _length; }
            set
            {
                if(value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("La lunghezza deve essere maggiore di 0");
                }
            }
            
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("La larghezza deve essere >0");
                }
            }
        }
        public double Raggio
        {
            get { return _r; }
            set
            {
                if(value > 0)
                {
                    _r = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Il raggio deve essere >0");
                }
            }
        }
        public Gomma() 
        {
            _length = 0;
            _width = 0;
            _r = 0;
        }
        public Gomma(double length, double width, double r)
        {
            _length = length;
            _width = width;
            _r = r;
        }
        public Gomma(Gomma vecchia)
        {
            Length = vecchia.Length;
            Width = vecchia.Width;
            Raggio = vecchia.Raggio;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Gomma otherGomma) || otherGomma is null)
            {
                return false;
            }

            return Length == otherGomma.Length && Width  == otherGomma.Width && Raggio == otherGomma.Raggio;

        }
        public void Add(IComposite componente)
        {

        }
        public void Remove(int index)
        {

        }
        public IComposite Get(int index)
        {
            return null;
        }
        public override string ToString()
        {
            return $"Altezza:{Length};Larghezza:{Width};Raggio:{Raggio}";
        }
        public double Price()
        {
            return  Length * Width * Raggio;
        }
    }
}
