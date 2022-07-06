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
        private string _userName = "insukim";

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private string _email = "dlsenfl@naver.com";

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string UserInformation => $"{UserName} : {Email}";

        public ICommand DisplayInformation { get; set; }

        public FirstViewModel()
        {
            //DisplayInformation = new 
        }
    }
}
