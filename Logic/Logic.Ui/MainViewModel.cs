using GalaSoft.MvvmLight;

namespace lmwohlfart.tsbw.WpfMvvm.Logic.Ui.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                WindowTitle = "MainWindow (Design)";
            }
            else
            {
                WindowTitle = "MainWindow";
            }
        }

        public string WindowTitle { get; private set; }
    }
}