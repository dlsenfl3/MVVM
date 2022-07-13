using NavigationMVVM.Commands;
using NavigationMVVM.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationMVVM.ViewModels
{
    public class HomeViewModel :ViewModelBase
    {
        public string WelcomeMessage => "Welcome to my application.";

        public ICommand NavigateAccountCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateAccountCommand = new NavigateAccountCommand(navigationStore);
        }
    }
}
