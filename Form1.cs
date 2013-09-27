using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ConsoleRedirection
{
    public partial class FormConsole : Form
    {
        TextWriter _writer = null;

        public FormConsole()
        {
            InitializeComponent();
        }

        private void FormConsole_Load(object sender, EventArgs e)
        {
            _writer = new TextBoxStreamWriter(txtConsole);
            Console.SetOut(_writer);

            int nivel = 5;
            int a;
            int espacios;
            for (int i = 1; i <= nivel; i++)
            {
                StringBuilder final = new StringBuilder();
                espacios = nivel - i;
                a = i + (i - 1);
                for (int i1 = 0; i1 < espacios; i1++)
                    final.Append(" ");
                for (int i2 = 0; i2 < a; i2++)
                    final.Append("*");
                Console.WriteLine(final.ToString());
            } 

        }

        /*private void txtSayHello_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Trying to write into text box!! jaja");
        }*/

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {

        }
    }
}