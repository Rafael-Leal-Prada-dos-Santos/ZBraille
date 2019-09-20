using GcoderPrinter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcoderPrinter.Controller
{
    class Gcoder
    {
        Build builder = new Build();

        //public List<String> gerarGcode(String texto)
        //{

        //    return builder.text(texto, 0, 0);

        //}
        public List<String> gerarGcode(List<String> texto)
        {
            //    List<String> retorno = new List<string>();
            //    float posLinha = 0;
            //    foreach (string s in texto)
            //    {
            //        retorno.AddRange(builder.text(s, 0, posLinha));
            //        posLinha += 10;
            //    }
            //    return retorno;

            return builder.text(texto, 0, 0);

        }

    }
}
