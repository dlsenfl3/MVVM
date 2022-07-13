using MVVM_Example.Commands;
using MVVM_Example.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Example.ViewModels
{
    public class ThirdViewModel : ViewModelBase
    {
        private string _thirdName;

        public string ThirdName
        {
            get { return _thirdName; }
            set
            {
                _thirdName = value;
                OnPropertyChanged();
            }
        }
        private string _thirdEmail;

        public string ThirdEmail
        {
            get { return _thirdEmail; }
            set
            {
                _thirdEmail = value;
                OnPropertyChanged();
            }
        }

        public string UserInformation => $"{ThirdName} : {ThirdEmail}";

        public ICommand ConvertFirstViewCommand { get; set; }
        public ICommand ConvertSecondViewCommand { get; set; }

        public ThirdViewModel(NavigationStore navigationstore)
        {
            ConvertFirstViewCommand = new ConvertViewCommand<FirstViewModel>(navigationstore, () => new FirstViewModel(navigationstore));
            ConvertSecondViewCommand = new ConvertViewCommand<SecondViewModel>(navigationstore, () => new SecondViewModel(navigationstore));
        }
    }
}
