using System;
using System.Windows.Forms;

namespace DateCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            calculate();
        }
        public void calculate()
        {
            try
            {
                DateTime dt1 = DateTime.Parse(maskedTextBox1.Text);
                DateTime dt2 = DateTime.Parse(maskedTextBox2.Text);
                TimeSpan ts = new TimeSpan();
                ts = dt2 - dt1;
                textBox1.Text = ts.TotalDays.ToString();
                textBox2.Text = Math.Round(ts.TotalDays / (365.25 / 12)).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Date " + ex.Message);
            }
        }
        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                calculate();
            }
            
        }
    }
}
