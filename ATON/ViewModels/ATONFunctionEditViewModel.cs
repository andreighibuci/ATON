using ATON.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATON.ViewModels
{
    public class ATONFunctionEditViewModel : INotifyPropertyChanged
    {
        //AtonFunction object to be altered via editor
        private AtonFunction function;

        public ATONFunctionEditViewModel(AtonFunction atonFunction)
        {
                //Inject upcoming function to be altered
                function = atonFunction;
        }





        //INotify Implementations for notifiying the GUI on Binding values change
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
