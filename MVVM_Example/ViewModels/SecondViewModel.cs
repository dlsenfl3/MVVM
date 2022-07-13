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
    public class SecondViewModel : ViewModelBase
    {
        private string _userID;

        public string UserID
        {
            get { return _userID; }
            set
            {
                _userID = value;
                OnPropertyChanged(nameof(UserID));
            }
        }

        private int _phoneNumber;

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }
        public string UserInformation2 => $"{UserID} : {PhoneNumber}";

        public ICommand UserInformation2Command { get; set; }
        public ICommand ConvertFirstViewCommand { get; set; }
        //public ICommand TextBoxPreviewTextInput { get; set; }

        public SecondViewModel(NavigationStore navigationStore)
        {
            UserInformation2Command = new DelegateCommand(OnUserInformationChanged);
            ConvertFirstViewCommand = new ConvertViewCommand<FirstViewModel>(navigationStore, () => new FirstViewModel(navigationStore));
            //TextBoxPreviewTextInput = new DelegateCommand(TextBox_PreviewTextInput);
        }

        public void OnUserInformationChanged(object obj)
        {
            OnPropertyChanged(nameof(UserInformation2));
        }


        public void TextBoxPreviewInput(object obj, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public bool IsValidation(object value)
        {
            Regex regex = new Regex("[^0-9]+");
            var isValidation = regex.IsMatch(value.ToString());
            if (isValidation)
            {
                return true;
            }
            return false;
        }


    }
}
