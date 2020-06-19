using System;
using System.Collections.Generic;
using System.Text;
using Wallet.Enumeration;
using Wallet.Interfaces;

namespace Wallet.Class
{
    internal sealed class CreditCard : IWalletCards
    {
        public CreditCard(string name)
        {
            Name = name;
            Type = TypeCard.Type.CreditCard;

        }
        public string Name { get; }

        public TypeCard.Type Type { get; }

        public void OnRead()
        {
            Console.WriteLine($"Считана карта {Name} c помощью PayPass");
        }
    }
}
