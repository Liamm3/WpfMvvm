using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace lmwohlfart.tsbw.WpfMvvm.Logic.Ui.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public string WindowTitle { get; private set; }

        private string input;

        public string Input
        {
            get => input;
            set
            {
                input = value;
                RaisePropertyChanged("Input");
            }
        }

        public ObservableCollection<Thing> Things { get; set; }

        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                WindowTitle = "MainWindow (Design)";
            }
            else
            {
                Things = new ObservableCollection<Thing>();
                WindowTitle = "MainWindow";
                Input = "Hallo Welt";
            }
        }

        private ICommand _onButtonClick;

        public ICommand OnButtonClick
        {
            get
            {
                if (_onButtonClick == null)
                {
                    _onButtonClick = new RelayCommand(() =>
                    {
                        if (!string.IsNullOrWhiteSpace(Input))
                        {
                            Things.Add(new Thing(Input));
                        }
                    });
                }

                return _onButtonClick;
            }
        }
    }
}