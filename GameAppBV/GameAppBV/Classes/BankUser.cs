using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppBV
{
    public class BankUser : User
    {
        public bool error { get; set; }
        public string BankName { get; set; }
        public double Saldo { get; set; }
        public double Cash { get; set; }

        public BankUser() 
        {
            Name = "Jos";
            Address = "Grote Straat 7";
            Saldo = 5000;
            Cash = 250;
            BankName = "Bankier";
        }

        public BankUser(string name, string address, double saldo, double cash, string bankName)
        {
            Address = address;
            Name = name;
            Saldo = saldo;
            Cash = cash;
            BankName = bankName;
        }

        public void WithdrawMoney(double amount) 
        { 
            if((Saldo - amount) >= 0) 
            { 
                Saldo -= amount;
                Cash += amount;
            }
            else
            {
                error = true;
            }
        }

        public void DepositMoney(double amount) 
        { 
            if((Cash - amount) >= 0)
            {
                Cash -= amount;
                Saldo += amount;
            } else
            {
                error = true;
            }
        }
     }
}
