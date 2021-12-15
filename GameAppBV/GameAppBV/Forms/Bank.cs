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
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }

        BankUser bankUser;
        public void buttonSubmit_Click(object sender, EventArgs e)
        {
            try 
            { 
                bankUser = new BankUser(textBoxNameInput.Text, textBoxAddrInput.Text, Convert.ToDouble(textBoxSaldoInput.Text), Convert.ToDouble(textBoxCashInput.Text), textBoxBankInput.Text);
                textBoxSaldo.Text = (bankUser.Saldo).ToString();
                textBoxCash.Text = (bankUser.Cash).ToString();
                labelBankName.Text = bankUser.BankName;
                labelUserAddr.Text = bankUser.Address;
                labelUserName.Text = bankUser.Name;
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill in all the fields!");
            }
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                bankUser.DepositMoney(Convert.ToDouble(textBoxAmount.Text));
                if(bankUser.error == true) { MessageBox.Show("You don't have enough cash money to do this!"); }
                bankUser.error = false;
                textBoxSaldo.Text = (bankUser.Saldo).ToString();
                textBoxCash.Text = (bankUser.Cash).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You have to choose an amount!");
            }

        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                bankUser.WithdrawMoney(Convert.ToDouble(textBoxAmount.Text));
                if (bankUser.error == true) { MessageBox.Show("You don't have enough cash money to do this!"); }
                bankUser.error = false;
                textBoxSaldo.Text = (bankUser.Saldo).ToString();
                textBoxCash.Text = (bankUser.Cash).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You have to choose an amount!");
            }
        }
    }
}
