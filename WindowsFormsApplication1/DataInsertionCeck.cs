using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DataInsertionCeck
    {
        
    public bool dataCeck(string str)
        {
            bool res = false;

            if (Convert.ToInt32(str) > 0 )
            {
                res = true;
            }
                      
            return  res;
        }
    }
}
