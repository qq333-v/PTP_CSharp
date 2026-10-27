
namespace Aula_1_CSharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnClicar = new System.Windows.Forms.Button();

            btnClicar.Name = "btnClicar";
            btnClicar.Text = "Clica em mim";
            btnClicar.Size = new System.Drawing.Size(220, 60);
            btnClicar.Location = new System.Drawing.Point(290, 170);
            btnClicar.Font = new System.Drawing.Font(
                "Segoe UI", 14, System.Drawing.FontStyle.Bold);
            btnClicar.BackColor = System.Drawing.Color.FromArgb(35, 100, 180);
            btnClicar.ForeColor = System.Drawing.Color.White;
            btnClicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClicar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClicar.Click += btnClicar_Click;

            Controls.Add(btnClicar);

            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            BackColor = System.Drawing.Color.FromArgb(240, 245, 250);
            Text = "Aula 1 - CSharp";
        }
    }
}
