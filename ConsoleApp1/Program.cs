﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Enginnier
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu MeuMenu = new Menu(new Operations(), new Data());

            MeuMenu.MostraMenu();
        }
    }
}