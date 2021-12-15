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
    public partial class name2 : Form
    {
        TextBox tb;
        TextBox tb2;
        Label lb;
        Label lb2;
        Button bt;
        public name2()
        {
            this.Height = 300;
            this.Width = 400;
            this.Text = "Kivist paber käärid";
            this.BackColor = Color.White;

            this.BackColor = Color.FromArgb(101, 94, 144);

            lb = new Label();
            tb = new TextBox();
            tb.Size = new Size(200, 100);
            tb.Location = new Point(50, 40);

            lb.Size = new Size(100, 50);
            lb.Location = new Point(50, 20);
            lb.Text = "Kirjuta esimene nimi";

            lb2 = new Label();
            tb2 = new TextBox();
            tb2.Size = new Size(200, 100);
            tb2.Location = new Point(50, 150);

            lb2.Size = new Size(200, 100);
            lb2.Location = new Point(50, 120);
            lb2.Text = "Kirjuta teine nimi";

            bt = new Button();
            bt.Size = new Size(60, 50);
            bt.Location = new Point(60,210);
            bt.Text = "alustame";
            bt.BackColor = Color.White;
            bt.MouseClick += Bt_MouseClick;


            this.Controls.Add(tb);
            this.Controls.Add(lb);

            this.Controls.Add(tb2);
            this.Controls.Add(lb2);
            this.Controls.Add(bt);


        }

        private void Bt_MouseClick(object sender, MouseEventArgs e)
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
            using (StreamWriter write = new StreamWriter(@"../../name2.txt"))
            {
                if (String.IsNullOrEmpty(tb2.Text))
                {
                    write.WriteLine("Anonimus");
                }
                else
                {
                    write.WriteLine(tb2.Text);

                }
            }
            this.Hide();
            TwoPlayers op = new TwoPlayers();
            op.Show();
        }
    }
}
