using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcoderPrinter.Model
{
    class BrailleAlphabet
    {
        public bool[,] character(char c)
        {
            switch (c)
            {
                case (char)254://Sinalizador de Shift
                    return new bool[,] {
                        {false, true},
                        {false, false},
                        {false, true}
                    };
                case ' ':
                    return new bool[,] {
                        {false, false},
                        {false, false},
                        {false, false}
                    };
                case 'a':
                    return new bool[,]
                    {
                        {true,false},
                        {false,false},
                        {false,false}
                    };
                case 'b':
                    return new bool[,]
                    {
                        { true, false},
                        { true, false},
                        { false, false}
                    };
                case 'c':
                    return new bool[,] {
                        {true, true},
                        {false, false},
                        {false, false}
                    };
                case 'd':
                    return new bool[,] {
                        {true, true},
                        {false, true},
                        {false, false}
                    };
                case 'e':
                    return new bool[,] {
                        {true, false},
                        {false, true},
                        {false, false}
                    };
                case 'f':
                    return new bool[,] {
                        {true, true},
                        {true, false},
                        {false, false}
                    };
                case 'g':
                    return new bool[,] {
                        {true, true},
                        {true, true},
                        {false, false}
                    };
                case 'h':
                    return new bool[,] {
                        {true, false},
                        {true, true},
                        {false, false}
                    };
                case 'i':
                    return new bool[,] {
                        {false, true},
                        {true, false},
                        {false, false}
                    };
                case 'j':
                    return new bool[,] {
                        {false, true},
                        {true, true},
                        {false, false}
                    };
                case 'k':
                    return new bool[,] {
                        {true, false},
                        {false, false},
                        {true, false}
                    };
                case 'l':
                    return new bool[,] {
                        {true, false},
                        {true, false},
                        {true, false}
                    };
                case 'm':
                    return new bool[,] {
                        {true, true},
                        {false, false},
                        {true, false}
                    };
                case 'n':
                    return new bool[,] {
                        {true, true},
                        {false, true},
                        {true, false}
                    };
                case 'o':
                    return new bool[,] {
                        {true, false},
                        {false, true},
                        {true, false}
                    };
                case 'p':
                    return new bool[,] {
                        {true, true},
                        {true, false},
                        {true, false}
                    };
                case 'q':
                    return new bool[,] {
                        {true, true},
                        {true, true},
                        {true, false}
                    };
                case 'r':
                    return new bool[,] {
                        {true, false},
                        {true, true},
                        {true, false}
                    };
                case 's':
                    return new bool[,] {
                        {false, true},
                        {true, false},
                        {true, false}
                    };
                case 't':
                    return new bool[,] {
                        {false, true},
                        {true, true},
                        {true, false}
                    };
                case 'u':
                    return new bool[,] {
                        {true, false},
                        {false, false},
                        {true, true}
                    };
                case 'v':
                    return new bool[,] {
                        {true, false},
                        {true, false},
                        {true, true}
                    };
                case 'w':
                    return new bool[,] {
                        {false, true},
                        {true, true},
                        {false, true}
                    };
                case 'x':
                    return new bool[,] {
                        {true, true},
                        {false, false},
                        {true, true}
                    };
                case 'y':
                    return new bool[,] {
                        {true, true},
                        {false, true},
                        {true, true}
                    };
                case 'z':
                    return new bool[,] {
                        {true, false},
                        {false, true},
                        {true, true}
                    };
                case '0':
                    return new bool[,] {
                        {false, true},
                        {true, true},
                        {false, false}
                    };
                case '1':
                    return new bool[,] {
                        {true, false},
                        {false, false},
                        {false, false}
                    };
                case '2':
                    return new bool[,] {
                        {true, false},
                        {true, false},
                        {false, false}
                    };
                case '3':
                    return new bool[,] {
                        {true, true},
                        {false, false},
                        {false, false}
                    };
                case '4':
                    return new bool[,] {
                        {true, true},
                        {false, true},
                        {false, false}
                    };
                case '5':
                    return new bool[,] {
                        {true, false},
                        {false, true},
                        {false, false}
                    };
                case '6':
                    return new bool[,] {
                        {true, true},
                        {true, false},
                        {false, false}
                    };
                case '7':
                    return new bool[,] {
                        {true, true},
                        {true, true},
                        {false, false}
                    };
                case '8':
                    return new bool[,] {
                        {true, false},
                        {true, true},
                        {false, false}
                    };
                case '9':
                    return new bool[,] {
                        {false, true},
                        {true, false},
                        {false, false}
                    };
                case '.':
                    return new bool[,] {
                        {false, false},
                        {true, true},
                        {false, true}
                    };
                case ',':
                    return new bool[,] {
                        {false, false},
                        {true, false},
                        {false, false}
                    };
                case ';':
                    return new bool[,] {
                        {false, false},
                        {true, false},
                        {true, false}
                    };
                case ':':
                    return new bool[,] {
                        {false, false},
                        {true, true},
                        {false, false}
                    };
                case '/':
                    return new bool[,] {
                        {false, true},
                        {false, false},
                        {true, false}
                    };
                case '?':
                    return new bool[,] {
                        {false, false},
                        {true, false},
                        {true, true}
                    };
                case '!':
                    return new bool[,] {
                        {false, false},
                        {true, true},
                        {true, false}
                    };
                case '@':
                    return new bool[,] {
                        {false, false},
                        {false, true},
                        {true, false}
                    };
                case '*':
                    return new bool[,] {
                        {false, true},
                        {false, true},
                        {true, false}
                    };
                case '#':
                    return new bool[,] {
                        {false, true},
                        {false, true},
                        {true, true}
                    };
                case '+':
                    return new bool[,] {
                        {false, false},
                        {true, true},
                        {true, false}
                    };
                case '-':
                    return new bool[,] {
                        {false, false},
                        {true, true},
                        {false, false}
                    };
                case '=':
                    return new bool[,] {
                        {false, false},
                        {true, true},
                        {true, true}
                    };
                case 'á':
                    return new bool[,] {
                        {true, false},
                        {true, true},
                        {true, true}
                    };
                case 'à':
                    return new bool[,] {
                        {true, true},
                        {true, false},
                        {false, true}
                    };
                case 'ã':
                    return new bool[,] {
                        {false, true},
                        {false, true},
                        {true, false}
                    };
                case 'â':
                    return new bool[,] {
                        {true, false},
                        {false, false},
                        {false, true}
                    };
                case 'é':
                    return new bool[,] {
                        {true, true},
                        {true, true},
                        {true, true}
                    };
                case 'è':
                    return new bool[,] {
                        {false, true},
                        {true, false},
                        {true, true}
                    };
                case 'ê':
                    return new bool[,] {
                        {true, false},
                        {true, false},
                        {false, true}
                    };
                case 'í':
                    return new bool[,] {
                        {false, true},
                        {false, false},
                        {true, false}
                    };
                case 'ì':
                    return new bool[,] {
                        {true, true},
                        {false, false},
                        {false, true}
                    };
                case 'ó':
                    return new bool[,] {
                        {false, true},
                        {false, false},
                        {true, true}
                    };
                case 'õ':
                    return new bool[,] {
                        {false, true},
                        {true, false},
                        {false, true}
                    };
                case 'ô':
                    return new bool[,] {
                        {true, true},
                        {false, true},
                        {false, true}
                    };
                case 'ú':
                    return new bool[,] {
                        {false, true},
                        {true, true},
                        {true, true}
                    };
                case 'ç':
                    return new bool[,] {
                        {true, true},
                        {true, false},
                        {true, true}
                    };
                default:
                    return new bool[,]
                    {
                        {false, false},
                        {false, false},
                        {false, false}
                    };
            }
        }
    }
}
