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
        /// <summary>
        /// FirstViewModel의 프로퍼티 변경시 호출.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(FirstViewModel.UserName))
            {
                OnCanExecuteChanged();  //_firstViewModel.PropertyChanged이벤트가 발생하여 호출.
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_firstViewModel.UserName) && base.CanExecute(parameter);//OnCanExecuteChanged호출로인한 호출
        }

        /// <summary>
        /// CanExecute호출 뒤에 호출.
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object? parameter)
        {
            _firstViewModel.OnUserInformationChanged();
            //Debug.WriteLine("DisplayInformation");
        }
    }
}
