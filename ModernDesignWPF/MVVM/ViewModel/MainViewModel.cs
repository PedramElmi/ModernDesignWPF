using ModernDesignWPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModernDesignWPF.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public ICommand HomeViewCommand { get; set; }
        public ICommand DiscoveryViewCommand { get; set; }



        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }



        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(_ => CurrentView = HomeVM);
            DiscoveryViewCommand = new RelayCommand(_ => CurrentView = DiscoveryVM);
        }



    }
}
