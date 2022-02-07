using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class ContaPoupanca:Conta
    {
        public override void saca(double x)
        {
            saldo -= (x + 0.10);
        }
    }
}
