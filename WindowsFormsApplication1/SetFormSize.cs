using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Converte due stringhe in due int, con un valore massimo impostabile
    /// I valori risultanti sono su variabili globali
    /// </summary>
    class SetFormSize
    {
        public int larghezza;
        public int altezza;

        public void imposta(String h, String l, int minh, int minl)
        {
            altezza = Convert.ToInt32(h);
            larghezza = Convert.ToInt32(l);

            if (altezza < minh)
            {
                altezza = minh;
            }

            if (larghezza < minl)
            {
                larghezza = minl;
            }
        }
    }
}
