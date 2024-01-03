using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace _2023_Aliante_Intera
{
    internal class Fusoliera:IComposite
    {
        private double _length;
        private string _materiale;

        public double Length
        {
            get { return _length; }
            set
            {
                if( value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException("La lunghezza deve esseere > 0");
                }
            }
        }
        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }
        public Fusoliera()
        {
            Length = 0;
            Materiale = String.Empty;
        }
        public Fusoliera(double length,string materiale)
        {
            Length = 0;
            Materiale = materiale;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Fusoliera otherFusoliera) || otherFusoliera is null)
            {
                return false;
            }

            return Length == otherFusoliera.Length && Materiale == otherFusoliera.Materiale;
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
            return $"Lunghezza fusoliera:{Length};Materiale fusoliera:{Materiale}";
        }
        public double Price()
        {
            return Length * 3;
        }
    }
}
