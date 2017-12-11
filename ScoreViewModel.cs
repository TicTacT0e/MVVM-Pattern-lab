using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApplication1
{
    class ScoreViewModel : INotifyPropertyChanged
    {
        private Score score;
        public ScoreViewModel(Score s)
        {
            score = s;
        }
        public int Number
        {
            get { return score.Number; }
            set
            {
                score.Number = value;
                OnPropertyChanged("Number");
            }
        }
        public string Type
        {
            get { return score.Type; }
            set
            {
                score.Type = value;
                OnPropertyChanged("Type");
            }
        }
        public int Balance
        {
            get { return score.Balance; }
            set
            {
                score.Balance = value;
                OnPropertyChanged("Balance");
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
