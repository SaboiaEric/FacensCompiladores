using Compiler.Analysers;
using System;
using System.Windows.Forms;

namespace Compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            new Lexer().Analyse(textBox1.Text).ForEach(x => listView1.Items.Add(x));
        }
    }
}
