﻿using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace BorderlessGaming
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
           
            Native.CheckForUpdates();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Borderless());
         /*   AppDomain.CurrentDomain.FirstChanceException += (sender, args) =>
            {

                MessageBox.Show(args.Exception.Message, "FirstChanceException");
                throw args.Exception;

            };*/
        }
    }
}