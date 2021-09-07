using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop04___ATM.Classes
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        private int _Pin { get; set; }
        private int _Balance { get; set; }
        public string[] Message { get; set; }


        public Customer(string firstName, string lastName, long cardNumber,int pin, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            _Pin = pin;
            _Balance = balance;

        }

        public bool CheckPin(int Pin)
        {
            if(_Pin == Pin) return true;
            return false;
        }

        public int ForBalance()
        {
            return _Balance;
        }

        public bool MakeWithdraw(int amount)
        {
            if (amount > _Balance)
                return false;
                _Balance -= amount;
                return true;
        }

        public void MakeDeposit(int amountForDeposit)
        {
            _Balance += amountForDeposit;
        }
    }
}
