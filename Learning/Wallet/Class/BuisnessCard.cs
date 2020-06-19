using System;
using System.Collections.Generic;
using System.Text;
using Wallet.Enumeration;
using Wallet.Interfaces;

namespace Wallet.Class
{
    internal sealed class BuisnessCard : IWalletCards
    {
        public BuisnessCard(string name)
        {
            Name = name;
            Type = TypeCard.Type.BuisnessCard;

        }
        public string Name { get; }

        public TypeCard.Type Type {get; }

        public void OnRead()
        {
            Console.WriteLine($"Считана карта {Name} c помощью QR-Code");
        }
    }
}
