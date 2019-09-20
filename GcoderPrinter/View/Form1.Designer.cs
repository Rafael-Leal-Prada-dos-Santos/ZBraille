using System.Drawing;

namespace GcoderPrinter
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "COM EXEMPLO"}, -1, System.Drawing.SystemColors.HotTrack, System.Drawing.Color.Empty, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lsbSaida = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnConectar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEscolher = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnImprimir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.barProgress = new MaterialSkin.Controls.MaterialProgressBar();
            this.lblProgress = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblProgresso = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.impressorasListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveConfig = new MaterialSkin.Controls.MaterialFlatButton();
            this.chkDoubleDots = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtMaxCharPerLine = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSetHome = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnLimpar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtServoDown = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtServoUp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtYStep = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtXStep = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnZUp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnZDown = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGoHome = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXMinus = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnYMinus = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnXPlus = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnYPlus = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEnviar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtEnviar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.logBox = new System.Windows.Forms.TextBox();
            this.lsbGcoder = new System.Windows.Forms.ListBox();
            this.lblStatusImpressoraLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblStatusImpressora = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbSaida
            // 
            this.lsbSaida.FormattingEnabled = true;
            this.lsbSaida.Location = new System.Drawing.Point(7, 7);
            this.lsbSaida.Margin = new System.Windows.Forms.Padding(4);
            this.lsbSaida.Name = "lsbSaida";
            this.lsbSaida.Size = new System.Drawing.Size(185, 173);
            this.lsbSaida.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnConectar
            // 
            this.btnConectar.AutoSize = true;
            this.btnConectar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConectar.BackColor = System.Drawing.Color.Black;
            this.btnConectar.Depth = 0;
            this.btnConectar.Icon = null;
            this.btnConectar.Location = new System.Drawing.Point(4, 58);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConectar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Primary = false;
            this.btnConectar.Size = new System.Drawing.Size(92, 36);
            this.btnConectar.TabIndex = 18;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnEscolher
            // 
            this.btnEscolher.AutoSize = true;
            this.btnEscolher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEscolher.Depth = 0;
            this.btnEscolher.Icon = null;
            this.btnEscolher.Location = new System.Drawing.Point(212, 58);
            this.btnEscolher.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEscolher.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Primary = false;
            this.btnEscolher.Size = new System.Drawing.Size(176, 36);
            this.btnEscolher.TabIndex = 20;
            this.btnEscolher.Text = "Escolher documento";
            this.btnEscolher.UseVisualStyleBackColor = true;
            this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.Icon = null;
            this.btnImprimir.Location = new System.Drawing.Point(441, 58);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Primary = true;
            this.btnImprimir.Size = new System.Drawing.Size(83, 36);
            this.btnImprimir.TabIndex = 21;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(310, 75);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(106, 19);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Desconectado";
            // 
            // barProgress
            // 
            this.barProgress.Depth = 0;
            this.barProgress.Location = new System.Drawing.Point(6, 177);
            this.barProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.barProgress.Name = "barProgress";
            this.barProgress.Size = new System.Drawing.Size(658, 5);
            this.barProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barProgress.TabIndex = 23;
            this.barProgress.Value = 50;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Depth = 0;
            this.lblProgress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProgress.Location = new System.Drawing.Point(670, 167);
            this.lblProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(28, 19);
            this.lblProgress.TabIndex = 24;
            this.lblProgress.Text = "0%";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(5, 230);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(719, 437);
            this.materialTabControl1.TabIndex = 25;
            this.materialTabControl1.Leave += new System.EventHandler(this.materialTabControl1_Leave);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblProgresso);
            this.tabPage1.Controls.Add(this.btnConectar);
            this.tabPage1.Controls.Add(this.btnEscolher);
            this.tabPage1.Controls.Add(this.lblProgress);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.barProgress);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(711, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblProgresso
            // 
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.BackColor = System.Drawing.Color.Transparent;
            this.lblProgresso.Depth = 0;
            this.lblProgresso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProgresso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProgresso.Location = new System.Drawing.Point(313, 110);
            this.lblProgresso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(82, 19);
            this.lblProgresso.TabIndex = 31;
            this.lblProgresso.Text = "Progresso:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.impressorasListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(711, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Impressoras";
            // 
            // impressorasListView
            // 
            this.impressorasListView.BackColor = System.Drawing.SystemColors.Window;
            this.impressorasListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.impressorasListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.impressorasListView.Depth = 0;
            this.impressorasListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.impressorasListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.impressorasListView.FullRowSelect = true;
            this.impressorasListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.impressorasListView.HideSelection = false;
            this.impressorasListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.impressorasListView.Location = new System.Drawing.Point(3, 2);
            this.impressorasListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.impressorasListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.impressorasListView.MouseState = MaterialSkin.MouseState.OUT;
            this.impressorasListView.MultiSelect = false;
            this.impressorasListView.Name = "impressorasListView";
            this.impressorasListView.OwnerDraw = true;
            this.impressorasListView.Scrollable = false;
            this.impressorasListView.Size = new System.Drawing.Size(705, 407);
            this.impressorasListView.TabIndex = 0;
            this.impressorasListView.UseCompatibleStateImageBehavior = false;
            this.impressorasListView.View = System.Windows.Forms.View.Details;
            this.impressorasListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.impressorasListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 900;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnSaveConfig);
            this.tabPage2.Controls.Add(this.chkDoubleDots);
            this.tabPage2.Controls.Add(this.txtMaxCharPerLine);
            this.tabPage2.Controls.Add(this.materialLabel7);
            this.tabPage2.Controls.Add(this.btnSetHome);
            this.tabPage2.Controls.Add(this.materialRadioButton1);
            this.tabPage2.Controls.Add(this.materialRadioButton2);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.btnLimpar);
            this.tabPage2.Controls.Add(this.txtServoDown);
            this.tabPage2.Controls.Add(this.txtServoUp);
            this.tabPage2.Controls.Add(this.txtYStep);
            this.tabPage2.Controls.Add(this.txtXStep);
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.btnZUp);
            this.tabPage2.Controls.Add(this.btnZDown);
            this.tabPage2.Controls.Add(this.btnGoHome);
            this.tabPage2.Controls.Add(this.btnXMinus);
            this.tabPage2.Controls.Add(this.btnYMinus);
            this.tabPage2.Controls.Add(this.btnXPlus);
            this.tabPage2.Controls.Add(this.btnYPlus);
            this.tabPage2.Controls.Add(this.btnEnviar);
            this.tabPage2.Controls.Add(this.txtEnviar);
            this.tabPage2.Controls.Add(this.logBox);
            this.tabPage2.Controls.Add(this.lsbGcoder);
            this.tabPage2.Controls.Add(this.lsbSaida);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(711, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tools";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.AutoSize = true;
            this.btnSaveConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveConfig.BackgroundImage")));
            this.btnSaveConfig.Depth = 0;
            this.btnSaveConfig.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveConfig.Icon")));
            this.btnSaveConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveConfig.Image")));
            this.btnSaveConfig.Location = new System.Drawing.Point(612, 362);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Primary = false;
            this.btnSaveConfig.Size = new System.Drawing.Size(44, 36);
            this.btnSaveConfig.TabIndex = 54;
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // chkDoubleDots
            // 
            this.chkDoubleDots.AutoSize = true;
            this.chkDoubleDots.Checked = true;
            this.chkDoubleDots.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDoubleDots.Depth = 0;
            this.chkDoubleDots.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkDoubleDots.Location = new System.Drawing.Point(437, 366);
            this.chkDoubleDots.Margin = new System.Windows.Forms.Padding(0);
            this.chkDoubleDots.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkDoubleDots.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkDoubleDots.Name = "chkDoubleDots";
            this.chkDoubleDots.Ripple = true;
            this.chkDoubleDots.Size = new System.Drawing.Size(98, 30);
            this.chkDoubleDots.TabIndex = 46;
            this.chkDoubleDots.Text = "Double Dot";
            this.chkDoubleDots.UseVisualStyleBackColor = true;
            // 
            // txtMaxCharPerLine
            // 
            this.txtMaxCharPerLine.Depth = 0;
            this.txtMaxCharPerLine.Hint = "";
            this.txtMaxCharPerLine.Location = new System.Drawing.Point(612, 342);
            this.txtMaxCharPerLine.MaxLength = 32767;
            this.txtMaxCharPerLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaxCharPerLine.Name = "txtMaxCharPerLine";
            this.txtMaxCharPerLine.PasswordChar = '\0';
            this.txtMaxCharPerLine.SelectedText = "";
            this.txtMaxCharPerLine.SelectionLength = 0;
            this.txtMaxCharPerLine.SelectionStart = 0;
            this.txtMaxCharPerLine.Size = new System.Drawing.Size(40, 23);
            this.txtMaxCharPerLine.TabIndex = 45;
            this.txtMaxCharPerLine.TabStop = false;
            this.txtMaxCharPerLine.Text = "0";
            this.txtMaxCharPerLine.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(440, 346);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(100, 19);
            this.materialLabel7.TabIndex = 51;
            this.materialLabel7.Text = "Max char/line";
            // 
            // btnSetHome
            // 
            this.btnSetHome.AutoSize = true;
            this.btnSetHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetHome.Depth = 0;
            this.btnSetHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetHome.Icon = null;
            this.btnSetHome.Location = new System.Drawing.Point(444, 174);
            this.btnSetHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetHome.Name = "btnSetHome";
            this.btnSetHome.Primary = true;
            this.btnSetHome.Size = new System.Drawing.Size(41, 36);
            this.btnSetHome.TabIndex = 50;
            this.btnSetHome.Text = "⟲⌂";
            this.btnSetHome.UseVisualStyleBackColor = true;
            this.btnSetHome.Click += new System.EventHandler(this.btnSetHome_Click);
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Checked = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(531, 8);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(60, 30);
            this.materialRadioButton1.TabIndex = 47;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "9600";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(612, 8);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(76, 30);
            this.materialRadioButton2.TabIndex = 48;
            this.materialRadioButton2.Text = "115200";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(427, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 49;
            this.materialLabel1.Text = "Baud Rate:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.Icon = null;
            this.btnLimpar.Location = new System.Drawing.Point(327, 360);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Primary = true;
            this.btnLimpar.Size = new System.Drawing.Size(71, 36);
            this.btnLimpar.TabIndex = 46;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtServoDown
            // 
            this.txtServoDown.Depth = 0;
            this.txtServoDown.Hint = "";
            this.txtServoDown.Location = new System.Drawing.Point(612, 316);
            this.txtServoDown.MaxLength = 32767;
            this.txtServoDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServoDown.Name = "txtServoDown";
            this.txtServoDown.PasswordChar = '\0';
            this.txtServoDown.SelectedText = "";
            this.txtServoDown.SelectionLength = 0;
            this.txtServoDown.SelectionStart = 0;
            this.txtServoDown.Size = new System.Drawing.Size(40, 23);
            this.txtServoDown.TabIndex = 44;
            this.txtServoDown.TabStop = false;
            this.txtServoDown.Text = "0";
            this.txtServoDown.UseSystemPasswordChar = false;
            // 
            // txtServoUp
            // 
            this.txtServoUp.Depth = 0;
            this.txtServoUp.Hint = "";
            this.txtServoUp.Location = new System.Drawing.Point(612, 287);
            this.txtServoUp.MaxLength = 32767;
            this.txtServoUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServoUp.Name = "txtServoUp";
            this.txtServoUp.PasswordChar = '\0';
            this.txtServoUp.SelectedText = "";
            this.txtServoUp.SelectionLength = 0;
            this.txtServoUp.SelectionStart = 0;
            this.txtServoUp.Size = new System.Drawing.Size(39, 23);
            this.txtServoUp.TabIndex = 43;
            this.txtServoUp.TabStop = false;
            this.txtServoUp.Text = "0";
            this.txtServoUp.UseSystemPasswordChar = false;
            // 
            // txtYStep
            // 
            this.txtYStep.Depth = 0;
            this.txtYStep.Hint = "";
            this.txtYStep.Location = new System.Drawing.Point(612, 259);
            this.txtYStep.MaxLength = 32767;
            this.txtYStep.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtYStep.Name = "txtYStep";
            this.txtYStep.PasswordChar = '\0';
            this.txtYStep.SelectedText = "";
            this.txtYStep.SelectionLength = 0;
            this.txtYStep.SelectionStart = 0;
            this.txtYStep.Size = new System.Drawing.Size(40, 23);
            this.txtYStep.TabIndex = 42;
            this.txtYStep.TabStop = false;
            this.txtYStep.Text = "0";
            this.txtYStep.UseSystemPasswordChar = false;
            // 
            // txtXStep
            // 
            this.txtXStep.Depth = 0;
            this.txtXStep.Hint = "";
            this.txtXStep.Location = new System.Drawing.Point(612, 230);
            this.txtXStep.MaxLength = 32767;
            this.txtXStep.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtXStep.Name = "txtXStep";
            this.txtXStep.PasswordChar = '\0';
            this.txtXStep.SelectedText = "";
            this.txtXStep.SelectionLength = 0;
            this.txtXStep.SelectionStart = 0;
            this.txtXStep.Size = new System.Drawing.Size(39, 23);
            this.txtXStep.TabIndex = 41;
            this.txtXStep.TabStop = false;
            this.txtXStep.Text = "0";
            this.txtXStep.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(440, 320);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(60, 19);
            this.materialLabel6.TabIndex = 39;
            this.materialLabel6.Text = "Servo ▼";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(440, 291);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(60, 19);
            this.materialLabel5.TabIndex = 38;
            this.materialLabel5.Text = "Servo ▲";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(440, 262);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(52, 19);
            this.materialLabel4.TabIndex = 37;
            this.materialLabel4.Text = "Y Step";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(440, 234);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 19);
            this.materialLabel3.TabIndex = 36;
            this.materialLabel3.Text = "X Step";
            // 
            // btnZUp
            // 
            this.btnZUp.AutoSize = true;
            this.btnZUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnZUp.Depth = 0;
            this.btnZUp.Icon = null;
            this.btnZUp.Location = new System.Drawing.Point(577, 55);
            this.btnZUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnZUp.Name = "btnZUp";
            this.btnZUp.Primary = true;
            this.btnZUp.Size = new System.Drawing.Size(74, 36);
            this.btnZUp.TabIndex = 34;
            this.btnZUp.Text = "▲\t";
            this.btnZUp.UseVisualStyleBackColor = true;
            this.btnZUp.Click += new System.EventHandler(this.btnZUp_Click);
            // 
            // btnZDown
            // 
            this.btnZDown.AutoSize = true;
            this.btnZDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnZDown.Depth = 0;
            this.btnZDown.Icon = null;
            this.btnZDown.Location = new System.Drawing.Point(577, 127);
            this.btnZDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnZDown.Name = "btnZDown";
            this.btnZDown.Primary = true;
            this.btnZDown.Size = new System.Drawing.Size(74, 36);
            this.btnZDown.TabIndex = 33;
            this.btnZDown.Text = "▼\t";
            this.btnZDown.UseVisualStyleBackColor = true;
            this.btnZDown.Click += new System.EventHandler(this.btnZDown_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.AutoSize = true;
            this.btnGoHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoHome.Depth = 0;
            this.btnGoHome.Icon = null;
            this.btnGoHome.Location = new System.Drawing.Point(480, 91);
            this.btnGoHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Primary = true;
            this.btnGoHome.Size = new System.Drawing.Size(30, 36);
            this.btnGoHome.TabIndex = 32;
            this.btnGoHome.Text = "⌂";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // btnXMinus
            // 
            this.btnXMinus.AutoSize = true;
            this.btnXMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXMinus.Depth = 0;
            this.btnXMinus.Icon = null;
            this.btnXMinus.Location = new System.Drawing.Point(444, 91);
            this.btnXMinus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXMinus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXMinus.Name = "btnXMinus";
            this.btnXMinus.Primary = false;
            this.btnXMinus.Size = new System.Drawing.Size(35, 36);
            this.btnXMinus.TabIndex = 31;
            this.btnXMinus.Text = "⬅";
            this.btnXMinus.UseVisualStyleBackColor = true;
            this.btnXMinus.Click += new System.EventHandler(this.btnXMinus_Click);
            // 
            // btnYMinus
            // 
            this.btnYMinus.AutoSize = true;
            this.btnYMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYMinus.Depth = 0;
            this.btnYMinus.Icon = null;
            this.btnYMinus.Location = new System.Drawing.Point(480, 127);
            this.btnYMinus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnYMinus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYMinus.Name = "btnYMinus";
            this.btnYMinus.Primary = false;
            this.btnYMinus.Size = new System.Drawing.Size(35, 36);
            this.btnYMinus.TabIndex = 30;
            this.btnYMinus.Text = "⬇";
            this.btnYMinus.UseVisualStyleBackColor = true;
            this.btnYMinus.Click += new System.EventHandler(this.btnYMinus_Click);
            // 
            // btnXPlus
            // 
            this.btnXPlus.AutoSize = true;
            this.btnXPlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXPlus.Depth = 0;
            this.btnXPlus.Icon = null;
            this.btnXPlus.Location = new System.Drawing.Point(515, 91);
            this.btnXPlus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXPlus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXPlus.Name = "btnXPlus";
            this.btnXPlus.Primary = false;
            this.btnXPlus.Size = new System.Drawing.Size(36, 36);
            this.btnXPlus.TabIndex = 29;
            this.btnXPlus.Text = "➡";
            this.btnXPlus.UseVisualStyleBackColor = true;
            this.btnXPlus.Click += new System.EventHandler(this.btnXPlus_Click);
            // 
            // btnYPlus
            // 
            this.btnYPlus.AutoSize = true;
            this.btnYPlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYPlus.Depth = 0;
            this.btnYPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYPlus.Icon = null;
            this.btnYPlus.Location = new System.Drawing.Point(480, 55);
            this.btnYPlus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnYPlus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYPlus.Name = "btnYPlus";
            this.btnYPlus.Primary = false;
            this.btnYPlus.Size = new System.Drawing.Size(35, 36);
            this.btnYPlus.TabIndex = 28;
            this.btnYPlus.Text = "⬆";
            this.btnYPlus.UseVisualStyleBackColor = true;
            this.btnYPlus.Click += new System.EventHandler(this.btnYPlus_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.AutoSize = true;
            this.btnEnviar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.Depth = 0;
            this.btnEnviar.Icon = null;
            this.btnEnviar.Location = new System.Drawing.Point(257, 360);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Primary = true;
            this.btnEnviar.Size = new System.Drawing.Size(69, 36);
            this.btnEnviar.TabIndex = 14;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtEnviar.Depth = 0;
            this.txtEnviar.Hint = "";
            this.txtEnviar.Location = new System.Drawing.Point(17, 366);
            this.txtEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnviar.MaxLength = 32767;
            this.txtEnviar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.PasswordChar = '\0';
            this.txtEnviar.SelectedText = "";
            this.txtEnviar.SelectionLength = 0;
            this.txtEnviar.SelectionStart = 0;
            this.txtEnviar.Size = new System.Drawing.Size(234, 23);
            this.txtEnviar.TabIndex = 27;
            this.txtEnviar.TabStop = false;
            this.txtEnviar.UseSystemPasswordChar = false;
            this.txtEnviar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnviar_KeyDown);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.logBox.ForeColor = System.Drawing.Color.Lime;
            this.logBox.Location = new System.Drawing.Point(0, 193);
            this.logBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(398, 163);
            this.logBox.TabIndex = 11;
            // 
            // lsbGcoder
            // 
            this.lsbGcoder.FormattingEnabled = true;
            this.lsbGcoder.Location = new System.Drawing.Point(213, 7);
            this.lsbGcoder.Margin = new System.Windows.Forms.Padding(4);
            this.lsbGcoder.Name = "lsbGcoder";
            this.lsbGcoder.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbGcoder.Size = new System.Drawing.Size(185, 173);
            this.lsbGcoder.TabIndex = 2;
            this.lsbGcoder.Click += new System.EventHandler(this.copyToClipboard);
            this.lsbGcoder.SelectedValueChanged += new System.EventHandler(this.copyToClipboard);
            // 
            // lblStatusImpressoraLabel
            // 
            this.lblStatusImpressoraLabel.AutoSize = true;
            this.lblStatusImpressoraLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblStatusImpressoraLabel.Depth = 0;
            this.lblStatusImpressoraLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatusImpressoraLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatusImpressoraLabel.Location = new System.Drawing.Point(356, 183);
            this.lblStatusImpressoraLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatusImpressoraLabel.Name = "lblStatusImpressoraLabel";
            this.lblStatusImpressoraLabel.Size = new System.Drawing.Size(60, 19);
            this.lblStatusImpressoraLabel.TabIndex = 32;
            this.lblStatusImpressoraLabel.Text = "Status: ";
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.materialTabControl1;
            this.tabSelector.Depth = 0;
            this.tabSelector.Location = new System.Drawing.Point(0, 158);
            this.tabSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(733, 54);
            this.tabSelector.TabIndex = 26;
            this.tabSelector.Text = "materialTabSelector1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(215, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "Impressora ZBraille";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 131);
            this.panel1.TabIndex = 29;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(298, 54);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(143, 19);
            this.materialLabel8.TabIndex = 29;
            this.materialLabel8.Text = "Status da Conexão: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(47, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "⌂";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 44);
            this.panel2.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(260, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "⛭";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(154, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "🖶";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(534, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "⌂🖶⛭";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(298, 57);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(106, 19);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "Desconectado";
            // 
            // lblStatusImpressora
            // 
            this.lblStatusImpressora.AutoSize = true;
            this.lblStatusImpressora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblStatusImpressora.Depth = 0;
            this.lblStatusImpressora.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatusImpressora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatusImpressora.Location = new System.Drawing.Point(412, 183);
            this.lblStatusImpressora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatusImpressora.Name = "lblStatusImpressora";
            this.lblStatusImpressora.Size = new System.Drawing.Size(43, 19);
            this.lblStatusImpressora.TabIndex = 33;
            this.lblStatusImpressora.Text = "texto";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(729, 748);
            this.Controls.Add(this.lblStatusImpressoraLabel);
            this.Controls.Add(this.lblStatusImpressora);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabSelector);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lsbSaida;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialFlatButton btnConectar;
        private MaterialSkin.Controls.MaterialFlatButton btnEscolher;
        private MaterialSkin.Controls.MaterialRaisedButton btnImprimir;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialProgressBar barProgress;
        private MaterialSkin.Controls.MaterialLabel lblProgress;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialListView impressorasListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.ListBox lsbGcoder;
        private MaterialSkin.Controls.MaterialRaisedButton btnEnviar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialRaisedButton btnGoHome;
        private MaterialSkin.Controls.MaterialFlatButton btnXMinus;
        private MaterialSkin.Controls.MaterialFlatButton btnYMinus;
        private MaterialSkin.Controls.MaterialFlatButton btnXPlus;
        private MaterialSkin.Controls.MaterialFlatButton btnYPlus;
        private MaterialSkin.Controls.MaterialRaisedButton btnZUp;
        private MaterialSkin.Controls.MaterialRaisedButton btnZDown;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServoDown;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServoUp;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtYStep;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtXStep;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSetHome;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaxCharPerLine;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialCheckBox chkDoubleDots;
        private MaterialSkin.Controls.MaterialFlatButton btnSaveConfig;
        private MaterialSkin.Controls.MaterialLabel lblProgresso;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lblStatusImpressoraLabel;
        private MaterialSkin.Controls.MaterialLabel lblStatusImpressora;
    }
}

