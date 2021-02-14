using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_z_randomem_1
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int skladnik1;
        int skladnik2;
        int odjemna;
        int odjemnik;
        int pozostalyczas;



        public Form1()
        {
            InitializeComponent();
        }

        public void NoDawaj()
        {
            skladnik1 = randomizer.Next(51);
            skladnik2 = randomizer.Next(51);

            label2.Text = skladnik1.ToString();
            label5.Text = skladnik2.ToString();
            suma.Value = 0;
            pozostalyczas= 30;
            timeLabel.Text = "30 sekund";
            timer1.Start();
        }
        public bool Spr()
        {
            if (skladnik1+skladnik2==suma.Value)
                return true;
            else
                return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rozpocznij_Click(object sender, EventArgs e)
        {
            NoDawaj();
            rozpocznij.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Spr())
            {
                timer1.Stop();
                MessageBox.Show("brawo");
                rozpocznij.Enabled = true;

            }
            else if (pozostalyczas > 0)
            {
                pozostalyczas = pozostalyczas - 1;
                timeLabel.Text = pozostalyczas + " sekund";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Koniec czasu";
                MessageBox.Show("Słabiutko, ręce już nie te");
                suma.Value = skladnik1 + skladnik2;
                rozpocznij.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}