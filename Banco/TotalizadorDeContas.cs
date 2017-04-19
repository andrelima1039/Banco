﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class TotalizadorDeContas
    {
        public double SaldoTotal { get; private set; }

        public void Soma(Conta conta)
        {
            SaldoTotal += conta.Saldo;
        }


    }
}