using System;
using System.Windows.Forms;

namespace csharp.util.ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newline;
            foreach(var line in textBox1.Lines)
            {
                newline = line;
                newline = newline.Replace(@"""", @"\""");
                newline = "\"" + newline + "\"+ ";
                textBox2.AppendText(newline + Environment.NewLine);
            }
        }
    }
}
