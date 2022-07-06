using MVVM_Example.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Example.ViewModels
{
    public class FirstViewModel : ViewModelBase
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
                //OnPropertyChanged(nameof(UserInformation));
            }
        }

        private string _email = "dlsenfl@naver.com";

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
                //OnPropertyChanged(nameof(UserInformation));
            }
        }

        public string UserInformation => $"{UserName} : {Email}";

        public ICommand DisplayInformationCommand { get; set; }

        public FirstViewModel()
        {
            DisplayInformationCommand = new FirstViewCommand(this);
        }

        public void OnUserInformationChanged()
        {
            OnPropertyChanged(nameof(UserInformation));
        }
    }
}
