using MVVM_Basics.DataBase;
using MVVM_Basics.Models;
using MVVM_Basics.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Basics.Commands
{
    public class SignUpCommand : CommandBase
    {
        private readonly BViewModel _bViewModel;
        private readonly UserList _userList;
        BasicDbContext db = new BasicDbContext();

        public SignUpCommand(BViewModel bViewModel, UserList userList)
        {
            _bViewModel = bViewModel;
            _userList = userList;
            _bViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
           OnCanExecuteChanged();
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_bViewModel.UserName) &&
                !string.IsNullOrEmpty(_bViewModel.Email) &&
                (_bViewModel.PhoneNumber>0) &&
                base.CanExecute(parameter);//OnCanExecuteChanged호출로인한 호출
        }
        public override void Execute(object? parameter)
        {
            User user = new User{
                //_bViewModel.UserName,
                //_bViewModel.PhoneNumber,
                //_bViewModel.Email
                UserName = _bViewModel.UserName,
                Email = _bViewModel.Email,
                PhoneNumber = _bViewModel.PhoneNumber,
            };

            db.Users.Add(user);
            db.SaveChanges();
            
            _userList.AddUser(user);
        }
    }
}
