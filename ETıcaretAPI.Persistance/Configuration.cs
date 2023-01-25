using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETıcaretAPI.Persistance
{
    public static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../ETıcaretAPI/ETıcaretAPI.API"));
                //D:\ETıcaretAPI\ETıcaretAPI.Persistance
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("SQLSERVER");
            }
        }

    }
}
