﻿using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    static class Program
    {
        /// <summary>
        /// Main point of insertion.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
