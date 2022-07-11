using MVVM_Example.Stores;
using MVVM_Example.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Example.Commands
{
    public class MakeSecondViewCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public MakeSecondViewCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new SecondViewModel(_navigationStore);
        }
    }
}
