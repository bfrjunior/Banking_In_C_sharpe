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
    public partial class Form1 : Form
    {
        public int ultimo = 0;
        public Conta[] contas = new Conta[20];
        public Conta contaAcessada = new Conta();
        public Banco[] modelo = new Banco[20];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroConta = int.Parse(textBox2.Text);
            for(int i = 0; i<contas.Length;i++)
            {
                if (contas[i].numero == numeroConta)
                {
                    Form2 form2 = new Form2(contas, i);
                    form2.Show();
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aux = ultimo;
            for (int i = aux; i < aux+10; i++)
            {
                if (i <= 2)
                {
                    contas[i] = new ContaUniversitaria();
                    contas[i].titular = "João" + i;
                }
                else if (i > 2 && i <= 6)
                {
                    contas[i] = new ContaCorrente();
                    contas[i].titular = "Marcos" + i;
                }
                else if(i > 6 && i < 10)
                {
                    contas[i] = new ContaPoupanca();
                    contas[i].titular = "Chico" + i;
                }

                contas[i].saldo = i * 1000;
                contas[i].numero = i;


                ultimo++;
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            Form3 form3 = new Form3(contas, ultimo);
            form3.Show();
            ultimo++;
            
            
        }
    }
}
