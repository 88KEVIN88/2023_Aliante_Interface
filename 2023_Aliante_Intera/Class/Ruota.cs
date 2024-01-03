using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_Aliante_Intera
{
    internal class Ruota : IComposite
    {
        private Gomma _gomma;
        private Cerchione _cerchione;

        public Gomma Gomma
        {
            get { return _gomma; }
            set { _gomma = value; }
        }
        public Cerchione Cerchione
        {
            get { return _cerchione; }
            set { _cerchione = value; }
        }
        public Ruota()
        {
            Gomma = new Gomma();   
            Cerchione = new Cerchione();
        }
        public Ruota(Gomma gomma, Cerchione cerchione)
        {
            Gomma = gomma;
            Cerchione = cerchione;
        }
        public Ruota(Ruota vecchia)
        {
            Gomma = vecchia.Gomma;
            Cerchione = vecchia.Cerchione;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Ruota otherRuota) || otherRuota is null)
            {
                return false;
            }

            return Gomma.Equals(otherRuota.Gomma) && Cerchione.Equals(otherRuota.Cerchione);
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
            return $"Descrizione:{Gomma};Cerchioni:{Cerchione};";
        }
        public double Price()
        {
            return 0;
        }
    }
}
