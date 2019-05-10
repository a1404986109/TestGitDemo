using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Common
{
   public class AppConfigurtaionService
    {
        public static IConfiguration Configuration;
        static AppConfigurtaionService()
        {
            Configuration = new ConfigurationBuilder().Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
                .SetBasePath(Directory.GetCurrentDirectory())
               .Build();
        }
    }
}
