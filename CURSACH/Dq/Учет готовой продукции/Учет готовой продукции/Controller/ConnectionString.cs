using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Учет_готовой_продукции.Controller
{
    internal class ConnectionString
    {
        public static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Учет_готовой_продукции.Properties.Settings.ConnStr"].ConnectionString;
            }
        }
    }
}
