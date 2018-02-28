using System;
using System.Windows.Forms;

namespace UltimateToolBox
{
    public partial class Form3 : Form
    {
        public Form3(Form parentForm)
        {
            InitializeComponent();
        }

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();

        string GetRdmNumber()
        {
            Random r = new Random();
            int randomInt = r.Next((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            string number = Convert.ToString(randomInt);

            if (checkBox5.Checked) Clipboard.SetText(number);
            if (textBox1.TextLength > 1 || textBox1.TextLength == 1) textBox1.Clear();

            textBox1.Paste(number);

            return number; 
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown2.Value || numericUpDown1.Value == numericUpDown2.Value)
            {
                numericUpDown1.Value = numericUpDown2.Value - 1;
            }
        }

        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                numericUpDown2.Value = numericUpDown1.Value + 1;
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Enter) GetRdmNumber();
        }

        private void numericUpDown2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Enter) GetRdmNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetRdmNumber();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
