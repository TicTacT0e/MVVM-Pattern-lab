using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApplication1
{
    class Score : INotifyPropertyChanged
    {
        private int number;
        private string type;
        private int balance;
        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged("Title");
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Company");
            }
        }

        public int Balance
        {
            get { return balance; }
            set
            {
                balance = value;
                OnPropertyChanged("Price");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
