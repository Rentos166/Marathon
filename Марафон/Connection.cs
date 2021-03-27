using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Марафон
{
    class Connection
    {
        public static string GetString()
        {
            return @"Data Source=DESKTOP-PKUSCSQ\SQLEXPRESS;Initial Catalog=Marathon;Integrated Security=True";
        }
    }
}
