using MVVM_Basics.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Basics.Commands
{
    public class DisPlayUserInfoCommand : CommandBase
    {
        private readonly BViewModel _bViewModel;

        public DisPlayUserInfoCommand(BViewModel bViewModel)
        {
            _bViewModel = bViewModel;
            _bViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(BViewModel.UserName))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_bViewModel.UserName) && base.CanExecute(parameter);//OnCanExecuteChanged호출로인한 호출
        }

        public override void Execute(object? parameter)
        {
            _bViewModel.DisplayUserInfo2(parameter);
        }
    }
}
