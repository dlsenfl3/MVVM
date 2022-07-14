using MVVM_Example.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Example.Commands
{
    public class SecondViewCommand : CommandBase
    {
        private readonly SecondViewModel _secondViewModel;

        public SecondViewCommand(SecondViewModel secondViewModel)
        {
            _secondViewModel = secondViewModel;
        }

        public SecondViewCommand()
        {

        }

        public override bool CanExecute(object? parameter)
        {
            return base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
