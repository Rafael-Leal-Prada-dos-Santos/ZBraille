using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GcoderPrinter.Controller;
using SimuladorTubos.Controller;
using SimuladorTubos.Model;
using GcoderPrinter.View;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Text.RegularExpressions;
using ZBraillePrinter.Model;
using Newtonsoft.Json;
using System.Diagnostics;
namespace GcoderPrinter
{
    public partial class frmMain : MaterialForm
    {

        PortaSerial portaSerial;
        LeitorDeArquivos leitorDeArquivos;
        List<String> textoEmGcode = new List<string>();
        List<String> orderTextoEmGcode = new List<string>();
        private MaterialSkinManager materialSkinManager;
        bool autenticado = false;

        public frmMain()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800,//header
                Primary.Grey900,//top form
                Primary.Yellow100,//nada
                Accent.Red700,
                TextShade.WHITE
                );

        }
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
        //        return cp;
        //    }
        //}


        private void frmMain_Load(object sender, EventArgs e)
        {

            portaSerial = new PortaSerial(serialPort_DataReceived);
            lblStatus.ForeColor = System.Drawing.Color.Red;

            txtXStep.Text = Conkey.getConkey().xStep.ToString();
            txtYStep.Text = Conkey.getConkey().yStep.ToString();
            txtServoUp.Text = Conkey.getConkey().servoUp.ToString();
            txtServoDown.Text = Conkey.getConkey().servoDown.ToString();
            txtMaxCharPerLine.Text = Conkey.getConkey().maxCharLine.ToString();
            chkDoubleDots.Checked = Conkey.getConkey().doubleDot;

            this.btnSetHome.Size = new System.Drawing.Size(207, 36);
            this.btnSetHome.AutoSize = false;
            this.btnGoHome.Size = new System.Drawing.Size(35, 36);
            this.btnGoHome.AutoSize = false;

            int margin = 10;
            int btnHeight = 80;
            int btnWidth = (this.Size.Width - (margin * 4)) / 3;

            this.btnConectar.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnConectar.AutoSize = false;
            this.btnEscolher.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnEscolher.AutoSize = false;
            this.btnImprimir.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnImprimir.AutoSize = false;

            this.btnConectar.Location = new Point(margin, margin);
            this.btnConectar.AutoSize = false;
            this.btnEscolher.Location = new Point(btnWidth + (margin * 2), margin);
            this.btnEscolher.AutoSize = false;
            this.btnImprimir.Location = new Point((btnWidth * 2) + (margin * 3), margin);
            this.btnImprimir.AutoSize = false;

            this.barProgress.Location = new Point(margin, btnHeight + (margin * 5));
            this.barProgress.Size = new Size((Convert.ToInt16(this.Size.Width * 0.9)), 5);

            this.lblProgress.Location = new Point((margin * 2) + this.barProgress.Size.Width, btnHeight + (margin * 4));

            
            this.lblStatusImpressoraLabel.ForeColor = Color.Black;
            this.lblStatusImpressora.ForeColor = Color.Black;
            this.lblStatusImpressora.Text = "";

            btnConectar.PerformClick();
            if (portaSerial.isOpen())
            {
                materialTabControl1.SelectTab(0);
            }
            else
            {
                materialTabControl1.SelectTab(1);
            }

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (portaSerial.isOpen())
            {
                portaSerial.getPort().Close();
            }
            else
            {

                if (portaSerial.pegarPortasSeriais().Count == 1)
                {
                    portaSerial.conectar(portaSerial.pegarPortasSeriais()[0].ToString());
                }
                else
                {
                    materialTabControl1.SelectTab(1);
                }
            }

        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(displayData_Event));
        }

        public void displayData_Event(object sender, EventArgs e)
        {
            String saida = "";
            int count = portaSerial.getPort().BytesToRead;
            for (int i = 0; i < count; i++)
            {

                char caracter = Convert.ToChar(portaSerial.getPort().ReadByte());
                saida += caracter.ToString();

            }

            logBox.AppendText(saida);

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            portaSerial.encerrarPorta();
        }
        #region Timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800,//header
                Primary.Grey900,//top form
                Primary.Blue500,//nada
                portaSerial.isOpen() ? Accent.Teal700 : Accent.Red700,
                TextShade.WHITE
                );

            loadImpressoras();

            lblProgress.Text = barProgress.Value + "%";
            barProgress.Value = portaSerial.sendProgress;

            lblProgress.Visible = portaSerial.enviando;
            barProgress.Visible = portaSerial.enviando;

            lblStatus.Text = portaSerial.isOpen() ? "Conectado a porta " + portaSerial.getPort().PortName : "Desconectado";
            lblStatus.ForeColor = portaSerial.isOpen() ? Color.Teal : Color.Red;
            lblStatus.Location = portaSerial.isOpen() ? new Point(280, 75) : new Point(315, 75);

            btnConectar.Text = portaSerial.isOpen() ? "Desconectar" : "Conectar";
            btnImprimir.Text = portaSerial.enviando ? "Cancelar" : "Imprimir";

            btnConectar.Enabled = !portaSerial.enviando;
            btnEscolher.Enabled = !portaSerial.enviando;

            btnEnviar.Enabled = portaSerial.isOpen() && txtEnviar.Text.Length > 0;
            txtEnviar.Enabled = portaSerial.isOpen();

            btnImprimir.Visible = (lsbSaida.Items.Count > 0) && (portaSerial.isOpen());
            btnEscolher.Visible = (portaSerial.isOpen());

            lblProgresso.Visible = portaSerial.enviando;
            lblStatusImpressora.Text = portaSerial.statusImpressora;
            if (lblStatusImpressora.Text == "Configurando") lblStatusImpressora.ForeColor = Color.Orange;
            if (lblStatusImpressora.Text == "Impressora Configurada!") lblStatusImpressora.ForeColor = Color.LightGreen;
            if (lblStatusImpressora.Text == "Impressão Concluída!") lblStatusImpressora.ForeColor = Color.LightGreen;
            if (lblStatusImpressora.Text == "Impressão Cancelada!") lblStatusImpressora.ForeColor = Color.Red;



            if (portaSerial.enviando && materialTabControl1.SelectedTab == tabPage1)
            {
                resizeForm(450);
                //lsbGcoder.SetSelected(portaSerial.sendIndex, true);
            }
            else if(materialTabControl1.SelectedTab == tabPage1)
            {
                resizeForm(370);
                //this.Size = new Size(464, 154);
            }
            if (materialTabControl1.SelectedTab == tabPage3)
            {
                if (impressorasListView.Items.Count > 1)
                {
                    resizeForm(350 + (impressorasListView.Items.Count - 1) * 50);

                }
                else
                {
                    resizeForm(350);
                }
                //resizeForm(438);
                //this.Size = new Size(464, 276);
            }
            if (materialTabControl1.SelectedTab == tabPage2 && autenticado)
            {
                resizeForm(680);
                //this.Size = new Size(464, 276);
            }

        }

        
        #endregion
        private void loadImpressoras()
        {

            List<String> portas = portaSerial.pegarPortasImpressoras();

            if (portas != null)
            {
                impressorasListView.Items.Clear();
                foreach (String porta in portas)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = porta;
                    impressorasListView.Items.Add(item);
                }

            }

        }

        private void conectaImpressora(string _portName)
        {
            if (portaSerial.isOpen() && _portName == portaSerial.getPort().PortName)
            {
                portaSerial.getPort().Close();
            }
            else
            {
                portaSerial.conectar(_portName);
            }
        }

        private void copyToClipboard(object sender, EventArgs e)
        {
            string clipboard = "";
            foreach (string s in lsbGcoder.Items)
            {
                clipboard += s + '\n';
            }
            Clipboard.SetText(clipboard);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            resizeForm(420);
            
            if (portaSerial.enviando) portaSerial.cancelaImpressao = true;
            if (portaSerial.isOpen())
            {                             
                if (textoEmGcode.Count > 0)
                {                    
                    
                    portaSerial.imprimirGcoderAsync(portaSerial.getPort().PortName.ToString(), textoEmGcode);
                }
                else
                {
                    MessageBox.Show(null, "Selecione um arquivo para imprimir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(null, "Selecione a porta antes de testar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            lsbSaida.DataSource = new List<String>();
            lsbGcoder.DataSource = new List<String>();

            OpenFileDialog file = new OpenFileDialog();

            timer1.Stop();

            file.FileName = "teste";
            file.Filter = "Arquivos de texto | *.doc;*.docx;*.txt";
            file.Title = "Arquivo de texto";
            file.InitialDirectory = "Desktop";
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                leitorDeArquivos = new LeitorDeArquivos();

                Gcoder gCoder = new Gcoder();

                Cursor.Current = Cursors.WaitCursor;

                lsbSaida.DataSource = leitorDeArquivos.lerArquivo(file.FileName.ToString());

                textoEmGcode.AddRange(gCoder.gerarGcode(leitorDeArquivos.lerArquivo(file.FileName.ToString())));

                List<GPoint> ordererList = new List<GPoint>();

                foreach (string s in textoEmGcode)
                {
                    GPoint g = new GPoint(s);
                    ordererList.Add(g);
                }

                textoEmGcode.Clear();
                List<GPoint> orderedList = ordererList.OrderBy(y => y.yPoint).ThenBy(x => x.xPoint).ToList();

                foreach (GPoint g in orderedList)
                {
                    textoEmGcode.Add(g.instruction);
                }

                textoEmGcode.Clear();

                int repeatCounter = 0;
                List<String> auxList = new List<string>();
                foreach (GPoint g in orderedList)
                {
                    bool shouldRepeat = false;

                    if (textoEmGcode.Count > 0 && !chkDoubleDots.Checked)
                    {
                        string lastInstruction = textoEmGcode[textoEmGcode.Count - 1];
                        string commaInstruction = Regex.Replace(lastInstruction, @"[.,]", ".");
                        double lastYPont = Convert.ToDouble(commaInstruction.Substring(commaInstruction.IndexOf("Y") + 1, (commaInstruction.IndexOf("M") - commaInstruction.IndexOf("Y") - 1)));
                        double actualYPoint = (double)(decimal)(g.yPoint);

                        //lastPoint < gPoint
                        if (lastYPont < actualYPoint)
                        {
                            shouldRepeat = true;
                            repeatCounter = 0;
                        }
                        if (shouldRepeat || (repeatCounter > 0 && repeatCounter < 3))
                        {
                            textoEmGcode.Add(g.instruction);
                            auxList.Add(g.instruction);
                            if (repeatCounter == 2)
                            {
                                textoEmGcode.AddRange(auxList);
                                textoEmGcode.AddRange(auxList);
                                auxList.Clear();
                            }
                            repeatCounter++;
                        }
                        else
                        {
                            textoEmGcode.Add(g.instruction);
                        }
                    }
                    else
                    {
                        textoEmGcode.Add(g.instruction);
                    }

                }

                if (chkDoubleDots.Checked)
                {
                    List<List<String>> testList = new List<List<String>>();
                    List<List<String>> testList2 = new List<List<String>>();
                    testList = splitToSublists(textoEmGcode);
                    textoEmGcode.Clear();

                    foreach (List<String> ls in testList)
                    {
                        testList2.Add(ls);
                        testList2.Add(ls);
                    }
                    foreach (List<String> ls in testList2)
                    {
                        textoEmGcode.AddRange(ls);
                    }

                }

                lsbGcoder.DataSource = textoEmGcode;

            }
            timer1.Start();
            Cursor.Current = Cursors.Default;

        }

        public List<List<String>> splitToSublists(List<String> source)
        {
            return source
                     .Select((x, i) => new { Index = i, Value = x })
                     .GroupBy(x => x.Index / 3)
                     .Select(x => x.Select(v => v.Value).ToList())
                     .ToList();
        }

        public void resizeForm(int _tamanhoFinal)
        {
            this.Size = new Size(729, _tamanhoFinal);

            //if (_tamanhoFinal > this.Size.Height)
            //{
            //    for (int i = this.Size.Height; i < _tamanhoFinal; i++)
            //    {
            //        this.Size = new Size(729, i);
            //        //System.Threading.Thread.Sleep(1);
            //    }
            //}
            //else
            //{
            //    for (int i = this.Size.Height; i > _tamanhoFinal; i--)
            //    {
            //        this.Size = new Size(729, i);
            //        //System.Threading.Thread.Sleep(1);
            //    }
            //}
        }

        private void baudRadioButton_Click(object sender, EventArgs e)
        {
            if (portaSerial.isOpen())
            {
                MaterialRadioButton radio = new MaterialRadioButton();
                radio = (MaterialRadioButton)sender;
                String baudRate = radio.Text;
                String portName = portaSerial.getPort().PortName;
                portaSerial.getPort().Close();
                portaSerial = new PortaSerial(serialPort_DataReceived, Convert.ToInt32(baudRate));
                portaSerial.conectar(portName);
            }
        }

        private void impressorasListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Selected)
            {
                MaterialListView list = new MaterialListView();
                ListViewItem item = new ListViewItem();
                list = (MaterialListView)sender;
                if (!portaSerial.isOpen())
                {
                    conectaImpressora(e.Item.Text);
                    materialTabControl1.SelectTab(0);
                }
                else
                {
                    if (portaSerial.getPort().PortName == e.Item.Text)
                    {
                        portaSerial.getPort().Close();
                    }
                    else
                    {
                        portaSerial.getPort().Close();
                        conectaImpressora(e.Item.Text);
                        materialTabControl1.SelectTab(0);
                    }
                }
                e.Item.Selected = false;
            }

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            Form2 prompt = new Form2();
            if (prompt.ShowDialog("Área restrita") == "zalmstech")
            {
                autenticado = true;

            }
            else
            {
                materialTabControl1.SelectedIndex = materialTabControl1.SelectedIndex - 1;
            }

        }

        private void materialTabControl1_Leave(object sender, EventArgs e)
        {
            autenticado = false;
        }

        #region Console
        public void escreveNoConsole(string txt)
        {
            logBox.AppendText("User > " + txt + Environment.NewLine);
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtEnviar.Text == "^X" || txtEnviar.Text == "^x" || txtEnviar.Text == "reset" || txtEnviar.Text == "r")
            {
                string reset = Encoding.ASCII.GetString(new byte[] { 24 });
                portaSerial.getPort().Write(reset);
            }
            else if (txtEnviar.Text == "checkpaper"|| txtEnviar.Text == "checkPaper")
            {
                string check_paper = Encoding.ASCII.GetString(new byte[] { 37 });
                portaSerial.getPort().Write(check_paper);
            }
            else {
                portaSerial.getPort().WriteLine(txtEnviar.Text);
                escreveNoConsole(txtEnviar.Text);
            }                  
                      
            txtEnviar.Focus();
            txtEnviar.Clear();
        }

        private void txtEnviar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnEnviar.PerformClick();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            logBox.Text = "";
        }
        #endregion
        #region Jog Controllers
        private void btnXPlus_Click(object sender, EventArgs e)
        {
            string[] cmd =
            {
                "G91",  //Set Position to relative
                "X"+txtXStep.Text,  //Walk 10mm
                "G90",  //Set Position to absolute
            };
            foreach (string s in cmd)
            {
                portaSerial.getPort().WriteLine(s);
                escreveNoConsole(s);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void btnXMinus_Click(object sender, EventArgs e)
        {
            string[] cmd =
            {
                "G91",  //Set Position to relative
                "X-"+txtXStep.Text,  //Walk 10mm
                "G90",  //Set Position to absolute
            };
            foreach (string s in cmd)
            {
                portaSerial.getPort().WriteLine(s);
                escreveNoConsole(s);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void btnYPlus_Click(object sender, EventArgs e)
        {
            string[] cmd =
            {
                "G91",  //Set Position to relative
                "Y"+txtYStep.Text,  //Walk 10mm
                "G90",  //Set Position to absolute
            };
            foreach (string s in cmd)
            {
                portaSerial.getPort().WriteLine(s);
                escreveNoConsole(s);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void btnYMinus_Click(object sender, EventArgs e)
        {
            string[] cmd =
            {
                "G91",  //Set Position to relative
                "Y-"+txtYStep.Text,  //Walk 10mm
                "G90",  //Set Position to absolute
            };
            foreach (string s in cmd)
            {
                portaSerial.getPort().WriteLine(s);
                escreveNoConsole(s);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void btnZUp_Click(object sender, EventArgs e)
        {
            string[] cmd =
            {
                "M3 S"+txtServoUp.Text,  //Set Servo Position 45
            };
            foreach (string s in cmd)
            {
                portaSerial.getPort().WriteLine(s);
                escreveNoConsole(s);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void btnZDown_Click(object sender, EventArgs e)
        {
            string[] cmd =
            {
                "M3 S"+txtServoDown.Text,  //Set Servo Position 5
            };
            foreach (string s in cmd)
            {
                portaSerial.getPort().WriteLine(s);
                escreveNoConsole(s);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void btnSetHome_Click(object sender, EventArgs e)
        {
            string[] cmd =
            {
                "G92 X0"    //Set Current position to X0
            };
            foreach (string s in cmd)
            {
                portaSerial.getPort().WriteLine(s);
                escreveNoConsole(s);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            string[] cmd =
            {
                "G28"    //Go to home position
            };
            foreach (string s in cmd)
            {
                portaSerial.getPort().WriteLine(s);
                escreveNoConsole(s);
                System.Threading.Thread.Sleep(100);
            }
        }
        #endregion

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            var tempConkey = Conkey.getConkey();

            tempConkey.xStep = Convert.ToInt16(txtXStep.Text);
            tempConkey.yStep = Convert.ToInt16(txtYStep.Text);
            tempConkey.servoUp = Convert.ToInt32(txtServoUp.Text);
            tempConkey.servoDown = Convert.ToInt32(txtServoDown.Text);
            tempConkey.maxCharLine = Convert.ToInt16(txtMaxCharPerLine.Text);
            tempConkey.doubleDot = chkDoubleDots.Checked;

            Conkey.setConkey(tempConkey);
        }

               
     
    }
}

public class GPoint
{
    public string instruction { get; set; }
    public float xPoint { get; set; }
    public float yPoint { get; set; }

    public GPoint(string _instruction)
    {
        instruction = _instruction;
        string commaInstruction = Regex.Replace(instruction, @"[.,]", ".");
        xPoint = Convert.ToSingle(commaInstruction.Substring(instruction.ToLower().IndexOf('x') + 1, instruction.ToLower().IndexOf('y') - 1 - instruction.ToLower().IndexOf('x')));
        yPoint = Convert.ToSingle(commaInstruction.Substring(instruction.ToLower().IndexOf('y') + 1, instruction.ToLower().IndexOf('m') - 1 - instruction.ToLower().IndexOf('y')));
    }
}
