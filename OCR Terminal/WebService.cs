using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace OCR_Terminal
{
    class WebService
    {
        public static dynamic Request(string host, string url, object data)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(host + url);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "POST";

            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(data);
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();

                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    string temp = streamReader.ReadToEnd();
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    dynamic result = serializer.Deserialize<dynamic>(temp);
                    return result[url + "Result"];
                    //return JsonConvert.DeserializeObject(streamReader.ReadToEnd(), outputType);
                }
            }
        }
    }
}
