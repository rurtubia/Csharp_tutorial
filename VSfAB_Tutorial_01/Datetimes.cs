using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSfAB_Tutorial_01
{
    class Datetimes
    {
        DateTime myDateTyme = DateTime.Now;
        
        public void dateTimeToString()
        {
            Console.WriteLine(myDateTyme.ToString());
        }
    }
}
