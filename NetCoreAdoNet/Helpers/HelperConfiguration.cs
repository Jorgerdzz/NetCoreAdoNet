using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAdoNet.Helpers
{
    public class HelperConfiguration
    {
        //TENEMOS VARIAS OPCIONES
        //DEPENDIENDO DEL TIPO DE LOGICA, PODREMOS PENSAR DE UNA FORMA O DE OTRA
        //QUEREMOS RECUPERAR EL OBJETO CONFIGURATION
        public static IConfigurationRoot GetConfiguration()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            IConfigurationRoot configuration = builder.Build();
            return configuration;
        }
    }
}
