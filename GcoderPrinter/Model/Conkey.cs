using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBraillePrinter.Model
{
    class Conkey
    {
        public int xStep { get; set; }
        public int yStep { get; set; }
        public int servoUp { get; set; }
        public int servoDown { get; set; }
        public int maxCharLine { get; set; }
        public bool doubleDot { get; set; }

        public static Conkey getConkey()
        {
            Conkey conkey;
            string strArquivo = Application.StartupPath.ToString() + "\\Conkey.json";

            if (File.Exists(strArquivo))
            {
                StreamReader sr = new StreamReader(strArquivo);
                string conkeyJson = sr.ReadToEnd();
                sr.Close();
                conkey = JsonConvert.DeserializeObject<Conkey>(conkeyJson);
                return conkey;

            }
            else
            {

                return null;

            }
        }

        public static void setConkey(Conkey tempConkey)
        {
            string json = JsonConvert.SerializeObject(tempConkey, Formatting.Indented);
            string strArquivo = Application.StartupPath.ToString() + "\\Conkey.json";
            System.IO.File.WriteAllText(strArquivo, json);
        }

        private Conkey()
        {

        }

    }
}
