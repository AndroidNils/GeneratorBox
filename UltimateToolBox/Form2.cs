using System;
using System.Text;
using System.Windows.Forms;

namespace UltimateToolBox
{
    public partial class Form2 : Form
    {

        public Form2(Form parentForm)
        {
            InitializeComponent();
        }

        string generatePw(int length)
        {

            string validChars = "";

            if (checkBox1.Checked) validChars += "abcdefghijklmnopqrstuvwxyz";
            if (checkBox2.Checked) validChars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (checkBox3.Checked) validChars += boxSonderzeichen.Text;
            if (checkBox4.Checked) validChars += "1234567890";

            StringBuilder res = new StringBuilder();
            Random rnd = new Random();

            while (0 < length--)
            {
                res.Append(validChars[rnd.Next(validChars.Length)]);
            }

            if (textBox1.TextLength > 1) textBox1.Clear();
            if (checkBox5.Checked) Clipboard.SetText(res.ToString());

            return res.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSonderzeichen.Enabled) boxSonderzeichen.Enabled = false;
            else
            {
                boxSonderzeichen.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int length = (int) numericUpDown1.Value;
            string pass = generatePw(length);

            textBox1.Paste(pass);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        { 

            if (char.IsDigit(e.KeyChar))
                e.Handled = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.TextLength > 1) textBox1.Clear();

                int length = (int)numericUpDown1.Value;
                string pass = generatePw(length);

                textBox1.Paste(pass);

                if (checkBox5.Checked)
                {
                    Clipboard.SetText(pass);
                }
            }
        }
    }
}
