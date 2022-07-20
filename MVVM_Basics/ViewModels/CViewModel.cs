using MVVM_Basics.Commands;
using MVVM_Basics.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Basics.ViewModels
{
    public class CViewModel : ViewModelBase
    {
        public ICommand ConvertAViewCommand { get; set; }
        public ICommand ConvertBViewCommand { get; set; }

        public CViewModel(NavigationStore navigationStroe)
        {
            ConvertAViewCommand = new NavigateCommand<AViewModel>(navigationStroe, () => new AViewModel(navigationStroe));
            ConvertBViewCommand = new NavigateCommand<BViewModel>(navigationStroe, () => new BViewModel(navigationStroe));
        }
    }
}
