using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txt_comparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string OriginalText = richTextBox1.Text;
            string ComparingText = richTextBox2.Text;
            List<Int32> mistakes = new List<Int32>();
            Console.WriteLine("Working on it...");
            for (int i = 0 ; i < richTextBox1.Lines.Length; i++)
            {
                string line1 = richTextBox1.Lines[i];
                string line2 = line1;
                try
                {
                    line2 = richTextBox2.Lines[i];
                }
                catch
                {
                    continue;
                }
                bool eq = String.Equals(line1, line2);
                if (richTextBox1.Lines.Length == 0)
                { 
                    break;
                }
                if(eq != true)
                {
                    mistakes.Add(i);
                    Console.WriteLine(mistakes);
                }
            }
            if(richTextBox1.Lines.Length == 0)
            {
                textBox1.Text = "You should type something in first";
            }
            else if(mistakes.Count == 0)
            {
                textBox1.Text = "Those two texts are identical";
            }
            else
            {
                string lines = String.Join(", ", mistakes.ToArray());
                Console.WriteLine(lines);
                textBox1.Text = "You made mistakes at lines: " +  lines;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
