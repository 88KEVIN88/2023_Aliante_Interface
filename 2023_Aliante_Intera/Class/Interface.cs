using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_Aliante_Intera
{
    public interface IComposite
    {
        void Add(IComposite componente);
        void Remove(int index);
        IComposite Get(int index);
        bool Equals(object obj);
        string ToString();
        double Price();
    }
}
