using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountOperationDemoApp
{
    public partial class AccountOperationUI : Form
    {
        public AccountOperationUI()
        {
            InitializeComponent();
        }

        private AccountInformation accountInf = null;
        private void createButton_Click(object sender, EventArgs e)
        {
             accountInf =  new AccountInformation();

            if (accountNumberTextBox.Text=="" || customerNameTextBox.Text =="")
            {
                MessageBox.Show("Please enter the value");
            }
            else
            {
                
                accountInf.accountNumber = accountNumberTextBox.Text;
                accountInf.customerName = customerNameTextBox.Text;

                accountNumberTextBox.Text = "";
                customerNameTextBox.Text = "";
                MessageBox.Show("Account created.");
            }
            


        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (accountInf ==null)
            {
                MessageBox.Show("Account not created.");
            }
            else
            {
                if (amountTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the value");
                }
                else
                {

                    accountInf.DepositMoney(Convert.ToDouble(amountTextBox.Text));
                    MessageBox.Show("Deposited.");
                    amountTextBox.Text = "";


                }
            }
               
            
            
        }

        private void withDrawButton_Click(object sender, EventArgs e)
        {
            if (accountInf==null)
            {
                MessageBox.Show("Account not created .");
            }
            else
            {
                if (amountTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the value");
                }
                else
                {

                    accountInf.WithDrawMoney(Convert.ToDouble(amountTextBox.Text));
                    //  MessageBox.Show("With drawn.");
                    amountTextBox.Text = "";

                }
            }
            
        }

        private void reportGenerateButton_Click(object sender, EventArgs e)
        {
            accountInf.GenerateReport();
        }
    }
}
