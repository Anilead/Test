using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Interfaces;

namespace Learning.Classes.CreditCard
{
    
    class LolkaBank : ICards, IMoney
    {
        public string BankName { get; }

        public int CreditLimit { get; }

        public int InterestRate { get; }

        public int WindrawCommission { get; }

        public float Money { get; set; }

       


        public LolkaBank()
        {
            BankName = "LolkaBank";
            CreditLimit = 10000;
            InterestRate = 5;
            WindrawCommission = 5;

        }
        public void Deposit(float summ)
        {
            Money += summ;
        }

        public void Payment(float summ)
        {
            Money -= summ;
        }

        public void Windraw(float summ)
        {
            
        }
    }
}
