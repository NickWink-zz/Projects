using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountNS;

namespace CheckingAccountNS
{
    public class CheckingAccount : BankAccountBase
    {
        private int checkingFee;
        private double interestRate;
     //   private double depositAmount;
     //   private double withdrawlAmount;
       

        public CheckingAccount()
            : base()
        {
            checkingFee = 7;
            interestRate = 2.75;
         //   depositAmount = 0;   
         //   withdrawlAmount = 0;
        }

        public CheckingAccount(string aName, int aNumber, double aBalance, int checkFee, double intRate, double deposit, double withdraw)
            :base(aName, aNumber, aBalance)
        {
            checkingFee = checkFee;
            interestRate = intRate;
          //  depositAmount = deposit;
          //  withdrawlAmount = withdraw;
        }

        public int CheckingFee  //checkfee
        {
            get
            {
                return checkingFee;
            }
        }

        public double InterestRate //interestRate
        {
            get
            {
                return interestRate;
            }
        }

     //   public double DepositAmount //deposit
       // {
         //   get
           // {
             //   return depositAmount;
           // }
         //   set
         //   {
          //      depositAmount = value;
          //  }
       // }

        //public double WithdrawlAmount //withdraw
        //{
         //   get
           // {
             //   return withdrawlAmount;
          //  }
          //  set
         //   {
          //      withdrawlAmount = value;
          //  }
       // }



    }
}
