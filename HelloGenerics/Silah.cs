using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGenerics
{
    class Silah<T> where T:ISarjor

    {
        public int SeriNo { get; set; }
        public String ModelAdi { get; set; }
        public T SarjorModeli { get; set; }


        public Silah(T sarjorModeli)
        {
            if (!typeof(T).IsInterface)
                throw new Exception("Interface required");
            this.SarjorModeli = sarjorModeli;
        }

        public T getSarjor() {
            return SarjorModeli;
        }
        
    }
}
