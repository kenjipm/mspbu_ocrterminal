using System.Collections.Generic;
using System.IO;

namespace OCR_Terminal
{
    class Property
    {
        private Dictionary<string, string> prop = new Dictionary<string, string>();

        public Property(string filePath)
        {
            string[] property = File.ReadAllLines(filePath);
            string[] propTemp;

            foreach (string properties in property)
            {
                propTemp = properties.Split('=');

                if (propTemp.Length == 2)
                {
                    prop.Add(propTemp[0], propTemp[1]);
                }
            }
        }

        public string GetValue(string key, string defaultValue)
        {
            if (!prop.ContainsKey(key))
            {
                return defaultValue;
            }
            else
            {
                return prop[key];
            }
        }
    }
}
