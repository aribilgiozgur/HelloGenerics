using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGenerics
{
    class NormalSarjor : ISarjor
    {
        public String getText() {
            return "Normal Şarjör";
        }
        public int getId()
        {
            return 1;
        }
    }
}
