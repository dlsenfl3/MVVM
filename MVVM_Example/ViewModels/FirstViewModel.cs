using MVVM_Example.Commands;
using MVVM_Example.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                _userName = value;  //프로퍼티 변경시 
                OnPropertyChanged();    //프로퍼티 변경반영
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

        //private string _userInformation;

        //public string UserInformation
        //{
        //    get { return _userInformation; }
        //    set { _userInformation = value; }
        //}

        public string UserInformation => $"{UserName} : {Email}";

        public ICommand DisplayInformationCommand { get; set; }
        public ICommand ConvertSecondViewCommand { get; set; }
        public ICommand ConvertThirdViewCommand { get; set; }
        public ICommand WheelCommand { get; set; }

        

        public FirstViewModel(NavigationStore navigationStore)
        {
            //DisplayInformationCommand = new FirstViewCommand(this);
            ConvertSecondViewCommand = new ConvertViewCommand<SecondViewModel>(navigationStore, () => new SecondViewModel(navigationStore));
            ConvertThirdViewCommand = new ConvertViewCommand<ThirdViewModel>(navigationStore, () => new ThirdViewModel(navigationStore));
            DisplayInformationCommand = new RelayCommand<object>(OnUserInformationChanged);
            DisplayInformationCommand = new RelayCommand<object>(OnUserInformationChanged);

            //WheelCommand = new RelayCommand<object>(OnMouseWheel);
        }




        public void OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
            //UserInformation = $"{e.Delta}";
            OnPropertyChanged(nameof(UserInformation));
        }

        public void OnUserInformationChanged(object sender)
        {
            OnPropertyChanged(nameof(UserInformation));
        }

        public void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


    }
}
