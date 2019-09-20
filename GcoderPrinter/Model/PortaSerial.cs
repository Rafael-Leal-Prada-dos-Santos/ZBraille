using SimuladorTubos.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace SimuladorTubos.Model
{
    class PortaSerial : ComunicacaoArduino
    {
        private SerialPort portaSelecionada { get; set; }

        public List<String> log = new List<String>();
        public List<String> portasSeriais = new List<String>();


        public int sendProgress = 0;
        public int sendIndex = 0;
        public bool enviando = false;
        public bool cancelaImpressao = false;
        public bool papelNaPosicao = false;
        public string statusImpressora = "";


        #region Métodos e tratamentos para as portas Seriais
        public SerialPort getPort()
        {

            return portaSelecionada;

        }

        public void encerrarPorta()
        {

            if (portaSelecionada.IsOpen)
            {
                portaSelecionada.Close();
            }
        }

        public void conectar(String porta)
        {
            if (portaSelecionada.IsOpen)
            {
                portaSelecionada.Close();
            }
            portaSelecionada.PortName = porta;
            try
            {
                portaSelecionada.Open();
                configuraGRBL();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public Boolean isOpen()
        {
            return portaSelecionada.IsOpen;
        }

        public PortaSerial(SerialDataReceivedEventHandler callBackDisplay)
        {

            portaSelecionada = new SerialPort();
            portaSelecionada.BaudRate = 115200;
            portaSelecionada.ReadTimeout = 60000;
            portaSelecionada.WriteTimeout = 60000;
            portaSelecionada.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(callBackDisplay);


        }
        public PortaSerial(SerialDataReceivedEventHandler callBackDisplay, int _baudRate)
        {

            portaSelecionada = new SerialPort();
            //portaSelecionada.BaudRate = _baudRate;
            portaSelecionada.BaudRate = 115200;
            portaSelecionada.ReadTimeout = 60000;
            portaSelecionada.WriteTimeout = 60000;
            portaSelecionada.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(callBackDisplay);

        }
        public ArrayList pegarPortasSeriais()
        {

            String[] portas = SerialPort.GetPortNames();
            ArrayList PortasEncontradas = new ArrayList();
            foreach (String porta in portas)
            {
                PortasEncontradas.Add(porta);
            }
            return PortasEncontradas;
        }

        public List<String> pegarPortasImpressoras()
        {

            String[] portas = SerialPort.GetPortNames();
            List<String> PortasEncontradas = new List<String>();
            foreach (String porta in portas)
            {
                PortasEncontradas.Add(porta);
            }
            if (portasSeriais.SequenceEqual(PortasEncontradas))
            {
                return null;
            }
            else
            {
                portasSeriais = PortasEncontradas;
                return PortasEncontradas;
            }
        }
        #endregion
        #region metodos de comandos e configurações do Grbl
        public void configuraGRBL()
        {
            statusImpressora = "Configurando";

            string[] config =
            {
                "$X",              //Unlock  
                "$X",
                "$X",
                "$X",
                "$X",
                "$X",
                "$X",
                "$X",
                "G21",              //Set unit to millimeters
                "M3 S60",           //Servo initial position
                "F2000",            //Feed rate
                "$20=0",            //(software limits, bool, controlled by Axis max travel)
                "$22=1",            //Enable Homming
                "$23=0",            //Invert Homming Direction
                "$26=250",           //Homming Debounce, miliseconds                
                "$N0=G92X0Y0M3S60", //Set Homming position  
                "$N1=",             //Set Homming position
                "$110=3000",        //Max speed rate x axis        
                "$120=3000",        //Max acceleration x
                "$100=400",         //Steps per mm x axis
                "$101=125",         //Steps per mm y axis                
                "$130=220.000",     //(x max travel, mm)
                "$21=1",            //(hard limits, bool)                
                "$24=25",         //(homing feed, mm/min)
                "$25=500",         //(homing seek, mm/min)
                "$H",               //Go home
                "$3=3",             //Axis invert mask(1 = only X is inverted, 3 = X and Y inverted)  
                "X-206.5",
                "G92X0Y0M3S60"
                //"G28.1",
                //"G30.1",

            };
            foreach (string s in config)
            {
                portaSelecionada.WriteLine(s);
                System.Threading.Thread.Sleep(200);
            }

            statusImpressora = "Impressora Configurada!";
        }

        public void goHome()
        {
            portaSelecionada.WriteLine("X0");
            System.Threading.Thread.Sleep(500);
            portaSelecionada.WriteLine("G28.1");
            System.Threading.Thread.Sleep(500);
            portaSelecionada.WriteLine("G30.1");
        }

        Boolean readyToPrint() {
            

            Stopwatch relogio = new Stopwatch();
                       
            relogio.Start();

            checkPaper();

            
            string resposta = portaSelecionada.ReadLine();
            var tempoDecorrido = relogio.ElapsedMilliseconds;

            while (tempoDecorrido < 5000) {

                tempoDecorrido = relogio.ElapsedMilliseconds;

                if (resposta != "detectado\r")
                {
                    papelNaPosicao = false;
                    checkPaper();
                    resposta = portaSelecionada.ReadLine();
                }
                else {
                    papelNaPosicao = true;
                    break;
                }
                
            }

            if (resposta != "detectado\r")
            {
                papelNaPosicao = false;
            }
            else {
                papelNaPosicao = true;
            }

            relogio.Stop();

            return papelNaPosicao;

        }

        public void preparaImpressora()
        {
            pararFeed();
            System.Threading.Thread.Sleep(500);
            resetGrbl();
            System.Threading.Thread.Sleep(500);
            destravarGrbl();
        }



        #region Métodos para comandos
        public void puxarPapel() {
            portaSelecionada.WriteLine("Y2000");
        }

        public void destravarGrbl() {
            portaSelecionada.WriteLine("$X");
        }

        public void pararFeed()
        {
            portaSelecionada.WriteLine("!");
        }

        public void resetGrbl() {
            string reset = Encoding.ASCII.GetString(new byte[] { 24 });
            portaSelecionada.Write(reset);
        }

        public void checkPaper() {
            string checkForPaper = Encoding.ASCII.GetString(new byte[] { 37 });
            portaSelecionada.Write(checkForPaper);
        }
        
        #endregion

        #endregion

        #region Imprimir
        public async Task<bool> imprimirGcoderAsync(String Porta, List<String> _textoEmGcoder)
        {


            if (portaSelecionada.IsOpen == false)
            {

                try
                {
                    portaSelecionada.PortName = Porta;
                    portaSelecionada.Open();
                }
                catch
                {
                    return false;
                }
            }

            puxarPapel();

            statusImpressora = "Verificando Papel...";

            if (readyToPrint()) {           
                                

                statusImpressora = "Papel na posição.";   
                
                preparaImpressora();

                statusImpressora = "imprimindo...";

                sendIndex = -1;
                foreach (String linha in _textoEmGcoder)
                {
                    if (cancelaImpressao)
                    {                       
                        enviando = false;
                        statusImpressora = "Impressão Cancelada!";
                        goHome();
                        return true;
                    }
                    else 
                    {                       
                        enviando = true;
                        portaSelecionada.WriteLine(linha);
                        sendIndex++;
                        sendProgress = 100 * sendIndex / _textoEmGcoder.Count;
                        await Task.Delay(625);
                    }
                    

                }

            }
            else
            {                
                goHome();
                preparaImpressora();
                enviando = false;
                statusImpressora = "Impressão Cancelada!";
                MessageBox.Show("5 segundos sem folha na base de impressão. insira uma folha ", "Tempo Esgotado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            statusImpressora = "Impressão Concluída!";

            goHome();
            enviando = false;
            return true;
            

        }

        #endregion

    }



}