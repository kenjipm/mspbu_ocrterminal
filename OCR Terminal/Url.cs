using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR_Terminal
{
    class Url
    {
        private static string propFilePath = "app.properties";
        private static Property prop = new Property(propFilePath);
        public static string Service = prop.GetValue("host", "http://localhost:2424/Service.svc/");

        public static string Login = "validateLogin";
        public static string Information = "getInformation";
        public static string UpdateStock = "stockInsert";
        public static string GetStock = "stockGet";
        public static string UploadOrder = "uploadOrder";
        public static string UploadPDF = "sppSavePDF";
        public static string UploadSpp = "sppInsert";
    }
}