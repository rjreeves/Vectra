using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Vectra
{
    static class myConfig
    {
        public static string connstr
        {
            get { 
                    return ConfigurationManager.ConnectionStrings["Vectra.Properties.Settings.ConnectionString"].ToString();
                }
        }
            
    }
}
