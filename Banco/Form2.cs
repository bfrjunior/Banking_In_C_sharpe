using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form2 : Form
    {
        public Conta[] contas = new Conta[20];

        int acessada;
        public Form2(Conta[] contas, int acessada)
        {
            InitializeComponent();
            
            this.contas = contas;
            this.acessada = acessada;
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contas[acessada].saca(int.Parse(textBox2.Text));
            textBox3.Text = ""+contas[acessada].saldo;
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            contas[acessada].deposita(int.Parse(textBox4.Text));
            textBox3.Text = "" + contas[acessada].saldo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contas[acessada].saca(int.Parse(textBox5.Text));
            textBox3.Text = "" + contas[acessada].saldo;
            textBox2.Clear();

            int a = int.Parse(textBox6.Text);
            contas[a].deposita(int.Parse(textBox5.Text));
            textBox4.Clear();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "" + contas[acessada].saldo;
            label5.Text = "Bem Vindo: " + contas[acessada].titular;
            label8.Text = "Banco: " + contas[acessada].banco.modelo;
        }
    }
}
