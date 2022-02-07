using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class Conta
    {
        public double saldo { get; set; }

        public string titular { get; set; }

        public int numero { get; set; }

        public Banco banco { get; set; } // na hora de estancia a conta estancia o banco também onde ele também é usado como uma variavel

        public virtual void saca(double x)
        {
            this.saldo -= x;
        }

        public void deposita(int x)
        {
            this.saldo += x;
        }
    }
}
