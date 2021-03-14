using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictonary
{
    class MyDictonary<K, L>
    {
        K[] Numara;
        L[] Isim;

        public MyDictonary()
        {
            Numara = new K[0];
            Isim = new L[0];
        }

        public void Add(K item1, L item2)
        {
            K[] tempNumara = Numara;
            L[] tempİsim = Isim;

            Numara = new K[Numara.Length + 1];
            Isim = new L[Isim.Length + 1];

            for (int i = 0; i < tempNumara.Length; i++)
            {
                Numara[i] = tempNumara[i];
                Isim[i] = tempİsim[i];
            }
            Numara[Numara.Length - 1] = item1;
            Isim[Isim.Length - 1] = item2;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyDictonary<K, L>);
        }

        public bool Equals(MyDictonary<K, L> other)
        {
            return other != null &&
                   EqualityComparer<K[]>.Default.Equals(Numara, other.Numara) &&
                   EqualityComparer<L[]>.Default.Equals(Isim, other.Isim);
        }
    }
}
