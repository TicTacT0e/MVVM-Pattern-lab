using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;


namespace WpfApplication1
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private Score selectedScore;
        public ObservableCollection<Score> Scores { get; set; }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                (addCommand = new RelayCommand(obj =>
                {
                    Score score = new Score();
                    Scores.Insert(0, score);
                    SelectedScore = score;
                }));
            }
        }
        public Score SelectedScore
        {
            get { return selectedScore; }
            set
            {
                selectedScore = value;
                OnPropertyChanged("SelectedScore");
            }
        }
        public ApplicationViewModel()
        {
            Scores = new ObservableCollection<Score>
{
new Score { Number=121, Type="Дебетовый", Balance=1256 },
new Score {Number=1059, Type="Накопительный", Balance =436 },
new Score {Number=563, Type="Кредитный", Balance=5690 },
new Score {Number=789, Type="Подарочный", Balance=2000 }
};
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}