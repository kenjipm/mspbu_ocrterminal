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
        public static dynamic Request(string host, string url, string content, string method, object data)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(host + url);
            httpWebRequest.ContentType = content;
            httpWebRequest.Method = method;
            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(data);
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

        public static dynamic Request(string host, string url, object data)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(host + url);
            //Console.WriteLine(host + url);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.KeepAlive = false;
            httpWebRequest.Timeout = 100000;
            //Console.WriteLine(httpWebRequest.ContentType);
            //Console.WriteLine(httpWebRequest.Method);
            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(data);
                //Console.WriteLine(json);
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

        public static dynamic UploadPDF(string filePath)
        {
            byte[] pdfFile = File.ReadAllBytes(filePath);

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Url.Service + Url.UploadPDF);
            httpWebRequest.Method = "POST";
            httpWebRequest.AllowWriteStreamBuffering = true;
            httpWebRequest.ContentLength = pdfFile.Length;

            Stream stream = httpWebRequest.GetRequestStream();
            stream.Write(pdfFile, 0, pdfFile.Length);
            stream.Flush();
            stream.Close();

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                string temp = streamReader.ReadToEnd();
                streamReader.Close();
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                dynamic result = serializer.Deserialize<dynamic>(temp);
                return result[Url.UploadPDF + "Result"];
            }
        }
    }
}