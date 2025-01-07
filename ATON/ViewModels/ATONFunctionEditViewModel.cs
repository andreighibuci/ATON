using ATON.Helpers;
using ATON.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ATON.ViewModels
{
    public class ATONFunctionEditViewModel : INotifyPropertyChanged
    {
        //AtonFunction object to be altered via editor
        private AtonFunction function;

        //Name Property to be binded for title
        private String _name;
        public String Name { get { return _name; } set { _name = value; OnPropertyChanged("Name"); } }

        //PyCode Property to be binded
        private String _pyCode;
        public String PyCode { get { return _pyCode; } set { PyCode = value; OnPropertyChanged("PyCode"); } }
   
        public ATONFunctionEditViewModel(AtonFunction atonFunction)
        {
            //Inject upcoming function to be altered
            function = atonFunction;

            //Inject Name
            Name = atonFunction.Name;
            Helper.ATONFunctionEditViewModel = this;

            

        }



        //INotify Implementations for notifiying the GUI on Binding values change
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
