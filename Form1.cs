using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace macchinaripassoverifica
{
    public partial class Form1 : Form
    {
        Macchina m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpieno_Click(object sender, EventArgs e)
        {
            m.pieno();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            m.accellera();
        }

        private void btnfrena_Click(object sender, EventArgs e)
        {
            m.frena();
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(m.print(m.getTarga(textBox1.Text)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = new Macchina(textBox1.Text, double.Parse(textBox2.Text));
        }
    }
    class Macchina
    {
        private string targa;
        private double velocita;
        private double serbatoio;
        public Macchina(string targa, double velocita)
        {
            this.targa = targa;
            this.velocita = velocita;
            serbatoio = 50.0;
        }
        public string getTarga(string targa)
        {
            return targa;
        }
        public double getVelocita(double velocita)
        {
            return velocita;
        }
        public double getSerbatoio(double serbatoio)
        {
            return serbatoio;
        }
        public bool pieno()
        {
            bool ret = false;
            if(serbatoio < 50)
            {
                serbatoio = 50;
                ret = true;
            }
            return ret;
        }
        public void accellera()
        {
            velocita += 10;
            serbatoio -= serbatoio * 0.1 / 100;
        }
        public void frena()
        {
            velocita -= 5;
        }
        public string print(string t)
        {
            return "Targa: " + t + " Velocità: " + velocita + " litri nel serbatoio: " + this.serbatoio;
        }
    }
}
