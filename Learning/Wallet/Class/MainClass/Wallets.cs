using System;
using System.Collections.Generic;
using System.Text;
using Wallet.Interfaces;
using Wallet.Enumeration;

namespace Wallet.Class
{
    
    internal sealed class Wallets
    {
        private List<IWalletCards> walletCards = new List<IWalletCards>(); //Все карты в кошельке
        /// <summary>
        /// Add Card in Wallet
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(IWalletCards card)
        {
            this.walletCards.Add(card);
        }
        /// <summary>
        /// Drop Card in Wallet
        /// </summary>
        /// <param name="card"></param>
        public void DropCard(IWalletCards card)
        {
            if (card != null)
            {
                this.walletCards.Remove(card);
            }
            
        }
        /// <summary>
        /// Get info about Card
        /// </summary>
        /// <param name="card"></param>
        public void GetInfoCard(string name)
        {
            var findCard = this.walletCards.Find(t => t.Name == name);
            if (findCard != null)
            {
                Console.WriteLine($"Информация по карте: {findCard.Type}");
            }

        }
        public void GetAllCardName()
        {
            foreach (var item in this.walletCards)
            {
                Console.WriteLine($"{item.Type}: {item.Name}");

            }
        }

        public IWalletCards GetCard(string name)
        {
            return this.walletCards.Find(t => t.Name == name);
        }

    }
}
