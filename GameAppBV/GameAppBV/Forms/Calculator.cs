using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAppBV.Forms
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(57, 73, 87);
            button1.ForeColor = Color.Snow;
            button2.BackColor = Color.FromArgb(57, 73, 87);
            button2.ForeColor = Color.Snow;
            button3.BackColor = Color.FromArgb(57, 73, 87);
            button3.ForeColor = Color.Snow;
            button4.BackColor = Color.FromArgb(57, 73, 87);
            button4.ForeColor = Color.Snow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            try
            {
                double result = Convert.ToDouble(textBoxOp1.Text) + Convert.ToDouble(textBoxOp2.Text);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You have to input 2 valid numbers! (, as comma)");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            try
            {
                double result = Convert.ToDouble(textBoxOp1.Text) - Convert.ToDouble(textBoxOp2.Text);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You have to input 2 valid numbers! (, as comma)");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            try
            {
                double result = Convert.ToDouble(textBoxOp1.Text) * Convert.ToDouble(textBoxOp2.Text);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You have to input 2 valid numbers! (, as comma)");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            try
            {
                double result = Convert.ToDouble(textBoxOp1.Text) / Convert.ToDouble(textBoxOp2.Text);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You have to input 2 valid numbers! (, as comma)");
            }
        }
    }
}
