using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalLib
{
    public class Json
    {
        public static void Serialize<T>(string fileName, T obj)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if(!File.Exists(desktop + "\\" + fileName))
            {
                FileStream fileStream = File.Create(desktop + "\\" + fileName);
                fileStream.Dispose();
            }

            var json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(desktop + "\\" + fileName, json);
        }

        public static T Deserialize<T>(string fileName)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (!File.Exists(desktop + "\\" + fileName))
            {
                FileStream fileStream = File.Create(desktop + "\\" + fileName);
                fileStream.Dispose();
            }

            string json = File.ReadAllText(desktop + "\\" + fileName);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
    }
}
