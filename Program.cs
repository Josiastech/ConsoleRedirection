using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConsoleRedirection
{
    static class Program
    {
        /// <summary>
        /// Draw asterisks in windows form app 
        /// using the output from console application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormConsole());
        }
    }
}