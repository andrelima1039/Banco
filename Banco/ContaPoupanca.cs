﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numero) : base(numero) { }

        public override bool Saca(double valor)
        {
            return base.Saca(valor + 0.10);
        }
    }
}
