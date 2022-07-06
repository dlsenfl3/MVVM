using MVVM_Example.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Example.Commands
{
    public class FirstViewCommand : CommandBase
    {
        private readonly FirstViewModel _firstViewModel;

        public FirstViewCommand(FirstViewModel firstViewModel)
        {
            _firstViewModel = firstViewModel;
            _firstViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(FirstViewModel.UserName))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_firstViewModel.UserName) && base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            _firstViewModel.OnUserInformationChanged();
            //Debug.WriteLine("DisplayInformation");
        }
    }
}
