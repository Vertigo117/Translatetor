using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Windows;

namespace Translator
{
    class YandexTranslator
    {
        private const string key = "trnsl.1.1.20190605T111104Z.4130d6ab94a26d20.8d5e537c584627ea61ee3512bcd840e528f6eb7e";
        private WebResponse response;
        private WebRequest request;
        private Languages languages;

        public string Translate(string s, string lang)
        {
            if(s.Length>0)
            {
                request = WebRequest.Create("https://translate.yandex.net/api/v1.5/tr.json/translate?"
                     + "key=" + key
                     + "&text=" + s
                     + "&lang=" + lang);

                try
                {
                    response = request.GetResponse();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return "";
                }


                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    string line;

                    if ((line = stream.ReadLine()) != null)
                    {
                        Translation translation = JsonConvert.DeserializeObject<Translation>(line);

                        s = "";

                        foreach (string str in translation.text)
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

        public Dictionary<string,string> GetLanguages()
        {
            request = WebRequest.Create("https://translate.yandex.net/api/v1.5/tr.json/getLangs?"
                + "key=" + key
                + "&ui=ru");

            try
            {
                response = request.GetResponse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Dictionary<string, string> emptyDict = new Dictionary<string, string>();
                emptyDict.Add("пусто", "пусто");
                return emptyDict;
            }

            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                string line;

                if ((line = stream.ReadLine()) != null)
                {
                    languages = JsonConvert.DeserializeObject<Languages>(line);
                }
            }

            return languages.langs;
        }
    }
}
