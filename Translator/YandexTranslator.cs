using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Translator
{
    class YandexTranslator
    {
        private const string key = "trnsl.1.1.20190605T111104Z.4130d6ab94a26d20.8d5e537c584627ea61ee3512bcd840e528f6eb7e";

        public string Translate(string s, string lang)
        {
            if(s.Length>0)
            {
                WebRequest request = WebRequest.Create("https://translate.yandex.net/api/v1.5/tr.json/translate?"
                     + "key=" + key
                     + "&text=" + s
                     + "&lang=" + lang);

                WebResponse response = request.GetResponse();

                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    string line;

                    if ((line = stream.ReadLine()) != null)
                    {
                        Translation translation = JsonConvert.DeserializeObject<Translation>(line);

                        s = "";

                        foreach (string str in translation.Text)
                        {
                            s += str;
                        }
                    }
                    
                       
                }

                return s;
            }
            else
            {
                return "";
            }
        }
    }
}
