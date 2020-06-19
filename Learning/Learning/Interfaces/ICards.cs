using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Interfaces
{
    /// <summary>
    /// Interface for Credit card in wallet account
    /// </summary>
    interface ICards
    {
        string BankName { get; }
        int CreditLimit { get; } //Credit limit for card
        int InterestRate { get; } //Loan interest Rate
        
        int WindrawCommission { get; } //Comission for windraw

        


        void Deposit(float summ); //insert Deposit on Card
        void Windraw(float summ);  // Windraw money 
        void Payment(float summ); //Payment anywere
        
    }
}
