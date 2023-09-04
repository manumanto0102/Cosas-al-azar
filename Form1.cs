using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_1
{
    public partial class Form1 : Form
    {
        private const bool V = true;

        public Form1()
        {
            InitializeComponent();
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\manum\Desktop\carpetas x de escritorio\Nueva carpeta\chimes.wav");
            simpleSound.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como que te quieres ir sin responder >:v");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades, te traigo la patrulla porque tu eres la oficial bb");
            MessageBox.Show("Que tension la del ambiente, deberiamos besarnos para aliviar el ambiente");
            MessageBox.Show("Se que ya llevamos 2 meses pero igual es algo que queria hacer desde el inicio");
            MessageBox.Show("Te amo Ximena, eres la niña mas hermosa del mundo y deseo pasar mis dias contigo, enserio que eres la mujer mas hermosa del mundo y enserio enserio te amo como no lo puedes imaginar <3<3<3");
            this.Close();

            
        }

        private void caja_CheckedChanged(object sender, EventArgs e)
        {
            if (!caja.ThreeState)
            {
                caja.ThreeState = true;
                button2.Show();
                button3.Show();
            }
            else
            {
                caja.ThreeState = false;
                button2.Hide();
                button3.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como que no culera, asi no iba la cosa");
            button4.Hide();
            MessageBox.Show("De esta no se escapara tan facil, responde o responde >:v");
            button3.Hide();
        }
    }
}
