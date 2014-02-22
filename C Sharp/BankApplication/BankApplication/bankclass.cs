using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class bankclass
    {
       private string accountName;
       private int accountNumber;
       private double balance;
       
      

       public bankclass()
       {
       }

       public bankclass (string accName)
       {
           accountName = accName;
       }

       public bankclass (string accName, int accNum)
       {
           accountName = accName;
           accountNumber = accNum;
       }

       public bankclass(string accName, int accNum, double beginBal)
       {
           accountName = accName;
           accountNumber = accNum;
           balance = beginBal;   
       }

       public double Balance
       {
           get
           {
               return balance;
           }
           set
           {
               balance = value;
           }
       }

       public double deposit
       {
           get 
           {
               return deposit;
           }
           set
           {
               deposit = value;
           }
       }

       public double withdrawal
       {
           get
           {
               return withdrawal;
           }
           set
           {
               withdrawal = value;
           }
       }

       public double depositamount(double dep)
       {
           balance = dep + balance;
           return (balance);
       }

       public double withdrawalamount(double with)
       {
           balance = balance - with;

           return (balance);
       }
    }
}
