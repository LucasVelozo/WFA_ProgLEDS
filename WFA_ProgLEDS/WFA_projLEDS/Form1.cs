using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFA_projLEDS
{
    public partial class Form1 : Form
    {
        private Leds meusLeds;

        public Form1()
        {
            InitializeComponent();
            meusLeds = new Leds();
            atualizaInterface();
        }

        public void atualizaInterface()
        {
            lblEstado.Text = meusLeds.getEstado().ToString();
            picLed1.Image = (meusLeds.getEstado(1) ?
                Properties.Resources.LampadaAcesa :
                Properties.Resources.LampadaApagada);
            picLed2.Image = (meusLeds.getEstado(2) ?
                Properties.Resources.LampadaAcesa :
                Properties.Resources.LampadaApagada);
            picLed3.Image = (meusLeds.getEstado(3) ?
                Properties.Resources.LampadaAcesa :
                Properties.Resources.LampadaApagada);
            picLed4.Image = (meusLeds.getEstado(4) ?
                Properties.Resources.LampadaAcesa :
                Properties.Resources.LampadaApagada);
            picLed5.Image = (meusLeds.getEstado(5) ?
                Properties.Resources.LampadaAcesa :
                Properties.Resources.LampadaApagada);
            picLed6.Image = (meusLeds.getEstado(6) ?
                Properties.Resources.LampadaAcesa :
                Properties.Resources.LampadaApagada);
            picLed7.Image = (meusLeds.getEstado(7) ?
                Properties.Resources.LampadaAcesa :
                Properties.Resources.LampadaApagada);
            picLed8.Image = (meusLeds.getEstado(8) ?
                Properties.Resources.LampadaAcesa :
                Properties.Resources.LampadaApagada);
        }

        private void btnON1_Click(object sender, EventArgs e)
        {
            meusLeds.acender(1);
            atualizaInterface();
        }

        private void btnOFF1_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(1);
            atualizaInterface();
        }

        private void btnON2_Click(object sender, EventArgs e)
        {
            meusLeds.acender(2);
            atualizaInterface();
        }

        private void btnOFF2_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(2);
            atualizaInterface();
        }

        private void btnON3_Click(object sender, EventArgs e)
        {
            meusLeds.acender(3);
            atualizaInterface();
        }

        private void btnON4_Click(object sender, EventArgs e)
        {
            meusLeds.acender(4);
            atualizaInterface();
        }

        private void btnON5_Click(object sender, EventArgs e)
        {
            meusLeds.acender(5);
            atualizaInterface();
        }

        private void btnON6_Click(object sender, EventArgs e)
        {
            meusLeds.acender(6);
            atualizaInterface();
        }

        private void btnON7_Click(object sender, EventArgs e)
        {
            meusLeds.acender(7);
            atualizaInterface();

        }

        private void btnON8_Click(object sender, EventArgs e)
        {
            meusLeds.acender(8);
            atualizaInterface();
        }

        private void btnOFF3_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(3);
            atualizaInterface();
        }

        private void btnOFF4_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(4);
            atualizaInterface();

        }

        private void btnOFF5_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(5);
            atualizaInterface();

        }

        private void btnOFF6_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(6);
            atualizaInterface();
        }

        private void btnOFF7_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(7);
            atualizaInterface();
        }

        private void btnOFF8_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(8);
            atualizaInterface();
        }
    }
}
