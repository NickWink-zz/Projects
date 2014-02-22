using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAccountNS;
using CheckingAccountNS;
using SavingsAccountNS;


namespace BankApplication
{
    public partial class Form1 : Form
    {
        CheckingAccount aCheckingAccount;
        SavingsAccount aSavingsAccount;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            aCheckingAccount = new CheckingAccount("Mark Whalberg", 2948564, 8500.00, 7, 2.75, 0.00, 0.00);
            aSavingsAccount = new SavingsAccount("Mickey Mouse", 904736, 100000000, 5.00, 10);
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //checking checkbox
        {
            if (this.checkBox2.Checked == true)
            {
                labelName.Text = "Account Name: " + aCheckingAccount.AccountName +  //displays class made Account for savings
                  "\nAccount Number: " + aCheckingAccount.AccountNumber + "\nAccount Balance: " +
                  string.Format("{0:C}", aCheckingAccount.AccountBalance) + 
                  "\nChecking Fee Amount: " + string.Format("{0:C}",aCheckingAccount.CheckingFee) +
                  "\nInterest Rate: " + aCheckingAccount.InterestRate; 
            }
            else
            {
                labelName.ResetText();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //savings checkbox
        {
            if (this.checkBox1.Checked == true)
            {
                labelSavings.Text = "Account Name: " + aSavingsAccount.AccountName +  //displays class made Account for savings
                    "\nAccount Number: " + aSavingsAccount.AccountNumber +
                    "\nAccount Balance: " + string.Format("{0:C}",aSavingsAccount.AccountBalance) +
                    "\nWithdrawls Allowed: " + aSavingsAccount.WithdrawlsAllowed +
                    "\nInterest Rate: " + aSavingsAccount.InterestRate;
            }
            else
            {
                labelSavings.ResetText();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the application with the button
        }
    }
}
