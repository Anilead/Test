using System;
using System.Collections.Generic;
using System.Text;
using Wallet.Enumeration;

namespace Wallet.Interfaces
{
    internal interface IWalletCards
    {
        public string Name { get; } //Название карты
        public TypeCard.Type Type { get; } //Тип карты
        public void OnRead(); //Считвыание карты

    }
}
