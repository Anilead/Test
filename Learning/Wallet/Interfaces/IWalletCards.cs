using System;
using System.Collections.Generic;
using System.Text;

namespace Wallet.Interfaces
{
    interface IWalletCards
    {
        public string Name { get; } //Название карты
        public Enum Type { get; } //Тип карты
        public void DoRead(); //Считвыание карты

    }
}
