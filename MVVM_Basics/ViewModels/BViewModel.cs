using MVVM_Basics.Commands;
using MVVM_Basics.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Basics.ViewModels
{
    public class BViewModel : ViewModelBase
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        private int _phoneNumber;

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged();
            }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private string _userInformation;

        public string UserInformation
        {
            get { return _userInformation; }
            set
            {
                _userInformation = value;
                OnPropertyChanged();
            }
        }

        private RelayCommand _displayUserInformationCommand;
        public RelayCommand DisplayUserInformationCommand =>
            _displayUserInformationCommand ?? (_displayUserInformationCommand = new RelayCommand(DisplayUserInfo));

        public void DisplayUserInfo2(object obj)
        {
            UserInformation = $"Name:{UserName} PhoneNum: {PhoneNumber} Email:{Email}";
        }

        private void DisplayUserInfo(object obj)
        {
            UserInformation = $"Name:{UserName} PhoneNum: {PhoneNumber} Email:{Email}";
        }

        public ICommand DisplayUserInformation2Command { get; }
        public ICommand ConvertAViewCommand { get; }

        public BViewModel(NavigationStore navigationStore)
        {
            DisplayUserInformation2Command = new DisPlayUserInfoCommand(this);
            ConvertAViewCommand = new NavigateCommand<AViewModel>(navigationStore, () => new AViewModel(navigationStore));
        }


        public void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
