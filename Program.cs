﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace EldenRingDeathCounter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Debugger.IsAttached)
                CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DeathCounter());
        }
    }
}
