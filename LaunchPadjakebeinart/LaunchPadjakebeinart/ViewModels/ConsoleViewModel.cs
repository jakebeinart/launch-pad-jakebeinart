using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchPadjakebeinart.Models;
using Caliburn.Micro;

namespace LaunchPadjakebeinart.ViewModels
{
    class ConsoleViewModel : PropertyChangedBase
    {
        private ConsoleModel Model;

        public ConsoleViewModel()
        {
            Model = new ConsoleModel();
        }
    }
}
