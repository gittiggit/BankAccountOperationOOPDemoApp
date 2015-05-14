using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountOperationDemoApp
{
  public  class AccountInformation
  {

      public string accountNumber { get; set; }
      public string  customerName { get; set; }
      public double accountBalance { get; set; }

      

      public void DepositMoney(double depMoney)
      {

          if (depMoney<=0)
          {
              MessageBox.Show("Enter the correct amount .");
          }
          else
          {
              this.accountBalance = this.accountBalance + depMoney; 
          }
          
      }
      public void WithDrawMoney(double money)
      {
          if (this.accountBalance>=money)
          {
              this.accountBalance = this.accountBalance - money;
              MessageBox.Show("With drawn.");
          }
          else
          {
              MessageBox.Show("Not sufficient balance");
          }

          
      }

      public void GenerateReport()
      {
          MessageBox.Show("Account Number"+accountNumber+"\nCustomer Name:"+customerName+"\nBalance :"+accountBalance);
      }


  }
}
