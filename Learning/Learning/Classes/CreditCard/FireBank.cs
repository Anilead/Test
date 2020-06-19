using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Interfaces;

namespace Learning.Classes.CreditCard
{
    class FireBank : ICards
    {
        public string BankName { get; }

        public int CreditLimit {get; }

        public int InterestRate { get; }

        public int WindrawCommission { get; }



        public FireBank()
        {
            BankName = "FireBank";
            CreditLimit = 5000;
            InterestRate = 5;
            WindrawCommission = 5;

        }
        public void Deposit(float summ)
        {
            
        }

        public void Payment(float summ)
        {
            
        }

        public void Windraw(float summ)
        {
            
        }
    }
}
