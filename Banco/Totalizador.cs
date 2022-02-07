using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    class Totalizador
    {
        public double valorTotal;

        public void soma(Conta conta)
        {
            valorTotal += conta.saldo;
        }
    }
}
