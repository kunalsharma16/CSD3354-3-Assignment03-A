﻿using System;

namespace BankAccountNS
{
    public class BankAccount
    {
        // c0727250 Kunal sharma//
        // c0730478 Shoit Sharma//

        private string m_customerName;
        private double m_balance;
        private bool m_frozen = false;

        private BankAccount()
        {

        }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName

        {
            get { return m_customerName; }
        }
        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (m_frozen)

            {
                throw new Exception("Account frozen");

            }

            if (amount > m_balance)

            {
                throw new ArgumentOutOfRangeException("amount");

            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance -= amount;

        }

        public void Credit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(" AMOUNT");
            }

            m_balance += amount;

        }

        private void FreezeAccount()
        {
            m_frozen = true;

        }

        private void unFreezeAccount()
        {
            m_frozen = false;

        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Credit(11.22);
            Console.WriteLine("CURRENT BALANCE IS $ {0}", ba.Balance);
        }
    }
}


