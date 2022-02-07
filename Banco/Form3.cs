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
    public partial class Form3 : Form
    {
        public Conta[] contas = new Conta[20];
        public Banco[] banco = new Banco[20];
        int ultimo;

        public Form3(Conta[] contas, int ultimo)
        {
            this.contas = contas;
            this.ultimo = ultimo;
            InitializeComponent();
            comboBox1.Items.Add("Conta Corrente");
            comboBox1.Items.Add("Conta Universitaria");
            comboBox1.Items.Add("Conta Poupança");
            comboBox2.Items.Add("Bradesco");
            comboBox2.Items.Add("Itau");
            comboBox2.Items.Add("Santander");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banco[ultimo] = new Banco();
            banco[ultimo].modelo = comboBox2.SelectedItem.ToString();

            switch(comboBox1.SelectedItem.ToString()) {
                case "Conta Corrente":
                    contas[ultimo] = new ContaCorrente();
                    break;
                case "Conta Universitaria":
                    contas[ultimo] = new ContaUniversitaria();
                    break;
                case "Conta Poupança":
                    contas[ultimo] = new ContaPoupanca();
                    break;
            }

            contas[ultimo].titular = textBox1.Text;
            contas[ultimo].saldo = 0;
            contas[ultimo].numero = ultimo;
            contas[ultimo].banco = banco[ultimo];
            ultimo++;

            MessageBox.Show("Numero da Conta: " + contas[ultimo - 1].numero + "\nBanco: "+comboBox2.SelectedItem +"\nTipo de Conta: " + comboBox1.SelectedItem + "\nNome do Usuario: "+ textBox1.Text);
            this.Close();
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}


