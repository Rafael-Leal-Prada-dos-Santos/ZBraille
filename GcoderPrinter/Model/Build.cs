using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GcoderPrinter.Model
{
    class Build
    {
        public List<String> cell(char _letra, float startX, float startY)
        {
            BrailleAlphabet alfabeto = new BrailleAlphabet();
            List<String> coordenadasGcoder = new List<String>();

            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    counter++;
                    float x = 0;
                    float y = 0;
                    switch (counter)
                    {
                        case 1:
                            x = startX;
                            y = startY;
                            break;
                        case 2:
                            x = startX + 2.7f;
                            y = startY;
                            break;
                        case 3:
                            x = startX;
                            y = startY + 2.7f;
                            break;
                        case 4:
                            x = startX + 2.7f;
                            y = startY + 2.7f;
                            break;
                        case 5:
                            x = startX;
                            y = startY + 2.7f + 2.7f;
                            break;
                        case 6:
                            x = startX + 2.7f;
                            y = startY + 2.7f + 2.7f;
                            break;
                    }
                    if (alfabeto.character(_letra)[i, j])
                    {

                        //System.Console.WriteLine(';' + _letra.ToString());

                        coordenadasGcoder.Add("G0 X" + x.ToString(CultureInfo.InvariantCulture) + " Y" + y.ToString(CultureInfo.InvariantCulture) + " M3 S50");
                        coordenadasGcoder.Add("G0 X" + x.ToString(CultureInfo.InvariantCulture) + " Y" + y.ToString(CultureInfo.InvariantCulture) + " M3 S5");
                        coordenadasGcoder.Add("G0 X" + x.ToString(CultureInfo.InvariantCulture) + " Y" + y.ToString(CultureInfo.InvariantCulture) + " M3 S50");
                        
                   }
                }
            }
            return coordenadasGcoder;
        }

        public List<String> line(String _texto, float startX, float startY)
        {
            double number;
            string[] words = _texto.Split(' ');
            bool hasNumber;
            List<string> gCoderFormatado = new List<string>();

            int index = 0;
            foreach (string s in words)
            {
                hasNumber = Double.TryParse(s, out number);

                if (hasNumber)
                {
                    words[index] = '#' + s;
                    index++;
                }
                else
                {
                    index++;
                }
            }

            if (_texto.Length > 20)
            {
                int qtdLinhas = calculaQuebrasDeLinha(_texto);
                string[] linhas = new String[qtdLinhas];
                int charCounter = 0;

                for (int j = 0; j < qtdLinhas; j++)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        charCounter += words[i].Length;
                        charCounter++;

                        if (charCounter >= 20)
                        {
                            charCounter = 0;
                            i--;
                            j++;
                        }
                        else
                        {
                            linhas[j] += words[i] + " ";
                        }
                    }
                }

                foreach (string s in linhas)
                {
                    buildChars(s);
                    startY += 10;
                    startX = 0;
                }
            }

            else
            {
                buildChars(String.Join(" ", words));
            }
            return gCoderFormatado;

            void buildChars(string _linha)
            {
                for (int i = 0; i < _linha.Length; i++)
                {
                    bool hasUpper = _linha[i] > 0x40 && _linha[i] < 0x5B;

                    if (hasUpper)
                    {
                        gCoderFormatado.AddRange(cell((char)254, (startX + (i * 6.6f)), startY));
                        startX += 6.6f;
                        gCoderFormatado.AddRange(cell((char)(_linha[i] + 0x20), (startX + (i * 6.6f)), startY));
                    }
                    else
                    {
                        gCoderFormatado.AddRange(cell(_linha[i], (startX + (i * 6.6f)), startY));
                    }

                }
            }
        }

        int calculaQuebrasDeLinha(String _texto)
        {
            string[] words = _texto.Split(' ');
            int qtdLinhas = 1;

            int charCounter = 0;
            for (int i = 0; i < words.Length; i++)
            {
                charCounter += words[i].Length;
                charCounter++;

                if (charCounter >= 20 || words[i].Contains('\n'))
                {
                    charCounter = 0;
                    qtdLinhas++;
                    i--;
                }
            }
            return qtdLinhas;
        }

        public List<String> text(List<String> _texto, float startX, float startY)
        {
            List<String> retorno = new List<string>();

            foreach (string s in _texto)
            {
                retorno.AddRange(line(s, startX, startY));

                startY += 10*calculaQuebrasDeLinha(s);
            }
            return retorno;
        }

    }

}