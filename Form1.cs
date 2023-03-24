using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Glavna.Location = new Point(panel1.Width / 2, panel1.Height / 2);
            lbl_Lokacija.Text = $"X: {lbl_Glavna.Location.X} Y:{lbl_Glavna.Location.Y}";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        
        int brojac = 0;
        Point a = new Point(0, 0);
        string t = "Ne mozete dalje pomerati na tu stranu";




        private void btn_Gore_Click(object sender, EventArgs e)
        {

            a = lbl_Glavna.Location;
            if (a.Y - 10 >= 0)
            {
                a.Y -= 10;
                lbl_Glavna.Location = a;
                brojac++;
                lbl_Lokacija.Text = $"X: {lbl_Glavna.Location.X} Y:{lbl_Glavna.Location.Y}";
            }
            else { MessageBox.Show(t); }
        }
        private void btn_Dole_Click(object sender, EventArgs e)
        {
            a = lbl_Glavna.Location;
            int visina = panel1.Size.Height;
            if (a.Y < visina - 20)
            {
                a.Y += 10;
                lbl_Glavna.Location = a;
                brojac++;
                lbl_Lokacija.Text = $"X: {lbl_Glavna.Location.X} Y:{lbl_Glavna.Location.Y}";
            }
            else { MessageBox.Show(t); }
        }
        private void btn_Levo_Click(object sender, EventArgs e)
        {
                a = lbl_Glavna.Location;

                if (a.X > 10 )
                {
                    a.X -= 10;
                    lbl_Glavna.Location = a;
                    brojac++;
                    lbl_Lokacija.Text = $"X: {lbl_Glavna.Location.X} Y:{lbl_Glavna.Location.Y}";
                }
                else { MessageBox.Show(t); }
        }
        private void btn_Desno_Click(object sender, EventArgs e)
        {

            a = lbl_Glavna.Location;
            int sirina = panel1.Width;
            if (a.X < sirina-18)
            {
                a.X += 10;
                lbl_Glavna.Location = a;
                brojac++;
                lbl_Lokacija.Text = $"X: {lbl_Glavna.Location.X} Y:{lbl_Glavna.Location.Y}";
            }
            else {MessageBox.Show(t);}
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            lbl_Glavna.Location = new Point(panel1.Width / 2, panel1.Height / 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

