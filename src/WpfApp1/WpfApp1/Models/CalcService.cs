﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class CalcService : ICalcService
    {
        public int Sum(int a, int b) => a + b;
        public int Product(int a, int b) => a - b; // わざとエラーに
    }
}
