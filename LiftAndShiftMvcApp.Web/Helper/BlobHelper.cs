using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;

namespace LiftAndShiftMvcApp.Web.Helper
{
    public static class BlobHelper
    {
        static string account = ConfigurationManager.AppSettings["StorageAccountName"];
        static string key = ConfigurationManager.AppSettings["StorageAccountKey"];
        public static CloudStorageAccount GetConnectionString()
        {
            string connectionString = string.Format("DefaultEndpointsProtocol=https;AccountName={0};AccountKey={1}", account, key);
            return CloudStorageAccount.Parse(connectionString);
        }
    }
}