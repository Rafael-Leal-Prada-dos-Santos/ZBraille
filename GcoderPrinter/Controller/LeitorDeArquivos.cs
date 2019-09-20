using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcoderPrinter.Controller
{

    class LeitorDeArquivos
    {

        public List<string> lerArquivo(String pathDoc)
        {

            List<string> data = new List<string>();
            Application app = new Application();
            Document doc = app.Documents.Open(pathDoc);

            foreach (Paragraph objParagraph in doc.Paragraphs)
                data.Add(objParagraph.Range.Text.Trim());

            ((_Document)doc).Close();
            ((_Application)app).Quit();

            return data;
        }

    }
}
