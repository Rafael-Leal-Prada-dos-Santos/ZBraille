using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorTubos.Controller
{
    public interface ComunicacaoArduino
    {
        #region Comunicação Serial

         ArrayList pegarPortasSeriais();
         //Boolean testeComunicacaoArduino(String Porta);
    

        #endregion


    }
}
