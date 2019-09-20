using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GcoderPrinter.View
{
    public partial class Form2 : MaterialForm
    {
        private MaterialSkinManager materialSkinManager2;

        public Form2()
        {
            InitializeComponent();

            materialSkinManager2 = MaterialSkinManager.Instance;
            materialSkinManager2.AddFormToManage(this);
            materialSkinManager2.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager2.ColorScheme = new ColorScheme(
                Primary.Grey800,//header
                Primary.Grey900,//top form
                Primary.Yellow100,//nada
                Accent.Red700,
                TextShade.WHITE
                );

        }

        public string ShowDialog(string caption)
        {
            
            Form2 prompt = new Form2()
            {
                Width = 181,
                Height = 145,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            MaterialRaisedButton btnEnviar = new MaterialRaisedButton() { Text = "Entrar", DialogResult = DialogResult.OK };
            btnEnviar.Location = new Point(52, 96);
            btnEnviar.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(btnEnviar);
            btnEnviar.TabIndex = 2;

            MaterialSingleLineTextField txtSenha = new MaterialSingleLineTextField() { Width=126 };
            txtSenha.Location = new Point(24,67);
            txtSenha.KeyDown += (sender, e) => { if (e.KeyData == Keys.Enter) btnEnviar.PerformClick(); };
            txtSenha.PasswordChar = '*';
            prompt.Controls.Add(txtSenha);
            txtSenha.TabIndex = 1;
            

            return prompt.ShowDialog() == DialogResult.OK ? txtSenha.Text : "";
        }

    }
}
