using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace NumbersDate
{
    internal class ConnectionString
    {
        public static string ConnStr 
        {
            get 
            {
                return ConfigurationManager.ConnectionStrings["NumbersDate.Properties.Settings.ConnStr"].ConnectionString;
            }
        }
    }
}
