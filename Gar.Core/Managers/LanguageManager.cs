using Gar.Data.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Gar.Core.Managers
{
    public class LanguageManager
    {
        public Language Language
        {
            get;
            set;
        }

        public LanguageManager()
        {
            LoadLanguage(SettingsManager.Language);
        }

        public void LoadLanguage(string code)
        {
            var stream = Assembly.GetAssembly(typeof(Language)).GetManifestResourceStream("Gar.Data.Resources.Languages." + code + ".json");
            try
            {
                using (var sr = new StreamReader(stream))
                {
                    string result = sr.ReadToEnd();
                    Language = JsonConvert.DeserializeObject<Language>(result);
                }
            }
            catch (Exception) { }
        }
    }
}
