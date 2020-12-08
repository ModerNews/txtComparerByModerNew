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
            for (int i = 0; i == richTextBox1.Lines.Length; i++)
            {
                if (richTextBox1.Lines[i].Equals(richTextBox2.Lines[i]))
                {
                    mistakes.Add(i);
                }
            }
            if(OriginalText.Equals(ComparingText) == true)
            {
                textBox1.Text = "Those two texts are identical";
            }
            else
            {
                string lines = String.Join(", ", mistakes.ToArray());
                textBox1.Text = "You made mistakes at lines: " +  lines;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
