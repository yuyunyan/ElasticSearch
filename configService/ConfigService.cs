using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Sabio.Web.Services
{
    public class ConfigService
    {
        public static string AWSProfileName
        {
            get { return ConfigService.GetFromConfig("AWSProfileName"); }
        }

        public static string uploadFileS3AccessKey
        {
            get { return ConfigService.GetFromConfig("uploadFileS3AccessKey"); }
        }

        public static string uploadFileS3SecretKey
        {
            get { return ConfigService.GetFromConfig("uploadFileS3SecretKey"); }
        }

        public static string uploadFileS3Prefix
        {
            get { return ConfigService.GetFromConfig("uploadFileS3Prefix"); }
        }

        public static string uploadFileS3BucketName
        {
            get { return ConfigService.GetFromConfig("uploadFileS3BucketName"); }
        }

        public static string uploadFileS3BaseUrl
        {
            get { return ConfigService.GetFromConfig("uploadFileS3BaseUrl"); }
        }

        public static string baseUrl
        {
            get { return ConfigService.GetFromConfig("baseUrl"); }
        }

        public static string TiwlioPhoneNumber
        {
            get { return ConfigService.GetFromConfig("TiwlioPhoneNumber"); }
        }

        public static string TwilioAccountSid
        {
            get { return ConfigService.GetFromConfig("TwilioAccountSid"); }
        }

        public static string TwilioAuthToken
        {
            get { return ConfigService.GetFromConfig("TwilioAuthToken"); }
        }

        public static string AutoDealioEntityID
        {
            get { return ConfigService.GetFromConfig("AutoDealioEntityID"); }
        }

        public static string AutoDealioWebsiteID
        {
            get { return ConfigService.GetFromConfig("AutoDealioWebsiteID"); }
        }
        public static string DTCFileName
        {
            get { return ConfigService.GetFromConfig("DTCFileName"); }
        }
        public static string DTCUserName
        {
            get { return ConfigService.GetFromConfig("DTCUserName"); }
        }
        public static string DTCPassword
        {
            get { return ConfigService.GetFromConfig("DTCPassword"); }
        }
        // for Elastic Search 
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
        //private static string GetElasticSearch(string key)
        //{
        //    return WebConfigurationManager.AppSettings[key];
        //}



    }
}