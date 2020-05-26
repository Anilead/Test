using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestBinding.Data
{
   public static class Classes
    {
        public static Visi V;
    }

    public class Visi : INotifyPropertyChanged
    {
        private Visibility _mainPage;
        private Visibility _mediaPlayer;

        public Visibility MainPage
        { 
            get => _mainPage; set 
            {
                _mainPage = value;
                OnPropertyChanged("MainPage");
            }
        }

        public Visibility MediaPlayer
        { 
            get => _mediaPlayer;
            set
            {
                _mediaPlayer = value;
                OnPropertyChanged("MediaPlayer");
            }

        }

        public Visi()
        {
            MainPage = Visibility.Visible;
            MediaPlayer = Visibility.Collapsed;
        }

        public void DisplayMainPage()
        {
            MainPage = Visibility.Visible;
            MediaPlayer = Visibility.Collapsed;
        }

        public void DisplayMediaPlayer()
        {
            MainPage = Visibility.Collapsed;
            MediaPlayer = Visibility.Visible;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        
        public void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
