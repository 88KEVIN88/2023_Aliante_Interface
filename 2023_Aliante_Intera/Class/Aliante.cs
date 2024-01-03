using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_Aliante_Intera
{
    internal class Aliante : IComposite
    {
        private List<IComposite> _componenti;

        public List<IComposite> Componenti
        {
            get { return _componenti; }
            set { _componenti = value; }
        }

        public Aliante()
        {
            Componenti = new List<IComposite>();
        }
        public Aliante(List<IComposite> componenti)
        {
            Componenti = componenti;
        }
        public Aliante(Aliante vecchio)
        {
            Componenti = vecchio.Componenti;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Aliante otherAliante) || otherAliante is null)
            {
                return false;
            }

            return Componenti.Count == otherAliante.Componenti.Count &&
                   Componenti.SequenceEqual(otherAliante.Componenti);
        }
        public void Add(IComposite componenti)
        {
            Componenti.Add(componenti);
        }
        public void Remove(int index)
        {
            Componenti.RemoveAt(index); 
        }
        public IComposite Get(int index)
        {
            if (Componenti.Count > index)
            {
                return Componenti[index];
            }
            return null;
        }
        public override string ToString()
        {
            string stringa = "";
            foreach(var componenti in Componenti)
            {
                stringa += componenti.ToString();
            }
            return stringa;
        }
        public double Price()
        {
            double tot  = 0;
            foreach(var componenti in Componenti)
            {
                tot += componenti.Price();
            }
            return tot;
        }
    }
}
