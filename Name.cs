using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePaperScissors
{
    public partial class Name : Form
    {
        TextBox tb;
        Label lb;
        public Name()
        {
            this.Height = 200;
            this.Width = 300;
            this.Text = "Kivist paber käärid";
            this.BackColor = Color.FromArgb(101, 94, 144);
            lb = new Label();
            tb = new TextBox();
            tb.KeyDown += Tb_KeyDown;
            tb.Size = new Size(200, 100);
            tb.Location = new Point(50, 60);

            lb.Size = new Size(200, 100);
            lb.Location = new Point(50, 45);
            lb.Text = "Kirjuta sinu nimi";

            this.Controls.Add(tb);
            this.Controls.Add(lb);


        }

        private void Tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                using (StreamWriter writer = new StreamWriter(@"../../name.txt"))
                {
                    if (String.IsNullOrEmpty(tb.Text))
                    {
                        writer.WriteLine("Anonimus");
                    }
                    else
                    {
                        writer.WriteLine(tb.Text);
                    }
                }
                this.Hide();
                OnePlayer op = new OnePlayer();
                op.Show();

            }
        }
    }
}
