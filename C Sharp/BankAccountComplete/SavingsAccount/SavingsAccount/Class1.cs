using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountNS;

namespace SavingsAccountNS
{
    public class SavingsAccount : BankAccountBase
    {
        private double interestRate;
        private int withdrawlsAllowed;
    //    private double depositAmount;
    //    private double withdrawlAmount;
       

        public SavingsAccount()
            : base()
        {
            interestRate = 5.00;
            withdrawlsAllowed = 10; //monthly withdrawls
          //  depositAmount = 0;
          //  withdrawlAmount = 0;
        }

        public SavingsAccount(string aName, int aNumber, double aBalance, double intRate, int withdrwals)// double deposit, double withdraw
            :base(aName, aNumber, aBalance)
        {
            
            interestRate = intRate;
            withdrawlsAllowed = withdrwals;
      //      depositAmount = deposit;
     //       withdrawlAmount = withdraw;
        }

        public double InterestRate //interestRate
        {
            get
            {
                return interestRate;
            }
        }

        public int WithdrawlsAllowed
        {
            get 
            {
                return withdrawlsAllowed;
            }
            
        }
   //     public double DepositAmount //deposit
   //     {
   //         get
   //         {
   //             return depositAmount;
   //         }
  //          set
   //         {
   //             depositAmount = value;
    //        }
    //    }

   //     public double WithdrawlAmount //withdraw
     //   {
       //     get
      //      {
       //         return withdrawlAmount;
        //    }
       //     set
        //    {
        //        withdrawlAmount = value;
        //    }
       // }
    }
}
