using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS
{
    public class BankAccountBase
    {
        
        
            private string mAccountName;
            private int mAccountNumber;
            private double mAccountBalance;


            public BankAccountBase()
            {
                mAccountBalance = 0;
                mAccountName = "";
                mAccountNumber = 0;
            }

            public BankAccountBase(string aName, int aNumber, double aBalance)
            {
                mAccountName = aName;
                mAccountBalance = aBalance;
                mAccountNumber = aNumber;
            }

            public string AccountName
            {
                get
                {
                    return mAccountName;
                }
            }

            public int AccountNumber
            {
                get
                {
                    return mAccountNumber;
                }
            }

            public double AccountBalance
            {
                get
                {
                    return mAccountBalance;
                }
                set
                {
                    mAccountBalance = value;
                }
            }

    }
}
