using System;
using Wallet.Class;
using Wallet.Interfaces;

namespace Wallet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var wallet = new Wallets();
            //Add cards in wallet
            wallet.AddCard(new BuisnessCard("MyBuisnessCard"));
            wallet.AddCard(new CreditCard("MyCreditCard"));
            wallet.AddCard(new Ticket("RZD Moscow-Leningrad"));

            wallet.GetInfoCard("MyBuisnessCard");
            wallet.GetAllCardName();

            var displayCard = wallet.GetCard("MyBuisnessCard");
            wallet.DropCard(displayCard);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wallet after Drop:");
            wallet.GetAllCardName();
            Console.ResetColor();


        }
    }
}
