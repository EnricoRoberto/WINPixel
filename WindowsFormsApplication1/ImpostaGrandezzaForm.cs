using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ImpostaGrandezzaForm
    {
        public int larghezza;
        public int altezza;

        public void imposta(String h, String l, int maxh, int maxl)
        {
            altezza = Convert.ToInt32(h);
            larghezza = Convert.ToInt32(l);

            if (altezza < maxh)
            {
                altezza = maxh;
            }

            if (larghezza < maxl)
            {
                larghezza = maxl;
            }
        }
    }
}
