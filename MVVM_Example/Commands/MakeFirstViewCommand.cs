using MVVM_Example.Stores;
using MVVM_Example.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Example.Commands
{
    public class MakeFirstViewCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public MakeFirstViewCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new FirstViewModel(_navigationStore);
        }
    }
}
