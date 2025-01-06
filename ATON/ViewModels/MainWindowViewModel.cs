using ATON.Helpers;
using ATON.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATON.ViewModels
{

    //MainWindow ViewModel
    public class MainWindowViewModel:INotifyPropertyChanged
    {

        //List with all available Functions that is automatically updated on delete and add 
        public ObservableCollection<AtonFunction> Functions { get; set; }

        //List with all availabe Tests that is automatically updated on delete and add
        public ObservableCollection<AtonTestCase> Tests { get; set; }


        //Initialization of Binded Elements
        public MainWindowViewModel()
        {
            //Initialization of Observalbe lists so they can be updated all the time on GUI
            Functions = new ObservableCollection<AtonFunction>();
            Tests = new ObservableCollection<AtonTestCase>();

            //Mocking Up List of Functions
            foreach (var func in Mockuper.CreateRandFuncs()) {
                Functions.Add(func);   
            }

            //Mocking Up List of Testcases
            foreach (var test in Mockuper.CreateRandTestCases())
            {
                Tests.Add(test);
            }


        }


        //INotify Implementations for notifiying the GUI on Binding values change
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
