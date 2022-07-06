using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Example.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {
        private int _userID;

        public int UserID
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

        public SecondViewModel()
        {
            //UserInformation2Command = new 
        }

    }
}
