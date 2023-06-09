using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace ConsoleApp1
{
    public class BankAccount
    {
        private static int _accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            decimal balance = 0;
            foreach(var item in allTransactions)
            {
            balance += IThreadPoolWorkItem.amount;
            }
        }
        
        private List<Transaction> allTransactions = new List<Transaction>();    

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = _accountNumberSeed.ToString();
            _accountNumberSeed++;
        }

       
        //private bool AccountValidator() 
        //{
            /*
            if ()
            {
                return true;
            }
           else
            {
                return false;
            }*/
        //}

       
  //  }
//}
