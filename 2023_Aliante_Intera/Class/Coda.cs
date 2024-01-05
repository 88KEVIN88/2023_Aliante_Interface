using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_Aliante_Intera
{
    internal class Coda : IComposite
    {
        private double _lenght;
        public double Lenght
        {
            get { return _lenght; }
            set
            {
                if (value > 0)
                {
                    _lenght = value;
                }
                else
                {
                    throw new ArgumentException("La lunghezza deve esseere > 0");
                }
            }
        }
        public Coda()
        {
            _lenght = 0;
        }
        public Coda(double lenght)
        {
            _lenght = lenght;
        }
        public Coda(Coda vecchia)
        {
            Lenght = vecchia.Lenght;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Coda) || obj == null)
            {
                return false;
            }

            Coda other = (Coda)obj;
            return Lenght == other.Lenght;
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
            return  $"Lunghezza coda:{Lenght}";
        }
        public double Price()
        {
            return _lenght;
        }
    }
}
