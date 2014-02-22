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
        //balance

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
        //deposit
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
        //withdrawl 
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

       public double depositamount(double dep) //calculate a deposit
       {
           balance = dep + balance;
           return (balance);
       }

       public double withdrawalamount(double with) //calculate a withdrawal
       {
           balance = balance - with;

           return (balance);
       }
    }
}
