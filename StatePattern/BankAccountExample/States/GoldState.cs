﻿using StatePattern.BankAccountExample.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.BankAccountExample
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Gold indicates an interest bearing state
    /// </remarks>
    /// </summary>
    class GoldState : State
    {
        private SilverState silverState;

        public GoldState(SilverState state) : this(state.Balance, state.Account) { }

        public GoldState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            interest = 0.05;
            lowerLimit = 1000.0;
            upperLimit = 10000000.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangedCheck();
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangedCheck();
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangedCheck();
        }

        private void StateChangedCheck()
        {
            if (balance < 0.0)
            {
                account.State = new RedState(this);
            }
            else if (balance < lowerLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }
}
