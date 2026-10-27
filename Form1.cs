
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aula_1_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClicar_Click(object sender, EventArgs e)
        {
            using (Form janela = new Form())
            {
                janela.Text = "Mensagem";
                janela.Size = new Size(600, 350);
                janela.StartPosition = FormStartPosition.CenterScreen;
                janela.BackColor = Color.White;
                janela.FormBorderStyle = FormBorderStyle.FixedDialog;
                janela.MaximizeBox = false;
                janela.MinimizeBox = false;

                Label mensagem = new Label();
                mensagem.Text = "Olá, Mundo!";
                mensagem.Dock = DockStyle.Fill;
                mensagem.TextAlign = ContentAlignment.MiddleCenter;
                mensagem.Font = new System.Drawing.Font(
                    "Segoe UI", 30, FontStyle.Bold);
                mensagem.ForeColor = Color.FromArgb(35, 100, 180);

                janela.Controls.Add(mensagem);
                janela.ShowDialog();
            }
        }
    }
}
