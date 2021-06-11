using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS018SlovaPozpatku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vstupTextBox_TextChanged(object sender, EventArgs e)
        {
            vystupTextBox.Text = SlovaPozpatku(vstupTextBox.Text);
        }
        private static string SlovaPozpatku(string text)
        {
            string[] slova = text.Split(new[] { " " }, StringSplitOptions.None);
            return string.Join(" ", slova.Reverse());
        }

        private void vystupTextBox_TextChanged(object sender, EventArgs e)
        {
            vstupTextBox.Text = SlovaPozpatku(vystupTextBox.Text);
        }
    }
}
