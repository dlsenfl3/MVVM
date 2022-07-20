using MVVM_Basics.Commands;
using MVVM_Basics.Services;
using MVVM_Basics.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Basics.ViewModels
{
    public class AViewModel : ViewModelBase
    {
        public ICommand ConvertBViewCommand { get; set; }
        public ICommand ConvertCViewCommand { get; set; }

        public AViewModel(NavigationStore navigationStore)
        {
            ConvertBViewCommand = new NavigateCommand<BViewModel>(navigationStore, () => new BViewModel(navigationStore));
            ConvertCViewCommand = new NavigateCommand<CViewModel>(navigationStore, () => new CViewModel(navigationStore));
        }

    }
}
