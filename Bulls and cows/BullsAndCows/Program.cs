﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    class Program
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            InitializeNumberOfChancesForm form = new InitializeNumberOfChancesForm();
            form.ShowDialog();
        }
    }
}
