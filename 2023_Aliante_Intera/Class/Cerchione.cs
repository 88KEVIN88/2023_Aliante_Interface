using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_Aliante_Intera
{
    public class Cerchione : IComposite
    {
        private double _pollici;
        private string _materiale;

        public double Pollici
        {
            get { return _pollici; }
            set
            {
                if(value > 0 && value < 10)
                {
                    _pollici = value;
                }
                else
                {
                    throw new ArgumentException("La dimensione deve esseere > 0");
                }
            }
        }
        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }
        public Cerchione()
        {
            Pollici = 0;
            Materiale = string.Empty;
        }
        public Cerchione(double pollici, string materiale)
        {
            Pollici = pollici;
            Materiale = materiale;
        }
        public Cerchione(Cerchione vecchio)
        {
            Pollici = vecchio.Pollici;
            Materiale = vecchio.Materiale;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Cerchione) || obj == null)
            {
                return false;
            }

            Cerchione other = (Cerchione)obj;
            return Pollici == other.Pollici && Materiale == other.Materiale;
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
            return $"Pollici: {Pollici}; Materiale:{Materiale}";
        }
        public double Price()
        {
            return Pollici;
        }
            
    }
}
