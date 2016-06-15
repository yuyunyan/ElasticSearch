using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Sabio.Web.Services
{
    public class ConfigService
    {
        public static string ESAccessKey
        {
            get { return ConfigService.GetFromConfig("ESAccessKey"); }
        }

        public static string ESSecretKey
        {
            get { return ConfigService.GetFromConfig("ESSecretKey"); }
        }

        public static string ESRegion
        {
            get { return ConfigService.GetFromConfig("ESRegion"); }
        }

        public static string ESurl
        {
            get { return ConfigService.GetFromConfig("ESurl"); }
        }

        //**********************************************************************

        private static string GetFromConfig(string key)
        {
            return WebConfigurationManager.AppSettings[key];
        }

        // DIY Principles 
       
    }
}
